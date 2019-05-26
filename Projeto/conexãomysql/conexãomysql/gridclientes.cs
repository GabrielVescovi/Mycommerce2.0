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

        private void Gridclientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gridClientesConexao1.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter1.Fill(this.gridClientesConexao1.clientes);
            // TODO: esta linha de código carrega dados na tabela 'gridClientesConexao.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter1.Fill(this.gridClientesConexao.clientes);

        }
    }
}
