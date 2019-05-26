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
    public partial class CadastrodeClientes : Form
    {
        string conexao = @"server = localhost; Database=my2; Uid=root; Port=3306; Pwd=vssql";
        bool novo;
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

        private void CadastrodeClientes_Load(object sender, EventArgs e)
        {
            GravarCad.Enabled = true;
            CancelCad.Enabled = true;
            txtid.Enabled = false;
            txtnome.Enabled = true;
            txtendereco.Enabled = true;
            maskfone.Enabled = true;
            txtbairro.Enabled = true;
            txtcidade.Enabled = true;
            txtUF.Enabled = true;
            txtnome.Focus();
            novo = true;
            
        }

        private void GravarCad_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                
                string sql = "INSERT INTO CLIENTES(Nome,Telefone,Endereco,Bairro,Cidade,UF,Email)"
                    +"VALUES('"+txtnome.Text+"','"+maskfone+"','"+txtendereco+"','"+txtbairro+"','"+txtcidade+"','"+txtUF+"','"+txtemail+"')";
          

                MySqlConnection con = new MySqlConnection(conexao);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro realizado com sucesso!");
                    gridclientes gridc = new gridclientes();
                    gridc.Show(this);
                    Hide();

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
}
