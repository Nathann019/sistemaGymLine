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
    }
}
