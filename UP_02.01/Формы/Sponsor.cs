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
    public partial class Sponsor : Form
    {

      


        public Sponsor()
        {
            InitializeComponent();
        }

        private void charityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.charityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marathonDataSet2);

        }

        private void Sponsor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonDataSet2.Charity". При необходимости она может быть перемещена или удалена.
            this.charityTableAdapter.Fill(this.marathonDataSet2.Charity);

        }
            
        public int sum = 0;
        public void button2_Click(object sender, EventArgs e)
        {            
            sum=sum+10;
            label6.Text = sum + "$";
        }

        public void button1_Click(object sender, EventArgs e)
        {            
            sum = sum - 10;
            label6.Text = sum + "$";
        }

        public void button3_Click(object sender, EventArgs e)
        {
            StaticData.DataBuffer = label6.Text;
            Confirm confirm = new Confirm();            
            confirm.Show();
            Hide();
        }
    }
}
