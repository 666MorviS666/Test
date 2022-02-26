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
    public partial class RegVznos : Form
    {
        int v = 0;
        public RegVznos()
        {
            InitializeComponent();
            Vz.Text =  v+"$";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                v = v + 145;
                Vz.Text = v + "$";
            }
            else
            {
                v = v - 145;
                Vz.Text = v + "$";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                v = v + 75;
                Vz.Text = v + "$";
            }
            else
            {
                v = v - 75;
                Vz.Text = v + "$";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                v = v + 20;
                Vz.Text = v + "$";
            }
            else
            {
                v = v - 20;
                Vz.Text = v + "$";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Vz.Text = v + "$";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                v = v + 20;
                Vz.Text = v + "$";
            }
            else
            {
                v = v - 20;
                Vz.Text = v + "$";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                v = v + 45;
                Vz.Text = v + "$";
            }
            else
            {
                v = v - 45;
                Vz.Text = v + "$";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Информация сохранена, с вами свяжутся в ближайшее время", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            Close();
        }
    }
}
