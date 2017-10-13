using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolEsc.Model;
using SchoolEsc.Controller;
using System.Timers;

namespace SchoolEsc.View
{
    public partial class SpeelveldPanel : UserControl
    {
        public static Speler speler;
        SpelerController spelerController;

        
        Random Willekeurig = new Random();

        public SpeelveldPanel()
        {
            InitializeComponent();

            // code om het flikkeren van de speler tegen te gaan.
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);

            // initialiseren nieuwe speler met een breedte en een hoogte.
            speler = new Speler(50, 50);
            spelerController = new SpelerController(speler);

            // bewegingY en X staan op het beginpunt ingesteld
            speler.BewegingY = 0;
            speler.BewegingX = 0;


            //Maakt een aantal vijanden aan.
            MaakVijanden(Willekeurig.Next(1, 3), Willekeurig.Next(0, 3));


            //Testregel
            Console.WriteLine("1 nieuwe vijandreeks");

            //Maakt een timer aan voor het laten bewegen van de vijanden.
            System.Timers.Timer VijandBewegingTimer = new System.Timers.Timer(10000);

            // Event koppelen aan timer.
            VijandBewegingTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            // Aantal miliseconden.
            VijandBewegingTimer.Interval = 100;
            VijandBewegingTimer.Enabled = true;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            //Verplaatst vijanden met 1 pixel.
            VijandController.VerplaatsVijand(1);



            

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics gc = e.Graphics;

            // een image wordt aangemaakt en geinitialeerd.
            Image imag = Image.FromFile(speler.imageFileNaam);
            gc.DrawImage(imag, speler.BewegingX, speler.BewegingY, speler.Breedte, speler.Hoogte);

            //Zorgt dat de karakters op hun nieuwe positie staan.
            foreach (VijandController Item in VijandController.Vijanden)
            {
                //Testregel


                gc.DrawImage(Item.vijand.Afbeelding, new Point(Item.vijand.X, Item.vijand.Y));
            }

            Invalidate();
        }

        // de spelercontroller wordt aangeroepen met de juiste methode zodra er op de arrow knop wordt gedrukt
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            CheckAanrakingVijanden();
            if (keyData == Keys.Down)
            {
                if (speler.BewegingY >= 325) //onderkant speelveld
                {
                    return false;
                }
                if (speler.BewegingX >= 420 && speler.BewegingY >= 220)
                {
                    Controller.ScoreData.VerhoogScore();

                    BeginOpnieuw();
                    // spelerController.ResetSpel();
                    Invalidate();
                    return false;
                }

                spelerController.MoveDown(5);
                Invalidate();
                return true;
            }

            if (keyData == Keys.Up)
            {
                if (speler.BewegingY == 0)
                {
                    return false;
                }
                spelerController.MoveUp(5);
                Invalidate();
                return true;
            }

            if (keyData == Keys.Left)
            {
                if (speler.BewegingX == 0)
                {
                    return false;
                }
                spelerController.MoveLeft(5);
                Invalidate();
                return true;
            }

            if (keyData == Keys.Right)
            {
                if (speler.BewegingX >= 520)
                {
                    return false;
                }
                if (speler.BewegingX >= 420 && speler.BewegingY >= 200)
                {
                    Controller.ScoreData.VerhoogScore();
                    BeginOpnieuw();
                    Invalidate();
                }
                spelerController.MoveRight(5);
                Invalidate();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


       
        public void ResetSpel()
        {
            {
                MessageBox.Show("U heeft gewonnen");
                speler.BewegingX = 0;
                speler.BewegingY = 0;

            }
        }


        public void MaakVijanden(int AantalBewegend, int AantalStilstaand)
        {
            string[] Lichaam = { "../../Resources/Tjeerd.png", "../../Resources/Thomas.png", "../../Resources/Eltjo.png" };

            for (int i = 0; i < AantalBewegend; i++)
            {
                Vijand Vijand = new Vijand(Lichaam[Willekeurig.Next(0, 3)], Vijand.VijandType.Bewegend, Willekeurig.Next(0, 500), Willekeurig.Next(0, 300));
                VijandController vijandcontroller = new VijandController(Vijand);
                SchoolEsc.Controller.VijandController.Vijanden.Add(vijandcontroller);
            }

            for (int i = 0; i < AantalStilstaand; i++)
            {
                Vijand Vijand = new Vijand(Lichaam[Willekeurig.Next(0, 3)], Vijand.VijandType.Stilstaand, Willekeurig.Next(0, 500), Willekeurig.Next(0, 300));
                VijandController vijandcontroller = new VijandController(Vijand);
                SchoolEsc.Controller.VijandController.Vijanden.Add(vijandcontroller);
            }


        }

        public void CheckAanrakingVijanden()
        {
            //Checkt of er een vijand wordt geraakt.
            bool Geraakt = false;
            foreach (VijandController Item in SchoolEsc.Controller.VijandController.Vijanden)
            {
                if ((speler.BewegingX > Item.vijand.X) && (speler.BewegingX < Item.vijand.X + 50)
                    &&
                    (speler.BewegingY > Item.vijand.Y) && (speler.BewegingY < Item.vijand.Y + 50))
                {
                    Geraakt = true;
                }

            }

            if (Geraakt)
            {
                //Wordt uitgevoerd bij het raken van vijanden.

                Console.WriteLine("TESTRAAK");
                BeginOpnieuw();
            }
        }

        public void BeginOpnieuw()
        {

            speler.BewegingY = 0;
            speler.BewegingX = 0;

            SchoolEsc.Controller.VijandController.Vijanden.Clear();
            MaakVijanden(Willekeurig.Next(1, 3), Willekeurig.Next(0, 10));
        }


    }
}
