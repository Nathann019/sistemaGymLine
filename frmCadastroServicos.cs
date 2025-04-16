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
using static sistemaGymLine.frmCadastroAlunos;

namespace sistemaGymLine
{
    public partial class frmCadastroServicos: Form
    {

        int idServico = 0;
        public frmCadastroServicos(int idServico)
        {
            InitializeComponent();
            this.idServico = idServico;
            if (this.idServico > 0)
                GetServico(idServico);
        }
        private void GetServico(int idServico)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "select*from servicos where idServico=" + idServico;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))


                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    txtProd.Text = dr["prodServico"].ToString();
                                    txtValorProd.Text = dr["valorServico"].ToString();
                                    txtObsProd.Text = dr["obsServico"].ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dados não atualizado .\n\n" + ex.Message);

            }
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
                    
                        var sql = "";
                    if (this.idServico == 0)
                        sql = "INSERT INTO servicos (prodServico, valorServico, obsServico) VALUES (@produto, @valor, @obs)";

                    else
                        sql = "UPDATE servicos set prodServico = @produto , valorServico = @valor, obsServico = @obs WHERE idServico=" + this.idServico;
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

        private void btnCancelarProd_Click(object sender, EventArgs e)
        {
            FormUtils.LimparCampos(this);
        }
    }
}
