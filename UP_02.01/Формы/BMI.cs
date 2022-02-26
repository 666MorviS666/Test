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
using UP_02._01.Формы;



namespace UP_02._01.Формы
{
    public partial class BMI : Form
    {

        float i;
        float r;
        float v;

        public BMI()
        {
            InitializeComponent();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            r = float.Parse(rost.Text);
            v = float.Parse(ves.Text);
            r = r / 100;
            i = v / (r * r);
            x.Text = i.ToString("N");
            trackBar1.Value = (int)i;


            if (i <= 15)
            {
                pictureBox2.Image = Resources.bmi_underweight_icon;
            }
            else if (i <= 28)
            {
                pictureBox2.Image = Resources.bmi_healthy_icon;
            }
            else if (i <= 40)
            {
                pictureBox2.Image = Resources.bmi_overweight_icon;
            }
            else if (i <= 50)
            {
                pictureBox2.Image = Resources.bmi_obese_icon;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Evants evants = new Evants();
            evants.Show();
            Close();
        }
    }
}
