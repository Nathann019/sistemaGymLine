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
    }
}
