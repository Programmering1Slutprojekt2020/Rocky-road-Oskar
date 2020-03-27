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
            if (true)
            {
                x[0] = x[1] = 27;
                y[0] = y[1] = 17;

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

        }

        bool Flytta = true;
        int Riktning = 0;
        int[] x = new int[2] {0,0};//första position Andra start position
        int[] y = new int[2] {0,0};//första position Andra start position

        bool röd = true;

        int Liv = 3;
        int Storlek = 20;
        int Bana = 1;

        List<int> BanaX = new List<int>();
        List<int> BanaY = new List<int>();
        List<int> BanaHinder = new List<int>();

        List<int> Bana1X = new List<int>();
        List<int> Bana1Y = new List<int>();
        List<int> Bana1Hinder = new List<int>();

        List<int> Bana2X = new List<int>();
        List<int> Bana2Y = new List<int>();
        List<int> Bana2Hinder = new List<int>();

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Flytta)
            {
                if (e.KeyData == Keys.Up) { Riktning = 1; Flytttid.Start(); }
                if (e.KeyData == Keys.Down) { Riktning = 2; Flytttid.Start(); }
                if (e.KeyData == Keys.Right) { Riktning = 3; Flytttid.Start(); }
                if (e.KeyData == Keys.Left) { Riktning = 4; Flytttid.Start(); }

                if (e.KeyData == Keys.P) { }
                if (e.KeyData == Keys.S) { }
            }
            
            if (e.KeyData == Keys.R) { Reset(); }           
        }

        private void Reset()
        {
            y[0] = y[1];
            x[0] = x[1];

            /*
            Bana++;            
            */
            panel1.Invalidate();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {                        
            Graphics g = e.Graphics;
                        
            SolidBrush BorsteVit = new SolidBrush(Color.White);
            SolidBrush BorsteBlå = new SolidBrush(Color.Blue);
            SolidBrush BorsteRöd = new SolidBrush(Color.Red);
            SolidBrush Borstegrön = new SolidBrush(Color.Green);
            SolidBrush BorsteMål = new SolidBrush(Color.Gold);

            Pen PennaGrön = new Pen(Color.Green);
            Pen PennaRöd = new Pen(Color.Red);

            BanaTyp();

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

                if (BanaHinder[i] == 4)
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

                }

            }

            g.FillEllipse(BorsteBlå, x[0] * Storlek, y[0] * Storlek, Storlek, Storlek);
        }

        private void BanaTyp()
        {
            BanaX = new List<int>();
            BanaY = new List<int>();
            BanaHinder = new List<int>();

            if (Bana == 1) { BanaX = Bana1X; BanaY = Bana1Y; BanaHinder = Bana1Hinder; }
            if (Bana == 2) { BanaX = Bana2X; BanaY = Bana2Y; BanaHinder = Bana2Hinder; }
            /*
            if (Bana == 3) { BanaX = Bana3X; BanaY = Bana3Y; BanaHinder = Bana3Hinder; }
            if (Bana == 4) { BanaX = Bana4X; BanaY = Bana4Y; BanaHinder = Bana4Hinder; }
            if (Bana == 5) { BanaX = Bana5X; BanaY = Bana5Y; BanaHinder = Bana5Hinder; }
            */
        }

        private void Flytttid_Tick(object sender, EventArgs e)
        {
            Flytta = false;

            int TestX = x[0];
            int TestY = y[0];

            if (Riktning == 1)
            {
                TestY--;
            }

            if (Riktning == 2)
            {
                TestY++;
            }

            if (Riktning == 3)
            {
                TestX++;
            }

            if (Riktning == 4)
            {
                TestX--;
            }

            BanaTyp();

            for (int i = 0; i < BanaX.Count; i++)
            {
                if (BanaX[i] == x[0] && BanaY[i] == y[0] && BanaHinder[i] == 4)
                {
                    while (BanaHinder.Contains(3))
                    {
                        BanaHinder[BanaHinder.IndexOf(3)] = 5;
                    }
                    if (röd == true)
                    {                                                
                        BanaHinder[BanaHinder.IndexOf(2)] = 6;

                        röd = false;
                    }                                        
                }

                if (BanaX[i] == x[0] && BanaY[i] == y[0] && BanaHinder[i] == 4)
                {
                    Mål();
                }

                if (BanaX[i] == TestX && BanaY[i] == TestY)
                {
                    if (BanaHinder[i] == 1 || BanaHinder[i] == 3)
                    {
                        Flytttid.Stop();

                        Flytta = true;                        

                        return;
                    }

                    if (BanaHinder[i] == 2)
                    {
                        Flytttid.Stop();

                        Flytta = true;

                        TestX = x[1];
                        TestY = y[1];
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
            TidTagning.Stop();
            Flytttid.Stop();
            


        }

        private void TidTagning_Tick(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
        }
    }
}
