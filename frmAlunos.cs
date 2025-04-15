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
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastroAlunos frm = new frmCadastroAlunos(0);
            frm.ShowDialog();
        }

        private void btnBuscarAluno_Click(object sender, EventArgs e)
        {
            try

            {

                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))

                {

                    cn.Open();

                    var sqlQuery = "select * from alunos where nomeAluno like '%" + txtBuscarAluno.Text + "%'" +
                        "or idAluno like '%" + txtBuscarAluno.Text + "%'" +
                        "or rgAluno like '%" + txtBuscarAluno.Text + "%'" +
                        "or cpfAluno like '%" + txtBuscarAluno.Text + "%'";

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))

                    {

                        using (DataTable dt = new DataTable())

                        {

                            da.Fill(dt);

                            dgvAlunosCadastrados.DataSource = dt;

                        }

                    }

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Falha ao tentar conctar\n\n" + ex.Message);

            }
        }

        private void btnVoltarAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }

        private void btnFecharAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            if (dgvAlunosCadastrados.SelectedRows.Count > 0)
            {
                int idAluno = Convert.ToInt32(dgvAlunosCadastrados.SelectedRows[0].Cells["idAluno"].Value);

                this.Hide();
                frmCadastroAlunos frm = new frmCadastroAlunos(idAluno);
                frm.ShowDialog();

                BuscarNovamente();
            }
            else
            {
                MessageBox.Show("Selecione uma venda para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            if (dgvAlunosCadastrados.SelectedRows.Count > 0)
            {
                int idAluno = Convert.ToInt32(dgvAlunosCadastrados.SelectedRows[0].Cells["idAluno"].Value);

                var confirm = MessageBox.Show("Tem certeza que deseja excluir este aluno?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                        {
                            cn.Open();
                            string sql = "DELETE FROM alunos WHERE idAluno = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", idAluno);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Aluno excluído com sucesso!");
                                BuscarNovamente(); // Recarrega a tabela após exclusão
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir aluno.\n\n" + ex.Message);
                    }
                }

            }
        }

        private void BuscarNovamente()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sqlQuery = "select * from alunos where nomeAluno like '%" + txtBuscarAluno.Text + "%'" +
                        "or idAluno like '%" + txtBuscarAluno.Text + "%'" +
                        "or rgAluno like '%" + txtBuscarAluno.Text + "%'" +
                        "or cpfAluno like '%" + txtBuscarAluno.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvAlunosCadastrados.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados.\n\n" + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAlunosCadastrados.SelectedRows.Count > 0)
            {
                // Pega o ID do aluno selecionado
                int idAluno = Convert.ToInt32(dgvAlunosCadastrados.SelectedRows[0].Cells["idAluno"].Value);

                // Abre o formulário de cadastro com os dados do aluno
               

                // Atualiza a lista após edição
                BuscarNovamente();
            }
            else
            {
                MessageBox.Show("Selecione um aluno para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
