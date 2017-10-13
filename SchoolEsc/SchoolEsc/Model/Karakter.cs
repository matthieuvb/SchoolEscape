using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolEsc.Model
{

    public abstract class Karakter
    {
        public int breedte;
        public int hoogte;

        public Karakter(int breedte, int hoogte)
        {
            this.breedte = breedte;
            this.hoogte = hoogte;
        }
    }
}
