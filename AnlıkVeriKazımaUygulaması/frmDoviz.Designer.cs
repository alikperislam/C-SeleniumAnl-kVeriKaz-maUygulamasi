namespace AnlıkVeriKazımaUygulaması
{
    partial class frmDoviz
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tarihgir = new System.Windows.Forms.Label();
            this.lbleuro = new System.Windows.Forms.Label();
            this.lblkanada = new System.Windows.Forms.Label();
            this.lblfrang = new System.Windows.Forms.Label();
            this.lbldinar = new System.Windows.Forms.Label();
            this.lblriyal = new System.Windows.Forms.Label();
            this.lblkron = new System.Windows.Forms.Label();
            this.lblsterlin = new System.Windows.Forms.Label();
            this.lblabd = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(568, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 91);
            this.button1.TabIndex = 0;
            this.button1.Text = "İSTATİSTİK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(484, 71);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "doviz";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(420, 329);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ABD DOLARI :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbleuro);
            this.groupBox1.Controls.Add(this.lblkanada);
            this.groupBox1.Controls.Add(this.lblfrang);
            this.groupBox1.Controls.Add(this.lbldinar);
            this.groupBox1.Controls.Add(this.lblriyal);
            this.groupBox1.Controls.Add(this.lblkron);
            this.groupBox1.Controls.Add(this.lblsterlin);
            this.groupBox1.Controls.Add(this.lblabd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(463, 664);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DÖVİZ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(107, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "STERLİN :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(122, 380);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "KRON :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(124, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "RİYAL :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(115, 460);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "DİNAR :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(109, 537);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "FRANG :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(43, 611);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "KANADA DOLARI :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(125, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "EURO :";
            // 
            // tarihgir
            // 
            this.tarihgir.AutoSize = true;
            this.tarihgir.Location = new System.Drawing.Point(484, 29);
            this.tarihgir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tarihgir.Name = "tarihgir";
            this.tarihgir.Size = new System.Drawing.Size(82, 23);
            this.tarihgir.TabIndex = 4;
            this.tarihgir.Text = "TARİH : ";
            // 
            // lbleuro
            // 
            this.lbleuro.AutoSize = true;
            this.lbleuro.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbleuro.Location = new System.Drawing.Point(215, 148);
            this.lbleuro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbleuro.Name = "lbleuro";
            this.lbleuro.Size = new System.Drawing.Size(114, 23);
            this.lbleuro.TabIndex = 17;
            this.lbleuro.Text = "---------->  ";
            // 
            // lblkanada
            // 
            this.lblkanada.AutoSize = true;
            this.lblkanada.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkanada.Location = new System.Drawing.Point(215, 611);
            this.lblkanada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkanada.Name = "lblkanada";
            this.lblkanada.Size = new System.Drawing.Size(114, 23);
            this.lblkanada.TabIndex = 16;
            this.lblkanada.Text = "---------->  ";
            // 
            // lblfrang
            // 
            this.lblfrang.AutoSize = true;
            this.lblfrang.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfrang.Location = new System.Drawing.Point(215, 537);
            this.lblfrang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfrang.Name = "lblfrang";
            this.lblfrang.Size = new System.Drawing.Size(114, 23);
            this.lblfrang.TabIndex = 15;
            this.lblfrang.Text = "---------->  ";
            // 
            // lbldinar
            // 
            this.lbldinar.AutoSize = true;
            this.lbldinar.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldinar.Location = new System.Drawing.Point(215, 460);
            this.lbldinar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldinar.Name = "lbldinar";
            this.lbldinar.Size = new System.Drawing.Size(114, 23);
            this.lbldinar.TabIndex = 14;
            this.lbldinar.Text = "---------->  ";
            // 
            // lblriyal
            // 
            this.lblriyal.AutoSize = true;
            this.lblriyal.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblriyal.Location = new System.Drawing.Point(215, 307);
            this.lblriyal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblriyal.Name = "lblriyal";
            this.lblriyal.Size = new System.Drawing.Size(114, 23);
            this.lblriyal.TabIndex = 13;
            this.lblriyal.Text = "---------->  ";
            // 
            // lblkron
            // 
            this.lblkron.AutoSize = true;
            this.lblkron.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkron.Location = new System.Drawing.Point(215, 380);
            this.lblkron.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkron.Name = "lblkron";
            this.lblkron.Size = new System.Drawing.Size(114, 23);
            this.lblkron.TabIndex = 12;
            this.lblkron.Text = "---------->  ";
            // 
            // lblsterlin
            // 
            this.lblsterlin.AutoSize = true;
            this.lblsterlin.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsterlin.Location = new System.Drawing.Point(215, 230);
            this.lblsterlin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsterlin.Name = "lblsterlin";
            this.lblsterlin.Size = new System.Drawing.Size(114, 23);
            this.lblsterlin.TabIndex = 11;
            this.lblsterlin.Text = "---------->  ";
            // 
            // lblabd
            // 
            this.lblabd.AutoSize = true;
            this.lblabd.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblabd.Location = new System.Drawing.Point(215, 70);
            this.lblabd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblabd.Name = "lblabd";
            this.lblabd.Size = new System.Drawing.Size(114, 23);
            this.lblabd.TabIndex = 10;
            this.lblabd.Text = "---------->  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(528, 583);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(397, 46);
            this.label9.TabIndex = 5;
            this.label9.Text = "TÜM VERİLER www.tcmb.com\r\nADRESİNDEN ANLIK OLARAK ALINMIŞTIR.";
            // 
            // frmDoviz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(917, 688);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tarihgir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmDoviz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doviz";
            this.Load += new System.EventHandler(this.frmDoviz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tarihgir;
        private System.Windows.Forms.Label lbleuro;
        private System.Windows.Forms.Label lblkanada;
        private System.Windows.Forms.Label lblfrang;
        private System.Windows.Forms.Label lbldinar;
        private System.Windows.Forms.Label lblriyal;
        private System.Windows.Forms.Label lblkron;
        private System.Windows.Forms.Label lblsterlin;
        private System.Windows.Forms.Label lblabd;
        private System.Windows.Forms.Label label9;
    }
}