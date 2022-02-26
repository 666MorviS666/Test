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
    public partial class Resoults : Form
    {
        public Resoults()
        {
            InitializeComponent();
        }

        private void Resoults_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonDataSet2.Resoults". При необходимости она может быть перемещена или удалена.
            this.resoultsTableAdapter1.Fill(this.marathonDataSet2.Resoults);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonDataSet2.Resoults". При необходимости она может быть перемещена или удалена.
            this.resoultsTableAdapter1.Fill(this.marathonDataSet2.Resoults);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonDataSet1.Resoults". При необходимости она может быть перемещена или удалена.
            this.resoultsTableAdapter.Fill(this.marathonDataSet1.Resoults);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonDataSet.RegistrationEvent". При необходимости она может быть перемещена или удалена.
            this.registrationEventTableAdapter.Fill(this.marathonDataSet.RegistrationEvent);

        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            Evants evants = new Evants();
            evants.Show();
            Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Place")
            {
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            }
            if (comboBox1.SelectedItem == "RaceTime")
            {
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            }
            if (comboBox1.SelectedItem == "FirstName")
            {
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
            }
            if (comboBox1.SelectedItem == "LastName")
            {
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
            }
            if (comboBox1.SelectedItem == "CountryCode")
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
            }
        }

        
    }
}
