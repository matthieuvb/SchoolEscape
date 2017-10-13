using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SchoolEsc.Model
{
    public class Speler : Karakter
    {
        public int BewegingX { get; set; }
        public int BewegingY { get; set; }
        public int Breedte { get; set; }
        public int Hoogte { get; set; }
        public string imageFileNaam { get; set; }

        public Speler(int breedte, int hoogte) : base (breedte, hoogte)
        {
            this.Breedte = breedte;
            this.Hoogte = hoogte;

            imageFileNaam = "../../Resources/student.png";
        }
    }
}
