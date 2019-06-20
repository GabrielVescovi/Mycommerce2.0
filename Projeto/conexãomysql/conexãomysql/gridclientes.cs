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
        static string conString = @"server = localhost; Database=my2; Uid=root; Port=3306; Pwd=vssql";
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
     
        

            


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    idcliente.Text = row.Cells[0].Value.ToString();
                    NomeC.Text = row.Cells[1].Value.ToString();
                    TelefoneC.Text = row.Cells[2].Value.ToString();
                    EndC.Text = row.Cells[3].Value.ToString();
                    BairroC.Text = row.Cells[4].Value.ToString();
                    CidadeC.Text = row.Cells[5].Value.ToString();
                    UFC.Text = row.Cells[6].Value.ToString();
                    EmailC.Text = row.Cells[7].Value.ToString();


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            CadastrodeClientesEdicao cce = new CadastrodeClientesEdicao(idcliente.Text, NomeC.Text, TelefoneC.Text, EndC.Text, BairroC.Text, CidadeC.Text, UFC.Text, EmailC.Text);
            cce.Show(this);
            Hide();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            

            string sql = "DELETE FROM CLIENTES WHERE ID=" + idcliente.Text;

            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd;
            cmd = new MySqlCommand(sql, con);
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i >0)                
                MessageBox.Show("Cadastro excluido!");
                dataGridView1.Update();
                dataGridView1.Refresh();
  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
            finally
            {
                con.Close();
                
            }

        }
        
    }


}
