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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarServico = new System.Windows.Forms.Button();
            this.txtBuscarServico = new System.Windows.Forms.TextBox();
            this.btnBuscarServico = new System.Windows.Forms.Button();
            this.dgvServicosCadastrados = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFecharServico = new System.Windows.Forms.Button();
            this.btnEditarServico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicosCadastrados)).BeginInit();
            this.SuspendLayout();
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
            this.btnCadastrarServico.Location = new System.Drawing.Point(437, 252);
            this.btnCadastrarServico.Name = "btnCadastrarServico";
            this.btnCadastrarServico.Size = new System.Drawing.Size(102, 35);
            this.btnCadastrarServico.TabIndex = 24;
            this.btnCadastrarServico.Text = "+ Cadastrar";
            this.btnCadastrarServico.UseVisualStyleBackColor = false;
            this.btnCadastrarServico.Click += new System.EventHandler(this.btnCadastrarServico_Click);
            // 
            // txtBuscarServico
            // 
            this.txtBuscarServico.Location = new System.Drawing.Point(545, 252);
            this.txtBuscarServico.Multiline = true;
            this.txtBuscarServico.Name = "txtBuscarServico";
            this.txtBuscarServico.Size = new System.Drawing.Size(449, 35);
            this.txtBuscarServico.TabIndex = 25;
            // 
            // btnBuscarServico
            // 
            this.btnBuscarServico.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarServico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarServico.ForeColor = System.Drawing.Color.White;
            this.btnBuscarServico.Location = new System.Drawing.Point(1000, 253);
            this.btnBuscarServico.Name = "btnBuscarServico";
            this.btnBuscarServico.Size = new System.Drawing.Size(67, 33);
            this.btnBuscarServico.TabIndex = 26;
            this.btnBuscarServico.Text = "Buscar";
            this.btnBuscarServico.UseVisualStyleBackColor = false;
            this.btnBuscarServico.Click += new System.EventHandler(this.btnBuscarServico_Click);
            // 
            // dgvServicosCadastrados
            // 
            this.dgvServicosCadastrados.BackgroundColor = System.Drawing.Color.White;
            this.dgvServicosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicosCadastrados.Location = new System.Drawing.Point(339, 292);
            this.dgvServicosCadastrados.Name = "dgvServicosCadastrados";
            this.dgvServicosCadastrados.Size = new System.Drawing.Size(852, 273);
            this.dgvServicosCadastrados.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(1116, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 29;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFecharServico
            // 
            this.btnFecharServico.BackColor = System.Drawing.Color.IndianRed;
            this.btnFecharServico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFecharServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharServico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFecharServico.Location = new System.Drawing.Point(1215, 12);
            this.btnFecharServico.Name = "btnFecharServico";
            this.btnFecharServico.Size = new System.Drawing.Size(37, 28);
            this.btnFecharServico.TabIndex = 31;
            this.btnFecharServico.Text = "X";
            this.btnFecharServico.UseVisualStyleBackColor = false;
            this.btnFecharServico.Click += new System.EventHandler(this.btnFecharServico_Click);
            // 
            // btnEditarServico
            // 
            this.btnEditarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarServico.ForeColor = System.Drawing.Color.Blue;
            this.btnEditarServico.Location = new System.Drawing.Point(1024, 583);
            this.btnEditarServico.Name = "btnEditarServico";
            this.btnEditarServico.Size = new System.Drawing.Size(75, 33);
            this.btnEditarServico.TabIndex = 32;
            this.btnEditarServico.Text = "Editar";
            this.btnEditarServico.UseVisualStyleBackColor = true;
            this.btnEditarServico.Click += new System.EventHandler(this.btnEditarServico_Click);
            // 
            // frmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnFecharServico);
            this.Controls.Add(this.btnBuscarServico);
            this.Controls.Add(this.txtBuscarServico);
            this.Controls.Add(this.btnCadastrarServico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvServicosCadastrados);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEditarServico);
            this.Name = "frmServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmServicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicosCadastrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarServico;
        private System.Windows.Forms.TextBox txtBuscarServico;
        private System.Windows.Forms.Button btnBuscarServico;
        private System.Windows.Forms.DataGridView dgvServicosCadastrados;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFecharServico;
        private System.Windows.Forms.Button btnEditarServico;
    }
}