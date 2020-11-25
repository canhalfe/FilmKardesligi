
namespace FilmKardesligi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiTurler = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstFilmler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gboPuan = new System.Windows.Forms.GroupBox();
            this.rbPuan2 = new System.Windows.Forms.RadioButton();
            this.rbPuan3 = new System.Windows.Forms.RadioButton();
            this.rbPuan4 = new System.Windows.Forms.RadioButton();
            this.rbPuan5 = new System.Windows.Forms.RadioButton();
            this.rbPuan1 = new System.Windows.Forms.RadioButton();
            this.clbTurler = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.gboPuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTurler});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiTurler
            // 
            this.tsmiTurler.Name = "tsmiTurler";
            this.tsmiTurler.Size = new System.Drawing.Size(78, 20);
            this.tsmiTurler.Text = "Film Türleri";
            this.tsmiTurler.Click += new System.EventHandler(this.tsmiTurler_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIptal.BackColor = System.Drawing.Color.Black;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(12, 387);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(87, 27);
            this.btnIptal.TabIndex = 9;
            this.btnIptal.Text = "IPTAL";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.BackColor = System.Drawing.Color.Black;
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnDuzenle.Location = new System.Drawing.Point(467, 387);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(254, 27);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.BackColor = System.Drawing.Color.Black;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(212, 387);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(249, 27);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstFilmler
            // 
            this.lstFilmler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFilmler.DisplayMember = "Kunye";
            this.lstFilmler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstFilmler.FormattingEnabled = true;
            this.lstFilmler.ItemHeight = 18;
            this.lstFilmler.Location = new System.Drawing.Point(212, 49);
            this.lstFilmler.Name = "lstFilmler";
            this.lstFilmler.Size = new System.Drawing.Size(509, 310);
            this.lstFilmler.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEkle.BackColor = System.Drawing.Color.Black;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(105, 387);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 27);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmAd.Location = new System.Drawing.Point(12, 64);
            this.txtFilmAd.Multiline = true;
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(178, 23);
            this.txtFilmAd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Türü:";
            // 
            // gboPuan
            // 
            this.gboPuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gboPuan.Controls.Add(this.rbPuan2);
            this.gboPuan.Controls.Add(this.rbPuan3);
            this.gboPuan.Controls.Add(this.rbPuan4);
            this.gboPuan.Controls.Add(this.rbPuan5);
            this.gboPuan.Controls.Add(this.rbPuan1);
            this.gboPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboPuan.ForeColor = System.Drawing.Color.White;
            this.gboPuan.Location = new System.Drawing.Point(12, 219);
            this.gboPuan.Name = "gboPuan";
            this.gboPuan.Size = new System.Drawing.Size(178, 162);
            this.gboPuan.TabIndex = 7;
            this.gboPuan.TabStop = false;
            this.gboPuan.Text = "Puan";
            // 
            // rbPuan2
            // 
            this.rbPuan2.AutoSize = true;
            this.rbPuan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan2.ForeColor = System.Drawing.Color.White;
            this.rbPuan2.Location = new System.Drawing.Point(6, 55);
            this.rbPuan2.Name = "rbPuan2";
            this.rbPuan2.Size = new System.Drawing.Size(55, 21);
            this.rbPuan2.TabIndex = 1;
            this.rbPuan2.Tag = "2";
            this.rbPuan2.Text = "Kötü";
            this.rbPuan2.UseVisualStyleBackColor = true;
            // 
            // rbPuan3
            // 
            this.rbPuan3.AutoSize = true;
            this.rbPuan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan3.ForeColor = System.Drawing.Color.White;
            this.rbPuan3.Location = new System.Drawing.Point(6, 78);
            this.rbPuan3.Name = "rbPuan3";
            this.rbPuan3.Size = new System.Drawing.Size(54, 21);
            this.rbPuan3.TabIndex = 2;
            this.rbPuan3.Tag = "3";
            this.rbPuan3.Text = "Orta";
            this.rbPuan3.UseVisualStyleBackColor = true;
            // 
            // rbPuan4
            // 
            this.rbPuan4.AutoSize = true;
            this.rbPuan4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan4.ForeColor = System.Drawing.Color.White;
            this.rbPuan4.Location = new System.Drawing.Point(6, 101);
            this.rbPuan4.Name = "rbPuan4";
            this.rbPuan4.Size = new System.Drawing.Size(39, 21);
            this.rbPuan4.TabIndex = 3;
            this.rbPuan4.Tag = "4";
            this.rbPuan4.Text = "İyi";
            this.rbPuan4.UseVisualStyleBackColor = true;
            // 
            // rbPuan5
            // 
            this.rbPuan5.AutoSize = true;
            this.rbPuan5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan5.ForeColor = System.Drawing.Color.White;
            this.rbPuan5.Location = new System.Drawing.Point(6, 124);
            this.rbPuan5.Name = "rbPuan5";
            this.rbPuan5.Size = new System.Drawing.Size(67, 21);
            this.rbPuan5.TabIndex = 4;
            this.rbPuan5.Tag = "5";
            this.rbPuan5.Text = "Çok İyi";
            this.rbPuan5.UseVisualStyleBackColor = true;
            // 
            // rbPuan1
            // 
            this.rbPuan1.AutoSize = true;
            this.rbPuan1.Checked = true;
            this.rbPuan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan1.ForeColor = System.Drawing.Color.White;
            this.rbPuan1.Location = new System.Drawing.Point(6, 32);
            this.rbPuan1.Name = "rbPuan1";
            this.rbPuan1.Size = new System.Drawing.Size(83, 21);
            this.rbPuan1.TabIndex = 0;
            this.rbPuan1.TabStop = true;
            this.rbPuan1.Tag = "1";
            this.rbPuan1.Text = "Çok Kötü";
            this.rbPuan1.UseVisualStyleBackColor = true;
            // 
            // clbTurler
            // 
            this.clbTurler.CheckOnClick = true;
            this.clbTurler.FormattingEnabled = true;
            this.clbTurler.Location = new System.Drawing.Point(12, 113);
            this.clbTurler.Name = "clbTurler";
            this.clbTurler.Size = new System.Drawing.Size(178, 94);
            this.clbTurler.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::FilmKardesligi.Properties.Resources._960x540;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 420);
            this.Controls.Add(this.clbTurler);
            this.Controls.Add(this.gboPuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lstFilmler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtFilmAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(749, 459);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Kardeşliği";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gboPuan.ResumeLayout(false);
            this.gboPuan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTurler;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox lstFilmler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboPuan;
        private System.Windows.Forms.RadioButton rbPuan2;
        private System.Windows.Forms.RadioButton rbPuan3;
        private System.Windows.Forms.RadioButton rbPuan4;
        private System.Windows.Forms.RadioButton rbPuan5;
        private System.Windows.Forms.RadioButton rbPuan1;
        private System.Windows.Forms.CheckedListBox clbTurler;
    }
}

