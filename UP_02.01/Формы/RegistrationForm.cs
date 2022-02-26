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
   
    public partial class RegistrationForm : Form
    { 
        
        public RegistrationForm()
        {
            InitializeComponent();
        }

        public void xuiButton3_Click(object sender, EventArgs e)
        {            
            RegisterAsARunner reg = new RegisterAsARunner();
            reg.Show();
            Close();
        }

        public void xuiButton1_Click(object sender, EventArgs e)
        { 
            if (passwordTextBox.Text == textBox1.Text)
            {
               runnersBindingSource.EndEdit();
               runnersTableAdapter.Update(marathonDataSet2);
               MessageBox.Show("Информация сохранена", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
               RegVznos reg1 = new RegVznos();
               reg1.Show();
               Hide();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public void registrationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();            
            this.tableAdapterManager.UpdateAll(this.marathonDataSet2);
        }

        public void runnersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.runnersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marathonDataSet2);
        }

        public void RegistrationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonDataSet2.Runners". При необходимости она может быть перемещена или удалена.
            this.runnersTableAdapter.Fill(this.marathonDataSet2.Runners);

        }

        public void runnersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int value = rand.Next(1000);
            iDTextBox.Text = Convert.ToString(value);
        }

        private void xuiButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog fl = new OpenFileDialog();
            fl.Filter = "Image Files(*.png;*.jpeg;*.jpg;)|*.png;*.jpeg;*.jpg|ALL Files(*.*)|*.*";
            
            if(fl.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(fl.FileName);
                textBox6.Text = fl.SafeFileName;
            }
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            Sponsor form11 = new Sponsor();
            form11.Show();
            Hide();
        }
    }
}
