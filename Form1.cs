using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaGymLine
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSenhaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MessageBox.Show("Por favor, preencha ambos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                    return;
                }

                if (AutenticarUsuario(txtUsuario.Text, txtSenha.Text))
                {
                    this.Hide();
                    var formPrincipal = new frmDashboard();
                    formPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.", "Falha no login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Clear();
                    txtUsuario.Focus();
                }

            }

            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao acessar o banco de dados:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            
        

        private bool AutenticarUsuario(string usuario, string senha)
        {
            using (SqlConnection conn = new SqlConnection(conexao.IniciarCon))
            {
                string query = "SELECT idUsuario FROM usuarios WHERE nomeUsuario = @Usuario AND senhaUsuario = @Senha";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    conn.Open();
                    var result = cmd.ExecuteScalar();

                    return result != null && result != DBNull.Value;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
