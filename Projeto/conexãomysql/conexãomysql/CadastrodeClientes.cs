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
    public partial class CadastrodeClientes : Form
    {
        public CadastrodeClientes()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            gridclientes gridc = new gridclientes();
            gridc.Show(this);
            Hide();
        }
    }
}
