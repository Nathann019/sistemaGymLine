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
    public partial class frmDashboard: Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAlunos frm = new frmAlunos();
            frm.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuarios frm = new frmUsuarios();
            frm.ShowDialog();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmServicos frm = new frmServicos();
            frm.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVendas frm = new frmVendas();
            frm.ShowDialog();
        }

        private void btnRelatorioMensalidades_Click(object sender, EventArgs e)
        {
            DataTable alunos = BuscarAlunos();

            this.Hide();
            frmRelatorioMensalidades relatorio = new frmRelatorioMensalidades();
            relatorio.CarregarDados(alunos);
            relatorio.ShowDialog();

        }

        private DataTable BuscarAlunos()
        {
            string query = "SELECT idAluno, nomeAluno, enderecoAluno, telAluno, rgAluno, cpfAluno, sexoAluno, datNascAluno, idadeAluno, obsAluno FROM alunos";
            DataTable tabela = new DataTable();
            using (SqlConnection conn = new SqlConnection(conexao.IniciarCon))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(tabela);
            }
            return tabela;

        }


        private void btnRelatorioVendas_Click(object sender, EventArgs e)
        {
            DataTable vendas = BuscarVendas();

            this.Hide();
            frmRelatorioVendas relatorio = new frmRelatorioVendas();
            relatorio.CarregarDados(vendas);
            relatorio.ShowDialog();
        }

        private DataTable BuscarVendas()
        {
            string query = "SELECT idUsuario, idAluno, idServico, valorVenda, formaPagVenda, dataVenda, dtVencVenda FROM vendas";
            DataTable tabela = new DataTable();
            using (SqlConnection conn = new SqlConnection(conexao.IniciarCon))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(tabela);
            }
            return tabela;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
