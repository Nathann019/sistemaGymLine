﻿using System;
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
            this.Hide();
            frmRelatorioMensalidades frm = new frmRelatorioMensalidades();
            frm.ShowDialog();
        }

        private void btnRelatorioVendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRelatorioVendas frm = new frmRelatorioVendas();
            frm.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
