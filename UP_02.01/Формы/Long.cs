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
    public partial class Long : Form
    {
        public Long()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.f1_car;
            label12.Text = "Скорость спорткара 300 км/ч \n поэтому она проедет марафон за\n 7 минут 20 секунд.";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.worm;
            label12.Text = "Скорость червя 60 м/ч \n поэтому он проползёт марафон за\n    700 часов.";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.sloth;
            label12.Text = "Скорость ленивца 180 м/ч \n поэтому он проползёт марафон за\n   350 часов.";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.capybara;
            label12.Text = "Скорость капубары 35 км/ч \n поэтому он пройдёт марафон за\n   1 час 20 минут.";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.jaguar;
            label12.Text = "Скорость ягуара 120 км/ч \n поэтому он пробежит марафон за\n   35 минут.";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.airbus_a380;
            label12.Text = "Длинна аэробуса А380 70 метров \n на всю дистанцию их влезло бы \n  600 штук.";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.pair_of_havaianas;
            label12.Text = "Длинна шлёпок 30 см \n на всю дистанцию их влезло бы \n  140 000 штук.";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.football_field;
            label12.Text = "Длинна стадиона 100 м \n на всю дистанцию их влезло бы \n  420 штук.";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.ronaldinho;
            label12.Text = "Рост Рональдино 1,85 м \n на всю дистанцию их влезло бы \n  22 700 штук.";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.bus;
            label12.Text = "Длинна автобуса 10 м \n на всю дистанцию их влезло бы \n  4 200 штук.";
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            Evants evants = new Evants();
            evants.Show();
            Close();
        }
    }
}
