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
    public partial class BMR : Form
    {
        float gen;
        float vs;
        float rostik;
        float aage;
        float sid;
        float mal;
        float sred;
        float high;
        float max;
        public BMR()
        {
            InitializeComponent();
            
        }

        private void xuiButton1_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.Show();

        }

        private void xuiButton1_MouseLeave(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gen = 66;
            vs = 13.7f;
            rostik = 5;
            aage = 6.8f;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gen = 655;
            
            vs = 9.6f;
            rostik = 1.8f;
            aage = 4.7f;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gen = 0;
            v.Clear();
            r.Clear();
            a.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            float ves1 = float.Parse(v.Text);
            float rostik1=float.Parse(r.Text);
            float aage1=float.Parse(a.Text);
            float f = gen + (vs * ves1) + (rostik * rostik1) - (aage1 * aage);
            f = f / 1000;
            bmrr.Text = f.ToString();
            sid = (float)(f * 1.2);
            mal= (float)(f * 1.375);
            sred= (float)(f * 1.55);
            high= (float)(f * 1.725);
            max= (float)(f * 1.9);
            labelsid.Text = sid.ToString();
            labelaml.Text = mal.ToString();
            labelsred.Text = sred.ToString();
            labelhigh.Text = high.ToString();
            labelmax.Text = max.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Evants evants = new Evants();
            evants.Show();
            Close();
        }
    }
}
