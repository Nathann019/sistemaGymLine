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
                                    dtpDataPagVenda.Text = dr["dataVenda"].ToString();
                                    dtpDataVencVenda.Text = dr["dtVencVenda"].ToString();
                                    txtTrocoVenda.Text = dr["trocoVenda"].ToString();
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
                        sql = "INSERT INTO vendas (idUsuario, idAluno, idServico, valorVenda, formaPagVenda, dataVenda, dtVencVenda, trocoVenda) VALUES (@idu, @ida, @ids, @valor, @formaPag, @dtVenda, @dtVenc, @troco)";
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
                        cmd.Parameters.AddWithValue("@dtVenc", dtpDataVencVenda.Text);
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
            public decimal ValorProd { get; set; }

            public override string ToString()
            {
                return Text; // Isso faz com que apareça o nome no ComboBox
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
            using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
            {
                cn.Open();
                string sql = "SELECT idUsuario, nomeUsuario FROM usuarios";

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbVendedorVenda.DataSource = dt;
                cmbVendedorVenda.DisplayMember = "nomeUsuario"; // Exibe o nome
                cmbVendedorVenda.ValueMember = "idUsuario";     // Usa o ID internamente
            }
        }




        private void CarregarProduto()
        {
            using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
            {
                cn.Open();
                string sql = "SELECT idServico, prodServico, valorServico FROM servicos";

                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader reader = cmd.ExecuteReader();

                cmbProdVenda.Items.Clear();

                while (reader.Read())
                {
                    cmbProdVenda.Items.Add(new ComboboxItem
                    {
                        Text = reader["prodServico"].ToString(),
                        Value = Convert.ToInt32(reader["idServico"]), // garante que é int
                        ValorProd = Convert.ToDecimal(reader["valorServico"])
                    });
                }
            }
        }
        



        private void CarregarIdAluno()
        {
            using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
            {
                cn.Open();
                string sql = "SELECT idAluno, nomeAluno FROM alunos";  // Consulta para buscar os alunos

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbIdAluno.DataSource = dt;
                cmbIdAluno.DisplayMember = "nomeAluno"; // O nome que aparece no ComboBox
                cmbIdAluno.ValueMember = "idAluno";     // O valor que será usado (ID do aluno)
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



        private void btnSalvarVenda_Click_1(object sender, EventArgs e)
        {
            DateTime dataPagVenda = dtpDataPagVenda.Value;
            DateTime dataVencVenda = dtpDataVencVenda.Value;

            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon)) // Cria a conexão
                {
                    cn.Open(); // Abre a conexão com o banco

                    string sql = "";

                    // Se idVenda for 0, faz o INSERT. Se não, faz o UPDATE.
                    if (this.idVenda == 0)
                    {
                        sql = "INSERT INTO vendas (idUsuario, idAluno, idServico, valorVenda, formaPagVenda, dataVenda, dtVencVenda, trocoVenda) " +
                              "VALUES (@idu, @ida, @ids, @valor, @formaPag, @dtVenda, @dtVenc, @troco)";
                    }
                    else
                    {
                        sql = "UPDATE vendas SET idUsuario=@idu, idAluno=@ida, idServico=@ids, valorVenda=@valor, formaPagVenda=@formaPag, " +
                              "dataVenda=@dtVenda, dtVencVenda=@dtVenc, trocoVenda=@troco WHERE idVenda=" + this.idVenda;
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, cn)) // Comando SQL a ser executado
                    {
                        // Aqui estamos pegando o valor do SelectedValue do ComboBox e passando o ID do vendedor para o comando
                        if (cmbVendedorVenda.SelectedValue != null)
                        {
                            cmd.Parameters.AddWithValue("@idu", Convert.ToInt32(cmbVendedorVenda.SelectedValue)); // Passa o ID do usuário
                        }
                        else
                        {
                            MessageBox.Show("Selecione um vendedor válido.");
                            return; // Retorna se não for selecionado um vendedor
                        }

                        // Aqui estamos pegando o valor do SelectedValue do ComboBox e passando o ID do aluno para o comando
                        if (cmbIdAluno.SelectedValue != null)
                        {
                            cmd.Parameters.AddWithValue("@ida", Convert.ToInt32(cmbIdAluno.SelectedValue)); // Passa o ID do aluno
                        }
                        else
                        {
                            MessageBox.Show("Selecione um aluno válido.");
                            return; // Retorna se não for selecionado um aluno
                        }

                        if (cmbProdVenda.SelectedItem is ComboboxItem itemServico)
                        {
                            int idServico = Convert.ToInt32(itemServico.Value); // 👈 aqui o ID é tratado como int
                            cmd.Parameters.AddWithValue("@ids", idServico);     // 👈 mandamos como int (não texto)
                        }
                        else
                        {
                            MessageBox.Show("Selecione um serviço válido.");
                            return;
                        }

                        {
                         
                            // VALOR da venda
                            if (!decimal.TryParse(txtValorVenda.Text, out decimal valorVenda))
                            {
                                MessageBox.Show("Valor da venda inválido.");
                                return;
                            }
                            cmd.Parameters.AddWithValue("@valor", valorVenda);

                            // Forma de pagamento
                            cmd.Parameters.AddWithValue("@formaPag", cmbFormaPagVenda.Text);

                            // Datas
                            cmd.Parameters.AddWithValue("@dtVenda", dtpDataPagVenda.Value);
                            cmd.Parameters.AddWithValue("@dtVenc", dtpDataVencVenda.Value);

                            // TROCO
                            if (!decimal.TryParse(txtTrocoVenda.Text, out decimal troco))
                            {
                                MessageBox.Show("Troco inválido.");
                                return;
                            }
                            cmd.Parameters.AddWithValue("@troco", troco);

                            // Se for edição (update)
                            if (this.idVenda != 0)
                            {
                                cmd.Parameters.AddWithValue("@idVenda", this.idVenda);
                            }

                            // Executa
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Venda salva com sucesso!");
                        }

                        // Adicionando os parâmetros restantes
                        //cmd.Parameters.AddWithValue("@valor", txtValorVenda.Text);  // Passa o valor da venda
                        //cmd.Parameters.AddWithValue("@formaPag", cmbFormaPagVenda.Text);  // Forma de pagamento
                        //cmd.Parameters.AddWithValue("@dtVenda", dtpDataPagVenda.Value);  // Data da venda
                        //cmd.Parameters.AddWithValue("@dtVenc", dtpDataVencVenda.Value);  // Data de vencimento
                        //cmd.Parameters.AddWithValue("@troco", txtTrocoVenda.Text);  // Troco

                        // Executa o comando SQL
                        cmd.ExecuteNonQuery();

                        // Mensagem de sucesso
                        MessageBox.Show("Salvo com sucesso");
                    }
                }
            }

            //Se ocorrer algum erro durante a execução do código no bloco try, o controle será passado para o bloco catch.
            catch (Exception ex) //Exception ex: Captura a exceção gerada.
            {
                MessageBox.Show("Dados não salvos.\n\n" + ex.Message);//exibe uma mensagem de erro ao usuário, incluindo a mensagem da exceção (ex.Message).

            }
        }



        private void cmbProdVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProdVenda.SelectedItem is ComboboxItem selectedItem)
            {
                txtValorVenda.Text = selectedItem.ValorProd.ToString("F2"); ; // Exibe com duas casas decimais
            }
            else
            {
                txtValorVenda.Text = ""; // Ou mantém o valor anterior
            }

            


           


        }

        private void btnVoltarCadVenda_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmVendas frm = new frmVendas();
            frm.Show();
        }

        private void btnFecharCadVenda_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }
    }
}