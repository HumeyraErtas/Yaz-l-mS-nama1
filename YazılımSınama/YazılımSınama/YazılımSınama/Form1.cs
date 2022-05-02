using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using YazılımSınama.Model;

namespace YazılımSınama
{
    public partial class Form1 : Form
    {
        public static int[,] ImageMatrix { get; set; }
        public static PictureBox[,] ImageList { get; set; }
        public static int SatırSutunCount { get; set; }
        public Form1()
        {
            InitializeComponent();
            ComboBoxDoldur();
        }
        public void ComboBoxDoldur()
        {
            SatırSutunComboBox.Items.Add(5);
            SatırSutunComboBox.Items.Add(6);
            SatırSutunComboBox.Items.Add(7);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ParaImage.AllowDrop = true;
            YıldızImage.AllowDrop = true;
            AsagıYukarıImage.AllowDrop = true;
        }
        private void YıldızImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void YıldızImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                YıldızImage.DoDragDrop(YıldızImage.Image, DragDropEffects.Copy);
        }
        private void AsagıYukarıImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void AsagıYukarıImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                AsagıYukarıImage.DoDragDrop(AsagıYukarıImage.Image, DragDropEffects.Copy);
        }
        private void ParaImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void ParaImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                ParaImage.DoDragDrop(ParaImage.Image, DragDropEffects.Copy);
        }
        private void TabloOlusturBtn_Click(object sender, EventArgs e)
        {
            List<PictureBox> imageList = new List<PictureBox>();
            var item = this.SatırSutunComboBox.GetItemText(this.SatırSutunComboBox.SelectedItem);
            if (item != "")
            {
                SatırSutunCount = int.Parse(item);
                var count = 0;
                for (int i = 1; i <= int.Parse(item); i++)
                {
                    for (int j = 1; j <= int.Parse(item); j++)
                    {
                        count += 1;
                        var picture = new PictureBox();
                        picture.Name = count.ToString();
                        picture.Size = new Size(48, 48);
                        picture.Location = new Point(90 * j, 75 * i + 20);
                        picture.BackColor = Color.LightBlue;
                        picture.SizeMode = PictureBoxSizeMode.Zoom;
                        picture.DragDrop += Picture_DragDrop;
                        picture.DragEnter += Picture_DragEnter;
                        picture.AllowDrop = true;
                        this.Controls.Add(picture);
                        imageList.Add(picture);
                    }
                }
                ImageMatrix = YıldızParaMatrix(int.Parse(item), int.Parse(item));
                ImageList = PictureBoxImageList(int.Parse(item), imageList);
                TabloOlusturBtn.Visible = false;
                SatırSutunComboBox.Visible = false;
            }
            else
            {
                MessageBox.Show("Oyunu Başlatmak için Bir tane seçin.");
            }

        }
        public static PictureBox[,] PictureBoxImageList(int satır_sutun, List<PictureBox> pictures)
        {
            var count = 0;
            PictureBox[,] matrix = new PictureBox[satır_sutun, satır_sutun];
            for (int i = 0; i < satır_sutun; i++)
            {
                for (int j = 0; j < satır_sutun; j++)
                {
                    matrix[i, j] = pictures[count];
                    count += 1;
                }
            }
            return matrix;
        }
        public static int[,] YıldızParaMatrix(int sutun, int satır)
        {
            int[,] matrix = new int[satır, sutun];
            for (int i = 0; i < sutun; i++)
            {
                for (int j = 0; j < satır; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            return matrix;
        }
        private void Picture_DragEnter(object sender, DragEventArgs e)
        {
            DragEventArgs drag = (DragEventArgs)e;
            if (drag.Data.GetData(DataFormats.Bitmap) != null)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        public int AsagıYukarıSayac { get; set; }
        public int ParaSayac { get; set; }
        private void Picture_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            if (picture.Image == null)
            {
                var image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
                var imagecount = image.Size.Width;
                if (imagecount == 256)
                {
                    imagecount = 3;
                    YıldızImage.Visible = false;
                }
                if (imagecount == 128)
                {
                    imagecount = 2;
                    AsagıYukarıSayac += 1;
                    if (AsagıYukarıSayac == 2)
                    {
                        AsagıYukarıImage.Visible = false;
                    }
                }
                if (imagecount == 64)
                {
                    imagecount = 1;
                    ParaSayac += 1;
                    if (ParaSayac == 5)
                    {
                        ParaImage.Visible = false;
                    }
                }
                var controlMatrix = ImageMatrix;
                var numberImage = int.Parse(picture.Name);
                var count = 0;
                for (int i = 0; i < controlMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < controlMatrix.GetLength(1); j++)
                    {
                        count += 1;
                        if (count == numberImage)
                        {
                            controlMatrix[i, j] = imagecount;
                        }
                    }
                }
                picture.Image = image;
            }
        }
        private void ParaCalıstır_Click(object sender, EventArgs e)
        {
            if (YıldızImage.Visible == false && AsagıYukarıImage.Visible == false && ParaImage.Visible == false)
            {
                int[,] count = ImageMatrix;
                string[] starList = new string[2];
                List<ParaModel> paraModel = new List<ParaModel>();
                List<AsagıYukarıModel> asagıYukarıModel = new List<AsagıYukarıModel>();
                for (int i = 0; i < ImageMatrix.GetLength(1); i++)
                {
                    for (int j = 0; j < ImageMatrix.GetLength(1); j++)
                    {
                        if (ImageMatrix[i, j] == 1)
                        {
                            paraModel.Add(new ParaModel() { I = i, J = j });
                        }
                        if (ImageMatrix[i, j] == 2)
                        {
                            asagıYukarıModel.Add(new AsagıYukarıModel() { I = i, J = j });
                        }
                        if (ImageMatrix[i, j] == 3)
                        {
                            starList[0] = i.ToString();
                            starList[1] = j.ToString();
                        }
                    }
                }
                foreach (var item in paraModel)
                {
                    var X = 0;
                    var Y = 0;
                    X = item.I - int.Parse(starList[0]);
                    Y = item.J - int.Parse(starList[1]);
                    ParaRun((X * SatırSutunCount + Y), item.I, item.J);

                    ImageMatrix[item.I, item.J] = 0;
                }
                ParaCalıstır.Visible = false;
            }
            else
            {
                MessageBox.Show("Bütün Resimleri koymadan çalışmaz.");
            }
        }
        public void ParaRun(int count, int parai, int paraj)
        {
            while (count > 0)
            {
                if (paraj >= 0)
                {
                    if (ImageMatrix[parai, paraj] == 3)
                    {
                        MessageBox.Show("Para Hedefe Ulaştı");
                        count = 0;
                    }
                    else
                    {
                        if (paraj == 0)
                        {
                            var x = parai - 1;
                            if (!YıldızImagePozitif(x, SatırSutunCount - 1))
                            {
                                Image temp;
                                PictureBox box = ImageList[x, SatırSutunCount - 1];
                                PictureBox box2 = ImageList[parai, paraj];
                                temp = box.Image;
                                box.Image = box2.Image;
                                box2.Image = temp;
                                ImageMatrix[parai, SatırSutunCount - 1] = 1;
                            }
                            else
                            {
                                MessageBox.Show("Para Hedefe Ulaştı");
                            }
                        }
                        else
                        {
                            if (!YıldızImagePozitif(parai, paraj - 1))
                            {
                                if (!AsagıYukarıImagePozitif(parai, paraj - 1))
                                {
                                    Image temp;
                                    PictureBox box = ImageList[parai, paraj - 1];
                                    PictureBox box2 = ImageList[parai, paraj];
                                    temp = box.Image;
                                    box.Image = box2.Image;
                                    box2.Image = temp;
                                    ImageMatrix[parai, paraj - 1] = 1;
                                }
                                else
                                {
                                    --parai;
                                    ++paraj;
                                    Image temp;
                                    PictureBox box = ImageList[parai + 1, paraj - 1];
                                    PictureBox box2 = ImageList[parai, paraj - 1];
                                    temp = box.Image;
                                    box.Image = box2.Image;
                                    box2.Image = temp;
                                    ImageMatrix[parai, paraj - 1] = 1;
                                }
                            }
                        }
                        paraj--;
                    }
                    count--;
                }
                else
                {
                    --parai;
                    paraj = SatırSutunCount - 1;
                }
                MessageBox.Show("Tamamdır");
            }
            while (count < 0)
            {
                if (paraj >= 0)
                {
                    if (paraj == SatırSutunCount - 1)
                    {
                        var x = parai + 1;
                        paraj = 0;
                        if (!YıldızImageNefatif(x, paraj + 1))
                        {
                            if (!AsagıYukarıImageNegatif(x, paraj + 1))
                            {
                                Image temp;
                                PictureBox box = ImageList[parai, SatırSutunCount - 1];
                                PictureBox box2 = ImageList[x, paraj];
                                temp = box.Image;
                                box.Image = box2.Image;
                                box2.Image = temp;
                                ImageMatrix[parai, SatırSutunCount - 1] = 1;
                            }
                        }
                        else
                            MessageBox.Show("Para Hedefe Ulaştı");
                        parai += 1;
                    }
                    else
                    {
                        if (!YıldızImageNefatif(parai, paraj + 1))
                        {
                            if (!AsagıYukarıImageNegatif(parai, paraj + 1))
                            {
                                Image temp;
                                PictureBox box = ImageList[parai, paraj];
                                PictureBox box2 = ImageList[parai, paraj + 1];
                                temp = box.Image;
                                box.Image = box2.Image;
                                box2.Image = temp;
                                ImageMatrix[parai, paraj] = 1;
                                paraj++;
                            }
                            else
                            {
                                ++parai;
                                Image temp;
                                PictureBox box = ImageList[parai - 1, paraj];
                                PictureBox box2 = ImageList[parai, paraj];
                                temp = box.Image;
                                box.Image = box2.Image;
                                box2.Image = temp;
                                ImageMatrix[parai, paraj - 1] = 1;
                            }
                        }
                        else
                            count = 0;
                    }
                    count++;
                }
                MessageBox.Show("Tamamdır");
            }
        }
        public bool YıldızImagePozitif(int i, int j)
        {
            if (ImageMatrix[i, j] == 3)
            {
                ImageList[i, j + 1].Image = null;
                return true;
            }
            else
                return false;
        }
        public bool YıldızImageNefatif(int i, int j)
        {
            if (ImageMatrix[i, j] == 3)
            {
                ImageList[i, j - 1].Image = null;
                return true;
            }
            else
                return false;
        }
        public bool AsagıYukarıImagePozitif(int i, int j)
        {
            if (ImageMatrix[i, j] == 2)
            {
                //ImageList[i, j].Image = null;
                return true;
            }
            else
                return false;
        }
        public bool AsagıYukarıImageNegatif(int i, int j)
        {
            if (ImageMatrix[i, j] == 2)
            {
                //ImageList[i, j].Image = null;
                return true;
            }
            else
                return false;
        }
    }
}
