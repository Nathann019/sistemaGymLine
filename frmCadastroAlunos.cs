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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sistemaGymLine
{
    public partial class frmCadastroAlunos: Form
    {
        int idAluno = 0;
        public frmCadastroAlunos(int idAluno)
        {
            InitializeComponent();
            this.idAluno = idAluno;
            if (this.idAluno > 0)
                GetAlunos(idAluno);
        }
        private void GetAlunos(int idAluno)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "select*from alunos where idAluno=" + idAluno;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    txtNomeAluno.Text = dr["nomeAluno"].ToString();
                                    txtEnderecoAluno.Text = dr["enderecoAluno"].ToString();
                                    txtTelAluno.Text = dr["telAluno"].ToString();
                                    txtRgAluno.Text = dr["rgAluno"].ToString();
                                    txtCpfAluno.Text = dr["cpfAluno"].ToString();
                                    cmbSexoAluno.Text = dr["sexoAluno"].ToString();
                                    dtpDataNascAluno.Text = dr["datNascAluno"].ToString();
                                    txtIdadeAluno.Text = dr["idadeAluno"].ToString();
                                    txtObsAluno.Text = dr["obsAluno"].ToString();
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
            

             

            
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {

            DateTime dtDatNascAluno = dtpDataNascAluno.Value;
            string sexoAluno = cmbSexoAluno.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "";
                    if (this.idAluno == 0)
                        sql = "INSERT INTO alunos (nomeAluno, enderecoAluno, telAluno, rgAluno, cpfAluno, idadeAluno, sexoAluno, datNascAluno, obsAluno) VALUES (@nome, @endereco, @telefone, @rg, @cpf, @idade, @sexo, @dataNasc, @obs)";
                    
                        else
                        sql = "UPDATE alunos set nomeAluno = @nome , enderecoAluno = @endereco, telAluno = @telefone, rgAluno = @rg, cpfAluno = @cpf, idadeAluno = @idade, sexoAluno = @sexo, datNascAluno = @dataNasc, obsAluno = @obs where idAluno=" + this.idAluno;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNomeAluno.Text);
                        cmd.Parameters.AddWithValue("@endereco", txtEnderecoAluno.Text);
                        cmd.Parameters.AddWithValue("@telefone", txtTelAluno.Text);
                        cmd.Parameters.AddWithValue("@rg", txtRgAluno.Text);
                        cmd.Parameters.AddWithValue("@cpf", txtCpfAluno.Text);
                        cmd.Parameters.AddWithValue("@idade", txtIdadeAluno.Text);
                        cmd.Parameters.AddWithValue("@dataNasc", dtDatNascAluno);
                        cmd.Parameters.AddWithValue("@sexo", sexoAluno);
                        cmd.Parameters.AddWithValue("@obs", txtObsAluno.Text);

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

        private void btnVoltarCadAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAlunos frm = new frmAlunos();
            frm.Show();
        }

        private void btnFecharCadAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.Show();
        }

        public static class FormUtils
        {
           
            public static void LimparCampos(Control container)
            {
                
                foreach (Control control in container.Controls)
                {
                    
                    if (control is System.Windows.Forms.TextBox)
                    {
                        ((System.Windows.Forms.TextBox)control).Clear();
                    }
                    
                    else if (control is System.Windows.Forms.ComboBox)
                    {
                        ((System.Windows.Forms.ComboBox)control).SelectedIndex = -1; 
                    }
                   
                    if (control.HasChildren)
                    {
                        LimparCampos(control);
                    }
                }
            }
        }

        private void frmCadastroAlunos_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarAluno_Click(object sender, EventArgs e)
        {
            
                FormUtils.LimparCampos(this);
            
        }
    }
}
