using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaGymLine
{
    public partial class frmRelatorioMensalidades: Form
    {
        public frmRelatorioMensalidades()
        {
            InitializeComponent();
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
    }
}
