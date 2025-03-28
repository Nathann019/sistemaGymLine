namespace sistemaGymLine
{
    partial class frmCadastroAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroAlunos));
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObsAluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelAluno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnderecoAluno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCpfAluno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRgAluno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdadeAluno = new System.Windows.Forms.TextBox();
            this.cmbSexoAluno = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDataNascAluno = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSalvarAluno = new System.Windows.Forms.Button();
            this.btnCancelarAluno = new System.Windows.Forms.Button();
            this.btnVoltarCadAluno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdAluno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(483, 244);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(340, 29);
            this.txtNomeAluno.TabIndex = 0;
            this.txtNomeAluno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Completo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Observação";
            // 
            // txtObsAluno
            // 
            this.txtObsAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObsAluno.Location = new System.Drawing.Point(483, 400);
            this.txtObsAluno.Multiline = true;
            this.txtObsAluno.Name = "txtObsAluno";
            this.txtObsAluno.Size = new System.Drawing.Size(548, 112);
            this.txtObsAluno.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(689, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTelAluno
            // 
            this.txtTelAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelAluno.Location = new System.Drawing.Point(692, 348);
            this.txtTelAluno.Name = "txtTelAluno";
            this.txtTelAluno.Size = new System.Drawing.Size(203, 29);
            this.txtTelAluno.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(480, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Endereço";
            // 
            // txtEnderecoAluno
            // 
            this.txtEnderecoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoAluno.Location = new System.Drawing.Point(483, 348);
            this.txtEnderecoAluno.Name = "txtEnderecoAluno";
            this.txtEnderecoAluno.Size = new System.Drawing.Size(203, 29);
            this.txtEnderecoAluno.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(689, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "CPF";
            // 
            // txtCpfAluno
            // 
            this.txtCpfAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfAluno.Location = new System.Drawing.Point(692, 296);
            this.txtCpfAluno.Name = "txtCpfAluno";
            this.txtCpfAluno.Size = new System.Drawing.Size(203, 29);
            this.txtCpfAluno.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(480, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "RG";
            // 
            // txtRgAluno
            // 
            this.txtRgAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgAluno.Location = new System.Drawing.Point(483, 296);
            this.txtRgAluno.Name = "txtRgAluno";
            this.txtRgAluno.Size = new System.Drawing.Size(203, 29);
            this.txtRgAluno.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(826, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Idade";
            // 
            // txtIdadeAluno
            // 
            this.txtIdadeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdadeAluno.Location = new System.Drawing.Point(829, 244);
            this.txtIdadeAluno.Name = "txtIdadeAluno";
            this.txtIdadeAluno.Size = new System.Drawing.Size(66, 29);
            this.txtIdadeAluno.TabIndex = 14;
            // 
            // cmbSexoAluno
            // 
            this.cmbSexoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexoAluno.FormattingEnabled = true;
            this.cmbSexoAluno.Location = new System.Drawing.Point(901, 244);
            this.cmbSexoAluno.Name = "cmbSexoAluno";
            this.cmbSexoAluno.Size = new System.Drawing.Size(130, 28);
            this.cmbSexoAluno.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(907, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Sexo";
            // 
            // dtpDataNascAluno
            // 
            this.dtpDataNascAluno.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpDataNascAluno.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpDataNascAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascAluno.Location = new System.Drawing.Point(901, 296);
            this.dtpDataNascAluno.Name = "dtpDataNascAluno";
            this.dtpDataNascAluno.Size = new System.Drawing.Size(130, 29);
            this.dtpDataNascAluno.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(898, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Data de Nascimento";
            // 
            // btnSalvarAluno
            // 
            this.btnSalvarAluno.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSalvarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAluno.ForeColor = System.Drawing.Color.White;
            this.btnSalvarAluno.Location = new System.Drawing.Point(678, 533);
            this.btnSalvarAluno.Name = "btnSalvarAluno";
            this.btnSalvarAluno.Size = new System.Drawing.Size(75, 32);
            this.btnSalvarAluno.TabIndex = 21;
            this.btnSalvarAluno.Text = "Salvar";
            this.btnSalvarAluno.UseVisualStyleBackColor = false;
            // 
            // btnCancelarAluno
            // 
            this.btnCancelarAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAluno.ForeColor = System.Drawing.Color.White;
            this.btnCancelarAluno.Location = new System.Drawing.Point(761, 533);
            this.btnCancelarAluno.Name = "btnCancelarAluno";
            this.btnCancelarAluno.Size = new System.Drawing.Size(82, 32);
            this.btnCancelarAluno.TabIndex = 22;
            this.btnCancelarAluno.Text = "Cancelar";
            this.btnCancelarAluno.UseVisualStyleBackColor = false;
            // 
            // btnVoltarCadAluno
            // 
            this.btnVoltarCadAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarCadAluno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVoltarCadAluno.Location = new System.Drawing.Point(12, 632);
            this.btnVoltarCadAluno.Name = "btnVoltarCadAluno";
            this.btnVoltarCadAluno.Size = new System.Drawing.Size(75, 37);
            this.btnVoltarCadAluno.TabIndex = 23;
            this.btnVoltarCadAluno.Text = "Voltar";
            this.btnVoltarCadAluno.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "ID - Aluno";
            // 
            // txtIdAluno
            // 
            this.txtIdAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAluno.Location = new System.Drawing.Point(483, 191);
            this.txtIdAluno.Name = "txtIdAluno";
            this.txtIdAluno.Size = new System.Drawing.Size(84, 29);
            this.txtIdAluno.TabIndex = 47;
            // 
            // frmCadastroAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdAluno);
            this.Controls.Add(this.btnVoltarCadAluno);
            this.Controls.Add(this.btnCancelarAluno);
            this.Controls.Add(this.btnSalvarAluno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpDataNascAluno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbSexoAluno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdadeAluno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRgAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCpfAluno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEnderecoAluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtObsAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeAluno);
            this.Name = "frmCadastroAlunos";
            this.Text = "frmCadastroAlunos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObsAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelAluno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnderecoAluno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCpfAluno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdadeAluno;
        private System.Windows.Forms.ComboBox cmbSexoAluno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDataNascAluno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSalvarAluno;
        private System.Windows.Forms.Button btnCancelarAluno;
        private System.Windows.Forms.Button btnVoltarCadAluno;
        private System.Windows.Forms.TextBox txtRgAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdAluno;
    }
}