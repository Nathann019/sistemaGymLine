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
    public partial class frmUsuarios: Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnCadastrarUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastroUsuarios frm = new frmCadastroUsuarios();
            frm.ShowDialog();
        }

        private void btnBuscarUser_Click(object sender, EventArgs e)
        {
            try

            {

                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))

                {

                    cn.Open();

                    var sqlQuery = "select * from usuarios where nomeUsuario like '%" + txtBuscarUser.Text + "%'" +
                        "or nomeCompUsuario like '%" + txtBuscarUser.Text + "%'" +
                        "or idUsuario like '%" + txtBuscarUser.Text + "%'";

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))

                    {

                        using (DataTable dt = new DataTable())

                        {

                            da.Fill(dt);

                            dgvUsersCadastrados.DataSource = dt;

                        }

                    }

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Falha ao tentar conctar\n\n" + ex.Message);

            }
        }

        private void btnVoltarUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }

        private void btnFecharUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }

        private void btnExcluirUser_Click(object sender, EventArgs e)
        {
            if (dgvUsersCadastrados.SelectedRows.Count > 0)
            {
                // Pega o idAluno da linha selecionada
                int idUsuario = Convert.ToInt32(dgvUsersCadastrados.SelectedRows[0].Cells["idUsuario"].Value);

                var confirm = MessageBox.Show("Tem certeza que deseja excluir este usuário?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                        {
                            cn.Open();
                            string sql = "DELETE FROM usuarios WHERE idUsuario = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", idUsuario);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Usuário excluído com sucesso!");
                                BuscarUsuario(); // Recarrega a tabela após exclusão
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir usuário.\n\n" + ex.Message);
                    }
                }
            }
        }
        private void BuscarUsuario()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sqlQuery = "select * from usuarios where nomeUsuario like '%" + txtBuscarUser.Text + "%'" +
                        "or idUsuario like '%" + txtBuscarUser.Text + "%'" +
                        "or nomeCompUsuario like '%" + txtBuscarUser.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvUsersCadastrados.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados.\n\n" + ex.Message);
            }
        }
    }
}
       