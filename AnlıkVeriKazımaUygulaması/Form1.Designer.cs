namespace AnlıkVeriKazımaUygulaması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimum = new System.Windows.Forms.Button();
            this.lblbaslik = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureDunyaDeprem = new System.Windows.Forms.PictureBox();
            this.pictureTarih = new System.Windows.Forms.PictureBox();
            this.pictureCovid = new System.Windows.Forms.PictureBox();
            this.pictureTurkiyeNufus = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureDoviz = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureDunyaNufus = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.anaPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDunyaDeprem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCovid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTurkiyeNufus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDoviz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDunyaNufus)).BeginInit();
            this.anaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(33)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.btnMinimum);
            this.panel1.Controls.Add(this.lblbaslik);
            this.panel1.Controls.Add(this.btnMinMax);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnMinimum
            // 
            this.btnMinimum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimum.BackgroundImage")));
            this.btnMinimum.FlatAppearance.BorderSize = 0;
            this.btnMinimum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimum.Location = new System.Drawing.Point(1097, 12);
            this.btnMinimum.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(27, 25);
            this.btnMinimum.TabIndex = 4;
            this.btnMinimum.UseVisualStyleBackColor = true;
            this.btnMinimum.Click += new System.EventHandler(this.button12_Click);
            // 
            // lblbaslik
            // 
            this.lblbaslik.AutoSize = true;
            this.lblbaslik.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaslik.ForeColor = System.Drawing.Color.White;
            this.lblbaslik.Location = new System.Drawing.Point(3, 10);
            this.lblbaslik.Name = "lblbaslik";
            this.lblbaslik.Size = new System.Drawing.Size(337, 25);
            this.lblbaslik.TabIndex = 3;
            this.lblbaslik.Text = "STATISTICS APPLICATION";
            // 
            // btnMinMax
            // 
            this.btnMinMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinMax.BackgroundImage")));
            this.btnMinMax.FlatAppearance.BorderSize = 0;
            this.btnMinMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinMax.Location = new System.Drawing.Point(1132, 12);
            this.btnMinMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(27, 25);
            this.btnMinMax.TabIndex = 3;
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(1167, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(27, 25);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.pictureDunyaDeprem);
            this.panel2.Controls.Add(this.pictureTarih);
            this.panel2.Controls.Add(this.pictureCovid);
            this.panel2.Controls.Add(this.pictureTurkiyeNufus);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.pictureDoviz);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 688);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(38, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(210, 87);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(198, 544);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 132);
            this.button10.TabIndex = 4;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(12, 544);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 132);
            this.button9.TabIndex = 3;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(98, 544);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 132);
            this.button8.TabIndex = 2;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureDunyaDeprem
            // 
            this.pictureDunyaDeprem.Location = new System.Drawing.Point(0, 451);
            this.pictureDunyaDeprem.Name = "pictureDunyaDeprem";
            this.pictureDunyaDeprem.Size = new System.Drawing.Size(18, 87);
            this.pictureDunyaDeprem.TabIndex = 5;
            this.pictureDunyaDeprem.TabStop = false;
            // 
            // pictureTarih
            // 
            this.pictureTarih.Location = new System.Drawing.Point(0, 103);
            this.pictureTarih.Name = "pictureTarih";
            this.pictureTarih.Size = new System.Drawing.Size(18, 87);
            this.pictureTarih.TabIndex = 0;
            this.pictureTarih.TabStop = false;
            // 
            // pictureCovid
            // 
            this.pictureCovid.Location = new System.Drawing.Point(0, 364);
            this.pictureCovid.Name = "pictureCovid";
            this.pictureCovid.Size = new System.Drawing.Size(18, 87);
            this.pictureCovid.TabIndex = 2;
            this.pictureCovid.TabStop = false;
            // 
            // pictureTurkiyeNufus
            // 
            this.pictureTurkiyeNufus.Location = new System.Drawing.Point(0, 277);
            this.pictureTurkiyeNufus.Name = "pictureTurkiyeNufus";
            this.pictureTurkiyeNufus.Size = new System.Drawing.Size(18, 87);
            this.pictureTurkiyeNufus.TabIndex = 4;
            this.pictureTurkiyeNufus.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(19, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(274, 87);
            this.button3.TabIndex = 2;
            this.button3.Text = "ANA SAYFA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(19, 364);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(274, 87);
            this.button4.TabIndex = 3;
            this.button4.Text = "     COVID - 19 VERİLERİ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(19, 277);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(274, 87);
            this.button5.TabIndex = 4;
            this.button5.Text = "   TÜRKİYE NÜFUSU";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureDoviz
            // 
            this.pictureDoviz.Location = new System.Drawing.Point(0, 190);
            this.pictureDoviz.Name = "pictureDoviz";
            this.pictureDoviz.Size = new System.Drawing.Size(18, 87);
            this.pictureDoviz.TabIndex = 1;
            this.pictureDoviz.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(19, 190);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(274, 87);
            this.button7.TabIndex = 6;
            this.button7.Text = "ANLIK DÖVİZ KURU";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(19, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 87);
            this.button2.TabIndex = 1;
            this.button2.Text = "FİLM İMDB";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureDunyaNufus
            // 
            this.pictureDunyaNufus.Location = new System.Drawing.Point(381, 33);
            this.pictureDunyaNufus.Name = "pictureDunyaNufus";
            this.pictureDunyaNufus.Size = new System.Drawing.Size(18, 87);
            this.pictureDunyaNufus.TabIndex = 3;
            this.pictureDunyaNufus.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(94, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(271, 87);
            this.button6.TabIndex = 5;
            this.button6.Text = "  ANLIK DÜNYA NÜFUSU";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // anaPanel
            // 
            this.anaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.anaPanel.Controls.Add(this.bunifuCustomLabel1);
            this.anaPanel.Controls.Add(this.panel3);
            this.anaPanel.Controls.Add(this.button6);
            this.anaPanel.Controls.Add(this.pictureDunyaNufus);
            this.anaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anaPanel.Location = new System.Drawing.Point(293, 48);
            this.anaPanel.Name = "anaPanel";
            this.anaPanel.Size = new System.Drawing.Size(917, 688);
            this.anaPanel.TabIndex = 3;
            this.anaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.anaPanel_Paint_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.panel3.Location = new System.Drawing.Point(83, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 170);
            this.panel3.TabIndex = 6;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(78, 627);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(970, 30);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Copyright 2020 TBCSOFT All Right Reversed || Design and Coding by Alikper İslam";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 736);
            this.Controls.Add(this.anaPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDunyaDeprem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCovid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTurkiyeNufus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDoviz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDunyaNufus)).EndInit();
            this.anaPanel.ResumeLayout(false);
            this.anaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblbaslik;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureTarih;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureDunyaDeprem;
        private System.Windows.Forms.PictureBox pictureCovid;
        private System.Windows.Forms.PictureBox pictureTurkiyeNufus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureDunyaNufus;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureDoviz;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnMinimum;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Panel anaPanel;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}

