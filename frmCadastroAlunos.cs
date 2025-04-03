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
    public partial class frmCadastroAlunos: Form
    {
        public frmCadastroAlunos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {

            DateTime dtDatNascAluno = dtpDataNascAluno.Value;
            string sexoAluno = cmbSexoAluno.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "INSERT INTO alunos (nomeAluno, enderecoAluno, telAluno, rgAluno, cpfAluno, idadeAluno, sexoAluno, datNascAluno, obsAluno) VALUES (@nome, @endereco, @telefone, @rg, @cpf, @idade, @sexo, @dataNasc, @obs)";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNomeAluno.Text);
                        cmd.Parameters.AddWithValue("@endereco", txtEnderecoAluno.Text);
                        cmd.Parameters.AddWithValue("@telefone", txtTelAluno.Text);
                        cmd.Parameters.AddWithValue("@rg", txtRgAluno.Text);
                        cmd.Parameters.AddWithValue("@cpf", txtCpfAluno.Text);
                        cmd.Parameters.AddWithValue("@idade", txtIdadeAluno.Text);
                        cmd.Parameters.AddWithValue("@dataNasc", dtDatNascAluno);
                        cmd.Parameters.AddWithValue("@sexo", sexoAluno);
                        cmd.Parameters.AddWithValue("@obs", txtObsAluno.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Salvo com sucesso");


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dados não Salvos.\n\n" + ex.Message);
            }
        }

        private void btnVoltarCadAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAlunos frm = new frmAlunos();
            frm.Show();
        }

        private void btnFecharCadAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }
    }
}
