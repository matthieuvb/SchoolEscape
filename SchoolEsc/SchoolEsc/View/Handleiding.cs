using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolEsc.View
{
    public partial class Handleiding : Form
    {
        public Handleiding()
        {
            InitializeComponent();
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ml = new Menu();
            ml.Show();
            ml.Location = this.Location;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
