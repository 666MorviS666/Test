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
    public partial class Confirm : Form
    {
        int sum {get;}
        public Confirm()
        {
            InitializeComponent();            
        }

        private void Confirm_Load(object sender, EventArgs e)
        {
            label1.Text = StaticData.DataBuffer;
        }
    }
}
