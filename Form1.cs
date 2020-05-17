using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockyRoad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Meny();            
        }

        SolidBrush Blå = new SolidBrush(Color.Blue);
        SolidBrush Ljusblå = new SolidBrush(Color.LightBlue);
        SolidBrush Vit = new SolidBrush(Color.White);
        SolidBrush Röd = new SolidBrush(Color.Red);
        SolidBrush Grön = new SolidBrush(Color.Green);
        SolidBrush Gul = new SolidBrush(Color.Yellow);
        SolidBrush Svart = new SolidBrush(Color.Black);

        Pen PVit = new Pen(Color.White);
        Pen PBlå = new Pen(Color.Blue);
        Pen PLjusblå = new Pen(Color.LightBlue);
        Pen PGrön = new Pen(Color.Green);
        Pen PRöd = new Pen(Color.Red);
        Pen PGul = new Pen(Color.Yellow);
        
        //Meny
        List<int> MenyX = new List<int>();
        List<int> MenyY = new List<int>();
        List<double> MenyHinder = new List<double>();

        Point InfoMeny = new Point(189,30);
        Point ActiveMeny = new Point(12, 9);
        Point StartMeny = new Point(620, 9);
        Point LevelMakerMeny = new Point(620, 340);
        Point HighScoreMeny = new Point(12, 410);
        Point MenyNamn = new Point(189, 144);

        bool Special = false;
        private void Meny()
        {
            Width = 600;
            Height = 440;
            pnlStartMeny.Location = ActiveMeny;

            //R
            MenyX.Add(2); MenyY.Add(2); MenyHinder.Add(1);
            MenyX.Add(2); MenyY.Add(3); MenyHinder.Add(1);
            MenyX.Add(2); MenyY.Add(4); MenyHinder.Add(1);
            MenyX.Add(2); MenyY.Add(5); MenyHinder.Add(1);
            MenyX.Add(2); MenyY.Add(6); MenyHinder.Add(1);
            MenyX.Add(2); MenyY.Add(7); MenyHinder.Add(1);
            MenyX.Add(3); MenyY.Add(2); MenyHinder.Add(1);
            MenyX.Add(3); MenyY.Add(4); MenyHinder.Add(1);
            MenyX.Add(3); MenyY.Add(5); MenyHinder.Add(1);
            MenyX.Add(4); MenyY.Add(2); MenyHinder.Add(1);
            MenyX.Add(4); MenyY.Add(4); MenyHinder.Add(1);
            MenyX.Add(4); MenyY.Add(6); MenyHinder.Add(1);
            MenyX.Add(5); MenyY.Add(3); MenyHinder.Add(1);
            MenyX.Add(5); MenyY.Add(7); MenyHinder.Add(1);
            //O
            MenyX.Add(7); MenyY.Add(3); MenyHinder.Add(1);
            MenyX.Add(7); MenyY.Add(4); MenyHinder.Add(1);
            MenyX.Add(7); MenyY.Add(5); MenyHinder.Add(1);
            MenyX.Add(7); MenyY.Add(6); MenyHinder.Add(1);
            MenyX.Add(8); MenyY.Add(2); MenyHinder.Add(1);
            MenyX.Add(8); MenyY.Add(7); MenyHinder.Add(1);
            MenyX.Add(9); MenyY.Add(2); MenyHinder.Add(1);
            MenyX.Add(9); MenyY.Add(7); MenyHinder.Add(1);
            MenyX.Add(10); MenyY.Add(3); MenyHinder.Add(1);
            MenyX.Add(10); MenyY.Add(4); MenyHinder.Add(1);
            MenyX.Add(10); MenyY.Add(5); MenyHinder.Add(1);
            MenyX.Add(10); MenyY.Add(6); MenyHinder.Add(1);
            //C
            MenyX.Add(12); MenyY.Add(3); MenyHinder.Add(1);
            MenyX.Add(12); MenyY.Add(4); MenyHinder.Add(1);
            MenyX.Add(12); MenyY.Add(5); MenyHinder.Add(1);
            MenyX.Add(12); MenyY.Add(6); MenyHinder.Add(1);
            MenyX.Add(13); MenyY.Add(2); MenyHinder.Add(1);
            MenyX.Add(13); MenyY.Add(7); MenyHinder.Add(1);
            MenyX.Add(14); MenyY.Add(2); MenyHinder.Add(1);
            MenyX.Add(14); MenyY.Add(7); MenyHinder.Add(1);
            MenyX.Add(15); MenyY.Add(3); MenyHinder.Add(1);            
            MenyX.Add(15); MenyY.Add(6); MenyHinder.Add(1);
            //K
            MenyX.Add(17); MenyY.Add(2); MenyHinder.Add(1);
            MenyX.Add(17); MenyY.Add(3); MenyHinder.Add(1);
            MenyX.Add(17); MenyY.Add(4); MenyHinder.Add(1);
            MenyX.Add(17); MenyY.Add(5); MenyHinder.Add(1);
            MenyX.Add(17); MenyY.Add(6); MenyHinder.Add(1);
            MenyX.Add(17); MenyY.Add(7); MenyHinder.Add(1);            
            MenyX.Add(18); MenyY.Add(4); MenyHinder.Add(1);
            MenyX.Add(18); MenyY.Add(5); MenyHinder.Add(1);
            MenyX.Add(19); MenyY.Add(3); MenyHinder.Add(1);
            MenyX.Add(19); MenyY.Add(6); MenyHinder.Add(1);
            MenyX.Add(20); MenyY.Add(2); MenyHinder.Add(1);
            MenyX.Add(20); MenyY.Add(7); MenyHinder.Add(1);
            //Y
            MenyX.Add(22); MenyY.Add(2); MenyHinder.Add(1);
            MenyX.Add(23); MenyY.Add(3); MenyHinder.Add(1);
            MenyX.Add(24); MenyY.Add(4); MenyHinder.Add(1);
            MenyX.Add(24); MenyY.Add(5); MenyHinder.Add(1);
            MenyX.Add(24); MenyY.Add(6); MenyHinder.Add(1);
            MenyX.Add(24); MenyY.Add(7); MenyHinder.Add(1);
            MenyX.Add(25); MenyY.Add(3); MenyHinder.Add(1);
            MenyX.Add(26); MenyY.Add(2); MenyHinder.Add(1);

            //R
            MenyX.Add(2); MenyY.Add(11); MenyHinder.Add(1);
            MenyX.Add(2); MenyY.Add(12); MenyHinder.Add(1);
            MenyX.Add(2); MenyY.Add(13); MenyHinder.Add(1);
            MenyX.Add(2); MenyY.Add(14); MenyHinder.Add(1);
            MenyX.Add(2); MenyY.Add(15); MenyHinder.Add(1);
            MenyX.Add(2); MenyY.Add(16); MenyHinder.Add(1);
            MenyX.Add(3); MenyY.Add(11); MenyHinder.Add(1);
            MenyX.Add(3); MenyY.Add(13); MenyHinder.Add(1);
            MenyX.Add(3); MenyY.Add(14); MenyHinder.Add(1);
            MenyX.Add(4); MenyY.Add(11); MenyHinder.Add(1);
            MenyX.Add(4); MenyY.Add(13); MenyHinder.Add(1);
            MenyX.Add(4); MenyY.Add(15); MenyHinder.Add(1);
            MenyX.Add(5); MenyY.Add(12); MenyHinder.Add(1);
            MenyX.Add(5); MenyY.Add(16); MenyHinder.Add(1);
            //O
            MenyX.Add(7); MenyY.Add(12); MenyHinder.Add(1);
            MenyX.Add(7); MenyY.Add(13); MenyHinder.Add(1);
            MenyX.Add(7); MenyY.Add(14); MenyHinder.Add(1);
            MenyX.Add(7); MenyY.Add(15); MenyHinder.Add(1);
            MenyX.Add(8); MenyY.Add(11); MenyHinder.Add(1);
            MenyX.Add(8); MenyY.Add(16); MenyHinder.Add(1);
            MenyX.Add(9); MenyY.Add(11); MenyHinder.Add(1);
            MenyX.Add(9); MenyY.Add(16); MenyHinder.Add(1);
            MenyX.Add(10); MenyY.Add(12); MenyHinder.Add(1);
            MenyX.Add(10); MenyY.Add(13); MenyHinder.Add(1);
            MenyX.Add(10); MenyY.Add(14); MenyHinder.Add(1);
            MenyX.Add(10); MenyY.Add(15); MenyHinder.Add(1);
            //A
            MenyX.Add(17); MenyY.Add(14); MenyHinder.Add(1);
            MenyX.Add(17); MenyY.Add(15); MenyHinder.Add(1);
            MenyX.Add(17); MenyY.Add(16); MenyHinder.Add(1);
            MenyX.Add(18); MenyY.Add(12); MenyHinder.Add(1);
            MenyX.Add(18); MenyY.Add(13); MenyHinder.Add(1);
            MenyX.Add(18); MenyY.Add(14); MenyHinder.Add(1);
            MenyX.Add(19); MenyY.Add(11); MenyHinder.Add(1);
            MenyX.Add(19); MenyY.Add(14); MenyHinder.Add(1);
            MenyX.Add(20); MenyY.Add(12); MenyHinder.Add(1);
            MenyX.Add(20); MenyY.Add(13); MenyHinder.Add(1);
            MenyX.Add(20); MenyY.Add(14); MenyHinder.Add(1);
            MenyX.Add(21); MenyY.Add(14); MenyHinder.Add(1);
            MenyX.Add(21); MenyY.Add(15); MenyHinder.Add(1);
            MenyX.Add(21); MenyY.Add(16); MenyHinder.Add(1);
            //O
            MenyX.Add(23); MenyY.Add(11); MenyHinder.Add(1);
            MenyX.Add(23); MenyY.Add(12); MenyHinder.Add(1);
            MenyX.Add(23); MenyY.Add(13); MenyHinder.Add(1);
            MenyX.Add(23); MenyY.Add(14); MenyHinder.Add(1);
            MenyX.Add(23); MenyY.Add(15); MenyHinder.Add(1);
            MenyX.Add(23); MenyY.Add(16); MenyHinder.Add(1);
            MenyX.Add(24); MenyY.Add(11); MenyHinder.Add(1);
            MenyX.Add(24); MenyY.Add(16); MenyHinder.Add(1);
            MenyX.Add(25); MenyY.Add(11); MenyHinder.Add(1);
            MenyX.Add(25); MenyY.Add(16); MenyHinder.Add(1);
            MenyX.Add(26); MenyY.Add(12); MenyHinder.Add(1);
            MenyX.Add(26); MenyY.Add(13); MenyHinder.Add(1);
            MenyX.Add(26); MenyY.Add(14); MenyHinder.Add(1);
            MenyX.Add(26); MenyY.Add(15); MenyHinder.Add(1);
        }
                                                              
        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            // Måla Meny
            for (int i = 0; i < MenyX.Count; i++)
            {
                //Vanliga
                if (MenyHinder[i] == 1)
                {
                    g.FillRectangle(Vit, MenyX[i] * Storlek, MenyY[i] * Storlek, Storlek, Storlek);
                }

                //fylda
                if ((int)MenyHinder[i] == 2)
                {
                    if (MenyHinder[i] == 2.1)
                    {
                        g.FillRectangle(Grön, MenyX[i] * Storlek, MenyY[i] * Storlek, Storlek, Storlek);
                    }
                    
                    if (MenyHinder[i] == 2.2)
                    {
                        g.FillRectangle(Röd, MenyX[i] * Storlek, MenyY[i] * Storlek, Storlek, Storlek);
                    }

                    if (MenyHinder[i] == 2.3)
                    {
                        g.FillRectangle(Ljusblå, MenyX[i] * Storlek, MenyY[i] * Storlek, Storlek, Storlek);
                    }

                    if (MenyHinder[i] == 2.4)
                    {
                        g.FillRectangle(Blå, MenyX[i] * Storlek, MenyY[i] * Storlek, Storlek, Storlek);
                    }

                    if (MenyHinder[i] == 2.5)
                    {
                        g.FillRectangle(Gul, MenyX[i] * Storlek, MenyY[i] * Storlek, Storlek, Storlek);
                    }                    
                }
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            pnlInfo.Enabled = true;
            pnlInfo.Location = InfoMeny;
            pnlStartMeny.Location = StartMeny;
            pnlStartMeny.Enabled = false;
            pnlBana.Visible = false;
        }

        private void BtnStart2_Click(object sender, EventArgs e)
        {
            pnlBana.Enabled = true;            
           
            pnlBana.Visible = true;
            pnlInfo.Enabled = false;
            pnlInfo.Location = StartMeny;

            BanaTyp();
           
            pnlBana.Invalidate();
        }

        private void BtnStartSpecial_Click(object sender, EventArgs e)
        {
            Special = true;

            pnlBana.Enabled = true;

            pnlBana.Visible = true;
            pnlInfo.Enabled = false;
            pnlInfo.Location = StartMeny;

            BanaTyp();

            pnlBana.Invalidate();
        }

        private void BtnFelmedelande_Click(object sender, EventArgs e)
        {
            Text = "Rocky Road";
            pnlFelmedelande.Enabled = false;
            pnlStartMeny.Location = ActiveMeny;
            pnlFelmedelande.Location = HighScoreMeny;
            pnlStartMeny.Enabled = true;          
            pnlStartMeny.Invalidate();
        }
        private void PnlInfo2_Paint(object sender, PaintEventArgs e)
        {           
            Graphics g = e.Graphics;

            g.FillEllipse(Blå, 19, 19, Storlek + 1, Storlek + 1);//Spelare
            g.FillRectangle(Gul, 20, 40, Storlek, Storlek);//Mål
            g.FillRectangle(Vit, 20, 60, Storlek, Storlek);//Vanliga Hinder
            g.FillRectangle(Röd, 20, 80, Storlek, Storlek);//Dödande Hinder
            g.FillRectangle(Grön, 20, 100, Storlek, Storlek);//Fylda Hinder
            g.DrawRectangle(PGrön, 20, 120, Storlek, Storlek);//Tömmda Hinder
            g.FillEllipse(Grön, 19, 139, Storlek + 1, Storlek + 1);//Knappar
            g.FillRectangle(Grön, 20, 160, Storlek, Storlek);//Portal
            g.FillEllipse(Ljusblå, 19, 159, Storlek + 1, Storlek + 1);
            //Riktnings Bytande Hinder
            Pil1.X = ((20) + (20 / 2));
            Pil1.Y = ((180) - 1);

            Pil2.X = ((20) + (20 / 2));
            Pil2.Y = (180 + 20);

            Pil3.X = ((20) + 20);
            Pil3.Y = (180 + (20 / 2));

            g.FillRectangle(Blå, 20, 180 + ((20 / 2) - (20 / 4)), 20 / 2, 20 / 2);
            g.FillPolygon(Blå, new Point[] { Pil1, Pil2, Pil3 });
        }
        
        Point GOReset = new Point(445, 9);
        Point GOResetS = new Point(0, 0);        

        List<int> BanaX = new List<int>();
        List<int> BanaY = new List<int>();
        List<double> BanaHinder = new List<double>();                 
        
        //flytnign av pjäs relaterat
        bool Flytta = true;
        int TestX = 0;
        int TestY = 0;
        int Riktning = 0;
        int[] x = new int[2] { 0, 0 };// {Nuvarande position,start position}
        int[] y = new int[2] { 0, 0 };// {Nuvarande position,start position}
        //tidtagning
        int Timme = 0;
        int Minut = 0;
        int Secund = 0;
        int Tick = 0;
        //spel Relaterat
        bool PauseFT = false;
        bool TotalReset = false;
        int Liv = 3;
        int försök = 0;
        int Storlek = 20;
        int Bana = 1;
        int Pause = 0;
        //hinder riktnitng
        Point Pil1 = new Point(0, 0);
        Point Pil2 = new Point(0, 0);
        Point Pil3 = new Point(0, 0);
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Flytta)
            {
                if (e.KeyData == Keys.Up) { Riktning = 1; Flytttid.Start(); TidTagning.Start(); }
                if (e.KeyData == Keys.Down) { Riktning = 2; Flytttid.Start(); TidTagning.Start(); }
                if (e.KeyData == Keys.Right) { Riktning = 3; Flytttid.Start(); TidTagning.Start(); }
                if (e.KeyData == Keys.Left) { Riktning = 4; Flytttid.Start(); TidTagning.Start(); }
            }

            //pause
            if (e.KeyData == Keys.P)
            {
                Flytttid.Start();
                Flytttid.Stop();

                TidTagning.Start();
                TidTagning.Stop();

                PauseFT = true;
                Pause = Bana;
                Bana = 0;

                lblPausInfo.Text = "Tryck På S För Att Starta";
                lblPaused.Text = "Paused";

                pnlBana.Invalidate();
            }

            //Start
            if (e.KeyData == Keys.S && PauseFT)
            {
                if (Riktning != 0)
                {
                    Flytttid.Start();
                    TidTagning.Start();
                }

                PauseFT = false;
                Bana = Pause;
                Pause = 0;

                lblPausInfo.Text = "Tryck På P För Att Pausa";
                lblPaused.Text = "";

                pnlBana.Invalidate();
            }

            if (e.KeyData == Keys.R) { Reset(); }

            if (e.KeyData == Keys.Q)
            {
                Reset();

                Text = "Rocky Road";
                pnlBana.Enabled = false;
                pnlStartMeny.Location = ActiveMeny;                
                pnlStartMeny.Enabled = true;
                pnlBana.Visible = false;
                pnlStartMeny.Invalidate();
            }

            if (e.KeyData == Keys.M) Mål();
        }

        private void Reset()
        {
            if (TotalReset)
            {
                Liv = 3;
                försök = 0;

                Bana = 1;

                Timme = 0;
                Minut = 0;
                Secund = 0;
                Tick = 0;
                lblTime.Text = "Tid: " + Timme + ":" + Minut + ":" + Secund + ":" + Tick;

                lblPausInfo.Location = GOResetS;
                lblPausInfo.Text = "Tryck På P För Att Pausa";
                lblPaused.Text = "";

                Riktning = 0;
                Flytta = true;
                TotalReset = false;
            }
            else
            {
                Flytttid.Stop();
                TidTagning.Stop();

                Riktning = 0;

                Flytta = true;

                y[0] = y[1];
                x[0] = x[1];

                försök++;
            }
                        
            BanaTyp();

            pnlBana.Invalidate();
        }

        private void GameOver()
        {
            TotalReset = true;
            Flytta = false;

            lblPaused.Location = new Point((pnlBana.Width- 153)/2,(pnlBana.Height - 31)/2);

            TidTagning.Stop();

            lblPaused.Text = "Game Over";

            GOResetS = lblPausInfo.Location;
            lblPausInfo.Location = GOReset;

            lblPausInfo.Text = "Tryck På R För Att Börja Om";
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;            

            lblLiv.Text = "Liv: " + Liv;
            lblFörsök.Text = "Försök: " + försök;

            if (Liv == 0 || Liv < 0)
            {
                GameOver();
            }            

            // Måla Banan
            for (int i = 0; i < BanaX.Count; i++)
            {
                //Vanliga
                if (BanaHinder[i] == 1)
                {
                    g.FillRectangle(Vit, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                }

                //fylda
                if ((int)BanaHinder[i] == 2)
                {
                    if (BanaHinder[i] == 2.1)
                    {
                        g.FillRectangle(Grön, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                    }// Grön

                    //döda
                    if (BanaHinder[i] == 2.2 || BanaHinder[i] == 2.21)
                    {
                        g.FillRectangle(Röd, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                    }//Röd

                    if (BanaHinder[i] == 2.3)
                    {
                        g.FillRectangle(Ljusblå, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                    }//Ljusblå

                    if (BanaHinder[i] == 2.4)
                    {
                        g.FillRectangle(Blå, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                    }//Blå

                    if (BanaHinder[i] == 2.5)
                    {
                        g.FillRectangle(Gul, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                    }//Gul/Mål

                    if (BanaHinder[i] == 2.6)
                    {
                        g.FillRectangle(Svart, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                    }//Svart
                }

                //ofylda
                if ((int)BanaHinder[i] == 3)
                {
                    if (BanaHinder[i] == 3.1)
                    {
                        g.DrawRectangle(PGrön, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek - 1, Storlek - 1);
                    }//Grön

                    if (BanaHinder[i] == 3.22 || BanaHinder[i] == 3.21)
                    {
                        g.DrawRectangle(PRöd, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek - 1, Storlek - 1);
                    }//Röd

                    if (BanaHinder[i] == 3.3)
                    {
                        g.DrawRectangle(PLjusblå, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                    }//Ljusblå

                    if (BanaHinder[i] == 3.4)
                    {
                        g.DrawRectangle(PBlå, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                    }//Blå

                    if (BanaHinder[i] == 3.5)
                    {
                        g.DrawRectangle(PGul, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                    }//Gul
                }

                //knapp
                if ((int)BanaHinder[i] == 4)
                {
                    if (BanaHinder[i] == 4.11 /*fyld till ofyld*/ || BanaHinder[i] == 4.12 /*ofyld till fyld*/)
                    {
                        g.FillEllipse(Grön, BanaX[i] * Storlek - 1, BanaY[i] * Storlek - 1, Storlek + 1, Storlek + 1);
                    }//Grön

                    if (BanaHinder[i] == 4.21 /*fyld till ofyld*/ || BanaHinder[i] == 4.22 /*ofyld till fyld*/)
                    {
                        g.FillEllipse(Ljusblå, BanaX[i] * Storlek - 1, BanaY[i] * Storlek - 1, Storlek + 1, Storlek + 1);
                    }//Ljusblå

                    if (BanaHinder[i] == 4.31 /*fyld till ofyld*/ || BanaHinder[i] == 4.32 /*ofyld till fyld*/)
                    {
                        g.FillEllipse(Blå, BanaX[i] * Storlek - 1, BanaY[i] * Storlek - 1, Storlek + 1, Storlek + 1);
                    }//Blå

                    if (BanaHinder[i] == 4.41 /*fyld till ofyld*/ || BanaHinder[i] == 4.42 /*ofyld till fyld*/)
                    {
                        g.FillEllipse(Röd, BanaX[i] * Storlek - 1, BanaY[i] * Storlek - 1, Storlek + 1, Storlek + 1);
                    }//Röd

                    if (BanaHinder[i] == 4.51 /*fyld till ofyld*/ || BanaHinder[i] == 4.52 /*ofyld till fyld*/)
                    {
                        g.FillEllipse(Gul, BanaX[i] * Storlek - 1, BanaY[i] * Storlek - 1, Storlek + 1, Storlek + 1);
                    }//Gul
                }

                //Mål
                if (BanaHinder[i] == 5)
                {
                    g.FillRectangle(Gul, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                }

                //Teleport
                if ((int)BanaHinder[i] == 6)
                {
                    if (BanaHinder[i] == 6.1)
                    {
                        g.FillRectangle(Blå, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);

                        g.FillEllipse(Ljusblå, BanaX[i] * Storlek - 1, BanaY[i] * Storlek - 1, Storlek + 1, Storlek + 1);
                    }

                    if (BanaHinder[i] == 6.2)
                    {
                        g.FillRectangle(Grön, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);

                        g.FillEllipse(Ljusblå, BanaX[i] * Storlek - 1, BanaY[i] * Storlek - 1, Storlek + 1, Storlek + 1);
                    }

                    if (BanaHinder[i] == 6.3)
                    {
                        g.FillRectangle(Röd, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);

                        g.FillEllipse(Ljusblå, BanaX[i] * Storlek - 1, BanaY[i] * Storlek - 1, Storlek + 1, Storlek + 1);
                    }

                    if (BanaHinder[i] == 6.4)
                    {
                        g.FillRectangle(Gul, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);

                        g.FillEllipse(Ljusblå, BanaX[i] * Storlek - 1, BanaY[i] * Storlek - 1, Storlek + 1, Storlek + 1);
                    }
                }

                //riktning
                if ((int)BanaHinder[i] == 7)
                {
                    //ner
                    if (BanaHinder[i] == 7.1)
                    {
                        Pil1.X = ((BanaX[i] * Storlek));
                        Pil1.Y = ((BanaY[i] * Storlek) + ((Storlek / 2)));

                        Pil2.X = ((BanaX[i] * Storlek) + Storlek);
                        Pil2.Y = (BanaY[i] * Storlek + (Storlek / 2));

                        Pil3.X = (BanaX[i] * Storlek) + (Storlek / 2);
                        Pil3.Y = (BanaY[i] * Storlek) + Storlek;

                        g.FillRectangle(Blå, (BanaX[i] * Storlek) + ((Storlek / 4)), BanaY[i] * Storlek, (Storlek / 2), Storlek / 2);
                    }

                    //upp
                    if (BanaHinder[i] == 7.2)
                    {
                        Pil1.X = ((BanaX[i] * Storlek) - 2);
                        Pil1.Y = ((BanaY[i] * Storlek) + ((Storlek / 2)));

                        Pil2.X = ((BanaX[i] * Storlek) + Storlek);
                        Pil2.Y = (BanaY[i] * Storlek + (Storlek / 2));

                        Pil3.X = (BanaX[i] * Storlek) + (Storlek / 2);
                        Pil3.Y = (BanaY[i] * Storlek) - 1;

                        g.FillRectangle(Blå, (BanaX[i] * Storlek) + ((Storlek / 4)), BanaY[i] * Storlek + (Storlek / 2), (Storlek / 2), Storlek / 2);
                    }

                    //vänster
                    if (BanaHinder[i] == 7.3)
                    {
                        Pil1.X = ((BanaX[i] * Storlek) + ((Storlek / 2)));
                        Pil1.Y = ((BanaY[i] * Storlek) - 2);

                        Pil2.X = ((BanaX[i] * Storlek) + ((Storlek / 2)));
                        Pil2.Y = (BanaY[i] * Storlek + Storlek);

                        Pil3.X = (BanaX[i] * Storlek) - 1;
                        Pil3.Y = (BanaY[i] * Storlek + (Storlek / 2));

                        g.FillRectangle(Blå, (BanaX[i] * Storlek) + (Storlek / 2), BanaY[i] * Storlek + ((Storlek / 2) - (Storlek / 4)), Storlek / 2, Storlek / 2);
                    }

                    //höger
                    if (BanaHinder[i] == 7.4)
                    {
                        Pil1.X = ((BanaX[i] * Storlek) + (Storlek / 2));
                        Pil1.Y = ((BanaY[i] * Storlek) - 1);

                        Pil2.X = ((BanaX[i] * Storlek) + (Storlek / 2));
                        Pil2.Y = (BanaY[i] * Storlek + Storlek);

                        Pil3.X = ((BanaX[i] * Storlek) + Storlek);
                        Pil3.Y = (BanaY[i] * Storlek + (Storlek / 2));

                        g.FillRectangle(Blå, BanaX[i] * Storlek, BanaY[i] * Storlek + ((Storlek / 2) - (Storlek / 4)), Storlek / 2, Storlek / 2);
                    }

                    g.FillPolygon(Blå, new Point[] { Pil1, Pil2, Pil3 });
                }
            }

            // Måla pjäs
            g.FillEllipse(Blå, x[0] * Storlek - 1, y[0] * Storlek - 1, Storlek + 1, Storlek + 1);
        }

        int SpecialBana = 0;

        /// <summary>
        /// Denna Metodem läser in Banan Som Ska Visas/Kollas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BanaTyp()
        {
            BanaX = new List<int>();
            BanaY = new List<int>();
            BanaHinder = new List<double>();
            
            if (!Special)
            {
                if (Bana == 1) { sökväg = @"Bana1.txt"; }
                if (Bana == 2) { sökväg = @"Bana2.txt"; }
                if (Bana == 3) { sökväg = @"Bana3.txt"; }
                if (Bana == 4) { sökväg = @"Bana4.txt"; }
                if (Bana == 5) { sökväg = @"Bana5.txt"; }
            }
            else
            {
                if (Bana == 1) { sökväg = @"BanaCostum1.txt"; }
                if (Bana == 2) { sökväg = @"BanaCostum2.txt"; }
                if (Bana == 3) { sökväg = @"BanaCostum3.txt"; }
            }

            if (File.Exists(sökväg))
            {
                StreamReader sr = new StreamReader(sökväg);

                string[] enRad;
                if (!sr.EndOfStream)
                {
                    enRad = sr.ReadLine().Split(',');
                    pnlBana.Width = int.Parse(enRad[0]);
                    pnlBana.Height = int.Parse(enRad[1]);

                    enRad = sr.ReadLine().Split(',');
                    x[0] = x[1] = int.Parse(enRad[0]);
                    y[0] = y[1] = int.Parse(enRad[1]);
                }
                else
                {
                    SpecialBana++; 
                }

                while (!sr.EndOfStream)
                {
                    enRad = sr.ReadLine().Split(',');

                    BanaX.Add(int.Parse(enRad[0]));
                    BanaY.Add(int.Parse(enRad[1]));
                    if (enRad.Length == 4)
                    {
                        if (double.Parse(enRad[3]) >= 0)
                        {
                            if (double.Parse(enRad[3]) >= 10)
                            {
                                BanaHinder.Add(double.Parse(enRad[2]) + ((double.Parse(enRad[3]) / 100)));
                            }
                            else
                            {
                                BanaHinder.Add(double.Parse(enRad[2]) + ((double.Parse(enRad[3]) / 10)));
                            }
                        }
                    }
                    else
                    {
                        BanaHinder.Add(double.Parse(enRad[2]));
                    }
                }
                
                sr.Close();                
            }

            pnlBana.Location = new Point(((560 - pnlBana.Width) / 2) + 12, ((360 - pnlBana.Height) / 2) + 30);
            lblPaused.Location = new Point((pnlBana.Width - 106) / 2, (pnlBana.Height - 32) / 2);

            if (!BanaHinder.Contains(5))
            {
                Mål();
            }
        }

        private void FlyttaEttSteg()
        {
            //uppåt
            if (Riktning == 1)
            {
                TestY--;
            }

            //neråt
            if (Riktning == 2)
            {
                TestY++;
            }

            //höger
            if (Riktning == 3)
            {
                TestX++;
            }

            //vänster
            if (Riktning == 4)
            {
                TestX--;
            }
        }

        private void Flytttid_Tick(object sender, EventArgs e)
        {
            Flytta = false;

            TestX = x[0];
            TestY = y[0];

            FlyttaEttSteg();            

            //Händelser
            for (int i = 0; i < BanaX.Count; i++)
            {
                //Sväva ovan
                if (BanaX[i] == x[0] && BanaY[i] == y[0])
                {
                    //knapp
                    if ((int)BanaHinder[i] == 4)
                    {
                        //Grön
                        if (BanaHinder[i] == 4.11)
                        {
                            while (BanaHinder.Contains(2.1))
                            {
                                BanaHinder[BanaHinder.IndexOf(2.1)] = 3.1;
                            }
                        }

                        if (BanaHinder[i] == 4.12)
                        {
                            while (BanaHinder.Contains(3.1))
                            {
                                BanaHinder[BanaHinder.IndexOf(3.1)] = 2.1;
                            }
                        }
                        //Ljusblå
                        if (BanaHinder[i] == 4.21)
                        {
                            while (BanaHinder.Contains(2.3))
                            {
                                BanaHinder[BanaHinder.IndexOf(2.3)] = 3.3;
                            }
                        }

                        if (BanaHinder[i] == 4.22)
                        {
                            while (BanaHinder.Contains(3.3))
                            {
                                BanaHinder[BanaHinder.IndexOf(3.3)] = 2.3;
                            }
                        }
                        //Blå
                        if (BanaHinder[i] == 4.31)
                        {
                            while (BanaHinder.Contains(2.4))
                            {
                                BanaHinder[BanaHinder.IndexOf(2.4)] = 3.4;
                            }
                        }

                        if (BanaHinder[i] == 4.32)
                        {
                            while (BanaHinder.Contains(3.4))
                            {
                                BanaHinder[BanaHinder.IndexOf(3.4)] = 2.4;
                            }
                        }
                        //Röd
                        if (BanaHinder[i] == 4.41)
                        {
                            while (BanaHinder.Contains(2.21))
                            {
                                BanaHinder[BanaHinder.IndexOf(2.21)] = 3.22;
                            }
                        }

                        if (BanaHinder[i] == 4.42)
                        {
                            while (BanaHinder.Contains(3.22))
                            {
                                BanaHinder[BanaHinder.IndexOf(3.22)] = 2.21;
                            }
                        }
                        //Gul
                        if (BanaHinder[i] == 4.51)
                        {
                            while (BanaHinder.Contains(3.5))
                            {
                                BanaHinder[BanaHinder.IndexOf(3.5)] = 2.5;
                            }
                        }

                        if (BanaHinder[i] == 4.52)
                        {
                            while (BanaHinder.Contains(3.5))
                            {
                                BanaHinder[BanaHinder.IndexOf(3.5)] = 2.5;
                            }
                        }
                    }

                    //Mål
                    if (BanaHinder[i] == 5)
                    {
                        Mål();
                        Flytta = true;
                        TestX = x[0];
                        TestY = y[0];
                        if(Bana > 5 || (Special && Bana > 3) ) { break; }
                    }

                    //teleport
                    if ((int)BanaHinder[i] == 6)
                    {
                        if (BanaHinder.Contains(6.1))
                        {
                            //Blå Portal
                            if (BanaX[BanaHinder.IndexOf(6.1)] == x[0] && BanaY[BanaHinder.IndexOf(6.1)] == y[0])
                            {
                                TestX = BanaX[BanaHinder.LastIndexOf(6.1)];
                                TestY = BanaY[BanaHinder.LastIndexOf(6.1)];

                                FlyttaEttSteg();
                            }

                            if (BanaX[BanaHinder.LastIndexOf(6.1)] == x[0] && BanaY[BanaHinder.LastIndexOf(6.1)] == y[0])
                            {
                                TestX = BanaX[BanaHinder.IndexOf(6.1)];
                                TestY = BanaY[BanaHinder.IndexOf(6.1)];

                                FlyttaEttSteg();
                            }
                        }
                                                
                        if (BanaHinder.Contains(6.2))
                        {
                            //Grön Portal
                            if (BanaX[BanaHinder.IndexOf(6.2)] == x[0] && BanaY[BanaHinder.IndexOf(6.2)] == y[0])
                            {
                                TestX = BanaX[BanaHinder.LastIndexOf(6.2)];
                                TestY = BanaY[BanaHinder.LastIndexOf(6.2)];

                                FlyttaEttSteg();
                            }

                            if (BanaX[BanaHinder.LastIndexOf(6.2)] == x[0] && BanaY[BanaHinder.LastIndexOf(6.2)] == y[0])
                            {
                                TestX = BanaX[BanaHinder.IndexOf(6.2)];
                                TestY = BanaY[BanaHinder.IndexOf(6.2)];

                                FlyttaEttSteg();
                            }

                        }

                        if (BanaHinder.Contains(6.3))
                        {
                            //Röd Portal
                            if (BanaX[BanaHinder.IndexOf(6.3)] == x[0] && BanaY[BanaHinder.IndexOf(6.3)] == y[0])
                            {
                                TestX = BanaX[BanaHinder.LastIndexOf(6.3)];
                                TestY = BanaY[BanaHinder.LastIndexOf(6.3)];

                                FlyttaEttSteg();
                            }

                            if (BanaX[BanaHinder.LastIndexOf(6.3)] == x[0] && BanaY[BanaHinder.LastIndexOf(6.3)] == y[0])
                            {
                                TestX = BanaX[BanaHinder.IndexOf(6.3)];
                                TestY = BanaY[BanaHinder.IndexOf(6.3)];

                                FlyttaEttSteg();
                            }

                        }

                        if (BanaHinder.Contains(6.4))
                        {
                            //Gul Portal
                            if (BanaX[BanaHinder.IndexOf(6.4)] == x[0] && BanaY[BanaHinder.IndexOf(6.4)] == y[0])
                            {
                                TestX = BanaX[BanaHinder.LastIndexOf(6.4)];
                                TestY = BanaY[BanaHinder.LastIndexOf(6.4)];

                                FlyttaEttSteg();
                            }

                            if (BanaX[BanaHinder.LastIndexOf(6.4)] == x[0] && BanaY[BanaHinder.LastIndexOf(6.4)] == y[0])
                            {
                                TestX = BanaX[BanaHinder.IndexOf(6.4)];
                                TestY = BanaY[BanaHinder.IndexOf(6.4)];

                                FlyttaEttSteg();
                            }
                        }                        
                    }
                }

                //out of bounds
                if (x[0] > (pnlBana.Width / Storlek) || x[0] < 0 || y[0] < 0 || y[0] > (pnlBana.Height / Storlek))
                {
                    Reset();

                    Liv--;

                    pnlBana.Invalidate();

                    return;
                }

                //Kolition
                if (BanaX[i] == TestX && BanaY[i] == TestY)
                {
                    //Riktning
                    if ((int)BanaHinder[i] == 7)
                    {
                        //ner
                        if (BanaHinder[i] == 7.1)
                        {
                            Riktning = 2;
                        }

                        //up
                        if (BanaHinder[i] == 7.2)
                        {
                            Riktning = 1;
                        }

                        //vänster
                        if (BanaHinder[i] == 7.3)
                        {
                            Riktning = 4;
                        }

                        //höger
                        if (BanaHinder[i] == 7.4)
                        {
                            Riktning = 3;
                        }
                        break;
                    }

                    //Vanliga / fylda block
                    if (BanaHinder[i] == 1 || ((int)BanaHinder[i] == 2 && BanaHinder[i] < 2.5))
                    {
                        //Döda block
                        if (BanaHinder[i] == 2.2 || BanaHinder[i] == 2.21)
                        {
                            Reset();

                            TestX = x[1];
                            TestY = y[1];

                            Liv--;
                        }
                        else
                        {
                            Flytttid.Stop();

                            Flytta = true;

                            return;
                        }
                    }
                }
                pnlBana.Invalidate();
            }

            x[0] = TestX;
            y[0] = TestY;
            pnlBana.Invalidate();
        }

        private void Mål()
        {
            Bana++;

            TidTagning.Stop();
            Flytttid.Stop();

            if (Bana > 5 || (Special && Bana > 3))
            {
                if (SpecialBana == 3)
                {
                    pnlFelmedelande.Enabled = true;
                    pnlFelmedelande.Location = MenyNamn;
                    pnlInfo.Location = StartMeny;
                    pnlInfo.Enabled = false;

                    pnlBana.Visible = false;

                    Bana = 0;
                    SpecialBana = 0;
                }
                else
                {
                    pnlNamn.Enabled = true;
                    pnlNamn.Location = MenyNamn;
                    pnlBana.Enabled = false;

                    pnlBana.Width = 1;
                    pnlBana.Height = 1;                    
                }
                return;
            }

            BanaTyp();

            Riktning = 0;
            
            pnlBana.Invalidate();
        }

        private void BtnSparaHighscore_Click(object sender, EventArgs e)
        {
            int[] ListaTid = new int[10];

            if (!Special)
            {
                SökvägHighscore = @"HighScore.txt";
            }
            else
            {
                SökvägHighscore = @"HighScoreCostum.txt";
            }
            
            HighScoreLäsare();

            string SpelarNamn = tbxNamn.Text;
            int SpelarTid = Timme * 36000 + Minut * 600 + Secund * 10 + Tick;
            string SpelarTidTimarMinSecTick = Timme + ":" + Minut + ":" + Secund + ":" + Tick;

            for (int i = 0; i < Tid.Count && i < 10; i++)
            {
                string[] TidDelning = Tid.ElementAt(i).Split(':');

                ListaTid[i] = ((int.Parse(TidDelning[0]) * 36000) + (int.Parse(TidDelning[1]) * 600 )+( int.Parse(TidDelning[2]) * 10) + (int.Parse(TidDelning[3])));
            }

            for(int i = 0; i < 10; i++)
            {
                if (SpelarTid < ListaTid[i])
                {
                    Namn.Insert(i, SpelarNamn); Tid.Insert(i, SpelarTidTimarMinSecTick);
                    continue;
                }

                if( i == 9 && SpelarTid > ListaTid[i])
                {
                    Namn.Add(SpelarNamn); Tid.Add(SpelarTidTimarMinSecTick);
                } 
            }

            if (File.Exists(SökvägHighscore))
            {
                StreamWriter sr = new StreamWriter(SökvägHighscore, false);
                                
                for (int i = 0; i < Namn.Count; i++)
                {
                    string s = Namn.ElementAt(i) + "," + Tid[i];
                    sr.WriteLine(s);
                }

                sr.Close();                
            }

            Text = "High Score";
            pnlHighScore.Enabled = true;
            pnlNamn.Location = StartMeny;
            pnlHighScore.Location = ActiveMeny;
            pnlNamn.Enabled = false;
            Height = 460;
            Lista = 0;
            Bana = 0;
            pnlHighScore.Invalidate();

            if (Special) { btnBytaHigscore.PerformClick(); }

        }        

        private void TidTagning_Tick(object sender, EventArgs e)
        {
            Tick++;
            if (Tick == 10)
            {
                Secund++;

                if (Secund == 60)
                {
                    Minut++;

                    if (Minut == 60)
                    {
                        Timme++;
                        Minut = 0;
                    }

                    Secund = 0;
                }

                Tick = 0;
            }

            lblTime.Text = "Tid: " + Timme + ":" + Minut + ":" + Secund + ":" + Tick;
        }

        private void HighScoreLäsare()
        {
            if (File.Exists(SökvägHighscore))
            {
                StreamReader sr = new StreamReader(SökvägHighscore);

                Namn.Clear();
                Tid.Clear();

                while (!sr.EndOfStream)
                {
                    string[] enRad = sr.ReadLine().Split(',');

                    Namn.Add(enRad[0]);
                    Tid.Add(enRad[1]);
                }
                sr.Close();
            }
        }

        private void BtnHighScore_Click(object sender, EventArgs e)
        {
            Text = "High Score";
            pnlHighScore.Enabled = true;
            pnlStartMeny.Location = StartMeny;
            pnlHighScore.Location = ActiveMeny;
            pnlStartMeny.Enabled = false;
            Height = 460;
            Lista = 0;
            pnlHighScore.Invalidate();
        }

        List<string> Namn = new List<string>();
        List<string> Tid = new List<string>();

        int Lista = 0;

        string SökvägHighscore = @"HighScore.txt";
        /// <summary>
        /// Denna metod Fyller Highscore efter bestämd Lista
        /// </summary>
        private void HighScore()
        {
            HighScoreLäsare();

            for (int x = 0; x < Namn.Count; x++)
            {
                if (x == 0) { lblPlats1.Text = Namn[x]; lblTid1.Text = Tid[x]; }
                if (x == 1) { lblPlats2.Text = Namn[x]; lblTid2.Text = Tid[x]; }
                if (x == 2) { lblPlats3.Text = Namn[x]; lblTid3.Text = Tid[x]; }
                if (x == 3) { lblPlats4.Text = Namn[x]; lblTid4.Text = Tid[x]; }
                if (x == 4) { lblPlats5.Text = Namn[x]; lblTid5.Text = Tid[x]; }
                if (x == 5) { lblPlats6.Text = Namn[x]; lblTid6.Text = Tid[x]; }
                if (x == 6) { lblPlats7.Text = Namn[x]; lblTid7.Text = Tid[x]; }
                if (x == 7) { lblPlats8.Text = Namn[x]; lblTid8.Text = Tid[x]; }
                if (x == 8) { lblPlats9.Text = Namn[x]; lblTid9.Text = Tid[x]; }
                if (x == 9) { lblPlats10.Text = Namn[x]; lblTid10.Text = Tid[x]; }
            }
        }

        private void PnlHighScore_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;            
            Pen PVit = new Pen(Color.White,2);

            HighScore();

            g.FillRectangle(Vit, 40, 40, 480, 20);
            g.FillRectangle(Vit, 40, 60, 20, 300);
            g.FillRectangle(Vit, 40, 340, 480, 20);
            g.FillRectangle(Vit, 500, 40, 20, 320);

            g.FillRectangle(Vit, 60, 100, 440, 20);
            g.FillRectangle(Vit, 60, 160, 440, 20);
            g.FillRectangle(Vit, 60, 220, 440, 20);
            g.FillRectangle(Vit, 60, 280, 440, 20);

            g.FillRectangle(Vit, 260, 60, 40, 280);

            g.DrawLine(PVit, 100, 60, 100, 340);
            g.DrawLine(PVit, 200, 60, 200, 340);
            g.DrawLine(PVit, 260, 60, 260, 340);
            g.DrawLine(PVit, 300, 60, 300, 340);
            g.DrawLine(PVit, 340, 60, 340, 340);
            g.DrawLine(PVit, 440, 60, 440, 340);
        }

        private void BtnBytaHigscore_Click(object sender, EventArgs e)
        {          
            lblPlats1.Text = "Plats1"; lblPlats2.Text = "Plats2"; lblPlats3.Text = "Plats3"; lblPlats4.Text = "Plats4"; lblPlats5.Text = "Plats5"; lblPlats6.Text = "Plats6"; lblPlats7.Text = "Plats7"; lblPlats8.Text = "Plats8"; lblPlats9.Text = "Plats9"; lblPlats10.Text = "Plats10";
            lblTid1.Text = "Tid1"; lblTid2.Text = "Tid2"; lblTid3.Text = "Tid3"; lblTid4.Text = "Tid4"; lblTid5.Text = "Tid5"; lblTid6.Text = "Tid6"; lblTid7.Text = "Tid7"; lblTid8.Text = "Tid8"; lblTid9.Text = "Tid9"; lblTid10.Text = "Tid10";

            if (Lista % 2 == 0)
            {
                btnBytaHigscore.Text = "Normal";
                lblHighscoreTop.Text = "High Score: Special Levels";
                SökvägHighscore = @"HighScoreCostum.txt";
                Lista++;
            }
            else
            {
                btnBytaHigscore.Text = "Spacial";
                lblHighscoreTop.Text = "High Score: Normal Levels";
                SökvägHighscore = @"HighScore.txt";
                Lista = 0;
            }

            pnlHighScore.Invalidate();
        }

        private void BtnMenyHigscore_Click(object sender, EventArgs e)
        {
            Text = "Rocky Road";
            pnlHighScore.Enabled = false;
            pnlStartMeny.Location = ActiveMeny;
            pnlHighScore.Location = HighScoreMeny;
            pnlStartMeny.Enabled = true;
            Height = 440;
            pnlHighScore.Invalidate();
        }

        private void BtnLevelMaker_Click(object sender, EventArgs e)
        {
            Text = "Level Maker";

            pnlLevelMaker.Enabled = true;
            pnlStartMeny.Location = StartMeny;
            pnlLevelMaker.Location = ActiveMeny;
            pnlStartMeny.Enabled = false;
            pnlLevelMaker.Invalidate();

            cbxHinder.Items.Add("Block");
            cbxHinder.Items.Add("Döda");            
            cbxHinder.Items.Add("Mål");
            cbxHinder.Items.Add("Start");
            cbxHinder.Items.Add("Disapearing Hinder");
            cbxHinder.Items.Add("Apearing Hinder");
            cbxHinder.Items.Add("Teleport");
            cbxHinder.Items.Add("Riktnigs bytare");

            cbxNamn.Items.Add("Bana 1");
            cbxNamn.Items.Add("Bana 2");
            cbxNamn.Items.Add("Bana 3");
        }

        List<double> Hindertyp = new List<double>();
        List<int> xList = new List<int>();
        List<int> yList = new List<int>();
        int[] Start = new int[2];
        int StorlekX = 20;
        int StorlekY = 20;
        double Hinder = 1;

        bool StartTillBlock = true;
        bool MålTillBlock = true;
        bool TeleportTillBlock = true;

        bool TGrön = true;
        bool TGul = true;
        bool TBlå = true;
        bool TRöd = true;
        bool Teleport = true;

        string sökväg = @"BanaCostum1.txt";

        private void PnlLevelMakerPaint_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;            
            
            // Rut Nät
            for (int x = 0; x < pnlLevelMakerPaint.Width; x += StorlekX)
            {
                g.DrawLine(PVit, x, 0, x, pnlLevelMakerPaint.Height);
            }
            for (int y = 0; y < pnlLevelMakerPaint.Height; y += StorlekY)
            {
                g.DrawLine(PVit, 0, y, pnlLevelMakerPaint.Width, y);
            }
            // Måla Bana
            for (int i = 0; i < xList.Count; i++)
            {
                if (Hindertyp[i] == 0)
                {
                    g.FillRectangle(Gul, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);

                    g.FillEllipse(Blå, xList[i] * StorlekX - 1, yList[i] * StorlekY - 1, StorlekX + 1, StorlekY + 1);
                }//start
                if (Hindertyp[i] == 1)
                {
                    g.FillRectangle(Vit, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }//Vit
                if (Hindertyp[i] == 2.1 || Hindertyp[i] == 6.2)
                {
                    g.FillRectangle(Grön, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }//Grön
                if (Hindertyp[i] == 2.2 || Hindertyp[i] == 6.3)
                {
                    g.FillRectangle(Röd, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }//Röd                
                if (Hindertyp[i] == 2.3)
                {
                    g.FillRectangle(Ljusblå, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }//Ljusblå
                if (Hindertyp[i] == 2.4 || Hindertyp[i] == 6.1)
                {
                    g.FillRectangle(Blå, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }//Blå
                if (Hindertyp[i] == 2.5 || Hindertyp[i] == 5 || Hindertyp[i] == 6.4)
                {
                    g.FillRectangle(Gul, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }//gul/Mål

                if (Hindertyp[i] == 4.11 || Hindertyp[i] == 4.12)
                {
                    g.FillEllipse(Grön, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }//Grön
                if (Hindertyp[i] == 4.21 || Hindertyp[i] == 4.22)
                {
                    g.FillEllipse(Ljusblå, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }//Ljusblå
                if (Hindertyp[i] == 4.31 || Hindertyp[i] == 4.32)
                {
                    g.FillEllipse(Blå, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }//Blå
                if (Hindertyp[i] == 4.41 || Hindertyp[i] == 4.42)
                {
                    g.FillEllipse(Röd, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }//Röd
                if (Hindertyp[i] == 4.51 || Hindertyp[i] == 4.52)
                {
                    g.FillEllipse(Gul, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }//Gul

                if ((int)Hindertyp[i] == 6)
                {
                    g.FillEllipse(Ljusblå, xList[i] * StorlekX - 1, yList[i] * StorlekY - 1, StorlekX + 1, StorlekY + 1);
                }//Cirkel till portal

                if (Hindertyp[i] == 3.1)
                {
                    g.DrawRectangle(PGrön, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }//grön
                if (Hindertyp[i] == 3.2)
                {
                    g.DrawRectangle(PRöd, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }//Röd
                if (Hindertyp[i] == 3.3)
                {
                    g.DrawRectangle(PLjusblå, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }//Ljusblå
                if (Hindertyp[i] == 3.4)
                {
                    g.DrawRectangle(PBlå, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }//Blå
                if (Hindertyp[i] == 3.5)
                {
                    g.DrawRectangle(PGul, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }//Gul

                if (Hindertyp[i] == 7.4)
                {
                    Pil1.X = ((xList[i] * StorlekX) + (StorlekX / 2));
                    Pil1.Y = ((yList[i] * StorlekY) - 1);

                    Pil2.X = ((xList[i] * StorlekX) + (StorlekX / 2));
                    Pil2.Y = (yList[i] * StorlekY + StorlekY);

                    Pil3.X = ((xList[i] * StorlekX) + StorlekX);
                    Pil3.Y = (yList[i] * StorlekY + (StorlekY / 2));

                    g.FillRectangle(Blå, xList[i] * StorlekX, yList[i] * StorlekY + ((StorlekY / 2) - (StorlekY / 4)), StorlekX / 2, StorlekY / 2);
                    g.FillPolygon(Blå, new Point[] { Pil1, Pil2, Pil3 });
                }//Höger
                if (Hindertyp[i] == 7.3)
                {
                    Pil1.X = ((xList[i] * StorlekX) + ((StorlekX / 2)));
                    Pil1.Y = ((yList[i] * StorlekY) - 2);

                    Pil2.X = ((xList[i] * StorlekX) + ((StorlekX / 2)));
                    Pil2.Y = (yList[i] * StorlekY + StorlekY);

                    Pil3.X = (xList[i] * StorlekX) - 1;
                    Pil3.Y = (yList[i] * StorlekY + (StorlekY / 2));

                    g.FillRectangle(Blå, (xList[i] * StorlekX) + (StorlekX / 2), yList[i] * StorlekY + ((StorlekY / 2) - (StorlekY / 4)), StorlekX / 2, StorlekY / 2);
                    g.FillPolygon(Blå, new Point[] { Pil1, Pil2, Pil3 });
                }//Vänster
                if (Hindertyp[i] == 7.2)
                {
                    Pil1.X = ((xList[i] * StorlekX) - 2);
                    Pil1.Y = ((yList[i] * StorlekY) + ((StorlekY / 2)));

                    Pil2.X = ((xList[i] * StorlekX) + StorlekX);
                    Pil2.Y = (yList[i] * StorlekY + (StorlekY / 2));

                    Pil3.X = (xList[i] * StorlekX) + (StorlekX / 2);
                    Pil3.Y = (yList[i] * StorlekY) - 1;

                    g.FillRectangle(Blå, (xList[i] * StorlekX) + ((StorlekX / 4)), yList[i] * StorlekY + (StorlekY / 2), (StorlekX / 2), StorlekY / 2);
                    g.FillPolygon(Blå, new Point[] { Pil1, Pil2, Pil3 });
                }//Upp
                if (Hindertyp[i] == 7.1)
                {
                    Pil1.X = ((xList[i] * StorlekX));
                    Pil1.Y = ((yList[i] * StorlekY) + ((StorlekY / 2)));

                    Pil2.X = ((xList[i] * StorlekX) + StorlekX);
                    Pil2.Y = (yList[i] * StorlekY + (StorlekY / 2));

                    Pil3.X = (xList[i] * StorlekX) + (StorlekX / 2);
                    Pil3.Y = (yList[i] * StorlekY) + StorlekY;

                    g.FillRectangle(Blå, (xList[i] * StorlekX) + ((StorlekX / 4)), yList[i] * StorlekY, (StorlekX / 2), StorlekY / 2);
                    g.FillPolygon(Blå, new Point[] { Pil1, Pil2, Pil3 });
                }//Ner
            }
            
            cbxHinder.Items.Clear();

            cbxHinder.Items.Add("Block");

            cbxHinder.Items.Add("Döda");

            if (!Hindertyp.Contains(5))
            {
                cbxHinder.Items.Add("Mål");
                btnSpara.Enabled = false;
                MålTillBlock = true;
            }
            else { if (MålTillBlock) { cbxHinder.SelectedItem = "Block"; } btnSpara.Enabled = true; MålTillBlock = false; }

            if (!Hindertyp.Contains(0))
            {
                cbxHinder.Items.Add("Start");
                btnSpara.Enabled = false;
                StartTillBlock = true;
            }
            else { if (StartTillBlock) { cbxHinder.SelectedItem = "Block"; } btnSpara.Enabled = true; StartTillBlock = false; }

            cbxHinder.Items.Add("Knapp");            

            cbxHinder.Items.Add("Fylda Hinder");

            cbxHinder.Items.Add("Tömda Hinder");
                       
            if ((!Hindertyp.Contains(6.1) || !Hindertyp.Contains(6.2) || !Hindertyp.Contains(6.3) || !Hindertyp.Contains(6.4)) && Teleport != true)
            {
                Teleport = true;
                pnlLevelMakerPaint.Invalidate();
            }

            if (Teleport)
            {
                cbxHinder.Items.Add("Teleport");
                TeleportTillBlock = true;
            }
            else { if (TeleportTillBlock) { cbxHinder.SelectedItem = "Block"; } TeleportTillBlock = false; }

            cbxHinder.Items.Add("Riktnigs bytare");

            //Kollar om Färgen inte fins i varken Val bara eller redan utritade och lägger till den på listan om den inte fins
            if (cbxHinder.Text.ToString() == "Teleport" && !cbxFärg.Items.Contains("Röd") && !Hindertyp.Contains(6.3))
            {
                cbxFärg.Items.Insert(0, "Röd");
                TRöd = true;
                Teleport = true;
            }
            if (cbxHinder.Text.ToString() == "Teleport" && !cbxFärg.Items.Contains("Blå") && !Hindertyp.Contains(6.1))
            {
                cbxFärg.Items.Insert(0, "Blå");
                TBlå = true;
                Teleport = true;
            }
            if (cbxHinder.Text.ToString() == "Teleport" && !cbxFärg.Items.Contains("Grön") && !Hindertyp.Contains(6.2))
            {
                cbxFärg.Items.Insert(0, "Grön");
                TGrön = true;
                Teleport = true;
            }
            if (cbxHinder.Text.ToString() == "Teleport" && !cbxFärg.Items.Contains("Gul") && !Hindertyp.Contains(6.4))
            {
                cbxFärg.Items.Insert(0, "Gul");
                TGul = true;
                Teleport = true;
            }

            if (Hindertyp.Count != 0)
            {                                                                                  
                if ((Hindertyp[Hindertyp.Count - 1] == 6.3))
                {
                    if ((Hindertyp.IndexOf(6.3) != Hindertyp.LastIndexOf(6.3)))
                    {
                        cbxFärg.Items.Remove("Röd");

                        if (cbxFärg.Items.Contains("Grön"))
                        {
                            cbxFärg.SelectedItem = "Grön";
                        }

                        if (cbxFärg.Items.Contains("Gul"))
                        {
                            cbxFärg.SelectedItem = "Gul";
                        }

                        if (cbxFärg.Items.Contains("Blå"))
                        {
                            cbxFärg.SelectedItem = "Blå";
                        }

                        if (cbxFärg.Items.Count == 0)
                        {
                            Teleport = false;
                            pnlLevelMakerPaint.Invalidate();
                        }

                        if (TRöd)
                        {
                            cbxHinder.Enabled = true;
                            cbxFärg.Enabled = true;
                            btnSpara.Enabled = true;
                            btnLäsa.Enabled = true;
                            TRöd = false;
                        }

                    }//Röd
                    else
                    {
                        if (Hindertyp.Contains(6.3))
                        {
                            cbxHinder.Enabled = false;
                            cbxFärg.Enabled = false;
                            btnSpara.Enabled = false;
                            btnLäsa.Enabled = false;
                        }                       
                    }                    
                }                
                if ((Hindertyp[Hindertyp.Count - 1] == 6.1))
                {
                    if (Hindertyp.IndexOf(6.1) != Hindertyp.LastIndexOf(6.1))
                    {
                        cbxFärg.Items.Remove("Blå");

                        if (cbxFärg.Items.Contains("Grön"))
                        {
                            cbxFärg.SelectedItem = "Grön";
                        }

                        if (cbxFärg.Items.Contains("Gul"))
                        {
                            cbxFärg.SelectedItem = "Gul";
                        }

                        if (cbxFärg.Items.Contains("Röd"))
                        {
                            cbxFärg.SelectedItem = "Röd";
                        }

                        if (cbxFärg.Items.Count == 0)
                        {
                            Teleport = false;
                            pnlLevelMakerPaint.Invalidate();
                        }

                        if (TBlå)
                        {
                            cbxHinder.Enabled = true;
                            cbxFärg.Enabled = true;
                            btnSpara.Enabled = true;
                            btnLäsa.Enabled = true;
                            TBlå = false;
                        }

                    }//Blå
                    else
                    {
                        if (Hindertyp.Contains(6.1))
                        {
                            cbxHinder.Enabled = false;
                            cbxFärg.Enabled = false;
                            btnSpara.Enabled = false;
                            btnLäsa.Enabled = false;
                        }                        
                    }
                }
                if ((Hindertyp[Hindertyp.Count - 1] == 6.2))
                {
                    if (Hindertyp.IndexOf(6.2) != Hindertyp.LastIndexOf(6.2))
                    {
                        cbxFärg.Items.Remove("Grön");

                        if (cbxFärg.Items.Contains("Röd"))
                        {
                            cbxFärg.SelectedItem = "Röd";
                        }

                        if (cbxFärg.Items.Contains("Gul"))
                        {
                            cbxFärg.SelectedItem = "Gul";
                        }

                        if (cbxFärg.Items.Contains("Blå"))
                        {
                            cbxFärg.SelectedItem = "Blå";
                        }

                        if (cbxFärg.Items.Count == 0)
                        {
                            Teleport = false;
                            pnlLevelMakerPaint.Invalidate();
                        }

                        if (TGrön)
                        {
                            cbxHinder.Enabled = true;
                            cbxFärg.Enabled = true;
                            btnSpara.Enabled = true;
                            btnLäsa.Enabled = true;
                            TGrön = false;
                        }

                    }//Grön
                    else
                    {
                        if (Hindertyp.Contains(6.2))
                        {
                            cbxHinder.Enabled = false;
                            cbxFärg.Enabled = false;
                            btnSpara.Enabled = false;
                            btnLäsa.Enabled = false;
                        }                        
                    }
                }
                if ((Hindertyp[Hindertyp.Count - 1] == 6.4))
                {
                    if (Hindertyp.IndexOf(6.4) != Hindertyp.LastIndexOf(6.4))
                    {
                        cbxFärg.Items.Remove("Gul");

                        if (cbxFärg.Items.Contains("Grön"))
                        {
                            cbxFärg.SelectedItem = "Grön";
                        }

                        if (cbxFärg.Items.Contains("Röd"))
                        {
                            cbxFärg.SelectedItem = "Röd";
                        }

                        if (cbxFärg.Items.Contains("Blå"))
                        {
                            cbxFärg.SelectedItem = "Blå";
                        }

                        if (cbxFärg.Items.Count == 0)
                        {
                            Teleport = false;
                            pnlLevelMakerPaint.Invalidate();
                        }

                        if (TGul)
                        {
                            cbxHinder.Enabled = true;
                            cbxFärg.Enabled = true;
                            btnSpara.Enabled = true;
                            btnLäsa.Enabled = true;
                            TGul = false;
                        }

                    }//Gul
                    else
                    {
                        if (Hindertyp.Contains(6.4))
                        {
                            cbxHinder.Enabled = false;
                            cbxFärg.Enabled = false;
                            btnSpara.Enabled = false;
                            btnLäsa.Enabled = false;
                        }                       
                    }
                }                    
            }            
        }

        private void PnlLevelMakerPaint_MouseClick(object sender, MouseEventArgs e)
        {
            int i = 0;
            if (xList.Count != 0)
            {
                for (i = 0; i < xList.Count; i++)
                {
                    if ((xList[i] == (e.X / StorlekX)) == true && (yList[i] == (e.Y / StorlekY)) == true)
                    {
                        if((int)Hindertyp[i] == 6)
                        {
                            double Typ = Hindertyp[i];

                            while (Hindertyp.Contains(Typ))
                            {                                                                
                                xList.RemoveAt(Hindertyp.IndexOf((Typ)));
                                yList.RemoveAt(Hindertyp.IndexOf((Typ)));
                                Hindertyp.RemoveAt(Hindertyp.IndexOf((Typ)));
                            }
                            break;
                        }
                        Hindertyp.RemoveAt(i);
                        xList.RemoveAt(i);
                        yList.RemoveAt(i);                        
                        break;
                    }

                    if (i > xList.Count - 2)
                    {
                        Hindertyp.Add(Hinder);
                        xList.Add(e.X / StorlekX);
                        yList.Add(e.Y / StorlekY);
                        break;
                    }
                }                
            }
            else
            {
                Hindertyp.Add(Hinder);
                xList.Add(e.X / StorlekX);
                yList.Add(e.Y / StorlekY);
            }            

            pnlLevelMakerPaint.Invalidate();
        }

        private void BtnRänsa_Click(object sender, EventArgs e)
        {
            xList.Clear();
            yList.Clear();
            Hindertyp.Clear();

            Teleport = true;
            cbxHinder.Enabled = true;
            cbxFärg.Enabled = true;
            btnSpara.Enabled = true;
            btnLäsa.Enabled = true;
            TRöd = true;
            TGul = true;
            TGrön = true;
            TBlå = true;
            cbxHinder.SelectedItem = "Block";            

            pnlLevelMakerPaint.Invalidate();
        }

        private void CbxFärg_TextChanged(object sender, EventArgs e)
        {
            if ("Vit" == cbxFärg.SelectedItem.ToString()) { }
            if ("Röd" == cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 2) Hinder = 2.2; if ((int)Hinder == 6) Hinder = 6.3; }
            if ("Blå" == cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 2) Hinder = 2.4; if ((int)Hinder == 3) Hinder = 3.4; if ((int)Hinder == 6) Hinder = 6.1; }
            if ("Gul" == cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 2) Hinder = 2.5; if ((int)Hinder == 3) Hinder = 3.5; if ((int)Hinder == 6) Hinder = 6.4; }
            if ("Ljusblå" == cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 2) Hinder = 2.3; if ((int)Hinder == 3) Hinder = 3.3; }
            if ("Grön" == cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 2) Hinder = 2.1; if ((int)Hinder == 3) Hinder = 3.1; if ((int)Hinder == 6) Hinder = 6.2; }
            
            if ("Fylda Hinder Röd" == cbxFärg.SelectedItem.ToString()) { Hinder = 2.21; }
            if ("Tömda Hinder Röd" == cbxFärg.SelectedItem.ToString()) { Hinder = 3.22; }

            if ("Tömma Grön" == cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 4) Hinder = 4.11; }
            if ("Fylla Grön" == cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 4) Hinder = 4.12; }
            if ("Tömma Ljusblå" == cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 4) Hinder = 4.21; }
            if ("Fylla Ljusblå" == cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 4) Hinder = 4.22; }
            if ("Tömma Blå" == cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 4) Hinder = 4.31; }
            if ("Fylla Blå" == cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 4) Hinder = 4.32; }
            if ("Tömma Röd" == cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 4) Hinder = 4.41; }
            if ("Fylla Röd" == cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 4) Hinder = 4.42; }
            if ("Tömma Gul" == cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 4) Hinder = 4.51; }
            if ("Fylla Gul" == cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 4) Hinder = 4.52; }

            if ("Ner" == cbxFärg.SelectedItem.ToString()) { Hinder = 7.1; }
            if ("Upp" == cbxFärg.SelectedItem.ToString()) { Hinder = 7.2; }
            if ("Vänster" == cbxFärg.SelectedItem.ToString()) { Hinder = 7.3; }
            if ("Höger" == cbxFärg.SelectedItem.ToString()) { Hinder = 7.4; }
        }

        private void CbxHinder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ("Start" == cbxHinder.SelectedItem.ToString())
            {
                Hinder = 0;
                cbxFärg.Enabled = false;                
                cbxFärg.Items.Clear();
                cbxFärg.Items.Add("Blå");
                cbxFärg.SelectedItem = "Blå";
                lblInfo.Text = "Bestämer Var Spelaren Startar";
            }

            if ("Block" == cbxHinder.SelectedItem.ToString())
            {
                Hinder = 1;
                cbxFärg.Enabled = false;
                cbxFärg.Items.Clear();
                cbxFärg.Items.Add("Vit");
                cbxFärg.SelectedItem = "Vit";
                lblInfo.Text = "Hindrar Spelaren Kan Inte Passeras";
            }

            if ("Fylda Hinder" == cbxHinder.SelectedItem.ToString())
            {
                Hinder = 2;
                cbxFärg.Enabled = true;
                lblFärg.Text = "Färg";
                cbxFärg.Items.Clear();
                cbxFärg.Items.Add("Grön");
                cbxFärg.Items.Add("Blå");                
                cbxFärg.Items.Add("Gul");
                cbxFärg.Items.Add("Ljusblå");
                cbxFärg.SelectedItem = "Grön";
                lblInfo.Text = "Fylda Hinder Kan Inte Passeras Kan Bli Tömda Hinder Via Knappar";
            }
            
            if ("Döda" == cbxHinder.SelectedItem.ToString())
            {
                Hinder = 2.2;
                cbxFärg.Enabled = false;
                lblFärg.Text = "Färg";
                cbxFärg.Items.Clear();
                cbxFärg.Items.Add("Röd");
                cbxFärg.Items.Add("Fylda Hinder Röd");
                cbxFärg.Items.Add("Tömda Hinder Röd");
                cbxFärg.SelectedItem = "Röd";
                lblInfo.Text = "Tömda Hinder Kan Passeras Utan Att Aktivera effekten Av Hindret";
            }

            if ("Tömda Hinder" == cbxHinder.SelectedItem.ToString())
            {
                Hinder = 3;
                cbxFärg.Enabled = true;
                lblFärg.Text = "Färg";
                cbxFärg.Items.Clear();
                cbxFärg.Items.Add("Grön");
                cbxFärg.Items.Add("Blå");                
                cbxFärg.Items.Add("Gul");
                cbxFärg.Items.Add("Ljusblå");
                cbxFärg.SelectedItem = "Grön";
                lblInfo.Text = "Tömda Hinder Kan Passeras Kan Bli Fylda Hinder Via Knappar";
            }

            if ("Knapp" == cbxHinder.SelectedItem.ToString())
            {
                Hinder = 4;
                cbxFärg.Enabled = true;
                lblFärg.Text = "Färg";
                cbxFärg.Items.Clear();
                cbxFärg.Items.Add("Tömma Grön");
                cbxFärg.Items.Add("Fylla Grön");
                cbxFärg.Items.Add("Tömma Blå");
                cbxFärg.Items.Add("Fylla Blå");
                cbxFärg.Items.Add("Tömma Röd");
                cbxFärg.Items.Add("Fylla Röd");
                cbxFärg.Items.Add("Tömma Gul");
                cbxFärg.Items.Add("Fylla Gul");
                cbxFärg.Items.Add("Tömma Ljusblå");
                cbxFärg.Items.Add("Fylla Ljusblå");
                cbxFärg.SelectedItem = "Tömma Grön";
                lblInfo.Text = "Kan Ändra Tömda och Fylda Hinder Mellan Varandra";
            }

            if ("Mål" == cbxHinder.SelectedItem.ToString())
            {
                Hinder = 5;
                cbxFärg.Enabled = false;
                lblFärg.Text = "Färg";
                cbxFärg.Items.Clear();
                cbxFärg.Items.Add("Gul");
                cbxFärg.SelectedItem = "Gul";
                lblInfo.Text = "Mål Punkt För Spelaren";
            }
            
            if("Teleport" == cbxHinder.SelectedItem.ToString())
            {
                Hinder = 6;
                cbxFärg.Enabled = true;
                lblFärg.Text = "Färg";
                cbxFärg.Items.Clear();
                lblInfo.Text = "Förflyttar Spelaren Till Sin Tvilling Behåller Rörelse Riktning";
                if (TRöd)
                {
                    cbxFärg.Items.Add("Röd");
                }
                if (TBlå)
                {
                    cbxFärg.Items.Add("Blå");
                }
                if (TGrön)
                {
                    cbxFärg.Items.Add("Grön");
                }
                if (TGul)
                {
                    cbxFärg.Items.Add("Gul");
                }

                //Kollar om Färgen inte fins i varken Val bara eller redan utritade och lägger till den på listan om den inte fins
                if (!cbxFärg.Items.Contains("Röd") && !Hindertyp.Contains(6.3))
                {
                    cbxFärg.Items.Insert(0, "Röd");
                    TRöd = true;
                    Teleport = true;
                }
                if (!cbxFärg.Items.Contains("Blå") && !Hindertyp.Contains(6.1))
                {
                    cbxFärg.Items.Insert(0, "Blå");
                    TBlå = true;
                    Teleport = true;
                }
                if (!cbxFärg.Items.Contains("Grön") && !Hindertyp.Contains(6.2))
                {
                    cbxFärg.Items.Insert(0, "Grön");
                    TGrön = true;
                    Teleport = true;
                }
                if (!cbxFärg.Items.Contains("Gul") && !Hindertyp.Contains(6.4))
                {
                    cbxFärg.Items.Insert(0, "Gul");
                    TGul = true;
                    Teleport = true;
                }

                if (cbxFärg.Items.Contains("Grön"))
                {
                    cbxFärg.SelectedItem = "Grön";
                }

                if (cbxFärg.Items.Contains("Gul"))
                {
                    cbxFärg.SelectedItem = "Gul";
                }

                if (cbxFärg.Items.Contains("Blå"))
                {
                    cbxFärg.SelectedItem = "Blå";
                }

                if (cbxFärg.Items.Contains("Röd"))
                {
                    cbxFärg.SelectedItem = "Röd";
                }                                
            }

            if("Riktnigs bytare" == cbxHinder.SelectedItem.ToString())
            {
                Hinder = 7;
                cbxFärg.Enabled = true;
                lblFärg.Text = "Riktning";
                cbxFärg.Items.Clear();
                cbxFärg.Items.Add("Höger");
                cbxFärg.Items.Add("Vänster");
                cbxFärg.Items.Add("Upp");
                cbxFärg.Items.Add("Ner");                
                cbxFärg.SelectedItem = "Höger";
                lblInfo.Text = "Byter Rörelse Riktning Till Den Som Pilen Visar";
            }            
        }

        private void BtnBekräfta_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbxX.Text) > 28) { tbxX.Text = "28"; }
            if (int.Parse(tbxY.Text) > 18) { tbxY.Text = "18"; }
            StorlekX = 400 / int.Parse(tbxX.Text);
            StorlekY = 300 / int.Parse(tbxY.Text);
            pnlLevelMakerPaint.Width = StorlekX * int.Parse(tbxX.Text);
            pnlLevelMakerPaint.Height = StorlekY * int.Parse(tbxY.Text);

            pnlLevelMakerPaint.Invalidate();
        }

        private void CbxNamn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ("Bana 1" == cbxNamn.SelectedItem.ToString()) { sökväg = @"BanaCostum1.txt"; }
            if ("Bana 2" == cbxNamn.SelectedItem.ToString()) { sökväg = @"BanaCostum2.txt"; }
            if ("Bana 3" == cbxNamn.SelectedItem.ToString()) { sökväg = @"BanaCostum3.txt"; }
        }

        private void BtnMeny_Click(object sender, EventArgs e)
        {
            Text = "Rocky Road";
            pnlLevelMaker.Enabled = false;
            pnlStartMeny.Location = ActiveMeny;
            pnlLevelMaker.Location = LevelMakerMeny;
            pnlStartMeny.Enabled = true;
            pnlLevelMaker.Invalidate();
        }

        private void BtnSpara_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(sökväg))
            {
                StreamWriter sr = new StreamWriter(sökväg, false);
                //Banans storlek
                string s = (int.Parse(tbxX.Text) * 20) + "," + (int.Parse(tbxY.Text) * 20);
                sr.WriteLine(s);
                //Start kordinat
                if (Hindertyp.Contains(0)) { s = xList[Hindertyp.IndexOf(0)] + "," + yList[Hindertyp.IndexOf(0)] + "," + Hindertyp[Hindertyp.IndexOf(0)]; sr.WriteLine(s); xList.RemoveAt(Hindertyp.IndexOf(0)); yList.RemoveAt(Hindertyp.IndexOf(0)); Hindertyp.RemoveAt(Hindertyp.IndexOf(0)); }

                //Banans innehåll
                for (int i = 0; i < xList.Count; i++)
                {
                    s = xList[i] + "," + yList[i] + "," + Hindertyp[i];
                    sr.WriteLine(s);
                }

                sr.Close();

                label1.Text = "Fil Status: Sparad";
            }
        }

        private void BtnLäsa_Click(object sender, EventArgs e)
        {
            xList.Clear();
            yList.Clear();
            Hindertyp.Clear();
            
            if (File.Exists(sökväg))
            {
                StreamReader sr = new StreamReader(sökväg);

                string[] enRad;
                if (!sr.EndOfStream)
                {
                    enRad = sr.ReadLine().Split(',');
                    tbxX.Text = enRad[0];
                    tbxY.Text = enRad[1];

                    tbxX.Text = "" + ((int.Parse(tbxX.Text) / 20));
                    tbxY.Text = "" + ((int.Parse(tbxY.Text) / 20));
                }

                while (!sr.EndOfStream)
                {                    
                    enRad = sr.ReadLine().Split(','); 
                    
                    xList.Add(int.Parse(enRad[0]));
                    yList.Add(int.Parse(enRad[1]));
                    if (enRad.Length == 4)
                    {
                        if (double.Parse(enRad[3]) >= 0)
                        {
                            if(double.Parse(enRad[3]) >= 10)
                            {
                                Hindertyp.Add(double.Parse(enRad[2]) + ((double.Parse(enRad[3]) / 100)));
                            }
                            else
                            {
                                Hindertyp.Add(double.Parse(enRad[2]) + ((double.Parse(enRad[3]) / 10)));
                            }                            
                        }
                    }                    
                    else
                    {
                        Hindertyp.Add(double.Parse(enRad[2]));
                    }                                        
                }                
                label1.Text = "Fil Status: Inläst";                
                sr.Close();
            }
            else label1.Text = "Filen finns inte!";

            if (Hindertyp.Contains(6.1))
            {
                TBlå = false;
            }
            if (Hindertyp.Contains(6.2))
            {
                TGrön = false;
            }
            if (Hindertyp.Contains(6.3))
            {
                TRöd = false;
            }
            if (Hindertyp.Contains(6.4))
            {
                TGul = false;
            }

            if (!TBlå && !TGrön && !TRöd && !TGul)
            {
                Teleport = false;
            }

            btnBekräfta.PerformClick();
            pnlLevelMakerPaint.Invalidate();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
/* Program använt för att spara över banorna till sina text dockumentet
            if (File.Exists(@"Bana5.txt"))
            {
                StreamWriter sr = new StreamWriter(@"Bana5.txt", false);
                //Banans storlek
                string s = pnlBana.Width + "," + pnlBana.Height;
                sr.WriteLine(s);
                //Start kordinat                
                s = x[0] + "," + y[0] + ",0";
                sr.WriteLine(s);
                //Banans innehåll
                for (int i = 0; i < Bana5X.Count; i++)
                {
                    s = Bana5X[i] + "," + Bana5Y[i] + "," + Bana5Hinder[i];
                    sr.WriteLine(s);
                }

                sr.Close();
            }*/
