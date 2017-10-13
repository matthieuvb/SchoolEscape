using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolEsc.Model;
using System.Windows.Forms;

namespace SchoolEsc.Controller
{
    class SpelerController
    {
        private Speler speler;

        public SpelerController(Speler speler)
        {
            this.speler = speler;
        }

        // methode voor de beweging van de speler
        public void MoveDown(int snelheid)
        {
            speler.BewegingY = speler.BewegingY + snelheid;
            Console.WriteLine(speler.BewegingX + " " + speler.BewegingY);
        }

        public void MoveUp(int snelheid)
        {
            speler.BewegingY = speler.BewegingY - snelheid;
            Console.WriteLine(speler.BewegingX + " " + speler.BewegingY);
        }

        public void MoveLeft(int snelheid)
        {
            speler.BewegingX = speler.BewegingX - snelheid;
            Console.WriteLine(speler.BewegingX + " " + speler.BewegingY);
        }

        public void MoveRight(int snelheid)
        {
            speler.BewegingX = speler.BewegingX + snelheid;
            Console.WriteLine(speler.BewegingX + " " + speler.BewegingY);
        }
    }
}
