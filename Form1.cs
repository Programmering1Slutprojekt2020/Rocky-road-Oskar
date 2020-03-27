using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_slut_Spel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bana1();
            Bana2();
        }

        private void Bana1()
        {
            if (Bana == 1)
            {
                panel1.Location = Bana1Point;
                panel1.Height = 360;
                panel1.Width = 560;

                x[0] = x[1] = 27;
                y[0] = y[1] = 17;
            }
            
            Bana1X.Add(7); Bana1Y.Add(7); Bana1Hinder.Add(2);

            Bana1X.Add(8); Bana1Y.Add(7); Bana1Hinder.Add(3);
            Bana1X.Add(18); Bana1Y.Add(1); Bana1Hinder.Add(3);

            Bana1X.Add(2); Bana1Y.Add(7); Bana1Hinder.Add(4);

            Bana1X.Add(26); Bana1Y.Add(1); Bana1Hinder.Add(7);

            Bana1X.Add(0); Bana1Y.Add(2); Bana1Hinder.Add(1);
            Bana1X.Add(0); Bana1Y.Add(10); Bana1Hinder.Add(1);
            Bana1X.Add(1); Bana1Y.Add(6); Bana1Hinder.Add(1);
            Bana1X.Add(1); Bana1Y.Add(7); Bana1Hinder.Add(1);
            Bana1X.Add(1); Bana1Y.Add(8); Bana1Hinder.Add(1);
            Bana1X.Add(1); Bana1Y.Add(15); Bana1Hinder.Add(1);
            Bana1X.Add(3); Bana1Y.Add(17); Bana1Hinder.Add(1);
            Bana1X.Add(4); Bana1Y.Add(5); Bana1Hinder.Add(1);
            Bana1X.Add(5); Bana1Y.Add(0); Bana1Hinder.Add(1);
            Bana1X.Add(5); Bana1Y.Add(6); Bana1Hinder.Add(1);
            Bana1X.Add(6); Bana1Y.Add(16); Bana1Hinder.Add(1);
            Bana1X.Add(7); Bana1Y.Add(8); Bana1Hinder.Add(1);
            Bana1X.Add(8); Bana1Y.Add(4); Bana1Hinder.Add(1);
            Bana1X.Add(8); Bana1Y.Add(17); Bana1Hinder.Add(1);
            Bana1X.Add(9); Bana1Y.Add(9); Bana1Hinder.Add(1);
            Bana1X.Add(9); Bana1Y.Add(11); Bana1Hinder.Add(1);
            Bana1X.Add(9); Bana1Y.Add(13); Bana1Hinder.Add(1);
            Bana1X.Add(9); Bana1Y.Add(15); Bana1Hinder.Add(1);
            Bana1X.Add(10); Bana1Y.Add(9); Bana1Hinder.Add(1);
            Bana1X.Add(10); Bana1Y.Add(17); Bana1Hinder.Add(1);
            Bana1X.Add(11); Bana1Y.Add(9); Bana1Hinder.Add(1);
            Bana1X.Add(11); Bana1Y.Add(11); Bana1Hinder.Add(1);
            Bana1X.Add(11); Bana1Y.Add(12); Bana1Hinder.Add(1);
            Bana1X.Add(12); Bana1Y.Add(9); Bana1Hinder.Add(1);
            Bana1X.Add(12); Bana1Y.Add(13); Bana1Hinder.Add(1);
            Bana1X.Add(12); Bana1Y.Add(17); Bana1Hinder.Add(1);
            Bana1X.Add(13); Bana1Y.Add(0); Bana1Hinder.Add(1);
            Bana1X.Add(13); Bana1Y.Add(11); Bana1Hinder.Add(1);
            Bana1X.Add(13); Bana1Y.Add(13); Bana1Hinder.Add(1);
            Bana1X.Add(13); Bana1Y.Add(17); Bana1Hinder.Add(1);
            Bana1X.Add(14); Bana1Y.Add(9); Bana1Hinder.Add(1);
            Bana1X.Add(14); Bana1Y.Add(11); Bana1Hinder.Add(1);
            Bana1X.Add(15); Bana1Y.Add(4); Bana1Hinder.Add(1);
            Bana1X.Add(15); Bana1Y.Add(9); Bana1Hinder.Add(1);
            Bana1X.Add(15); Bana1Y.Add(11); Bana1Hinder.Add(1);
            Bana1X.Add(15); Bana1Y.Add(12); Bana1Hinder.Add(1);
            Bana1X.Add(15); Bana1Y.Add(13); Bana1Hinder.Add(1);
            Bana1X.Add(16); Bana1Y.Add(0); Bana1Hinder.Add(1);
            Bana1X.Add(17); Bana1Y.Add(4); Bana1Hinder.Add(1);
            Bana1X.Add(17); Bana1Y.Add(9); Bana1Hinder.Add(1);
            Bana1X.Add(17); Bana1Y.Add(11); Bana1Hinder.Add(1);
            Bana1X.Add(17); Bana1Y.Add(13); Bana1Hinder.Add(1);
            Bana1X.Add(17); Bana1Y.Add(16); Bana1Hinder.Add(1);
            Bana1X.Add(18); Bana1Y.Add(0); Bana1Hinder.Add(1);
            Bana1X.Add(18); Bana1Y.Add(14); Bana1Hinder.Add(1);
            Bana1X.Add(18); Bana1Y.Add(17); Bana1Hinder.Add(1);
            Bana1X.Add(19); Bana1Y.Add(7); Bana1Hinder.Add(1);
            Bana1X.Add(20); Bana1Y.Add(16); Bana1Hinder.Add(1);
            Bana1X.Add(21); Bana1Y.Add(0); Bana1Hinder.Add(1);
            Bana1X.Add(21); Bana1Y.Add(3); Bana1Hinder.Add(1);
            Bana1X.Add(22); Bana1Y.Add(8); Bana1Hinder.Add(1);
            Bana1X.Add(22); Bana1Y.Add(11); Bana1Hinder.Add(1);
            Bana1X.Add(22); Bana1Y.Add(12); Bana1Hinder.Add(1);
            Bana1X.Add(22); Bana1Y.Add(17); Bana1Hinder.Add(1);
            Bana1X.Add(23); Bana1Y.Add(0); Bana1Hinder.Add(1);
            Bana1X.Add(23); Bana1Y.Add(4); Bana1Hinder.Add(1);
            Bana1X.Add(24); Bana1Y.Add(2); Bana1Hinder.Add(1);
            Bana1X.Add(24); Bana1Y.Add(9); Bana1Hinder.Add(1);
            Bana1X.Add(24); Bana1Y.Add(11); Bana1Hinder.Add(1);
            Bana1X.Add(24); Bana1Y.Add(15); Bana1Hinder.Add(1);
            Bana1X.Add(25); Bana1Y.Add(17); Bana1Hinder.Add(1);
            Bana1X.Add(26); Bana1Y.Add(0); Bana1Hinder.Add(1);
            Bana1X.Add(26); Bana1Y.Add(2); Bana1Hinder.Add(1);
            Bana1X.Add(26); Bana1Y.Add(4); Bana1Hinder.Add(1);
            Bana1X.Add(26); Bana1Y.Add(7); Bana1Hinder.Add(1);
            Bana1X.Add(27); Bana1Y.Add(0); Bana1Hinder.Add(1);
            Bana1X.Add(27); Bana1Y.Add(1); Bana1Hinder.Add(1);
            Bana1X.Add(27); Bana1Y.Add(2); Bana1Hinder.Add(1);
        }

        private void Bana2()
        {
            if(Bana == 2)
            {
                panel1.Location = Bana2Point;
                panel1.Height = 140;
                panel1.Width = 140;

                x[0] = x[1] = 0;
                y[0] = y[1] = 6;
            }

            Bana2X.Add(3); Bana2Y.Add(3); Bana2Hinder.Add(7);

            Bana2X.Add(1); Bana2Y.Add(1); Bana2Hinder.Add(9);
            Bana2X.Add(4); Bana2Y.Add(2); Bana2Hinder.Add(8);

            Bana2X.Add(1); Bana2Y.Add(6); Bana2Hinder.Add(5);
            Bana2X.Add(4); Bana2Y.Add(1); Bana2Hinder.Add(5);
            Bana2X.Add(5); Bana2Y.Add(5); Bana2Hinder.Add(5);

            Bana2X.Add(2); Bana2Y.Add(2); Bana2Hinder.Add(10);            

            Bana2X.Add(0); Bana2Y.Add(1); Bana2Hinder.Add(1);
            Bana2X.Add(5); Bana2Y.Add(0); Bana2Hinder.Add(1);
            Bana2X.Add(6); Bana2Y.Add(6); Bana2Hinder.Add(1);
        }

        bool TotalReset = false;
        bool Flytta = true;
        int Riktning = 0;
        int[] x = new int[2] {0,0};// Position, start position
        int[] y = new int[2] {0,0};// Position, start position

        int Timme = 0;
        int Minut = 0;
        int Secund = 0;
        int Tick = 0;

        int Liv = 3;
        int försök = 0;
        int Storlek = 20;
        int Bana = 1;
        int Pause = 0;

        Point Bana2Point = new Point(210, 110);
        Point Bana1Point = new Point(12, 30);
        Point point1 = new Point(445, 9);
        Point start = new Point(0, 0);

        List<int> BanaX = new List<int>();
        List<int> BanaY = new List<int>();
        List<int> BanaHinder = new List<int>();
        //Bana 1
        List<int> Bana1X = new List<int>();
        List<int> Bana1Y = new List<int>();
        List<int> Bana1Hinder = new List<int>();
        //bana 2
        List<int> Bana2X = new List<int>();
        List<int> Bana2Y = new List<int>();
        List<int> Bana2Hinder = new List<int>();
        //Bana 3
        List<int> Bana3X = new List<int>();
        List<int> Bana3Y = new List<int>();
        List<int> Bana3Hinder = new List<int>();
        //Bana 4

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Flytta)
            {
                if (e.KeyData == Keys.Up) { Riktning = 1; Flytttid.Start(); }
                if (e.KeyData == Keys.Down) { Riktning = 2; Flytttid.Start(); }
                if (e.KeyData == Keys.Right) { Riktning = 3; Flytttid.Start(); }
                if (e.KeyData == Keys.Left) { Riktning = 4; Flytttid.Start(); }                
            }

            //pause
            if (e.KeyData == Keys.P)
            {
                Flytttid.Stop();
                TidTagning.Stop();
                Pause = Bana; 
                Bana = 0;
                lblPausInfo.Text = "Tryck På S För Att Starta";
                lblPaused.Text = "Paused";
                panel1.Invalidate();
            }

            //Start
            if (e.KeyData == Keys.S)
            {
                Flytttid.Start();
                TidTagning.Start();
                Bana = Pause;
                Pause = 0;
                lblPausInfo.Text = "Tryck På P För Att Pausa";
                lblPaused.Text = "";
                panel1.Invalidate();
            }

            if (e.KeyData == Keys.R) { Reset(); }

            if (e.KeyData == Keys.M) Mål();
        }

        private void Reset()
        {
            if (TotalReset)
            {
                Liv = 3;
                försök = 0;
                
                TidTagning.Start();

                Bana = 1;

                lblPausInfo.Location = start;
                lblPausInfo.Text = "Tryck På P För Att Pausa";
                lblPaused.Text = "";

                Flytta = true;
                TotalReset = false;
            }
            else
            {
                Flytttid.Stop();

                Flytta = true;

                y[0] = y[1];
                x[0] = x[1];

                försök++;
            }

            Bana1();
            Bana2();

            panel1.Invalidate();
        }

        private void GameOver()
        {
            TotalReset = true;
            Flytta = false;

            lblPaused.Text = "Game Over";

            start = lblPausInfo.Location;
            lblPausInfo.Location = point1;

            lblPausInfo.Text = "Tryck På R För att börja om";
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {                        
            Graphics g = e.Graphics;

            SolidBrush BorsteBlå = new SolidBrush(Color.Blue);   //Pjäs

            SolidBrush BorsteLjusBlå = new SolidBrush(Color.LightBlue); //hinder 8
            SolidBrush BorsteVit = new SolidBrush(Color.White);  //Hinder 1            
            SolidBrush BorsteRöd = new SolidBrush(Color.Red);    //Hinde 2
            SolidBrush Borstegrön = new SolidBrush(Color.Green); //Hinder 3 & Hinder 4 & Hinder 9
            SolidBrush BorsteMål = new SolidBrush(Color.Gold);   //Hinder 7

            Pen PennaLjusBlå = new Pen(Color.LightBlue);         //Hinder 10
            Pen PennaGrön = new Pen(Color.Green);                //Hinder 5
            Pen PennaRöd = new Pen(Color.Red);                   //Hinder 6

            lblLiv.Text = "Liv: " + Liv;
            lblFörsök.Text = "Försök: " + försök;

            if(Liv == 0||Liv < 0)
            {
                GameOver();
            }

            BanaTyp();

            // Måla Banan
            for (int i = 0; i < BanaX.Count; i++)
            {                
                if (BanaHinder[i] == 1)
                {
                    g.FillRectangle(BorsteVit, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                }
                
                if (BanaHinder[i] == 2)
                {
                    g.FillRectangle(BorsteRöd, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                }

                if (BanaHinder[i] == 3)
                {
                    g.FillRectangle(Borstegrön, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                }

                if (BanaHinder[i] == 4 || BanaHinder[i] == 9)
                {
                    g.FillEllipse(Borstegrön, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                }

                if (BanaHinder[i] == 5)
                {
                    g.DrawRectangle(PennaGrön, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek-1, Storlek-1);
                }

                if (BanaHinder[i] == 6)
                {
                    g.DrawRectangle(PennaRöd, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek - 1, Storlek - 1);
                }

                if (BanaHinder[i] == 7)
                {
                    g.FillRectangle(BorsteMål, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                }

                if (BanaHinder[i] == 8)
                {
                    g.FillEllipse(BorsteLjusBlå, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                }

                if(BanaHinder[i] == 11)
                {
                    g.FillRectangle(BorsteLjusBlå, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                }

                if (BanaHinder[i] == 10)
                {
                    g.DrawRectangle(PennaLjusBlå, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                }

            }
            // Måla pjäs
            g.FillEllipse(BorsteBlå, x[0] * Storlek, y[0] * Storlek, Storlek, Storlek);
        }
        
        /// <summary>
        /// Denna Metod Bestämer Vilken Bana Som Ska Visas/Kollas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BanaTyp() 
        {            
            BanaX = new List<int>();
            BanaY = new List<int>();
            BanaHinder = new List<int>();

            if (Bana == 1) { BanaX = Bana1X; BanaY = Bana1Y; BanaHinder = Bana1Hinder; }
            if (Bana == 2) { BanaX = Bana2X; BanaY = Bana2Y; BanaHinder = Bana2Hinder; }
            if (Bana == 3) { BanaX = Bana3X; BanaY = Bana3Y; BanaHinder = Bana3Hinder; }

            /*
            
            if (Bana == 4) { BanaX = Bana4X; BanaY = Bana4Y; BanaHinder = Bana4Hinder; }
            if (Bana == 5) { BanaX = Bana5X; BanaY = Bana5Y; BanaHinder = Bana5Hinder; }
            */
        }

        private void Flytttid_Tick(object sender, EventArgs e)
        {
            Flytta = false;

            int TestX = x[0];
            int TestY = y[0];
            //neråt
            if (Riktning == 1)
            {
                TestY--;
            }
            //uppåt
            if (Riktning == 2)
            {
                TestY++;
            }
            //vänster
            if (Riktning == 3)
            {
                TestX++;
            }
            //höger
            if (Riktning == 4)
            {
                TestX--;
            }

            BanaTyp();
            //Händelser
            for (int i = 0; i < BanaX.Count; i++)
            {
                //Knapp/Hinder 4
                if (BanaX[i] == x[0] && BanaY[i] == y[0] && BanaHinder[i] == 4)
                {
                    while (BanaHinder.Contains(3))
                    {
                        BanaHinder[BanaHinder.IndexOf(3)] = 5;
                    }

                    while(BanaHinder.Contains(2) && Bana == 1)                    
                    {                                                
                        BanaHinder[BanaHinder.IndexOf(2)] = 6;                        
                    }                                        
                }

                //Kanpp/hinder 9
                if(BanaX[i] == x[0] && BanaY[i] == y[0] && BanaHinder[i] == 9)
                {
                    while (BanaHinder.Contains(5))
                    {
                        BanaHinder[BanaHinder.IndexOf(5)] = 3;
                    }
                }

                //Kanpp/hinder 8
                if (BanaX[i] == x[0] && BanaY[i] == y[0] && BanaHinder[i] == 8)
                {
                    while (BanaHinder.Contains(10))
                    {
                        BanaHinder[BanaHinder.IndexOf(10)] = 11;
                    }
                }

                //out of bounds
                if (x[0] > (panel1.Width / Storlek) || x[0] < 0 || y[0] < 0 || y[0] > (panel1.Height / Storlek))
                {
                    Flytttid.Stop();

                    Flytta = true;

                    x[0] = x[1];
                    y[0] = y[1];
                    försök++;
                    Liv--;

                    panel1.Invalidate();

                    return;
                }

                //Mål
                if (BanaX[i] == x[0] && BanaY[i] == y[0] && BanaHinder[i] == 7)
                {
                    Mål();
                }

                //Kolition
                if (BanaX[i] == TestX && BanaY[i] == TestY)
                {
                    //Vanliga block
                    if (BanaHinder[i] == 1 || BanaHinder[i] == 3 || BanaHinder[i] == 11)
                    {
                        Flytttid.Stop();

                        Flytta = true;                        

                        return;
                    }

                    //Döda block
                    if (BanaHinder[i] == 2)
                    {
                        Flytttid.Stop();

                        Flytta = true;
                        
                        TestX = x[1];
                        TestY = y[1];
                        försök++;
                        Liv--;
                    }

                    if(BanaHinder[i] == 5)
                    {
                        
                    }   
                }
                panel1.Invalidate();
            }
            
            x[0] = TestX;
            y[0] = TestY;
            panel1.Invalidate();
        }

        private void Mål()
        {
            Bana++;

            Bana1();
            Bana2();

            TidTagning.Stop();
            Flytttid.Stop();

            panel1.Invalidate();
        }

        private void TidTagning_Tick(object sender, EventArgs e)
        {
            Tick++;
            if (Tick == 10)
            {
                Secund++;

                if(Secund == 60)
                {
                    Minut++;

                    if(Minut == 60)
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
    }
}
