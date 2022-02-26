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
    public partial class Form1 : Form
    {

        
        
       
       
        public Form1()
        {
            InitializeComponent();
            DateTime data1  = new DateTime(2022, 05, 24, 08, 00, 00);
            int y = data1.Year - DateTime.Now.Year;
            int d = data1.Day - DateTime.Now.Day;
            int m = data1.Month - DateTime.Now.Month;
            int h = data1.Hour - DateTime.Now.Hour;
            if (data1.Hour<DateTime.Now.Hour)
            {
               h=h*-1;
            }            
            int mi = data1.Minute - DateTime.Now.Minute;
            if (data1.Minute < DateTime.Now.Minute)
            {               
                mi = mi+60;
            }
            
            label3.Text = m + " месяцa " + d + " дней " + h + " часa " + mi + " минут до начала марафона ";
        }

        private void xuiButton4_Click(object sender, EventArgs e)
        {           
            Login log = new Login();            
            log.Show();
            Hide();
           
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {            
            RegisterAsARunner reas = new RegisterAsARunner();
            reas.Show();
            Hide();
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            Evants ev = new Evants();
            ev.Show();
            Hide();
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            Sponsor e1v = new Sponsor();
            e1v.Show();
            Hide();
        }
    }
}
