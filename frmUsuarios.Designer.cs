namespace sistemaGymLine
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.btnVoltarUser = new System.Windows.Forms.Button();
            this.btnBuscarUser = new System.Windows.Forms.Button();
            this.btnExcluirUser = new System.Windows.Forms.Button();
            this.btnEditarUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarUser = new System.Windows.Forms.Button();
            this.txtBuscarUser = new System.Windows.Forms.TextBox();
            this.dgvUsersCadastrados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltarUser
            // 
            this.btnVoltarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVoltarUser.Location = new System.Drawing.Point(12, 632);
            this.btnVoltarUser.Name = "btnVoltarUser";
            this.btnVoltarUser.Size = new System.Drawing.Size(75, 37);
            this.btnVoltarUser.TabIndex = 15;
            this.btnVoltarUser.Text = "Voltar";
            this.btnVoltarUser.UseVisualStyleBackColor = true;
            // 
            // btnBuscarUser
            // 
            this.btnBuscarUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUser.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUser.Location = new System.Drawing.Point(1000, 252);
            this.btnBuscarUser.Name = "btnBuscarUser";
            this.btnBuscarUser.Size = new System.Drawing.Size(67, 33);
            this.btnBuscarUser.TabIndex = 14;
            this.btnBuscarUser.Text = "Buscar";
            this.btnBuscarUser.UseVisualStyleBackColor = false;
            this.btnBuscarUser.Click += new System.EventHandler(this.btnBuscarUser_Click);
            // 
            // btnExcluirUser
            // 
            this.btnExcluirUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirUser.ForeColor = System.Drawing.Color.Blue;
            this.btnExcluirUser.Location = new System.Drawing.Point(1116, 583);
            this.btnExcluirUser.Name = "btnExcluirUser";
            this.btnExcluirUser.Size = new System.Drawing.Size(75, 33);
            this.btnExcluirUser.TabIndex = 13;
            this.btnExcluirUser.Text = "Excluir";
            this.btnExcluirUser.UseVisualStyleBackColor = true;
            // 
            // btnEditarUser
            // 
            this.btnEditarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUser.ForeColor = System.Drawing.Color.Blue;
            this.btnEditarUser.Location = new System.Drawing.Point(1024, 583);
            this.btnEditarUser.Name = "btnEditarUser";
            this.btnEditarUser.Size = new System.Drawing.Size(75, 33);
            this.btnEditarUser.TabIndex = 12;
            this.btnEditarUser.Text = "Editar";
            this.btnEditarUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pesquisar Usuários Cadastrados";
            // 
            // btnCadastrarUser
            // 
            this.btnCadastrarUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCadastrarUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarUser.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarUser.Location = new System.Drawing.Point(437, 251);
            this.btnCadastrarUser.Name = "btnCadastrarUser";
            this.btnCadastrarUser.Size = new System.Drawing.Size(102, 35);
            this.btnCadastrarUser.TabIndex = 10;
            this.btnCadastrarUser.Text = "+ Cadastrar";
            this.btnCadastrarUser.UseVisualStyleBackColor = false;
            this.btnCadastrarUser.Click += new System.EventHandler(this.btnCadastrarUser_Click);
            // 
            // txtBuscarUser
            // 
            this.txtBuscarUser.Location = new System.Drawing.Point(545, 251);
            this.txtBuscarUser.Multiline = true;
            this.txtBuscarUser.Name = "txtBuscarUser";
            this.txtBuscarUser.Size = new System.Drawing.Size(449, 35);
            this.txtBuscarUser.TabIndex = 9;
            // 
            // dgvUsersCadastrados
            // 
            this.dgvUsersCadastrados.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsersCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersCadastrados.Location = new System.Drawing.Point(339, 292);
            this.dgvUsersCadastrados.Name = "dgvUsersCadastrados";
            this.dgvUsersCadastrados.Size = new System.Drawing.Size(852, 273);
            this.dgvUsersCadastrados.TabIndex = 8;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnVoltarUser);
            this.Controls.Add(this.btnBuscarUser);
            this.Controls.Add(this.btnExcluirUser);
            this.Controls.Add(this.btnEditarUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarUser);
            this.Controls.Add(this.txtBuscarUser);
            this.Controls.Add(this.dgvUsersCadastrados);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersCadastrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarUser;
        private System.Windows.Forms.Button btnBuscarUser;
        private System.Windows.Forms.Button btnExcluirUser;
        private System.Windows.Forms.Button btnEditarUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarUser;
        private System.Windows.Forms.TextBox txtBuscarUser;
        private System.Windows.Forms.DataGridView dgvUsersCadastrados;
    }
}