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

        private void Gridclientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.dataSet1.clientes);

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillBy(this.dataSet1.clientes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillBy(this.dataSet1.clientes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void Cadastrar_Click(object sender, EventArgs e)
        {
            CadastroCliente cc = new CadastroCliente();
            cc.Show(this);
            Hide();

        }
    }
}
