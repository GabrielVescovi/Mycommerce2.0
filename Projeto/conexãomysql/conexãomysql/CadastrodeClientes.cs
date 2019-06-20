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
                maskfone.TextMaskFormat=000;
                string Nome = txtnome.Text;
                string fone = maskfone.Text;
                string endereco = txtendereco.Text;
                string bairro = txtbairro.Text;
                string cidade = txtcidade.Text;
                string UF = txtUF.Text;
                string email = txtemail.Text;

                string sql = "INSERT INTO CLIENTES(Nome,Telefone,Endereco,Bairro,Cidade,UF,Email)"
                    + "VALUES('" + Nome + "','" + fone + "','" + endereco + "','" + bairro + "','" + cidade + "','" + UF + "','" + email + "')";
          

                MySqlConnection con = new MySqlConnection(conexao);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();

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
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Cadastro realizado com sucesso!");
                        gridclientes gridc = new gridclientes();
                        gridc.Show(this);
                        Hide();

                    }
                    catch (Exception ex)
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

        private void CancelCad_Click(object sender, EventArgs e)
        {
            gridclientes gridc = new gridclientes();
            gridc.Show(this);
            Hide();
        }


        private void Telefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
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
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                txtbairro.Focus();
            }

        }
        private void Cidade_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                txtcidade.Focus();
            }
        }
        private void UF_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                txtUF.Focus();
            }
        }
        private void Email_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                txtemail.Focus();
            }
        }
    }
}
