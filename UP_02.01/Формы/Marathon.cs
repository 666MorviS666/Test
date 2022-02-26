using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UP_02._01.Properties;

namespace UP_02._01.Формы
{
    public partial class Marathon : Form
    {
        public Marathon()
        {
            InitializeComponent();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            Map map = new Map();
            map.Show();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            button1.Visible = true;
            pictureBox6.Image = Resources.banco_banespa;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            button1.Visible = true;
            pictureBox6.Image = Resources.ibirapuera_park_lake;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            button1.Visible = true;
            pictureBox6.Image = Resources.marathon_image;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            button1.Visible = true;
            pictureBox6.Image = Resources.teatro_municipal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            button1.Visible = false;            
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
            Map map = new Map();
            map.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Evants evants = new Evants();
            evants.Show();
            Close();
        }
    }
}
