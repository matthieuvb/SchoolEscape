using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolEsc.Controller
{
    class VijandController
    {

        public SchoolEsc.Model.Vijand vijand;

        public VijandController(SchoolEsc.Model.Vijand vijand)
        {
            this.vijand = vijand;
        }

        public void Links(int Snelheid)
        {
            if (vijand.X == 0)
            {

            }
            vijand.X = vijand.X + Snelheid;
        }

        public void Rechts(int Snelheid)
        {
            if (vijand.X >= 500)
            {

            }
            vijand.X = vijand.X - Snelheid;
        }

        public void Boven(int Snelheid)
        {
            if (vijand.Y == 0)
            {

            }
            vijand.Y = vijand.Y - Snelheid;
        }

        public void Beneden(int Snelheid)
        {
            if (vijand.Y >= 279)
            {

            }
            vijand.Y = vijand.Y + Snelheid;
        }


        //Statische items voor het bewegen van vijanden.

        public static List<VijandController> Vijanden = new List<VijandController>();


        public static void VerplaatsVijand(int Snelheid)
        {
            // Zet i op nul om ook de speler te laten bewegen.
            for (int i = 0; i < Vijanden.Count; i++)
            {
                if (Vijanden[i].vijand.Type == SchoolEsc.Model.Vijand.VijandType.Bewegend)
                {

                    if (SchoolEsc.View.SpeelveldPanel.speler.BewegingX > Vijanden[i].vijand.X)
                    {
                        Vijanden[i].Links(Snelheid);
                    }
                    else
                    {
                        Vijanden[i].Rechts(Snelheid);
                    }

                    if (SchoolEsc.View.SpeelveldPanel.speler.BewegingY > Vijanden[i].vijand.Y)
                    {
                        Vijanden[i].Beneden(Snelheid);
                    }
                    else
                    {
                        Vijanden[i].Boven(Snelheid);
                    }
                }
            }

        }
    }
}
