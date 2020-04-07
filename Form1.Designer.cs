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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPaused = new System.Windows.Forms.Label();
            this.TidTagning = new System.Windows.Forms.Timer(this.components);
            this.Flytttid = new System.Windows.Forms.Timer(this.components);
            this.lblLiv = new System.Windows.Forms.Label();
            this.lblFörsök = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPausInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLevelMaker = new System.Windows.Forms.Button();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblPaused);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 360);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnLevelMaker);
            this.panel2.Controls.Add(this.btnHighScore);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Location = new System.Drawing.Point(612, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 380);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
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
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(240, 220);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 20);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(12, 396);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 380);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(612, 396);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(560, 380);
            this.panel4.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPausInfo);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblFörsök);
            this.Controls.Add(this.lblLiv);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Rocky Road";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer TidTagning;
        private System.Windows.Forms.Timer Flytttid;
        private System.Windows.Forms.Label lblLiv;
        private System.Windows.Forms.Label lblFörsök;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPaused;
        private System.Windows.Forms.Label lblPausInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLevelMaker;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

