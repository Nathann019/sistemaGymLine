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
    public partial class frmRelatorioVendas: Form
    {
        private PrintDocument documento = new PrintDocument();

        public frmRelatorioVendas()
        {
            InitializeComponent();
            documento.PrintPage += Documento_PrintPage;
        }

        public void CarregarDados(DataTable dados)
        {
            dgvRelVendas.DataSource = dados;
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
            e.Graphics.DrawString("Relatório de Vendas", fonteTitulo, Brushes.Black, margemEsquerda, y);
            y += linhaAltura * 2;

            // Cabeçalhos
            e.Graphics.DrawString("ID da Venda", fonteCabecalho, Brushes.Black, margemEsquerda, y);
            e.Graphics.DrawString("ID do Produto", fonteCabecalho, Brushes.Black, margemEsquerda + 250, y);
            e.Graphics.DrawString("ID do Vendedor", fonteCabecalho, Brushes.Black, margemEsquerda + 450, y);
            e.Graphics.DrawString("Nome do Vendedor", fonteCabecalho, Brushes.Black, margemEsquerda + 650, y);
            e.Graphics.DrawString("ID do Cliente", fonteCabecalho, Brushes.Black, margemEsquerda + 850, y);
            e.Graphics.DrawString("Nome do Cliente", fonteCabecalho, Brushes.Black, margemEsquerda + 1050, y);
            e.Graphics.DrawString("Valor", fonteCabecalho, Brushes.Black, margemEsquerda + 1250, y);
            e.Graphics.DrawString("Data de Vencimento", fonteCabecalho, Brushes.Black, margemEsquerda + 1450, y);
            y += linhaAltura;

            // Dados do DataGridView
            foreach (DataGridViewRow row in dgvRelVendas.Rows)
            {
                if (row.IsNewRow) continue;

                e.Graphics.DrawString(row.Cells["idVenda"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda, y);
                e.Graphics.DrawString(row.Cells["idServico"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 250, y);
                e.Graphics.DrawString(row.Cells["idUsuario"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 450, y);
                e.Graphics.DrawString(row.Cells["idAluno"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 650, y);
                e.Graphics.DrawString(row.Cells["valorVenda"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 850, y);
                e.Graphics.DrawString(row.Cells["dtVencVenda"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 1050, y);

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
            e.Graphics.DrawString("Total de vendas: " + (dgvRelVendas.Rows.Count - 1), fonteCorpo, Brushes.Black, margemEsquerda, y);
        }

        private void btnVoltarAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }

        private void btnFecharRelVendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }

        private void btnImprimirRelVendas_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = documento;
            preview.ShowDialog();
        }
    }
}
