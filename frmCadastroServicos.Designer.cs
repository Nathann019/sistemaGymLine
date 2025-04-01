namespace sistemaGymLine
{
    partial class frmCadastroServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroServicos));
            this.btnVoltarCadProd = new System.Windows.Forms.Button();
            this.btnCancelarProd = new System.Windows.Forms.Button();
            this.btnSalvarProd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDataVencProd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.txtObsProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.btnFecharCadServicos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltarCadProd
            // 
            this.btnVoltarCadProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarCadProd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVoltarCadProd.Location = new System.Drawing.Point(12, 632);
            this.btnVoltarCadProd.Name = "btnVoltarCadProd";
            this.btnVoltarCadProd.Size = new System.Drawing.Size(75, 37);
            this.btnVoltarCadProd.TabIndex = 65;
            this.btnVoltarCadProd.Text = "Voltar";
            this.btnVoltarCadProd.UseVisualStyleBackColor = true;
            this.btnVoltarCadProd.Click += new System.EventHandler(this.btnVoltarCadProd_Click);
            // 
            // btnCancelarProd
            // 
            this.btnCancelarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelarProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProd.ForeColor = System.Drawing.Color.White;
            this.btnCancelarProd.Location = new System.Drawing.Point(761, 533);
            this.btnCancelarProd.Name = "btnCancelarProd";
            this.btnCancelarProd.Size = new System.Drawing.Size(82, 32);
            this.btnCancelarProd.TabIndex = 64;
            this.btnCancelarProd.Text = "Cancelar";
            this.btnCancelarProd.UseVisualStyleBackColor = false;
            // 
            // btnSalvarProd
            // 
            this.btnSalvarProd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSalvarProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProd.ForeColor = System.Drawing.Color.White;
            this.btnSalvarProd.Location = new System.Drawing.Point(678, 533);
            this.btnSalvarProd.Name = "btnSalvarProd";
            this.btnSalvarProd.Size = new System.Drawing.Size(75, 32);
            this.btnSalvarProd.TabIndex = 63;
            this.btnSalvarProd.Text = "Salvar";
            this.btnSalvarProd.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(480, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 18);
            this.label10.TabIndex = 62;
            this.label10.Text = "Data de Vencimento";
            // 
            // dtpDataVencProd
            // 
            this.dtpDataVencProd.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpDataVencProd.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpDataVencProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataVencProd.Location = new System.Drawing.Point(483, 296);
            this.dtpDataVencProd.Name = "dtpDataVencProd";
            this.dtpDataVencProd.Size = new System.Drawing.Size(167, 29);
            this.dtpDataVencProd.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(878, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 18);
            this.label8.TabIndex = 58;
            this.label8.Text = "Valor";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtValorProd
            // 
            this.txtValorProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorProd.Location = new System.Drawing.Point(881, 244);
            this.txtValorProd.Name = "txtValorProd";
            this.txtValorProd.Size = new System.Drawing.Size(150, 29);
            this.txtValorProd.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Observação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Produto";
            // 
            // txtProd
            // 
            this.txtProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProd.Location = new System.Drawing.Point(483, 244);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(392, 29);
            this.txtProd.TabIndex = 45;
            // 
            // txtObsProd
            // 
            this.txtObsProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObsProd.Location = new System.Drawing.Point(483, 348);
            this.txtObsProd.Multiline = true;
            this.txtObsProd.Name = "txtObsProd";
            this.txtObsProd.Size = new System.Drawing.Size(548, 112);
            this.txtObsProd.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "ID - Produto";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProduto.Location = new System.Drawing.Point(483, 191);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(84, 29);
            this.txtIdProduto.TabIndex = 67;
            // 
            // btnFecharCadServicos
            // 
            this.btnFecharCadServicos.BackColor = System.Drawing.Color.IndianRed;
            this.btnFecharCadServicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFecharCadServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharCadServicos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFecharCadServicos.Location = new System.Drawing.Point(1215, 12);
            this.btnFecharCadServicos.Name = "btnFecharCadServicos";
            this.btnFecharCadServicos.Size = new System.Drawing.Size(37, 28);
            this.btnFecharCadServicos.TabIndex = 69;
            this.btnFecharCadServicos.Text = "X";
            this.btnFecharCadServicos.UseVisualStyleBackColor = false;
            this.btnFecharCadServicos.Click += new System.EventHandler(this.btnFecharCadServicos_Click);
            // 
            // frmCadastroServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnFecharCadServicos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.txtObsProd);
            this.Controls.Add(this.btnVoltarCadProd);
            this.Controls.Add(this.btnCancelarProd);
            this.Controls.Add(this.btnSalvarProd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpDataVencProd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtValorProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProd);
            this.Name = "frmCadastroServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroServicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarCadProd;
        private System.Windows.Forms.Button btnCancelarProd;
        private System.Windows.Forms.Button btnSalvarProd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDataVencProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.TextBox txtObsProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Button btnFecharCadServicos;
    }
}