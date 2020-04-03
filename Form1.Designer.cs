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
            this.panel1.SuspendLayout();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 401);
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
    }
}

