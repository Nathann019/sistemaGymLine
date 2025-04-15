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
    public partial class frmServicos: Form
    {
        public frmServicos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
                    
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuariosCadastrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCadastrarServico_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastroServicos frm = new frmCadastroServicos();
            frm.ShowDialog();
        }

        private void btnBuscarServico_Click(object sender, EventArgs e)
        {
            try

            {

                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))

                {

                    cn.Open();

                    var sqlQuery = "select * from servicos where prodServico like '%" + txtBuscarServico.Text + "%'" +
                    "or idServico like '%" + txtBuscarServico.Text + "%'";


                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))

                    {

                        using (DataTable dt = new DataTable())

                        {

                            da.Fill(dt);

                            dgvServicosCadastrados.DataSource = dt;

                        }

                    }

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Falha ao tentar conctar\n\n" + ex.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }

        private void btnFecharServico_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvServicosCadastrados.SelectedRows.Count > 0)
            {
                // Pega o idServico da linha selecionada
                int idServico = Convert.ToInt32(dgvServicosCadastrados.SelectedRows[0].Cells["idServico"].Value);

                var confirm = MessageBox.Show("Tem certeza que deseja excluir este serviço?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                        {
                            cn.Open();
                            string sql = "DELETE FROM servicos WHERE idServico = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", idServico);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Serviço excluído com sucesso!");
                                BuscarServico(); // Recarrega a tabela após exclusão
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir serviço.\n\n" + ex.Message);
                    }
                }
            }
        }
        private void BuscarServico()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sqlQuery = "select * from servicos where prodService like '%" + txtBuscarServico.Text + "%'" +
                        "or idServico like '%" + txtBuscarServico.Text + "%'" +
                        "or valorServico like '%" + txtBuscarServico.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvServicosCadastrados.DataSource = dt;
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
