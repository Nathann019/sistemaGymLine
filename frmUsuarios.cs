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
    }
}
