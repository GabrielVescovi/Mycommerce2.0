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
    public partial class CadastrodeClientesEdicao : Form
    {
        static string conString = @"server = localhost; Database=my2; Uid=root; Port=3306; Pwd=vssql";
        bool novo;
        public CadastrodeClientesEdicao()
        {
            InitializeComponent();
        }

        public CadastrodeClientesEdicao(string IDcliente,String NomeC,String TelefoneC, String EndC, String BairroC, String CidadeC, String UFC, String EmailC)
        {
            InitializeComponent();
            txtid.Text = IDcliente;
            txtnome.Text = NomeC;
            maskfone.Text = TelefoneC;
            txtendereco.Text = EndC;
            txtbairro.Text = BairroC;
            txtcidade.Text = CidadeC;
            txtUF.Text = UFC;
            txtemail.Text = EmailC;

        }




        private void CadastrodeClientesEdicao_Load(object sender, EventArgs e)
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
                maskfone.TextMaskFormat=000;
                string Nome = txtnome.Text;
                string fone = maskfone.Text;
                string endereco = txtendereco.Text;
                string bairro = txtbairro.Text;
                string cidade = txtcidade.Text;
                string UF = txtUF.Text;
                string email = txtemail.Text;

                string sql = "UPDATE CLIENTES SET NOME='" + Nome +
                    "',TELEFONE='" + fone + "',ENDERECO='" + endereco +
                    "', BAIRRO='" + bairro + "', CIDADE='" + cidade +
                    "', UF='" + UF + "', EMAIL='" + email +
                    "'WHERE ID=" + txtid.Text +';';


              
                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand cmd;
                cmd = new MySqlCommand(sql, con);

                if (Nome == string.Empty)
                {
                    MessageBox.Show("Nome em Branco");
                    txtnome.Focus();
                    txtnome.Select();
                }
                else if (fone == string.Empty)
                {
                    MessageBox.Show("Telefone em Branco");
                    maskfone.Focus();
                    maskfone.Select();
                }
                else if (endereco == string.Empty)
                {
                    MessageBox.Show("Endereço em Branco");
                    txtendereco.Focus();
                    txtendereco.Select();
                }
                else if (bairro == string.Empty)
                {
                    MessageBox.Show("Bairro em Branco");
                    txtbairro.Focus();
                    txtbairro.Select();
                }
                else if (cidade == string.Empty)
                {
                    MessageBox.Show("Cidade em branco");
                    txtcidade.Focus();
                    txtcidade.Select();
                }
                else if (UF == string.Empty)
                {
                    MessageBox.Show("UF em Branco");
                    txtUF.Focus();
                    txtUF.Select();
                }
                else if (email == string.Empty)
                {
                    MessageBox.Show("E-mail em Branco");
                    txtemail.Focus();
                    txtemail.Select();
                }
                else
                {

                    try
                    {
                        con.Open();

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Cadastro atualizado com sucesso!");
                            gridclientes gridc = new gridclientes();
                            gridc.Show(this);
                            Hide();
                        }

                        con.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro");
                        con.Close();
                    }
                }

            }
           
        }

        private void CancelCad_Click(object sender, EventArgs e)
        {
            gridclientes gridc = new gridclientes();
            gridc.Show(this);
            Hide();
        }

      
        private void Telefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maskfone.Focus();
            }

        }
        private void Endereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtendereco.Focus();
            }
        }
        private void Bairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbairro.Focus();
            }

        }
        private void Cidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcidade.Focus();
            }
        }
        private void UF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUF.Focus();
            }
        }
        private void Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtemail.Focus();
            }
        }
    }
}
