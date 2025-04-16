using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaGymLine
{
    public partial class frmRelatorioMensalidades: Form
    
    
    {

        private PrintDocument Documento = new PrintDocument();
       
        public void CarregarDados(DataTable dados)
        {
            dgvRelMensalidades.DataSource = dados;
        }

        public frmRelatorioMensalidades()
        {
            InitializeComponent();
            Documento.PrintPage += Documento_PrintPage;
        }

        private void Documento_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fonteTitulo = new Font("Arial", 18, FontStyle.Bold);
            Font fonteCabecalho = new Font("Arial", 12, FontStyle.Bold);
            Font fonteCorpo = new Font("Arial", 10);

            int margemEsquerda = e.MarginBounds.Left;
            int margemSuperior = e.MarginBounds.Top;

            float linhaAltura = fonteCorpo.GetHeight(e.Graphics) + 4;
            float y = margemSuperior;

            // Título
            e.Graphics.DrawString("Relatório de Alunos", fonteTitulo, Brushes.Black, margemEsquerda, y);
            y += linhaAltura * 2;

            // Cabeçalhos
            e.Graphics.DrawString("ID", fonteCabecalho, Brushes.Black, margemEsquerda, y);
            e.Graphics.DrawString("Nome", fonteCabecalho, Brushes.Black, margemEsquerda + 20, y);
            e.Graphics.DrawString("Endereço", fonteCabecalho, Brushes.Black, margemEsquerda + 80, y);
            e.Graphics.DrawString("Telefone", fonteCabecalho, Brushes.Black, margemEsquerda + 180, y);
            e.Graphics.DrawString("RG", fonteCabecalho, Brushes.Black, margemEsquerda + 300, y);
            e.Graphics.DrawString("CPF", fonteCabecalho, Brushes.Black, margemEsquerda + 340, y);
            e.Graphics.DrawString("Sexo", fonteCabecalho, Brushes.Black, margemEsquerda + 400, y);
            e.Graphics.DrawString("Data de Nascimento", fonteCabecalho, Brushes.Black, margemEsquerda +450, y);
            e.Graphics.DrawString("idade", fonteCabecalho, Brushes.Black, margemEsquerda + 650, y);
            e.Graphics.DrawString("Observação", fonteCabecalho, Brushes.Black, margemEsquerda + 750, y);
            y += linhaAltura;

            // Dados do DataGridView
            foreach (DataGridViewRow row in dgvRelMensalidades.Rows)
            {
                if (row.IsNewRow) continue;

                e.Graphics.DrawString(row.Cells["idAluno"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda, y);
                e.Graphics.DrawString(row.Cells["nomeAluno"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 250, y);
                e.Graphics.DrawString(row.Cells["enderecoAluno"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 250, y);
                e.Graphics.DrawString(row.Cells["telAluno"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 250, y);
                e.Graphics.DrawString(row.Cells["rgAluno"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 250, y);
                e.Graphics.DrawString(row.Cells["cpfAluno"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 250, y);
                e.Graphics.DrawString(row.Cells["sexoAluno"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 250, y);
                e.Graphics.DrawString(row.Cells["dtNascAluno"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 250, y);
                e.Graphics.DrawString(row.Cells["idadeAluno"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 250, y);
                e.Graphics.DrawString(row.Cells["obsAluno"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 250, y);

                y += linhaAltura;

                // Evita que ultrapasse a página
                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            // Rodapé ou total opcional
            y += linhaAltura;
            e.Graphics.DrawString("Total de alunos: " + (dgvRelMensalidades.Rows.Count - 1), fonteCorpo, Brushes.Black, margemEsquerda, y);
        }

        private void frmRelatorioMensalidades_Load(object sender, EventArgs e)
        {

            
        }

        private void btnVoltarAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }

        private void btnFecharRelMensalidades_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimirRelMensalidades_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = Documento;
            preview.ShowDialog();
        }
    }
}
