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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources._4e6c21b7e9d2100a19aebdf42ddbb529;
            label2.Text = "Станция подзарядки \n \n Здесь вы можете купить\n энергитические батончики и\n энергетики.";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources.image_3;
            label2.Text = "Точка Старта \n \n Здесь вы можете начать\n свой забег.";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources._804_eac69ad823a9a8335d31a7a492d0cc06;
            label2.Text = "Информационная панель \n \n Здесь вы можете\n посмотреть информацию о\n ключевых точках трассы.";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources.img_6973_m;
            label2.Text = "Кафе \n \n Здесь вы можете передохнуть\n чтобы продолжить свой забег.";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources.f3ccdd27d2000e3f9255a7e3e2c4880057765a0d140de853104722;
            label2.Text = "Кафе \n \n Здесь вы сможете отохнуть\n чтобы продолжить свой марафон.";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources._156005c5baf40ff51a327f1c34f2975b56572206ecac1055003333;
            label2.Text = "Туалет \n \n Здесь вы сможете ....\n чтобы продолжить свой марафон.";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources._38179480;
            label2.Text = "Туалет \n \n Здесь вы можете ....\n чтобы продолжить свой марафон.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Marathon marathon = new Marathon();
            marathon.Show();
            Close();
        }
    }
}
