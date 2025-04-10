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
    public partial class frmVendas: Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        private void btnCadastrarVenda_Click(object sender, EventArgs e)
        {
         
        }

        private void btnBuscarVenda_Click(object sender, EventArgs e)
        {
            try

            {

                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))

                {

                    cn.Open();

                    var sqlQuery = "select * from vendas where idVenda like '%" + txtBuscarVenda.Text + "%'" +
                        "or idAluno like '%" + txtBuscarVenda.Text + "%'" +
                        "or idUsuario like '%" + txtBuscarVenda.Text + "%'" +
                        "or idServico like '%" + txtBuscarVenda.Text + "%'";

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))

                    {

                        using (DataTable dt = new DataTable())

                        {

                            da.Fill(dt);

                            dgvVendasCadastradas.DataSource = dt;

                        }

                    }

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Falha ao tentar conctar\n\n" + ex.Message);

            }
        }

        private void btnVoltarVenda_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }

        private void btnFecharVendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }

        private void btnEditarVenda_Click(object sender, EventArgs e)
        {
            if (dgvVendasCadastradas.SelectedRows.Count > 0)
            {
                // Pega o ID da venda selecionada
                int idVenda = Convert.ToInt32(dgvVendasCadastradas.SelectedRows[0].Cells["idVenda"].Value);

                // Abre o formulário de cadastro com os dados da venda
                frmCadastroVendas frm = new frmCadastroVendas(idVenda);
                frm.ShowDialog();

                // Atualiza a lista após edição
                BuscarNovamente();
            }
            else
            {
                MessageBox.Show("Selecione uma venda para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BuscarNovamente()
        {
            throw new NotImplementedException();
        }
    }
}
