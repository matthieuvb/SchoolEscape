using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolEsc.Model;
using SchoolEsc.Controller;

namespace SchoolEsc.View
{
    public partial class Speelveld : Form
    {
        bool PauseClicked;

        // initialiseren van een speelveld paneel in deze speelveld form
        SpeelveldPanel speelveldPanel = new SpeelveldPanel();

        public Speelveld()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Speelveld_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu();
            //sv.ShowDialog(this);
            mn.Closed += (s, args) => this.Close();
            mn.Show();
        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PauseClicked = true;
            do
            {
                
                //pause program
            } while (PauseClicked);
        }

        private void Speelveld_Load(object sender, EventArgs e)
        {
            

        }

        private void Play_Click(object sender, EventArgs e)
        {
            PauseClicked = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BeginPunt_Click(object sender, EventArgs e)
        {

        }
    }
}
