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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Handleiding hl = new Handleiding();
            hl.Closed += (s, args) => this.Close();
            hl.Location = this.Location;
            hl.Show();

        }

        private void PlayGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Speelveld sv = new Speelveld();
            //sv.ShowDialog(this);
            sv.Closed += (s, args) => this.Close();
            sv.Location = this.Location;
            sv.Show();
        }

        private void ExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
