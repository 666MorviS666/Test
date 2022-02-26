using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UP_02._01.Формы;

namespace UP_02._01
{
    public partial class RegisterAsARunner : Form
    {
        public RegisterAsARunner()
        {
            InitializeComponent();
        }

        public void xuiButton1_Click(object sender, EventArgs e)
        {            
            Login reg = new Login();
            reg.Show();
            Close();
        }

        public void xuiButton2_Click(object sender, EventArgs e)
        {           
            RegistrationForm reg = new RegistrationForm();
            reg.Show();
            reg.runnersBindingSource.AddNew();            
            Close();
        }

        public void runnersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.runnersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marathonDataSet2);
        }

        public void RegisterAsARunner_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonDataSet2.Runners". При необходимости она может быть перемещена или удалена.
            this.runnersTableAdapter.Fill(this.marathonDataSet2.Runners);
        }

        public void runnersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }
    }
}
