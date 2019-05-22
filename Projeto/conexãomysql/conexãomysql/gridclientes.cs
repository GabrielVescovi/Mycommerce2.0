using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace conexãomysql
{
    public partial class gridclientes : Form
    {
        public gridclientes()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show(this);
            Hide();
        }


        private void Cadastrar_Click(object sender, EventArgs e)
        {
            CadastrodeClientes cc = new CadastrodeClientes();
            cc.Show(this);
            Hide();

        }

        private void ConsultaclientesToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.consultaclientes(this.tblClientes.clientes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void gridclientes_Load(object sender, EventArgs e)
        {
                dataGridView1.DataSource = GetListaclientes();

        }
        private DataTable GetListaclientes()
        {
            DataTable dteListaclientes = new DataTable();

            return dteListaclientes;
        }
    }
}
