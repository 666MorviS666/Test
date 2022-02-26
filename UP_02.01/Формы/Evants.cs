using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP_02._01.Формы
{
    public partial class Evants : Form
    {
        public Evants()
        {
            InitializeComponent();
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            
            BMI bMI = new BMI();
            bMI.Show();
            Close();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            
            Marathon marathon = new Marathon();
            marathon.Show();
            Close();
        }

        private void xuiButton6_Click(object sender, EventArgs e)
        {
            
            BMR marathonn = new BMR();
            marathonn.Show();
            Close();
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            Resoults marathonn1 = new Resoults();
            marathonn1.Show();
            Close();
        }

        private void xuiButton5_Click(object sender, EventArgs e)
        {
            Blago marathonn11 = new Blago();
            marathonn11.Show();
            Close();
        }

        private void xuiButton4_Click(object sender, EventArgs e)
        {
            Long mamam = new Long();
            mamam.Show();
            Close();
        }

        private void xuiButton7_Click(object sender, EventArgs e)
        {
            Sponsor form = new Sponsor();
            form.Show();
            Close();

        }
    }
}
