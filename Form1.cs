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
            Bana1();

            cbxHinder.Items.Add("Block");
            cbxHinder.Items.Add("Döda");
            cbxHinder.Items.Add("Apearing Hinder");
            cbxHinder.Items.Add("Mål");
            cbxHinder.Items.Add("Start");
            cbxHinder.Items.Add("Disapearing Hinder");

            cbxNamn.Items.Add("BanaCostum1");
            cbxNamn.Items.Add("BanaCostum2");
            cbxNamn.Items.Add("BanaCostum3");
        }

        private void Meny()
        {
            Width = 600;
            Height = 440;
            pnlStartMeny.Location = Meny1;

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

        private void Bana1()
        {
            if (Bana == 1)
            {
                pnlBana.Location = Bana1Point;
                pnlBana.Height = 140;
                pnlBana.Width = 140;

                lblPaused.Location = Pause1;

                x[0] = x[1] = 0;
                y[0] = y[1] = 6;
            }

            Bana1X.Clear(); Bana1Y.Clear(); Bana1Hinder.Clear();

            //mål
            Bana1X.Add(3); Bana1Y.Add(3); Bana1Hinder.Add(5);

            //knapp
            Bana1X.Add(1); Bana1Y.Add(1); Bana1Hinder.Add(4.12);
            Bana1X.Add(4); Bana1Y.Add(2); Bana1Hinder.Add(4.22);

            //ofylda
            Bana1X.Add(1); Bana1Y.Add(6); Bana1Hinder.Add(3.1);
            Bana1X.Add(4); Bana1Y.Add(1); Bana1Hinder.Add(3.1);
            Bana1X.Add(5); Bana1Y.Add(5); Bana1Hinder.Add(3.1);                        
            Bana1X.Add(2); Bana1Y.Add(2); Bana1Hinder.Add(3.3);

            //vanliga
            Bana1X.Add(0); Bana1Y.Add(1); Bana1Hinder.Add(1);
            Bana1X.Add(5); Bana1Y.Add(0); Bana1Hinder.Add(1);
            Bana1X.Add(6); Bana1Y.Add(6); Bana1Hinder.Add(1);            
        }

        private void Bana2()
        {
            if (Bana == 2)
            {
                pnlBana.Location = Bana2Point;
                pnlBana.Height = 360;
                pnlBana.Width = 560;

                lblPaused.Location = Pause2;

                x[0] = x[1] = 27;
                y[0] = y[1] = 17;
            }

            Bana2X.Clear(); Bana2Y.Clear(); Bana2Hinder.Clear();

            //döda
            Bana2X.Add(7); Bana2Y.Add(7); Bana2Hinder.Add(2.21);

            //fylda
            Bana2X.Add(8); Bana2Y.Add(7); Bana2Hinder.Add(2.1);
            Bana2X.Add(18); Bana2Y.Add(1); Bana2Hinder.Add(2.1);

            //knapp
            Bana2X.Add(2); Bana2Y.Add(7); Bana2Hinder.Add(4.41);
            Bana2X.Add(2); Bana2Y.Add(7); Bana2Hinder.Add(4.11);

            //Mål
            Bana2X.Add(26); Bana2Y.Add(1); Bana2Hinder.Add(5);

            //vanliga
            Bana2X.Add(0); Bana2Y.Add(2); Bana2Hinder.Add(1);
            Bana2X.Add(0); Bana2Y.Add(10); Bana2Hinder.Add(1);
            Bana2X.Add(1); Bana2Y.Add(6); Bana2Hinder.Add(1);
            Bana2X.Add(1); Bana2Y.Add(7); Bana2Hinder.Add(1);
            Bana2X.Add(1); Bana2Y.Add(8); Bana2Hinder.Add(1);
            Bana2X.Add(1); Bana2Y.Add(15); Bana2Hinder.Add(1);
            Bana2X.Add(3); Bana2Y.Add(17); Bana2Hinder.Add(1);
            Bana2X.Add(4); Bana2Y.Add(5); Bana2Hinder.Add(1);
            Bana2X.Add(5); Bana2Y.Add(0); Bana2Hinder.Add(1);
            Bana2X.Add(5); Bana2Y.Add(6); Bana2Hinder.Add(1);
            Bana2X.Add(6); Bana2Y.Add(16); Bana2Hinder.Add(1);
            Bana2X.Add(7); Bana2Y.Add(8); Bana2Hinder.Add(1);
            Bana2X.Add(8); Bana2Y.Add(4); Bana2Hinder.Add(1);
            Bana2X.Add(8); Bana2Y.Add(17); Bana2Hinder.Add(1);
            Bana2X.Add(9); Bana2Y.Add(9); Bana2Hinder.Add(1);
            Bana2X.Add(9); Bana2Y.Add(11); Bana2Hinder.Add(1);
            Bana2X.Add(9); Bana2Y.Add(13); Bana2Hinder.Add(1);
            Bana2X.Add(9); Bana2Y.Add(15); Bana2Hinder.Add(1);
            Bana2X.Add(10); Bana2Y.Add(9); Bana2Hinder.Add(1);
            Bana2X.Add(10); Bana2Y.Add(17); Bana2Hinder.Add(1);
            Bana2X.Add(11); Bana2Y.Add(9); Bana2Hinder.Add(1);
            Bana2X.Add(11); Bana2Y.Add(11); Bana2Hinder.Add(1);
            Bana2X.Add(11); Bana2Y.Add(12); Bana2Hinder.Add(1);
            Bana2X.Add(12); Bana2Y.Add(9); Bana2Hinder.Add(1);
            Bana2X.Add(12); Bana2Y.Add(13); Bana2Hinder.Add(1);
            Bana2X.Add(12); Bana2Y.Add(17); Bana2Hinder.Add(1);
            Bana2X.Add(13); Bana2Y.Add(0); Bana2Hinder.Add(1);
            Bana2X.Add(13); Bana2Y.Add(11); Bana2Hinder.Add(1);
            Bana2X.Add(13); Bana2Y.Add(13); Bana2Hinder.Add(1);
            Bana2X.Add(13); Bana2Y.Add(17); Bana2Hinder.Add(1);
            Bana2X.Add(14); Bana2Y.Add(9); Bana2Hinder.Add(1);
            Bana2X.Add(14); Bana2Y.Add(11); Bana2Hinder.Add(1);
            Bana2X.Add(15); Bana2Y.Add(4); Bana2Hinder.Add(1);
            Bana2X.Add(15); Bana2Y.Add(9); Bana2Hinder.Add(1);
            Bana2X.Add(15); Bana2Y.Add(11); Bana2Hinder.Add(1);
            Bana2X.Add(15); Bana2Y.Add(12); Bana2Hinder.Add(1);
            Bana2X.Add(15); Bana2Y.Add(13); Bana2Hinder.Add(1);
            Bana2X.Add(16); Bana2Y.Add(0); Bana2Hinder.Add(1);
            Bana2X.Add(17); Bana2Y.Add(4); Bana2Hinder.Add(1);
            Bana2X.Add(17); Bana2Y.Add(9); Bana2Hinder.Add(1);
            Bana2X.Add(17); Bana2Y.Add(11); Bana2Hinder.Add(1);
            Bana2X.Add(17); Bana2Y.Add(13); Bana2Hinder.Add(1);
            Bana2X.Add(17); Bana2Y.Add(16); Bana2Hinder.Add(1);
            Bana2X.Add(18); Bana2Y.Add(0); Bana2Hinder.Add(1);
            Bana2X.Add(18); Bana2Y.Add(14); Bana2Hinder.Add(1);
            Bana2X.Add(18); Bana2Y.Add(17); Bana2Hinder.Add(1);
            Bana2X.Add(19); Bana2Y.Add(7); Bana2Hinder.Add(1);
            Bana2X.Add(20); Bana2Y.Add(16); Bana2Hinder.Add(1);
            Bana2X.Add(21); Bana2Y.Add(0); Bana2Hinder.Add(1);
            Bana2X.Add(21); Bana2Y.Add(3); Bana2Hinder.Add(1);
            Bana2X.Add(22); Bana2Y.Add(8); Bana2Hinder.Add(1);
            Bana2X.Add(22); Bana2Y.Add(11); Bana2Hinder.Add(1);
            Bana2X.Add(22); Bana2Y.Add(12); Bana2Hinder.Add(1);
            Bana2X.Add(22); Bana2Y.Add(17); Bana2Hinder.Add(1);
            Bana2X.Add(23); Bana2Y.Add(0); Bana2Hinder.Add(1);
            Bana2X.Add(23); Bana2Y.Add(4); Bana2Hinder.Add(1);
            Bana2X.Add(24); Bana2Y.Add(2); Bana2Hinder.Add(1);
            Bana2X.Add(24); Bana2Y.Add(9); Bana2Hinder.Add(1);
            Bana2X.Add(24); Bana2Y.Add(11); Bana2Hinder.Add(1);
            Bana2X.Add(24); Bana2Y.Add(15); Bana2Hinder.Add(1);
            Bana2X.Add(25); Bana2Y.Add(17); Bana2Hinder.Add(1);
            Bana2X.Add(26); Bana2Y.Add(0); Bana2Hinder.Add(1);
            Bana2X.Add(26); Bana2Y.Add(2); Bana2Hinder.Add(1);
            Bana2X.Add(26); Bana2Y.Add(4); Bana2Hinder.Add(1);
            Bana2X.Add(26); Bana2Y.Add(7); Bana2Hinder.Add(1);
            Bana2X.Add(27); Bana2Y.Add(0); Bana2Hinder.Add(1);
            Bana2X.Add(27); Bana2Y.Add(1); Bana2Hinder.Add(1);
            Bana2X.Add(27); Bana2Y.Add(2); Bana2Hinder.Add(1);
        }

        private void Bana3()
        {
            if(Bana == 3)
            {
                pnlBana.Location = Bana3Point;
                pnlBana.Height = 140;
                pnlBana.Width = 300;

                lblPaused.Location = Pause3;

                TPX.Clear(); TPY.Clear(); TPI.Clear();
                

                x[0] = x[1] = 0;
                y[0] = y[1] = 6;
            }

            Bana3X.Clear(); Bana3Y.Clear(); Bana3Hinder.Clear();

            //Mål
            Bana3X.Add(12); Bana3Y.Add(6); Bana3Hinder.Add(5);

            //teleport
            Bana3X.Add(3); TPX.Add(3); Bana3Y.Add(3); TPY.Add(3); Bana3Hinder.Add(6.1); TPI.Add(1);
            Bana3X.Add(11); TPX.Add(11); Bana3Y.Add(3); TPY.Add(3); Bana3Hinder.Add(6.1); TPI.Add(0);

            Bana3X.Add(4); TPX.Add(4); Bana3Y.Add(1); TPY.Add(1); Bana3Hinder.Add(6.2); TPI.Add(3);
            Bana3X.Add(1); TPX.Add(1); Bana3Y.Add(5); TPY.Add(5); Bana3Hinder.Add(6.2); TPI.Add(2);

            Bana3X.Add(1); TPX.Add(1); Bana3Y.Add(3); TPY.Add(3); Bana3Hinder.Add(6.3); TPI.Add(5);
            Bana3X.Add(6); TPX.Add(6); Bana3Y.Add(2); TPY.Add(2); Bana3Hinder.Add(6.3); TPI.Add(4);

            Bana3X.Add(8); TPX.Add(8); Bana3Y.Add(6); TPY.Add(6); Bana3Hinder.Add(6.4); TPI.Add(7);
            Bana3X.Add(14); TPX.Add(14); Bana3Y.Add(3); TPY.Add(3); Bana3Hinder.Add(6.4); TPI.Add(6);

            //vanliga
            Bana3X.Add(0); Bana3Y.Add(0); Bana3Hinder.Add(1);
            Bana3X.Add(2); Bana3Y.Add(2); Bana3Hinder.Add(1);
            Bana3X.Add(2); Bana3Y.Add(4); Bana3Hinder.Add(1);
            Bana3X.Add(4); Bana3Y.Add(2); Bana3Hinder.Add(1);
            Bana3X.Add(4); Bana3Y.Add(4); Bana3Hinder.Add(1);
            Bana3X.Add(4); Bana3Y.Add(6); Bana3Hinder.Add(1);
            Bana3X.Add(5); Bana3Y.Add(1); Bana3Hinder.Add(1);
            Bana3X.Add(6); Bana3Y.Add(5); Bana3Hinder.Add(1);
            Bana3X.Add(7); Bana3Y.Add(0); Bana3Hinder.Add(1);
            Bana3X.Add(7); Bana3Y.Add(1); Bana3Hinder.Add(1);
            Bana3X.Add(7); Bana3Y.Add(2); Bana3Hinder.Add(1);
            Bana3X.Add(7); Bana3Y.Add(3); Bana3Hinder.Add(1);
            Bana3X.Add(7); Bana3Y.Add(4); Bana3Hinder.Add(1);
            Bana3X.Add(7); Bana3Y.Add(5); Bana3Hinder.Add(1);
            Bana3X.Add(7); Bana3Y.Add(6); Bana3Hinder.Add(1);
            Bana3X.Add(8); Bana3Y.Add(0); Bana3Hinder.Add(1);
            Bana3X.Add(8); Bana3Y.Add(5); Bana3Hinder.Add(1);
            Bana3X.Add(11); Bana3Y.Add(0); Bana3Hinder.Add(1);
            Bana3X.Add(13); Bana3Y.Add(6); Bana3Hinder.Add(1);
            Bana3X.Add(14); Bana3Y.Add(1); Bana3Hinder.Add(1);
        }

        private void Bana4()
        {
            if (Bana == 4)
            {
                pnlBana.Location = Bana4Point;
                pnlBana.Height = 200;
                pnlBana.Width = 400;

                lblPaused.Location = Pause4;

                TPX.Clear(); TPY.Clear(); TPI.Clear();

                x[0] = x[1] = 0;
                y[0] = y[1] = 0;
            }

            Bana4X.Clear(); Bana4Y.Clear(); Bana4Hinder.Clear(); 

            //Mål
            Bana4X.Add(0); Bana4Y.Add(4); Bana4Hinder.Add(5);

            //knapp            
            Bana4X.Add(2); Bana4Y.Add(4); Bana4Hinder.Add(4.22);
            Bana4X.Add(2); Bana4Y.Add(4); Bana4Hinder.Add(4.11);
            Bana4X.Add(1); Bana4Y.Add(6); Bana4Hinder.Add(4.32);
            Bana4X.Add(1); Bana4Y.Add(6); Bana4Hinder.Add(4.21);

            //Fylda
            Bana4X.Add(0); Bana4Y.Add(3); Bana4Hinder.Add(2.3);
            Bana4X.Add(1); Bana4Y.Add(3); Bana4Hinder.Add(2.3);
            Bana4X.Add(1); Bana4Y.Add(4); Bana4Hinder.Add(2.3);
            Bana4X.Add(9); Bana4Y.Add(1); Bana4Hinder.Add(2.3);
            Bana4X.Add(9); Bana4Y.Add(7); Bana4Hinder.Add(2.3);
            Bana4X.Add(9); Bana4Y.Add(4); Bana4Hinder.Add(2.1);

            //ofylda
            Bana4X.Add(0); Bana4Y.Add(1); Bana4Hinder.Add(3.4);
            Bana4X.Add(1); Bana4Y.Add(8); Bana4Hinder.Add(3.4);
            Bana4X.Add(10); Bana4Y.Add(0); Bana4Hinder.Add(3.4);
            Bana4X.Add(18); Bana4Y.Add(3); Bana4Hinder.Add(3.4);
            Bana4X.Add(18); Bana4Y.Add(9); Bana4Hinder.Add(3.4);

            //teleport
            Bana4X.Add(8); TPX.Add(8); Bana4Y.Add(6); TPY.Add(6); Bana4Hinder.Add(6.1); TPI.Add(1);
            Bana4X.Add(10); TPX.Add(10); Bana4Y.Add(9); TPY.Add(9); Bana4Hinder.Add(6.1); TPI.Add(0);

            //vanliga
            Bana4X.Add(0); Bana4Y.Add(5); Bana4Hinder.Add(1);
            Bana4X.Add(0); Bana4Y.Add(6); Bana4Hinder.Add(1);
            Bana4X.Add(0); Bana4Y.Add(8); Bana4Hinder.Add(1);
            Bana4X.Add(1); Bana4Y.Add(5); Bana4Hinder.Add(1);
            Bana4X.Add(2); Bana4Y.Add(5); Bana4Hinder.Add(1);
            Bana4X.Add(3); Bana4Y.Add(5); Bana4Hinder.Add(1);
            Bana4X.Add(4); Bana4Y.Add(5); Bana4Hinder.Add(1);
            Bana4X.Add(5); Bana4Y.Add(5); Bana4Hinder.Add(1);
            Bana4X.Add(6); Bana4Y.Add(5); Bana4Hinder.Add(1);
            Bana4X.Add(7); Bana4Y.Add(5); Bana4Hinder.Add(1);
            Bana4X.Add(8); Bana4Y.Add(5); Bana4Hinder.Add(1);
            Bana4X.Add(8); Bana4Y.Add(9); Bana4Hinder.Add(1);
            Bana4X.Add(9); Bana4Y.Add(0); Bana4Hinder.Add(1);
            Bana4X.Add(9); Bana4Y.Add(2); Bana4Hinder.Add(1);
            Bana4X.Add(9); Bana4Y.Add(3); Bana4Hinder.Add(1);
            Bana4X.Add(9); Bana4Y.Add(5); Bana4Hinder.Add(1);
            Bana4X.Add(9); Bana4Y.Add(6); Bana4Hinder.Add(1);
            Bana4X.Add(9); Bana4Y.Add(8); Bana4Hinder.Add(1);
            Bana4X.Add(9); Bana4Y.Add(9); Bana4Hinder.Add(1);
            Bana4X.Add(18); Bana4Y.Add(0); Bana4Hinder.Add(1);
            Bana4X.Add(19); Bana4Y.Add(4); Bana4Hinder.Add(1);
            Bana4X.Add(19); Bana4Y.Add(7); Bana4Hinder.Add(1);
        }

        private void Bana5()
        {
            if (Bana == 5)
            {
                pnlBana.Location = Bana5Point;
                pnlBana.Height = 200;
                pnlBana.Width = 300;

                lblPaused.Location = Pause5;

                TPX.Clear(); TPY.Clear(); TPI.Clear();


                x[0] = x[1] = 0;
                y[0] = y[1] = 9;
            }

            Bana5X.Clear(); Bana5Y.Clear(); Bana5Hinder.Clear();

            //Mål
            Bana5X.Add(2); Bana5Y.Add(0); Bana5Hinder.Add(5);            

            //Döda
            Bana5X.Add(0); Bana5Y.Add(0); Bana5Hinder.Add(2.2);
            Bana5X.Add(5); Bana5Y.Add(1); Bana5Hinder.Add(2.21);
            Bana5X.Add(13); Bana5Y.Add(0); Bana5Hinder.Add(2.2);
            Bana5X.Add(14); Bana5Y.Add(2); Bana5Hinder.Add(2.2);
            Bana5X.Add(14); Bana5Y.Add(3); Bana5Hinder.Add(2.2);

            //kanpp
            Bana5X.Add(0); Bana5Y.Add(5); Bana5Hinder.Add(4.41);
            Bana5X.Add(0); Bana5Y.Add(5); Bana5Hinder.Add(4.11);
            Bana5X.Add(7); Bana5Y.Add(4); Bana5Hinder.Add(4.11);
            Bana5X.Add(13); Bana5Y.Add(6); Bana5Hinder.Add(4.42);
            Bana5X.Add(13); Bana5Y.Add(6); Bana5Hinder.Add(4.12);

            //fylda
            Bana5X.Add(7); Bana5Y.Add(4); Bana5Hinder.Add(2.5);
            Bana5X.Add(2); Bana5Y.Add(0); Bana5Hinder.Add(2.6);

            //ofylda
            Bana5X.Add(13); Bana5Y.Add(2); Bana5Hinder.Add(3.1);
            Bana5X.Add(13); Bana5Y.Add(8); Bana5Hinder.Add(3.22);

            //teleport
            Bana5X.Add(7); TPX.Add(7); Bana5Y.Add(5); TPY.Add(5); Bana5Hinder.Add(6.1); TPI.Add(1);
            Bana5X.Add(14); TPX.Add(14); Bana5Y.Add(0); TPY.Add(0); Bana5Hinder.Add(6.1); TPI.Add(0);

            Bana5X.Add(1); TPX.Add(1); Bana5Y.Add(5); TPY.Add(5); Bana5Hinder.Add(6.2); TPI.Add(3);
            Bana5X.Add(14); TPX.Add(14); Bana5Y.Add(1); TPY.Add(1); Bana5Hinder.Add(6.2); TPI.Add(2);

            Bana5X.Add(1); TPX.Add(1); Bana5Y.Add(8); TPY.Add(8); Bana5Hinder.Add(6.3); TPI.Add(5);
            Bana5X.Add(12); TPX.Add(12); Bana5Y.Add(3); TPY.Add(3); Bana5Hinder.Add(6.3); TPI.Add(4);

            Bana5X.Add(7); TPX.Add(7); Bana5Y.Add(3); TPY.Add(3); Bana5Hinder.Add(6.4); TPI.Add(7);
            Bana5X.Add(11); TPX.Add(11); Bana5Y.Add(2); TPY.Add(2); Bana5Hinder.Add(6.4); TPI.Add(6);

            //Riktning
            Bana5X.Add(0); Bana5Y.Add(1); Bana5Hinder.Add(7.4);
            Bana5X.Add(4); Bana5Y.Add(5); Bana5Hinder.Add(7.1);
            Bana5X.Add(4); Bana5Y.Add(8); Bana5Hinder.Add(7.4);
            Bana5X.Add(12); Bana5Y.Add(8); Bana5Hinder.Add(7.2);
            Bana5X.Add(11); Bana5Y.Add(0); Bana5Hinder.Add(7.3);

            //vanliga 
            Bana5X.Add(14); Bana5Y.Add(9); Bana5Hinder.Add(1);
            Bana5X.Add(12); Bana5Y.Add(2); Bana5Hinder.Add(1);
        }
        
        bool PauseFT = false;
        bool TotalReset = false;

        bool Flytta = true;
        int TestX = 0;
        int TestY = 0;
        int Riktning = 0;
        int[] x = new int[2] {0,0};// {Position,start position}
        int[] y = new int[2] {0,0};// {Position,start position}
        //tidtagning
        int Timme = 0;
        int Minut = 0;
        int Secund = 0;
        int Tick = 0;
        //spel Relaterat
        int Liv = 3;
        int försök = 0;
        int Storlek = 20;
        int Bana = 1;
        int Pause = 0;

        Point Pause1 = new Point(12, 55);
        Point Pause2 = new Point(220, 160);
        Point Pause3 = new Point(97, 55);
        Point Pause4 = new Point(147, 85);
        Point Pause5 = new Point(97, 85);

        Point Meny1 = new Point(12, 9);
        Point Meny2 = new Point(620, 9);

        Point GameOver1 = new Point(0, 55);
        Point GameOver2 = new Point(118, 160);
        Point GameOver3 = new Point(74, 55);
        Point GameOver4 = new Point(124, 85);
        Point GameOver5 = new Point(74, 85);
        Point GOReset = new Point(445, 9);
        Point GOResetS = new Point(0, 0);

        Point Bana1Point = new Point(210, 110);
        Point Bana2Point = new Point(12, 30);
        Point Bana3Point = new Point(130, 110);
        Point Bana4Point = new Point(80, 80);
        Point Bana5Point = new Point(130, 80);

        Point Pil1 = new Point(0,0);
        Point Pil2 = new Point(0,0);
        Point Pil3 = new Point(0,0);

        List<int> TPX = new List<int>();
        List<int> TPY = new List<int>();
        List<int> TPI = new List<int>();
        //Meny
        List<int> MenyX = new List<int>();
        List<int> MenyY = new List<int>();
        List<double> MenyHinder = new List<double>();

        List<int> BanaX = new List<int>();
        List<int> BanaY = new List<int>();
        List<double> BanaHinder = new List<double>();
        //Bana 1
        List<int> Bana2X = new List<int>();
        List<int> Bana2Y = new List<int>();
        List<double> Bana2Hinder = new List<double>();
        //bana 2
        List<int> Bana1X = new List<int>();
        List<int> Bana1Y = new List<int>();
        List<double> Bana1Hinder = new List<double>();
        //Bana 3
        List<int> Bana3X = new List<int>();
        List<int> Bana3Y = new List<int>();
        List<double> Bana3Hinder = new List<double>();
        //Bana 4
        List<int> Bana4X = new List<int>();
        List<int> Bana4Y = new List<int>();
        List<double> Bana4Hinder = new List<double>();
        //Bana 5
        List<int> Bana5X = new List<int>();
        List<int> Bana5Y = new List<int>();
        List<double> Bana5Hinder = new List<double>();

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

            Bana1();
            Bana2();
            Bana3();
            Bana4();
            Bana5();

            pnlBana.Invalidate();
        }

        private void GameOver()
        {
            TotalReset = true;
            Flytta = false;

            if (Bana == 1) lblPaused.Location = GameOver1;
            if (Bana == 2) lblPaused.Location = GameOver2;
            if (Bana == 3) lblPaused.Location = GameOver3;
            if (Bana == 4) lblPaused.Location = GameOver4;
            if (Bana == 5) lblPaused.Location = GameOver5;

            TidTagning.Stop();

            lblPaused.Text = "Game Over";

            GOResetS = lblPausInfo.Location;
            lblPausInfo.Location = GOReset;

            lblPausInfo.Text = "Tryck På R För att börja om";
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {                        
            Graphics g = e.Graphics;

            SolidBrush BorsteBlå = new SolidBrush(Color.Blue);   
            SolidBrush BorsteLjusBlå = new SolidBrush(Color.LightBlue); 
            SolidBrush BorsteVit = new SolidBrush(Color.White);              
            SolidBrush BorsteRöd = new SolidBrush(Color.Red);    
            SolidBrush Borstegrön = new SolidBrush(Color.Green); 
            SolidBrush BorsteMål = new SolidBrush(Color.Gold);
            SolidBrush BorsteSvart = new SolidBrush(Color.Black);
            
            Pen PennaBlå = new Pen(Color.Blue);
            Pen PennaLjusBlå = new Pen(Color.LightBlue);         
            Pen PennaGrön = new Pen(Color.Green);                
            Pen PennaRöd = new Pen(Color.Red);            

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
                //Vanliga
                if (BanaHinder[i] == 1)
                {
                    g.FillRectangle(BorsteVit, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                }
                                                
                //fylda
                if((int)BanaHinder[i] == 2)
                {
                    if (BanaHinder[i] == 2.1)
                    {
                        g.FillRectangle(Borstegrön, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                    }

                    //döda
                    if (BanaHinder[i] == 2.2 || BanaHinder[i] == 2.21)
                    {
                        g.FillRectangle(BorsteRöd, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                    }

                    if (BanaHinder[i] == 2.3)
                    {
                        g.FillRectangle(BorsteLjusBlå, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                    }

                    if (BanaHinder[i] == 2.4)
                    {
                        g.FillRectangle(BorsteBlå, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                    }

                    if (BanaHinder[i] == 2.5)
                    {
                        g.FillRectangle(BorsteMål, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                    }

                    if (BanaHinder[i] == 2.6)
                    {
                        g.FillRectangle(BorsteSvart, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                    }
                }

                //ofylda
                if ((int)BanaHinder[i] == 3)
                {
                    if (BanaHinder[i] == 3.1)
                    {
                        g.DrawRectangle(PennaGrön, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek - 1, Storlek - 1);
                    }

                    if (BanaHinder[i] == 3.22|| BanaHinder[i] == 3.21)
                    {
                        g.DrawRectangle(PennaRöd, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek - 1, Storlek - 1);
                    }

                    if (BanaHinder[i] == 3.3)
                    {
                        g.DrawRectangle(PennaLjusBlå, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                    }

                    if (BanaHinder[i] == 3.4)
                    {
                        g.DrawRectangle(PennaBlå, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                    }
                }

                //knapp
                if ((int)BanaHinder[i] == 4)
                {
                    if(BanaHinder[i] == 4.11 /*fyld till ofyld*/ || BanaHinder[i] == 4.12 /*ofyld till fyld*/)
                    {
                        g.FillEllipse(Borstegrön, BanaX[i] * Storlek-1, BanaY[i] * Storlek-1, Storlek+1, Storlek+1);
                    }

                    if (BanaHinder[i] == 4.21 /*fyld till ofyld*/ || BanaHinder[i] == 4.22 /*ofyld till fyld*/)
                    {
                        g.FillEllipse(BorsteLjusBlå, BanaX[i] * Storlek-1, BanaY[i] * Storlek-1, Storlek+1, Storlek+1);
                    }

                    if (BanaHinder[i] == 4.31 /*fyld till ofyld*/ || BanaHinder[i] == 4.32 /*ofyld till fyld*/)
                    {
                        g.FillEllipse(BorsteBlå, BanaX[i] * Storlek - 1, BanaY[i] * Storlek - 1, Storlek + 1, Storlek + 1);
                    }

                    if (BanaHinder[i] == 4.41 /*fyld till ofyld*/ || BanaHinder[i] == 4.42 /*ofyld till fyld*/)
                    {
                        g.FillEllipse(BorsteRöd, BanaX[i] * Storlek - 1, BanaY[i] * Storlek - 1, Storlek + 1, Storlek + 1);
                    }
                }                
                
                //Mål
                if (BanaHinder[i] == 5)
                {
                    g.FillRectangle(BorsteMål, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);
                }                
                
                //Teleport
                if ((int)BanaHinder[i] == 6)
                {
                    if (BanaHinder[i] == 6.1)
                    {
                        g.FillRectangle(BorsteBlå, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);

                        g.FillEllipse(BorsteLjusBlå, BanaX[i] * Storlek-1, BanaY[i] * Storlek-1, Storlek+1, Storlek+1);
                    }

                    if (BanaHinder[i] == 6.2)
                    {
                        g.FillRectangle(Borstegrön, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);

                        g.FillEllipse(BorsteLjusBlå, BanaX[i] * Storlek-1, BanaY[i] * Storlek-1, Storlek+1, Storlek+1);
                    }

                    if (BanaHinder[i] == 6.3)
                    {
                        g.FillRectangle(BorsteRöd, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);

                        g.FillEllipse(BorsteLjusBlå, BanaX[i] * Storlek-1, BanaY[i] * Storlek-1, Storlek+1, Storlek+1);
                    }

                    if (BanaHinder[i] == 6.4)
                    {
                        g.FillRectangle(BorsteRöd, BanaX[i] * Storlek, BanaY[i] * Storlek, Storlek, Storlek);

                        g.FillEllipse(Borstegrön, BanaX[i] * Storlek-1, BanaY[i] * Storlek-1, Storlek+1, Storlek+1);
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

                        g.FillRectangle(BorsteBlå, (BanaX[i] * Storlek) + ((Storlek / 4)), BanaY[i] * Storlek, (Storlek / 2), Storlek / 2);
                    }

                    //upp
                    if (BanaHinder[i] == 7.2)
                    {
                        Pil1.X = ((BanaX[i] * Storlek) - 2);
                        Pil1.Y = ((BanaY[i] * Storlek) + ((Storlek / 2)) );

                        Pil2.X = ((BanaX[i] * Storlek) + Storlek);
                        Pil2.Y = (BanaY[i] * Storlek + (Storlek / 2));

                        Pil3.X = (BanaX[i] * Storlek) + (Storlek / 2);
                        Pil3.Y = (BanaY[i] * Storlek) - 1;

                        g.FillRectangle(BorsteBlå, (BanaX[i] * Storlek) + ((Storlek / 4 )), BanaY[i] * Storlek + (Storlek / 2), (Storlek / 2), Storlek / 2);
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

                        g.FillRectangle(BorsteBlå, (BanaX[i] * Storlek) + (Storlek/2), BanaY[i] * Storlek + ((Storlek / 2) - (Storlek / 4)), Storlek / 2, Storlek / 2);
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

                        g.FillRectangle(BorsteBlå, BanaX[i] * Storlek, BanaY[i] * Storlek + ((Storlek / 2) - (Storlek / 4)), Storlek / 2, Storlek / 2);
                    }
                                        
                    g.FillPolygon(BorsteBlå, new Point[] { Pil1, Pil2, Pil3 });
                }
            }

            // Måla pjäs
            g.FillEllipse(BorsteBlå, x[0] * Storlek-1, y[0] * Storlek-1, Storlek+1, Storlek+1);
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
            BanaHinder = new List<double>();

            if (Bana == 1) { BanaX = Bana1X; BanaY = Bana1Y; BanaHinder = Bana1Hinder; }
            if (Bana == 2) { BanaX = Bana2X; BanaY = Bana2Y; BanaHinder = Bana2Hinder; }
            if (Bana == 3) { BanaX = Bana3X; BanaY = Bana3Y; BanaHinder = Bana3Hinder; }
            if (Bana == 4) { BanaX = Bana4X; BanaY = Bana4Y; BanaHinder = Bana4Hinder; }
            if (Bana == 5) { BanaX = Bana5X; BanaY = Bana5Y; BanaHinder = Bana5Hinder; }                        
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

            BanaTyp();
            
            //Händelser
            for (int i = 0; i < BanaX.Count; i++)
            {
                //Sväva ovan
                if(BanaX[i] == x[0] && BanaY[i] == y[0])
                {
                    //knapp
                    if ((int)BanaHinder[i] == 4)
                    {                        
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
                    }
                    
                    //Mål
                    if (BanaHinder[i] == 5)
                    {
                        Mål();
                        Flytta = true;
                        TestX = x[0];
                        TestY = y[0];
                    }

                    //teleport
                    if ((int)BanaHinder[i] == 6)
                    {
                        for (int t = 0; t < TPX.Count; t++)
                        {
                            if (TPX[t] == x[0] && TPY[t] == y[0])
                            {
                                TestX = TPX[TPI[t]];
                                TestY = TPY[TPI[t]];

                                FlyttaEttSteg();
                                
                                continue;
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
                        if (BanaHinder[i] == 2.2|| BanaHinder[i] == 2.21)
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

            Bana1();
            Bana2();
            Bana3();
            Bana4();
            Bana5();

            Riktning = 0;

            TidTagning.Stop();
            Flytttid.Stop();

            pnlBana.Invalidate();
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

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush BorsteBlå = new SolidBrush(Color.Blue);
            SolidBrush BorsteLjusBlå = new SolidBrush(Color.LightBlue);
            SolidBrush BorsteVit = new SolidBrush(Color.White);
            SolidBrush BorsteRöd = new SolidBrush(Color.Red);
            SolidBrush Borstegrön = new SolidBrush(Color.Green);
            SolidBrush BorsteMål = new SolidBrush(Color.Gold);

            // Måla Meny
            for (int i = 0; i < MenyX.Count; i++)
            {
                //Vanliga
                if (MenyHinder[i] == 1)
                {
                    g.FillRectangle(BorsteVit, MenyX[i] * Storlek, MenyY[i] * Storlek, Storlek, Storlek);
                }

                //fylda
                if ((int)MenyHinder[i] == 2)
                {
                    if (MenyHinder[i] == 2.1)
                    {
                        g.FillRectangle(Borstegrön, MenyX[i] * Storlek, MenyY[i] * Storlek, Storlek, Storlek);
                    }
                    
                    if (MenyHinder[i] == 2.2)
                    {
                        g.FillRectangle(BorsteRöd, MenyX[i] * Storlek, MenyY[i] * Storlek, Storlek, Storlek);
                    }

                    if (MenyHinder[i] == 2.3)
                    {
                        g.FillRectangle(BorsteLjusBlå, MenyX[i] * Storlek, MenyY[i] * Storlek, Storlek, Storlek);
                    }

                    if (MenyHinder[i] == 2.4)
                    {
                        g.FillRectangle(BorsteBlå, MenyX[i] * Storlek, MenyY[i] * Storlek, Storlek, Storlek);
                    }

                    if (MenyHinder[i] == 2.5)
                    {
                        g.FillRectangle(BorsteMål, MenyX[i] * Storlek, MenyY[i] * Storlek, Storlek, Storlek);
                    }                    
                }
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {           
            pnlBana.Enabled = true;
            pnlStartMeny.Location = Meny2;
            pnlStartMeny.Enabled = false;
            pnlBana.Invalidate();            
        }

        private void BtnHighScore_Click(object sender, EventArgs e)
        {
            pnlHighScore.Enabled = true;
            pnlStartMeny.Location = Meny2;
            pnlHighScore.Location = Meny1;
            pnlStartMeny.Enabled = false;
            pnlHighScore.Invalidate();
        }

        private void BtnLevelMaker_Click(object sender, EventArgs e)
        {
            pnlLevelMaker.Enabled = true;
            pnlStartMeny.Location = Meny2;
            pnlLevelMaker.Location = Meny1;
            pnlStartMeny.Enabled = false;
            pnlLevelMaker.Invalidate();
        }

        List<double> Hindertyp = new List<double>();
        List<int> xList = new List<int>();
        List<int> yList = new List<int>();
        int StorlekX = 20;
        int StorlekY = 20;
        double Hinder = 1;

        string sökväg = @"BanaCostum1.txt";

        private void PnlLevelMakerPaint_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen PVit = new Pen(Color.White);

            SolidBrush Vit = new SolidBrush(Color.White);
            SolidBrush Blå = new SolidBrush(Color.Blue);
            SolidBrush Red = new SolidBrush(Color.Red);
            SolidBrush Gul = new SolidBrush(Color.Yellow);
            SolidBrush Grön = new SolidBrush(Color.Green);
            SolidBrush Ljusblå = new SolidBrush(Color.LightBlue);

            for (int x = 0; x < pnlLevelMakerPaint.Width; x += StorlekX)
            {
                g.DrawLine(PVit, x, 0, x, pnlLevelMakerPaint.Height);
            }

            for (int y = 0; y < pnlLevelMakerPaint.Height; y += StorlekY)
            {
                g.DrawLine(PVit, 0, y, pnlLevelMakerPaint.Width, y);
            }

            for (int i = 0; i < xList.Count; i++)
            {
                if (Hindertyp[i] == 1)
                {
                    g.FillRectangle(Vit, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }
                if (Hindertyp[i] == 2.2)
                {
                    g.FillRectangle(Red, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }
                if (Hindertyp[i] == 2.4)
                {
                    g.FillRectangle(Blå, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }
                if (Hindertyp[i] == 2.3)
                {
                    g.FillRectangle(Ljusblå, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }
                if (Hindertyp[i] == 2.5 || Hindertyp[i] == 5)
                {
                    g.FillRectangle(Gul, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }
                if (Hindertyp[i] == 2.1)
                {
                    g.FillRectangle(Grön, xList[i] * StorlekX, yList[i] * StorlekY, StorlekX, StorlekY);
                }
            }
        }

        private void PnlLevelMakerPaint_MouseClick(object sender, MouseEventArgs e)
        {
            if (xList.Count != 0)
            {
                for (int i = 0; i < xList.Count; i++)
                {
                    if ((xList[i] == (e.X / StorlekX)) == true && (yList[i] == (e.Y / StorlekY)) == true)
                    {
                        Hindertyp.RemoveAt(i);
                        xList.RemoveAt(i);
                        yList.RemoveAt(i);
                        break;
                    }
                    else
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
            pnlLevelMakerPaint.Invalidate();
        }

        private void CbxFärg_TextChanged(object sender, EventArgs e)
        {
            if ("Vit" == this.cbxFärg.SelectedItem.ToString()) { }
            if ("Röd" == this.cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 2) Hinder = 2.2; if ((int)Hinder == 3) Hinder = 3.2; }
            if ("Blå" == this.cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 2) Hinder = 2.4; if ((int)Hinder == 3) Hinder = 3.4; }
            if ("Gul" == this.cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 2) Hinder = 2.5; if ((int)Hinder == 3) Hinder = 3.5; }
            if ("Ljusblå" == this.cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 2) Hinder = 2.3; if ((int)Hinder == 3) Hinder = 3.3; }
            if ("Grön" == this.cbxFärg.SelectedItem.ToString()) { if ((int)Hinder == 2) Hinder = 2.1; if ((int)Hinder == 3) Hinder = 3.1; }
        }

        private void CbxHinder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ("Block" == this.cbxHinder.SelectedItem.ToString())
            {
                Hinder = 1;
                cbxFärg.Enabled = false;
                cbxFärg.Items.Clear();
                cbxFärg.Items.Add("Vit");
                cbxFärg.SelectedItem = "Vit";
            }

            if ("Döda" == this.cbxHinder.SelectedItem.ToString())
            {
                Hinder = 2.2;
                cbxFärg.Enabled = false;
                cbxFärg.Items.Add("Röd");
                cbxFärg.SelectedItem = "Röd";
            }

            if ("Apearing Hinder" == this.cbxHinder.SelectedItem.ToString())
            {
                Hinder = 2;
                cbxFärg.Enabled = true;
                cbxFärg.Items.Clear();
                cbxFärg.Items.Add("Grön");
                cbxFärg.Items.Add("Blå");
                cbxFärg.Items.Add("Röd");
                cbxFärg.Items.Add("Gul");
                cbxFärg.Items.Add("Ljusblå");
                cbxFärg.SelectedItem = "Grön";
            }

            if ("Mål" == this.cbxHinder.SelectedItem.ToString())
            {
                Hinder = 5;
                cbxFärg.Enabled = false;
                cbxFärg.Items.Clear();
                cbxFärg.Items.Add("Gul");
                cbxFärg.SelectedItem = "Gul";
            }

            if ("Start" == this.cbxHinder.SelectedItem.ToString())
            {
                Hinder = 0;
                cbxFärg.Enabled = false;
                cbxFärg.Text = "Blå";
            }

            if ("Disapearing Hinder" == this.cbxHinder.SelectedItem.ToString())
            {
                Hinder = 3;
                cbxFärg.Enabled = true;
                cbxFärg.Items.Clear();
                cbxFärg.Items.Add("Grön");
                cbxFärg.Items.Add("Blå");
                cbxFärg.Items.Add("Röd");
                cbxFärg.Items.Add("Gul");
                cbxFärg.Items.Add("Ljusblå");
                cbxFärg.SelectedItem = "Grön";
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
            if ("BanaCostum1" == this.cbxNamn.SelectedItem.ToString()) { sökväg = @"BanaCostum1.txt"; }
            if ("BanaCostum2" == this.cbxNamn.SelectedItem.ToString()) { sökväg = @"BanaCostum2.txt"; }
            if ("BanaCostum3" == this.cbxNamn.SelectedItem.ToString()) { sökväg = @"BanaCostum3.txt"; }
        }
    }
}
