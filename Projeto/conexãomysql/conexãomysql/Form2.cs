using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conexãomysql
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
           
            gridclientes gridc = new gridclientes();
            gridc.Show(this);
            Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);


        }
    }
}
