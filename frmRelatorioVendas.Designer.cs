namespace sistemaGymLine
{
    partial class frmRelatorioVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioVendas));
            this.btnSalvarRelVendas = new System.Windows.Forms.Button();
            this.btnImprimirRelVendas = new System.Windows.Forms.Button();
            this.dgvRelVendas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltarAluno = new System.Windows.Forms.Button();
            this.btnGerarRelVendas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvarRelVendas
            // 
            this.btnSalvarRelVendas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSalvarRelVendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarRelVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarRelVendas.Location = new System.Drawing.Point(1096, 620);
            this.btnSalvarRelVendas.Name = "btnSalvarRelVendas";
            this.btnSalvarRelVendas.Size = new System.Drawing.Size(75, 36);
            this.btnSalvarRelVendas.TabIndex = 5;
            this.btnSalvarRelVendas.Text = "Salvar";
            this.btnSalvarRelVendas.UseVisualStyleBackColor = false;
            // 
            // btnImprimirRelVendas
            // 
            this.btnImprimirRelVendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirRelVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirRelVendas.Location = new System.Drawing.Point(1177, 620);
            this.btnImprimirRelVendas.Name = "btnImprimirRelVendas";
            this.btnImprimirRelVendas.Size = new System.Drawing.Size(75, 36);
            this.btnImprimirRelVendas.TabIndex = 4;
            this.btnImprimirRelVendas.Text = "Imprimir";
            this.btnImprimirRelVendas.UseVisualStyleBackColor = true;
            // 
            // dgvRelVendas
            // 
            this.dgvRelVendas.BackgroundColor = System.Drawing.Color.White;
            this.dgvRelVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelVendas.Location = new System.Drawing.Point(265, 143);
            this.dgvRelVendas.Name = "dgvRelVendas";
            this.dgvRelVendas.Size = new System.Drawing.Size(987, 471);
            this.dgvRelVendas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 37);
            this.label1.TabIndex = 29;
            this.label1.Text = "Relatório de Vendas realizadas no mês";
            // 
            // btnVoltarAluno
            // 
            this.btnVoltarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarAluno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVoltarAluno.Location = new System.Drawing.Point(12, 632);
            this.btnVoltarAluno.Name = "btnVoltarAluno";
            this.btnVoltarAluno.Size = new System.Drawing.Size(75, 37);
            this.btnVoltarAluno.TabIndex = 45;
            this.btnVoltarAluno.Text = "Voltar";
            this.btnVoltarAluno.UseVisualStyleBackColor = true;
            // 
            // btnGerarRelVendas
            // 
            this.btnGerarRelVendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarRelVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelVendas.Location = new System.Drawing.Point(1177, 104);
            this.btnGerarRelVendas.Name = "btnGerarRelVendas";
            this.btnGerarRelVendas.Size = new System.Drawing.Size(75, 36);
            this.btnGerarRelVendas.TabIndex = 46;
            this.btnGerarRelVendas.Text = "Gerar";
            this.btnGerarRelVendas.UseVisualStyleBackColor = true;
            // 
            // frmRelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnGerarRelVendas);
            this.Controls.Add(this.btnVoltarAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvarRelVendas);
            this.Controls.Add(this.btnImprimirRelVendas);
            this.Controls.Add(this.dgvRelVendas);
            this.Name = "frmRelatorioVendas";
            this.Text = "frmRelatorioVendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarRelVendas;
        private System.Windows.Forms.Button btnImprimirRelVendas;
        private System.Windows.Forms.DataGridView dgvRelVendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltarAluno;
        private System.Windows.Forms.Button btnGerarRelVendas;
    }
}