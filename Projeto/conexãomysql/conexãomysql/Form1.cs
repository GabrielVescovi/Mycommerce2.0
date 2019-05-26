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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MySqlConnection conexao;
        private DataSet conexaoDataSet;

        private void Button1_Click(object sender, EventArgs e)
        {
            
            conexaoDataSet = new DataSet();
            conexao = new MySqlConnection("server = localhost; Database=my2; Uid=root; Port=3306; Pwd=vssql");

            try
            {
                conexao.Open();
                MySqlCommand verifica = new MySqlCommand("Select * from usuarios where Usuario= '" +  login.Text + "' and Senha= '" + senha.Text + "';", conexao);
                bool resultado = verifica.ExecuteReader().HasRows;

                if (resultado)
                {
                    conexao.Close();
                    Form2 f2 = new Form2();
                    f2.Show(this);
                    Hide();

                }
                else
                {
                    MessageBox.Show("Login inválido!");
                    conexao.Close();
                }
            }
            catch (Exception ete)
            {
                MessageBox.Show(ete.Message, "Erro de conexão com o banco de dados");
                conexao.Close();
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                senha.Focus();
            }
        }
    }
}
