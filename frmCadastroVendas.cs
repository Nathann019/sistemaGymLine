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
    public partial class frmCadastroVendas: Form
    {

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private string connectionString = conexao.IniciarCon;

        public frmCadastroVendas()
        {
            InitializeComponent();
            CarregarVendedor();
            CarregarProduto();
            CarregarIdAluno();
        }

        private void CarregarVendedor()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select idUsuario, nomeCompUsuario from usuarios", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbVendedorVenda.Items.Add(new ComboboxItem
                    {
                        Text = reader["nomeCompUsuario"].ToString(),
                        Value = reader["idUsuario"]
                    });
                }
            }
        }

        private void CarregarProduto()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select idServico, prodServico from servicos", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbProdVenda.Items.Add(new ComboboxItem
                    {
                        Text = reader["prodServico"].ToString(),
                        Value = reader["idServico"]
                    });
                }
            }
        }

        private void CarregarIdAluno()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select idAluno, nomeAluno from alunos", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbIdAluno.Items.Add(new ComboboxItem
                    {
                        Text = reader["nomeAluno"].ToString(),
                        Value = reader["idAluno"]
                    });
                }
            }
        }


        private void btnVoltarCadVenda_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVendas frm = new frmVendas();
            frm.Show();
        }

        private void btnFecharCadVenda_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }

        private void btnSalvarVenda_Click(object sender, EventArgs e)
        {
            DateTime dataPagVenda = dtpDataPagVenda.Value;
            DateTime dataVencVenda = dtpDataVencVenda.Value;

            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "INSERT INTO vendas (valorVenda, formaPagVenda, dataVenda, dtVencVenda, trocoVenda) VALUES (@valor, @dataVenda, @dataVencProd, @troco)";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@valor", txtValorVenda.Text);
                        cmd.Parameters.AddWithValue("@dataVenda", dataPagVenda);
                        cmd.Parameters.AddWithValue("@dataVencProd", dataVencVenda);
                        cmd.Parameters.AddWithValue("@troco", txtTrocoVenda.Text);

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
