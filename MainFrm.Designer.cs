namespace WhatsappWeb
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.openDialogNumara = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogDosya = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.iTalk_Panel1 = new iTalk.iTalk_Panel();
            this.txtDosyaYolu = new iTalk.iTalk_TextBox_Small();
            this.chkDosyaGonder = new iTalk.iTalk_CheckBox();
            this.iTalk_GroupBox2 = new iTalk.iTalk_GroupBox();
            this.btnNumaraEkle = new iTalk.iTalk_Button_1();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.txtNumara = new iTalk.iTalk_TextBox_Small();
            this.listViewNumaralar = new System.Windows.Forms.ListView();
            this.iTalk_btnNumaraYukle = new iTalk.iTalk_Button_1();
            this.iTalk_GroupBox1 = new iTalk.iTalk_GroupBox();
            this.txtMesaj = new iTalk.iTalk_TextBox_Small();
            this.iTalk_btnCalistir = new iTalk.iTalk_Button_1();
            this.iTalk_GroupBox3 = new iTalk.iTalk_GroupBox();
            this.txtBeklemeSuresi = new iTalk.iTalk_TextBox_Small();
            this.btnMesajGonder = new iTalk.iTalk_Button_1();
            this.btnDurdur = new iTalk.iTalk_Button_1();
            this.iTalk_Panel2 = new iTalk.iTalk_Panel();
            this.lblDurum = new iTalk.iTalk_Label();
            this.iTalk_Panel1.SuspendLayout();
            this.iTalk_GroupBox2.SuspendLayout();
            this.iTalk_GroupBox1.SuspendLayout();
            this.iTalk_GroupBox3.SuspendLayout();
            this.iTalk_Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openDialogNumara
            // 
            this.openDialogNumara.FileName = "openDialogNumara";
            // 
            // openFileDialogDosya
            // 
            this.openFileDialogDosya.FileName = "openFileDialogDosya";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 381);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(625, 22);
            this.progressBar1.TabIndex = 20;
            // 
            // iTalk_Panel1
            // 
            this.iTalk_Panel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Panel1.Controls.Add(this.txtDosyaYolu);
            this.iTalk_Panel1.Controls.Add(this.chkDosyaGonder);
            this.iTalk_Panel1.Location = new System.Drawing.Point(312, 171);
            this.iTalk_Panel1.Name = "iTalk_Panel1";
            this.iTalk_Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.iTalk_Panel1.Size = new System.Drawing.Size(325, 50);
            this.iTalk_Panel1.TabIndex = 26;
            this.iTalk_Panel1.Text = "iTalk_Panel1";
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.BackColor = System.Drawing.Color.Transparent;
            this.txtDosyaYolu.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDosyaYolu.ForeColor = System.Drawing.Color.DimGray;
            this.txtDosyaYolu.Location = new System.Drawing.Point(119, 11);
            this.txtDosyaYolu.MaxLength = 32767;
            this.txtDosyaYolu.Multiline = false;
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.ReadOnly = true;
            this.txtDosyaYolu.Size = new System.Drawing.Size(198, 28);
            this.txtDosyaYolu.TabIndex = 23;
            this.txtDosyaYolu.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDosyaYolu.UseSystemPasswordChar = false;
            // 
            // chkDosyaGonder
            // 
            this.chkDosyaGonder.BackColor = System.Drawing.Color.Transparent;
            this.chkDosyaGonder.Checked = false;
            this.chkDosyaGonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDosyaGonder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkDosyaGonder.Location = new System.Drawing.Point(8, 17);
            this.chkDosyaGonder.Name = "chkDosyaGonder";
            this.chkDosyaGonder.Size = new System.Drawing.Size(105, 15);
            this.chkDosyaGonder.TabIndex = 0;
            this.chkDosyaGonder.Text = "Dosya Gönder";
            this.chkDosyaGonder.CheckedChanged += new iTalk.iTalk_CheckBox.CheckedChangedEventHandler(this.chkDosyaGonder_CheckedChanged);
            // 
            // iTalk_GroupBox2
            // 
            this.iTalk_GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox2.Controls.Add(this.btnNumaraEkle);
            this.iTalk_GroupBox2.Controls.Add(this.iTalk_Label1);
            this.iTalk_GroupBox2.Controls.Add(this.txtNumara);
            this.iTalk_GroupBox2.Controls.Add(this.listViewNumaralar);
            this.iTalk_GroupBox2.Controls.Add(this.iTalk_btnNumaraYukle);
            this.iTalk_GroupBox2.Location = new System.Drawing.Point(12, 2);
            this.iTalk_GroupBox2.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox2.Name = "iTalk_GroupBox2";
            this.iTalk_GroupBox2.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox2.Size = new System.Drawing.Size(294, 373);
            this.iTalk_GroupBox2.TabIndex = 25;
            this.iTalk_GroupBox2.Text = "Numaralar";
            // 
            // btnNumaraEkle
            // 
            this.btnNumaraEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnNumaraEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNumaraEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNumaraEkle.Image = null;
            this.btnNumaraEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNumaraEkle.Location = new System.Drawing.Point(248, 31);
            this.btnNumaraEkle.Name = "btnNumaraEkle";
            this.btnNumaraEkle.Size = new System.Drawing.Size(38, 27);
            this.btnNumaraEkle.TabIndex = 24;
            this.btnNumaraEkle.Text = "Ekle";
            this.btnNumaraEkle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnNumaraEkle.Click += new System.EventHandler(this.btnNumaraEkle_Click);
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(8, 37);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(47, 13);
            this.iTalk_Label1.TabIndex = 23;
            this.iTalk_Label1.Text = "Numara";
            // 
            // txtNumara
            // 
            this.txtNumara.BackColor = System.Drawing.Color.Transparent;
            this.txtNumara.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNumara.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumara.Location = new System.Drawing.Point(61, 31);
            this.txtNumara.MaxLength = 32767;
            this.txtNumara.Multiline = false;
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.ReadOnly = false;
            this.txtNumara.Size = new System.Drawing.Size(173, 28);
            this.txtNumara.TabIndex = 22;
            this.txtNumara.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumara.UseSystemPasswordChar = false;
            // 
            // listViewNumaralar
            // 
            this.listViewNumaralar.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewNumaralar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewNumaralar.GridLines = true;
            this.listViewNumaralar.HoverSelection = true;
            this.listViewNumaralar.Location = new System.Drawing.Point(11, 65);
            this.listViewNumaralar.Name = "listViewNumaralar";
            this.listViewNumaralar.Size = new System.Drawing.Size(275, 273);
            this.listViewNumaralar.TabIndex = 21;
            this.listViewNumaralar.UseCompatibleStateImageBehavior = false;
            // 
            // iTalk_btnNumaraYukle
            // 
            this.iTalk_btnNumaraYukle.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_btnNumaraYukle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTalk_btnNumaraYukle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iTalk_btnNumaraYukle.Image = null;
            this.iTalk_btnNumaraYukle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_btnNumaraYukle.Location = new System.Drawing.Point(11, 344);
            this.iTalk_btnNumaraYukle.Name = "iTalk_btnNumaraYukle";
            this.iTalk_btnNumaraYukle.Size = new System.Drawing.Size(275, 20);
            this.iTalk_btnNumaraYukle.TabIndex = 0;
            this.iTalk_btnNumaraYukle.Text = "Çoklu Numara Yükle";
            this.iTalk_btnNumaraYukle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_btnNumaraYukle.Click += new System.EventHandler(this.iTalk_btnNumaraYukle_Click);
            // 
            // iTalk_GroupBox1
            // 
            this.iTalk_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox1.Controls.Add(this.txtMesaj);
            this.iTalk_GroupBox1.Location = new System.Drawing.Point(312, 2);
            this.iTalk_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox1.Name = "iTalk_GroupBox1";
            this.iTalk_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox1.Size = new System.Drawing.Size(325, 163);
            this.iTalk_GroupBox1.TabIndex = 24;
            this.iTalk_GroupBox1.Text = "Gönderilecek Mesaj";
            // 
            // txtMesaj
            // 
            this.txtMesaj.BackColor = System.Drawing.Color.Transparent;
            this.txtMesaj.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMesaj.ForeColor = System.Drawing.Color.DimGray;
            this.txtMesaj.Location = new System.Drawing.Point(6, 31);
            this.txtMesaj.MaxLength = 32767;
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.ReadOnly = false;
            this.txtMesaj.Size = new System.Drawing.Size(311, 124);
            this.txtMesaj.TabIndex = 26;
            this.txtMesaj.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMesaj.UseSystemPasswordChar = false;
            // 
            // iTalk_btnCalistir
            // 
            this.iTalk_btnCalistir.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_btnCalistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTalk_btnCalistir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iTalk_btnCalistir.Image = null;
            this.iTalk_btnCalistir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_btnCalistir.Location = new System.Drawing.Point(312, 296);
            this.iTalk_btnCalistir.Name = "iTalk_btnCalistir";
            this.iTalk_btnCalistir.Size = new System.Drawing.Size(325, 19);
            this.iTalk_btnCalistir.TabIndex = 21;
            this.iTalk_btnCalistir.Text = "WhatsappWeb Aç";
            this.iTalk_btnCalistir.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_btnCalistir.Click += new System.EventHandler(this.iTalk_btnCalistir_Click);
            // 
            // iTalk_GroupBox3
            // 
            this.iTalk_GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox3.Controls.Add(this.txtBeklemeSuresi);
            this.iTalk_GroupBox3.Location = new System.Drawing.Point(312, 227);
            this.iTalk_GroupBox3.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox3.Name = "iTalk_GroupBox3";
            this.iTalk_GroupBox3.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox3.Size = new System.Drawing.Size(325, 63);
            this.iTalk_GroupBox3.TabIndex = 27;
            this.iTalk_GroupBox3.Text = "Dosya Gönderme İçin Bekleme Süresi";
            // 
            // txtBeklemeSuresi
            // 
            this.txtBeklemeSuresi.BackColor = System.Drawing.Color.Transparent;
            this.txtBeklemeSuresi.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtBeklemeSuresi.ForeColor = System.Drawing.Color.DimGray;
            this.txtBeklemeSuresi.Location = new System.Drawing.Point(8, 27);
            this.txtBeklemeSuresi.MaxLength = 32767;
            this.txtBeklemeSuresi.Multiline = false;
            this.txtBeklemeSuresi.Name = "txtBeklemeSuresi";
            this.txtBeklemeSuresi.ReadOnly = false;
            this.txtBeklemeSuresi.Size = new System.Drawing.Size(309, 28);
            this.txtBeklemeSuresi.TabIndex = 0;
            this.txtBeklemeSuresi.Text = "4000";
            this.txtBeklemeSuresi.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBeklemeSuresi.UseSystemPasswordChar = false;
            // 
            // btnMesajGonder
            // 
            this.btnMesajGonder.BackColor = System.Drawing.Color.Transparent;
            this.btnMesajGonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMesajGonder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesajGonder.Image = null;
            this.btnMesajGonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesajGonder.Location = new System.Drawing.Point(312, 321);
            this.btnMesajGonder.Name = "btnMesajGonder";
            this.btnMesajGonder.Size = new System.Drawing.Size(219, 19);
            this.btnMesajGonder.TabIndex = 28;
            this.btnMesajGonder.Text = "Mesaj Göndermeye Başla";
            this.btnMesajGonder.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMesajGonder.Click += new System.EventHandler(this.btnMesajGonder_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.Transparent;
            this.btnDurdur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDurdur.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurdur.Image = null;
            this.btnDurdur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDurdur.Location = new System.Drawing.Point(537, 321);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(100, 19);
            this.btnDurdur.TabIndex = 29;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // iTalk_Panel2
            // 
            this.iTalk_Panel2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Panel2.Controls.Add(this.lblDurum);
            this.iTalk_Panel2.Location = new System.Drawing.Point(312, 346);
            this.iTalk_Panel2.Name = "iTalk_Panel2";
            this.iTalk_Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.iTalk_Panel2.Size = new System.Drawing.Size(325, 29);
            this.iTalk_Panel2.TabIndex = 30;
            this.iTalk_Panel2.Text = "iTalk_Panel2";
            // 
            // lblDurum
            // 
            this.lblDurum.BackColor = System.Drawing.Color.Transparent;
            this.lblDurum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.Color.Red;
            this.lblDurum.Location = new System.Drawing.Point(8, 5);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(309, 21);
            this.lblDurum.TabIndex = 0;
            this.lblDurum.Text = "Hazır";
            this.lblDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 413);
            this.Controls.Add(this.iTalk_Panel2);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnMesajGonder);
            this.Controls.Add(this.iTalk_GroupBox3);
            this.Controls.Add(this.iTalk_Panel1);
            this.Controls.Add(this.iTalk_GroupBox2);
            this.Controls.Add(this.iTalk_GroupBox1);
            this.Controls.Add(this.iTalk_btnCalistir);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(126, 39);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhatsappWeb Mesaj Gönder | Dursun KATAR";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.iTalk_Panel1.ResumeLayout(false);
            this.iTalk_GroupBox2.ResumeLayout(false);
            this.iTalk_GroupBox2.PerformLayout();
            this.iTalk_GroupBox1.ResumeLayout(false);
            this.iTalk_GroupBox3.ResumeLayout(false);
            this.iTalk_Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openDialogNumara;
        private System.Windows.Forms.OpenFileDialog openFileDialogDosya;
        private System.Windows.Forms.ProgressBar progressBar1;
        private iTalk.iTalk_Button_1 iTalk_btnCalistir;
        private iTalk.iTalk_GroupBox iTalk_GroupBox1;
        private iTalk.iTalk_TextBox_Small txtMesaj;
        private iTalk.iTalk_GroupBox iTalk_GroupBox2;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_TextBox_Small txtNumara;
        private System.Windows.Forms.ListView listViewNumaralar;
        private iTalk.iTalk_Button_1 iTalk_btnNumaraYukle;
        private iTalk.iTalk_Panel iTalk_Panel1;
        private iTalk.iTalk_CheckBox chkDosyaGonder;
        private iTalk.iTalk_TextBox_Small txtDosyaYolu;
        private iTalk.iTalk_Button_1 btnNumaraEkle;
        private iTalk.iTalk_GroupBox iTalk_GroupBox3;
        private iTalk.iTalk_TextBox_Small txtBeklemeSuresi;
        private iTalk.iTalk_Button_1 btnMesajGonder;
        private iTalk.iTalk_Button_1 btnDurdur;
        private iTalk.iTalk_Panel iTalk_Panel2;
        private iTalk.iTalk_Label lblDurum;
    }
}

