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
    public partial class frmCadastroUsuarios: Form
    {
        public frmCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void btnVoltarCadUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuarios frm = new frmUsuarios();
            frm.Show();
        }

        private void btnFecharCadUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }

        private void btnSalvarUser_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "INSERT INTO usuarios (nomeCompUsuario, nomeUsuario, senhaUsuario) VALUES (@nomeComp, @nomeUser, @senhaUser)";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@nomeComp", txtNomeCompletoUser.Text);
                        cmd.Parameters.AddWithValue("@nomeUser", txtNomeUser.Text);
                        cmd.Parameters.AddWithValue("@senhaUser", txtSenhaUser.Text);
                        
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

        private void btnCancelarUser_Click(object sender, EventArgs e)
        {
            FormUtils.LimparCampos(this);
        }
    }
}
