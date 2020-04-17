namespace RockyRoad
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
            this.components = new System.ComponentModel.Container();
            this.pnlBana = new System.Windows.Forms.Panel();
            this.lblPaused = new System.Windows.Forms.Label();
            this.TidTagning = new System.Windows.Forms.Timer(this.components);
            this.Flytttid = new System.Windows.Forms.Timer(this.components);
            this.lblLiv = new System.Windows.Forms.Label();
            this.lblFörsök = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPausInfo = new System.Windows.Forms.Label();
            this.pnlStartMeny = new System.Windows.Forms.Panel();
            this.btnLevelMaker = new System.Windows.Forms.Button();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlHighScore = new System.Windows.Forms.Panel();
            this.pnlLevelMaker = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxNamn = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBekräfta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxY = new System.Windows.Forms.TextBox();
            this.tbxX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxHinder = new System.Windows.Forms.ComboBox();
            this.cbxFärg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRänsa = new System.Windows.Forms.Button();
            this.btnLäsa = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.pnlLevelMakerPaint = new System.Windows.Forms.Panel();
            this.btnMeny = new System.Windows.Forms.Button();
            this.pnlBana.SuspendLayout();
            this.pnlStartMeny.SuspendLayout();
            this.pnlLevelMaker.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBana
            // 
            this.pnlBana.BackColor = System.Drawing.Color.Black;
            this.pnlBana.Controls.Add(this.lblPaused);
            this.pnlBana.Enabled = false;
            this.pnlBana.Location = new System.Drawing.Point(12, 30);
            this.pnlBana.Name = "pnlBana";
            this.pnlBana.Size = new System.Drawing.Size(560, 360);
            this.pnlBana.TabIndex = 0;
            this.pnlBana.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // lblPaused
            // 
            this.lblPaused.AutoSize = true;
            this.lblPaused.BackColor = System.Drawing.Color.Transparent;
            this.lblPaused.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaused.ForeColor = System.Drawing.Color.Red;
            this.lblPaused.Location = new System.Drawing.Point(220, 160);
            this.lblPaused.Name = "lblPaused";
            this.lblPaused.Size = new System.Drawing.Size(0, 31);
            this.lblPaused.TabIndex = 0;
            // 
            // TidTagning
            // 
            this.TidTagning.Tick += new System.EventHandler(this.TidTagning_Tick);
            // 
            // Flytttid
            // 
            this.Flytttid.Interval = 140;
            this.Flytttid.Tick += new System.EventHandler(this.Flytttid_Tick);
            // 
            // lblLiv
            // 
            this.lblLiv.AutoSize = true;
            this.lblLiv.Location = new System.Drawing.Point(12, 9);
            this.lblLiv.Name = "lblLiv";
            this.lblLiv.Size = new System.Drawing.Size(33, 13);
            this.lblLiv.TabIndex = 1;
            this.lblLiv.Text = "Liv: 3";
            // 
            // lblFörsök
            // 
            this.lblFörsök.AutoSize = true;
            this.lblFörsök.Location = new System.Drawing.Point(51, 9);
            this.lblFörsök.Name = "lblFörsök";
            this.lblFörsök.Size = new System.Drawing.Size(51, 13);
            this.lblFörsök.TabIndex = 2;
            this.lblFörsök.Text = "Försök: 0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(123, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(61, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Tid: 0:0:0:0";
            // 
            // lblPausInfo
            // 
            this.lblPausInfo.AutoSize = true;
            this.lblPausInfo.Location = new System.Drawing.Point(452, 9);
            this.lblPausInfo.Name = "lblPausInfo";
            this.lblPausInfo.Size = new System.Drawing.Size(127, 13);
            this.lblPausInfo.TabIndex = 4;
            this.lblPausInfo.Text = "Tryck På P För Att Pausa";
            // 
            // pnlStartMeny
            // 
            this.pnlStartMeny.BackColor = System.Drawing.Color.Black;
            this.pnlStartMeny.Controls.Add(this.btnLevelMaker);
            this.pnlStartMeny.Controls.Add(this.btnHighScore);
            this.pnlStartMeny.Controls.Add(this.btnStart);
            this.pnlStartMeny.Location = new System.Drawing.Point(612, 10);
            this.pnlStartMeny.Name = "pnlStartMeny";
            this.pnlStartMeny.Size = new System.Drawing.Size(560, 380);
            this.pnlStartMeny.TabIndex = 5;
            this.pnlStartMeny.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // btnLevelMaker
            // 
            this.btnLevelMaker.Enabled = false;
            this.btnLevelMaker.Location = new System.Drawing.Point(240, 300);
            this.btnLevelMaker.Name = "btnLevelMaker";
            this.btnLevelMaker.Size = new System.Drawing.Size(80, 20);
            this.btnLevelMaker.TabIndex = 2;
            this.btnLevelMaker.Text = "Level Maker";
            this.btnLevelMaker.UseVisualStyleBackColor = true;
            this.btnLevelMaker.Click += new System.EventHandler(this.BtnLevelMaker_Click);
            // 
            // btnHighScore
            // 
            this.btnHighScore.Enabled = false;
            this.btnHighScore.Location = new System.Drawing.Point(240, 260);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(80, 20);
            this.btnHighScore.TabIndex = 1;
            this.btnHighScore.Text = "High Score";
            this.btnHighScore.UseVisualStyleBackColor = true;
            this.btnHighScore.Click += new System.EventHandler(this.BtnHighScore_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(240, 220);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 20);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // pnlHighScore
            // 
            this.pnlHighScore.BackColor = System.Drawing.Color.Black;
            this.pnlHighScore.Enabled = false;
            this.pnlHighScore.Location = new System.Drawing.Point(12, 408);
            this.pnlHighScore.Name = "pnlHighScore";
            this.pnlHighScore.Size = new System.Drawing.Size(560, 380);
            this.pnlHighScore.TabIndex = 6;
            // 
            // pnlLevelMaker
            // 
            this.pnlLevelMaker.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLevelMaker.Controls.Add(this.btnMeny);
            this.pnlLevelMaker.Controls.Add(this.label7);
            this.pnlLevelMaker.Controls.Add(this.cbxNamn);
            this.pnlLevelMaker.Controls.Add(this.label6);
            this.pnlLevelMaker.Controls.Add(this.btnBekräfta);
            this.pnlLevelMaker.Controls.Add(this.label5);
            this.pnlLevelMaker.Controls.Add(this.label4);
            this.pnlLevelMaker.Controls.Add(this.tbxY);
            this.pnlLevelMaker.Controls.Add(this.tbxX);
            this.pnlLevelMaker.Controls.Add(this.label3);
            this.pnlLevelMaker.Controls.Add(this.label2);
            this.pnlLevelMaker.Controls.Add(this.cbxHinder);
            this.pnlLevelMaker.Controls.Add(this.cbxFärg);
            this.pnlLevelMaker.Controls.Add(this.label1);
            this.pnlLevelMaker.Controls.Add(this.btnRänsa);
            this.pnlLevelMaker.Controls.Add(this.btnLäsa);
            this.pnlLevelMaker.Controls.Add(this.btnSpara);
            this.pnlLevelMaker.Controls.Add(this.pnlLevelMakerPaint);
            this.pnlLevelMaker.Enabled = false;
            this.pnlLevelMaker.Location = new System.Drawing.Point(587, 337);
            this.pnlLevelMaker.Name = "pnlLevelMaker";
            this.pnlLevelMaker.Size = new System.Drawing.Size(560, 400);
            this.pnlLevelMaker.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Namn";
            // 
            // cbxNamn
            // 
            this.cbxNamn.FormattingEnabled = true;
            this.cbxNamn.Location = new System.Drawing.Point(440, 202);
            this.cbxNamn.Name = "cbxNamn";
            this.cbxNamn.Size = new System.Drawing.Size(100, 21);
            this.cbxNamn.TabIndex = 33;
            this.cbxNamn.Text = "BanaCostum1";
            this.cbxNamn.SelectedIndexChanged += new System.EventHandler(this.CbxNamn_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Size";
            // 
            // btnBekräfta
            // 
            this.btnBekräfta.Location = new System.Drawing.Point(440, 79);
            this.btnBekräfta.Name = "btnBekräfta";
            this.btnBekräfta.Size = new System.Drawing.Size(100, 20);
            this.btnBekräfta.TabIndex = 31;
            this.btnBekräfta.Text = "Bekräfta";
            this.btnBekräfta.UseVisualStyleBackColor = true;
            this.btnBekräfta.Click += new System.EventHandler(this.BtnBekräfta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "X";
            // 
            // tbxY
            // 
            this.tbxY.Location = new System.Drawing.Point(460, 59);
            this.tbxY.Name = "tbxY";
            this.tbxY.Size = new System.Drawing.Size(80, 20);
            this.tbxY.TabIndex = 28;
            this.tbxY.Text = "15";
            // 
            // tbxX
            // 
            this.tbxX.Location = new System.Drawing.Point(460, 39);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(80, 20);
            this.tbxX.TabIndex = 27;
            this.tbxX.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Hinder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Färg";
            // 
            // cbxHinder
            // 
            this.cbxHinder.FormattingEnabled = true;
            this.cbxHinder.Location = new System.Drawing.Point(440, 161);
            this.cbxHinder.Name = "cbxHinder";
            this.cbxHinder.Size = new System.Drawing.Size(100, 21);
            this.cbxHinder.TabIndex = 24;
            this.cbxHinder.Text = "Block";
            this.cbxHinder.SelectedIndexChanged += new System.EventHandler(this.CbxHinder_SelectedIndexChanged);
            // 
            // cbxFärg
            // 
            this.cbxFärg.Enabled = false;
            this.cbxFärg.FormattingEnabled = true;
            this.cbxFärg.Location = new System.Drawing.Point(440, 121);
            this.cbxFärg.Name = "cbxFärg";
            this.cbxFärg.Size = new System.Drawing.Size(100, 21);
            this.cbxFärg.TabIndex = 23;
            this.cbxFärg.Text = "Vit";
            this.cbxFärg.TextChanged += new System.EventHandler(this.CbxFärg_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // btnRänsa
            // 
            this.btnRänsa.Location = new System.Drawing.Point(440, 267);
            this.btnRänsa.Name = "btnRänsa";
            this.btnRänsa.Size = new System.Drawing.Size(100, 20);
            this.btnRänsa.TabIndex = 21;
            this.btnRänsa.Text = "Ränsa";
            this.btnRänsa.UseVisualStyleBackColor = true;
            this.btnRänsa.Click += new System.EventHandler(this.BtnRänsa_Click);
            // 
            // btnLäsa
            // 
            this.btnLäsa.Location = new System.Drawing.Point(440, 247);
            this.btnLäsa.Name = "btnLäsa";
            this.btnLäsa.Size = new System.Drawing.Size(100, 20);
            this.btnLäsa.TabIndex = 20;
            this.btnLäsa.Text = "Läsa";
            this.btnLäsa.UseVisualStyleBackColor = true;
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(440, 228);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(100, 20);
            this.btnSpara.TabIndex = 19;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            // 
            // pnlLevelMakerPaint
            // 
            this.pnlLevelMakerPaint.BackColor = System.Drawing.Color.Black;
            this.pnlLevelMakerPaint.Location = new System.Drawing.Point(20, 20);
            this.pnlLevelMakerPaint.Name = "pnlLevelMakerPaint";
            this.pnlLevelMakerPaint.Size = new System.Drawing.Size(400, 300);
            this.pnlLevelMakerPaint.TabIndex = 18;
            this.pnlLevelMakerPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlLevelMakerPaint_Paint);
            this.pnlLevelMakerPaint.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlLevelMakerPaint_MouseClick);
            // 
            // btnMeny
            // 
            this.btnMeny.Location = new System.Drawing.Point(20, 348);
            this.btnMeny.Name = "btnMeny";
            this.btnMeny.Size = new System.Drawing.Size(75, 23);
            this.btnMeny.TabIndex = 35;
            this.btnMeny.Text = "Meny";
            this.btnMeny.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.pnlLevelMaker);
            this.Controls.Add(this.pnlHighScore);
            this.Controls.Add(this.pnlStartMeny);
            this.Controls.Add(this.lblPausInfo);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblFörsök);
            this.Controls.Add(this.lblLiv);
            this.Controls.Add(this.pnlBana);
            this.Name = "Form1";
            this.Text = "Rocky Road";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pnlBana.ResumeLayout(false);
            this.pnlBana.PerformLayout();
            this.pnlStartMeny.ResumeLayout(false);
            this.pnlLevelMaker.ResumeLayout(false);
            this.pnlLevelMaker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBana;
        private System.Windows.Forms.Timer TidTagning;
        private System.Windows.Forms.Timer Flytttid;
        private System.Windows.Forms.Label lblLiv;
        private System.Windows.Forms.Label lblFörsök;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPaused;
        private System.Windows.Forms.Label lblPausInfo;
        private System.Windows.Forms.Panel pnlStartMeny;
        private System.Windows.Forms.Button btnLevelMaker;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlHighScore;
        private System.Windows.Forms.Panel pnlLevelMaker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxNamn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBekräfta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxY;
        private System.Windows.Forms.TextBox tbxX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxHinder;
        private System.Windows.Forms.ComboBox cbxFärg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRänsa;
        private System.Windows.Forms.Button btnLäsa;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Panel pnlLevelMakerPaint;
        private System.Windows.Forms.Button btnMeny;
    }
}

