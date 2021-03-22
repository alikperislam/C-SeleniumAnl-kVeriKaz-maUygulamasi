namespace AnlıkVeriKazımaUygulaması
{
    partial class frmTarih
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FİLM = new System.Windows.Forms.ListBox();
            this.İMDB = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboFilm = new System.Windows.Forms.ComboBox();
            this.txtFilm = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtİmdb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.lblfilmadı = new System.Windows.Forms.Label();
            this.comboİMDB = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FİLM
            // 
            this.FİLM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.FİLM.FormattingEnabled = true;
            this.FİLM.ItemHeight = 23;
            this.FİLM.Location = new System.Drawing.Point(13, 12);
            this.FİLM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FİLM.Name = "FİLM";
            this.FİLM.Size = new System.Drawing.Size(221, 349);
            this.FİLM.TabIndex = 0;
            // 
            // İMDB
            // 
            this.İMDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.İMDB.FormattingEnabled = true;
            this.İMDB.ItemHeight = 23;
            this.İMDB.Location = new System.Drawing.Point(264, 12);
            this.İMDB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.İMDB.Name = "İMDB";
            this.İMDB.Size = new System.Drawing.Size(221, 349);
            this.İMDB.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(107, 397);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "İMDB VERİLERİNİ AL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboFilm
            // 
            this.comboFilm.FormattingEnabled = true;
            this.comboFilm.Location = new System.Drawing.Point(653, 53);
            this.comboFilm.Name = "comboFilm";
            this.comboFilm.Size = new System.Drawing.Size(241, 31);
            this.comboFilm.TabIndex = 3;
            this.comboFilm.SelectedIndexChanged += new System.EventHandler(this.comboFilm_SelectedIndexChanged);
            // 
            // txtFilm
            // 
            this.txtFilm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilm.ForeColor = System.Drawing.Color.Black;
            this.txtFilm.HintForeColor = System.Drawing.Color.Empty;
            this.txtFilm.HintText = "";
            this.txtFilm.isPassword = false;
            this.txtFilm.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.txtFilm.LineIdleColor = System.Drawing.Color.LightSeaGreen;
            this.txtFilm.LineMouseHoverColor = System.Drawing.Color.DarkTurquoise;
            this.txtFilm.LineThickness = 3;
            this.txtFilm.Location = new System.Drawing.Point(654, 158);
            this.txtFilm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.Size = new System.Drawing.Size(240, 36);
            this.txtFilm.TabIndex = 4;
            this.txtFilm.Text = "FİLM ADI...";
            this.txtFilm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(539, 58);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(107, 23);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "FİLM SEÇ :";
            // 
            // txtİmdb
            // 
            this.txtİmdb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtİmdb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtİmdb.ForeColor = System.Drawing.Color.Black;
            this.txtİmdb.HintForeColor = System.Drawing.Color.Empty;
            this.txtİmdb.HintText = "";
            this.txtİmdb.isPassword = false;
            this.txtİmdb.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.txtİmdb.LineIdleColor = System.Drawing.Color.LightSeaGreen;
            this.txtİmdb.LineMouseHoverColor = System.Drawing.Color.DarkTurquoise;
            this.txtİmdb.LineThickness = 3;
            this.txtİmdb.Location = new System.Drawing.Point(654, 273);
            this.txtİmdb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtİmdb.Name = "txtİmdb";
            this.txtİmdb.Size = new System.Drawing.Size(240, 36);
            this.txtİmdb.TabIndex = 6;
            this.txtİmdb.Text = "İMDB PUANI...";
            this.txtİmdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(540, 167);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(106, 23);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "FİLM ADI :";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(508, 275);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(138, 23);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "İMDB PUANI :";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(572, 397);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 72);
            this.button2.TabIndex = 9;
            this.button2.Text = "İMDB";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblfilmadı
            // 
            this.lblfilmadı.AutoSize = true;
            this.lblfilmadı.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilmadı.ForeColor = System.Drawing.Color.Black;
            this.lblfilmadı.Location = new System.Drawing.Point(48, 567);
            this.lblfilmadı.Name = "lblfilmadı";
            this.lblfilmadı.Size = new System.Drawing.Size(0, 51);
            this.lblfilmadı.TabIndex = 10;
            // 
            // comboİMDB
            // 
            this.comboİMDB.FormattingEnabled = true;
            this.comboİMDB.Location = new System.Drawing.Point(653, 627);
            this.comboİMDB.Name = "comboİMDB";
            this.comboİMDB.Size = new System.Drawing.Size(241, 31);
            this.comboİMDB.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(653, 576);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 100);
            this.panel1.TabIndex = 12;
            // 
            // frmTarih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(917, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboİMDB);
            this.Controls.Add(this.lblfilmadı);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtİmdb);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtFilm);
            this.Controls.Add(this.comboFilm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.İMDB);
            this.Controls.Add(this.FİLM);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmTarih";
            this.Text = "tarih";
            this.Load += new System.EventHandler(this.frmTarih_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox İMDB;
        private System.Windows.Forms.ListBox FİLM;
        private System.Windows.Forms.Label lblfilmadı;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtİmdb;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFilm;
        private System.Windows.Forms.ComboBox comboFilm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboİMDB;
    }
}