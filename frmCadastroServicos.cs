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
    public partial class frmCadastroServicos: Form
    {
        public frmCadastroServicos()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarCadProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmServicos frm = new frmServicos();
            frm.Show();
        }

        private void btnFecharCadServicos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }

        private void btnSalvarProd_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "INSERT INTO servicos (prodServico, valorServico, obsServico) VALUES (@produto, @valor, @obs)";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@produto", txtProd.Text);
                        cmd.Parameters.AddWithValue("@valor", txtValorProd.Text);
                        cmd.Parameters.AddWithValue("@obs", txtObsProd.Text);
                        
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
    }
}
