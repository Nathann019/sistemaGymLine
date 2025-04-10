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
    public partial class frmCadastroVendas : Form
    {
        int idVenda = 0;
        public frmCadastroVendas(int idVenda)
        {
            InitializeComponent();
            this.idVenda = idVenda;
            if (this.idVenda > 0)
                GetVendas(idVenda);
        }
        private void GetVendas(int idVenda)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "select*from vendas where idVenda=" + idVenda;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                            {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    cmbVendedorVenda.Text = dr["idUsuario"].ToString();
                                    cmbIdAluno.Text = dr["idAluno"].ToString();
                                    cmbProdVenda.Text = dr["idServico"].ToString();
                                    txtValorVenda.Text = dr["valorVenda"].ToString();
                                    cmbFormaPagVenda.Text = dr["formaPagVenda"].ToString();
                                    txtTrocoVenda.Text = dr["trocoVenda"].ToString();
                                    dtpDataPagVenda.Text = dr["dataVenda"].ToString();
                                    dtpDataVencVenda.Text = dr["dtVencVenda"].ToString();
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
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarVenda();
            this.Close();
        }
        private void SalvarVenda()

        {

            //os blocos try e catch são usados para tratamento de exceções, ou seja, para lidar com erros que podem ocorrer durante a execução do código.

            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon)) //cria uma nova conexão com o banco 
                {
                    cn.Open(); //Abre a conexão com o banco de dados. Sem isso, não é possível executar comandos SQL

                    var sql = "";

                    if (this.idVenda == 0)
                        //Define a consulta SQL que será executada
                        sql = "INSERT INTO vendas (idUsuario, idAluno, idServico, valorVenda, formaPagVenda, dataVenda, dtVencVenda, trocoVenda) VALUES (@idu, @ida, @ids, @valor, @formaPag,@dtVenda,@dtVenc, @troco)";
                    else
                        sql = "update vendas set idUsuario=@idu, idAluno=@ida, idServico=@ids, valorVenda=@Valor, formaPagVenda=@formaPag, dataVenda=@dtVenda, dtVencVenda=@dtVenc, trocoVenda=@troco where idVenda=" + this.idVenda;
                    //Cria um objeto SqlCommand que representa o comando SQL a ser executado. 
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        //Adiciona os valores dos parâmetros ao comando SQL. Cada parâmetro é associado a um valor obtido dos controles
                        //do formulário (txtNome.Text, txtData.Text, etc.).
                        cmd.Parameters.AddWithValue("@idu", cmbVendedorVenda.Text);
                        cmd.Parameters.AddWithValue("@ida", cmbIdAluno.Text);
                        cmd.Parameters.AddWithValue("@ids", cmbProdVenda.Text);
                        cmd.Parameters.AddWithValue("@valor", txtValorVenda.Text);
                        cmd.Parameters.AddWithValue("@formaPag", cmbFormaPagVenda.Text);
                        cmd.Parameters.AddWithValue("@dtVenda", dtpDataPagVenda.Text);
                        cmd.Parameters.AddWithValue("@dtVencVenda", dtpDataVencVenda.Text);
                        cmd.Parameters.AddWithValue("@formaPag", cmbFormaPagVenda.Text);
                        cmd.Parameters.AddWithValue("@troco", txtTrocoVenda.Text);


                        cmd.ExecuteNonQuery();//Executa o comando SQL no banco de dados.

                        MessageBox.Show("Salvo com sucesso");//Se o comando SQL for executado com sucesso, uma mensagem é exibida ao usuário 
                    }
                }
            }
            //Se ocorrer algum erro durante a execução do código no bloco try, o controle será passado para o bloco catch.
            catch (Exception ex) //Exception ex: Captura a exceção gerada.
            {
                MessageBox.Show("Dados não salvos.\n\n" + ex.Message);//exibe uma mensagem de erro ao usuário, incluindo a mensagem da exceção (ex.Message).

            }
        }
        private void btnBuscarVenda1_Click(object sender, EventArgs e)
        {
            frmCadastroVendas frm = new frmCadastroVendas(0);
            frm.ShowDialog();
        }
   

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

            // Verifica se o valorVenda não está vazio ou com o texto "NULO"
            decimal valorVenda = 0;
            if (txtValorVenda.Text != "NULO" && decimal.TryParse(txtValorVenda.Text, out valorVenda))
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(connectionString))
                    {
                        cn.Open();
                        var sql = "INSERT INTO vendas (valorVenda, formaPagVenda, dataVenda, dtVencVenda, trocoVenda) VALUES (@valor, @dataVenda, @dataVencProd, @troco)";
                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@valor", valorVenda);  // Usa o valorVenda calculado ou vindo do texto
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
            else
            {
                MessageBox.Show("Por favor, verifique o valor do produto.");
            }

            
        }
        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            FormUtils.LimparCampos(this);
        }

        private void btnBuscarVenda1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastroVendas frm = new frmCadastroVendas();
            frm.Show();
        }
    }
}