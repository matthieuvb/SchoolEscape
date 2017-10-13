using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SchoolEsc.Model
{
    public class Vijand// : Karakter
    {
        public enum VijandType { Bewegend, Stilstaand };
        public VijandType Type;
        public Image Afbeelding;
        public string Bestandsnaam;
        public int X;
        public int Y;

        public Vijand(string Filename, VijandType type, int xc, int yc)
        {
            Bestandsnaam = Filename;
            Type = type;
            X = xc;
            Y = yc;

            Afbeelding = Image.FromFile(Bestandsnaam);
        }


    }
}
