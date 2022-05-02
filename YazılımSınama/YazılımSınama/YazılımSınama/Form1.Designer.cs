
namespace YazılımSınama
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AsagıYukarıImage = new System.Windows.Forms.PictureBox();
            this.YıldızImage = new System.Windows.Forms.PictureBox();
            this.ParaImage = new System.Windows.Forms.PictureBox();
            this.ParaCalıstır = new System.Windows.Forms.Button();
            this.TabloOlusturBtn = new System.Windows.Forms.Button();
            this.SatırSutunComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AsagıYukarıImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YıldızImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaImage)).BeginInit();
            this.SuspendLayout();
            // 
            // AsagıYukarıImage
            // 
            this.AsagıYukarıImage.Image = global::YazılımSınama.Properties.Resources.updown;
            this.AsagıYukarıImage.Location = new System.Drawing.Point(324, 0);
            this.AsagıYukarıImage.Name = "AsagıYukarıImage";
            this.AsagıYukarıImage.Size = new System.Drawing.Size(64, 64);
            this.AsagıYukarıImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AsagıYukarıImage.TabIndex = 18;
            this.AsagıYukarıImage.TabStop = false;
            this.AsagıYukarıImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.AsagıYukarıImage_DragEnter);
            this.AsagıYukarıImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AsagıYukarıImage_MouseDown);
            // 
            // YıldızImage
            // 
            this.YıldızImage.Image = global::YazılımSınama.Properties.Resources.star;
            this.YıldızImage.Location = new System.Drawing.Point(254, 0);
            this.YıldızImage.Name = "YıldızImage";
            this.YıldızImage.Size = new System.Drawing.Size(64, 64);
            this.YıldızImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YıldızImage.TabIndex = 17;
            this.YıldızImage.TabStop = false;
            this.YıldızImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.YıldızImage_DragEnter);
            this.YıldızImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.YıldızImage_MouseDown);
            // 
            // ParaImage
            // 
            this.ParaImage.Image = global::YazılımSınama.Properties.Resources.money_bag;
            this.ParaImage.Location = new System.Drawing.Point(394, 0);
            this.ParaImage.Name = "ParaImage";
            this.ParaImage.Size = new System.Drawing.Size(64, 64);
            this.ParaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ParaImage.TabIndex = 16;
            this.ParaImage.TabStop = false;
            this.ParaImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.ParaImage_DragEnter);
            this.ParaImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ParaImage_MouseDown);
            // 
            // ParaCalıstır
            // 
            this.ParaCalıstır.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ParaCalıstır.Location = new System.Drawing.Point(475, 0);
            this.ParaCalıstır.Name = "ParaCalıstır";
            this.ParaCalıstır.Size = new System.Drawing.Size(128, 64);
            this.ParaCalıstır.TabIndex = 20;
            this.ParaCalıstır.Text = "Çalıştır";
            this.ParaCalıstır.UseVisualStyleBackColor = true;
            this.ParaCalıstır.Click += new System.EventHandler(this.ParaCalıstır_Click);
            // 
            // TabloOlusturBtn
            // 
            this.TabloOlusturBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TabloOlusturBtn.Location = new System.Drawing.Point(694, 12);
            this.TabloOlusturBtn.Name = "TabloOlusturBtn";
            this.TabloOlusturBtn.Size = new System.Drawing.Size(128, 41);
            this.TabloOlusturBtn.TabIndex = 19;
            this.TabloOlusturBtn.Text = "Tablo Oluştur";
            this.TabloOlusturBtn.UseVisualStyleBackColor = true;
            this.TabloOlusturBtn.Click += new System.EventHandler(this.TabloOlusturBtn_Click);
            // 
            // SatırSutunComboBox
            // 
            this.SatırSutunComboBox.FormattingEnabled = true;
            this.SatırSutunComboBox.Location = new System.Drawing.Point(694, 55);
            this.SatırSutunComboBox.Name = "SatırSutunComboBox";
            this.SatırSutunComboBox.Size = new System.Drawing.Size(128, 21);
            this.SatırSutunComboBox.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.SatırSutunComboBox);
            this.Controls.Add(this.ParaCalıstır);
            this.Controls.Add(this.TabloOlusturBtn);
            this.Controls.Add(this.AsagıYukarıImage);
            this.Controls.Add(this.YıldızImage);
            this.Controls.Add(this.ParaImage);
            this.MaximumSize = new System.Drawing.Size(850, 650);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AsagıYukarıImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YıldızImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AsagıYukarıImage;
        private System.Windows.Forms.PictureBox YıldızImage;
        private System.Windows.Forms.PictureBox ParaImage;
        private System.Windows.Forms.Button ParaCalıstır;
        private System.Windows.Forms.Button TabloOlusturBtn;
        private System.Windows.Forms.ComboBox SatırSutunComboBox;
    }
}

