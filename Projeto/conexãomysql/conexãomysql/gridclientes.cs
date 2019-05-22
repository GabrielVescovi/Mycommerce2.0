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

        class ClasseDAL
        {
            string conectabanco = "server = localhost; Database=my2; Uid=root; Port=3306; Pwd=vssql";

            MySqlConnection conexao = null;
            MySqlCommand comando;

            public DataTable ExibirDados()
            {
                try
                {
                    conexao = new MySqlConnection(conectabanco);
                    comando = new MySqlCommand("select * from clientes", conexao);

                    MySqlDataAdapter Da = new MySqlDataAdapter();
                    Da.SelectCommand = comando;

                    DataTable Dt = new DataTable();

                    Da.Fill(Dt);

                    return Dt;
                }
                catch(Exception erro)
                {
                    throw erro;
                }
            }
        }
        

    }
}
