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
            frmCadastroVendas frm = new frmCadastroVendas();
            frm.ShowDialog();
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
    }
}
