namespace sistemaGymLine
{
    partial class frmServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicos));
            this.btnVoltarServico = new System.Windows.Forms.Button();
            this.btnBuscarServico = new System.Windows.Forms.Button();
            this.btnExcluirServico = new System.Windows.Forms.Button();
            this.btnEditarServico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarServico = new System.Windows.Forms.Button();
            this.txtBuscarServico = new System.Windows.Forms.TextBox();
            this.dgvServicosCadastrados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicosCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltarServico
            // 
            this.btnVoltarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarServico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVoltarServico.Location = new System.Drawing.Point(12, 632);
            this.btnVoltarServico.Name = "btnVoltarServico";
            this.btnVoltarServico.Size = new System.Drawing.Size(75, 37);
            this.btnVoltarServico.TabIndex = 23;
            this.btnVoltarServico.Text = "Voltar";
            this.btnVoltarServico.UseVisualStyleBackColor = true;
            this.btnVoltarServico.Click += new System.EventHandler(this.btnVoltarUsuario_Click);
            // 
            // btnBuscarServico
            // 
            this.btnBuscarServico.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarServico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarServico.ForeColor = System.Drawing.Color.White;
            this.btnBuscarServico.Location = new System.Drawing.Point(1000, 252);
            this.btnBuscarServico.Name = "btnBuscarServico";
            this.btnBuscarServico.Size = new System.Drawing.Size(67, 33);
            this.btnBuscarServico.TabIndex = 22;
            this.btnBuscarServico.Text = "Buscar";
            this.btnBuscarServico.UseVisualStyleBackColor = false;
            this.btnBuscarServico.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // btnExcluirServico
            // 
            this.btnExcluirServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirServico.ForeColor = System.Drawing.Color.Blue;
            this.btnExcluirServico.Location = new System.Drawing.Point(1116, 583);
            this.btnExcluirServico.Name = "btnExcluirServico";
            this.btnExcluirServico.Size = new System.Drawing.Size(75, 33);
            this.btnExcluirServico.TabIndex = 21;
            this.btnExcluirServico.Text = "Excluir";
            this.btnExcluirServico.UseVisualStyleBackColor = true;
            this.btnExcluirServico.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // btnEditarServico
            // 
            this.btnEditarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarServico.ForeColor = System.Drawing.Color.Blue;
            this.btnEditarServico.Location = new System.Drawing.Point(1024, 583);
            this.btnEditarServico.Name = "btnEditarServico";
            this.btnEditarServico.Size = new System.Drawing.Size(75, 33);
            this.btnEditarServico.TabIndex = 20;
            this.btnEditarServico.Text = "Editar";
            this.btnEditarServico.UseVisualStyleBackColor = true;
            this.btnEditarServico.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pesquisar Serviços Cadastrados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCadastrarServico
            // 
            this.btnCadastrarServico.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCadastrarServico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarServico.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarServico.Location = new System.Drawing.Point(437, 251);
            this.btnCadastrarServico.Name = "btnCadastrarServico";
            this.btnCadastrarServico.Size = new System.Drawing.Size(102, 35);
            this.btnCadastrarServico.TabIndex = 18;
            this.btnCadastrarServico.Text = "+ Cadastrar";
            this.btnCadastrarServico.UseVisualStyleBackColor = false;
            this.btnCadastrarServico.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // txtBuscarServico
            // 
            this.txtBuscarServico.Location = new System.Drawing.Point(545, 251);
            this.txtBuscarServico.Multiline = true;
            this.txtBuscarServico.Name = "txtBuscarServico";
            this.txtBuscarServico.Size = new System.Drawing.Size(449, 35);
            this.txtBuscarServico.TabIndex = 17;
            this.txtBuscarServico.TextChanged += new System.EventHandler(this.txtBuscarUsuario_TextChanged);
            // 
            // dgvServicosCadastrados
            // 
            this.dgvServicosCadastrados.BackgroundColor = System.Drawing.Color.White;
            this.dgvServicosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicosCadastrados.Location = new System.Drawing.Point(339, 292);
            this.dgvServicosCadastrados.Name = "dgvServicosCadastrados";
            this.dgvServicosCadastrados.Size = new System.Drawing.Size(852, 273);
            this.dgvServicosCadastrados.TabIndex = 16;
            this.dgvServicosCadastrados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosCadastrados_CellContentClick);
            // 
            // frmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnVoltarServico);
            this.Controls.Add(this.btnBuscarServico);
            this.Controls.Add(this.btnExcluirServico);
            this.Controls.Add(this.btnEditarServico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarServico);
            this.Controls.Add(this.txtBuscarServico);
            this.Controls.Add(this.dgvServicosCadastrados);
            this.Name = "frmServicos";
            this.Text = "frmServicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicosCadastrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarServico;
        private System.Windows.Forms.Button btnBuscarServico;
        private System.Windows.Forms.Button btnExcluirServico;
        private System.Windows.Forms.Button btnEditarServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarServico;
        private System.Windows.Forms.TextBox txtBuscarServico;
        private System.Windows.Forms.DataGridView dgvServicosCadastrados;
    }
}