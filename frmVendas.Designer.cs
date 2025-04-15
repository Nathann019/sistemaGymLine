namespace sistemaGymLine
{
    partial class frmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.btnBuscarVenda = new System.Windows.Forms.Button();
            this.btnExcluirVenda = new System.Windows.Forms.Button();
            this.btnEditarVenda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarVenda = new System.Windows.Forms.Button();
            this.txtBuscarVenda = new System.Windows.Forms.TextBox();
            this.dgvVendasCadastradas = new System.Windows.Forms.DataGridView();
            this.btnFecharVendas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendasCadastradas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarVenda
            // 
            this.btnBuscarVenda.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVenda.ForeColor = System.Drawing.Color.White;
            this.btnBuscarVenda.Location = new System.Drawing.Point(1000, 252);
            this.btnBuscarVenda.Name = "btnBuscarVenda";
            this.btnBuscarVenda.Size = new System.Drawing.Size(67, 33);
            this.btnBuscarVenda.TabIndex = 30;
            this.btnBuscarVenda.Text = "Buscar";
            this.btnBuscarVenda.UseVisualStyleBackColor = false;
            this.btnBuscarVenda.Click += new System.EventHandler(this.btnBuscarVenda_Click);
            // 
            // btnExcluirVenda
            // 
            this.btnExcluirVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirVenda.ForeColor = System.Drawing.Color.Blue;
            this.btnExcluirVenda.Location = new System.Drawing.Point(1116, 583);
            this.btnExcluirVenda.Name = "btnExcluirVenda";
            this.btnExcluirVenda.Size = new System.Drawing.Size(75, 33);
            this.btnExcluirVenda.TabIndex = 29;
            this.btnExcluirVenda.Text = "Excluir";
            this.btnExcluirVenda.UseVisualStyleBackColor = true;
            this.btnExcluirVenda.Click += new System.EventHandler(this.btnExcluirVenda_Click);
            // 
            // btnEditarVenda
            // 
            this.btnEditarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarVenda.ForeColor = System.Drawing.Color.Blue;
            this.btnEditarVenda.Location = new System.Drawing.Point(1024, 583);
            this.btnEditarVenda.Name = "btnEditarVenda";
            this.btnEditarVenda.Size = new System.Drawing.Size(75, 33);
            this.btnEditarVenda.TabIndex = 28;
            this.btnEditarVenda.Text = "Editar";
            this.btnEditarVenda.UseVisualStyleBackColor = true;
            this.btnEditarVenda.Click += new System.EventHandler(this.btnEditarVenda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "Pesquisar Vendas Cadastradas";
            // 
            // btnCadastrarVenda
            // 
            this.btnCadastrarVenda.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCadastrarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarVenda.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarVenda.Location = new System.Drawing.Point(437, 251);
            this.btnCadastrarVenda.Name = "btnCadastrarVenda";
            this.btnCadastrarVenda.Size = new System.Drawing.Size(102, 35);
            this.btnCadastrarVenda.TabIndex = 26;
            this.btnCadastrarVenda.Text = "+ Cadastrar";
            this.btnCadastrarVenda.UseVisualStyleBackColor = false;
            this.btnCadastrarVenda.Click += new System.EventHandler(this.btnCadastrarVenda_Click);
            // 
            // txtBuscarVenda
            // 
            this.txtBuscarVenda.Location = new System.Drawing.Point(545, 251);
            this.txtBuscarVenda.Multiline = true;
            this.txtBuscarVenda.Name = "txtBuscarVenda";
            this.txtBuscarVenda.Size = new System.Drawing.Size(449, 35);
            this.txtBuscarVenda.TabIndex = 25;
            // 
            // dgvVendasCadastradas
            // 
            this.dgvVendasCadastradas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVendasCadastradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendasCadastradas.Location = new System.Drawing.Point(339, 291);
            this.dgvVendasCadastradas.Name = "dgvVendasCadastradas";
            this.dgvVendasCadastradas.Size = new System.Drawing.Size(852, 273);
            this.dgvVendasCadastradas.TabIndex = 24;
            // 
            // btnFecharVendas
            // 
            this.btnFecharVendas.BackColor = System.Drawing.Color.IndianRed;
            this.btnFecharVendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFecharVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharVendas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFecharVendas.Location = new System.Drawing.Point(1215, 12);
            this.btnFecharVendas.Name = "btnFecharVendas";
            this.btnFecharVendas.Size = new System.Drawing.Size(37, 28);
            this.btnFecharVendas.TabIndex = 32;
            this.btnFecharVendas.Text = "X";
            this.btnFecharVendas.UseVisualStyleBackColor = false;
            this.btnFecharVendas.Click += new System.EventHandler(this.btnFecharVendas_Click);
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnFecharVendas);
            this.Controls.Add(this.btnBuscarVenda);
            this.Controls.Add(this.btnExcluirVenda);
            this.Controls.Add(this.btnEditarVenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarVenda);
            this.Controls.Add(this.txtBuscarVenda);
            this.Controls.Add(this.dgvVendasCadastradas);
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendasCadastradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarVenda;
        private System.Windows.Forms.Button btnExcluirVenda;
        private System.Windows.Forms.Button btnEditarVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarVenda;
        private System.Windows.Forms.TextBox txtBuscarVenda;
        private System.Windows.Forms.DataGridView dgvVendasCadastradas;
        private System.Windows.Forms.Button btnFecharVendas;
    }
}