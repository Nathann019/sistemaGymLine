namespace sistemaGymLine
{
    partial class frmRelatorioMensalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioMensalidades));
            this.dgvRelMensalidades = new System.Windows.Forms.DataGridView();
            this.btnImprimirRelMensalidades = new System.Windows.Forms.Button();
            this.btnSalvarRelMensalidades = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerarRelMensalidades = new System.Windows.Forms.Button();
            this.btnFecharRelMensalidades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelMensalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRelMensalidades
            // 
            this.dgvRelMensalidades.BackgroundColor = System.Drawing.Color.White;
            this.dgvRelMensalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelMensalidades.Location = new System.Drawing.Point(265, 143);
            this.dgvRelMensalidades.Name = "dgvRelMensalidades";
            this.dgvRelMensalidades.Size = new System.Drawing.Size(987, 471);
            this.dgvRelMensalidades.TabIndex = 0;
            // 
            // btnImprimirRelMensalidades
            // 
            this.btnImprimirRelMensalidades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirRelMensalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirRelMensalidades.Location = new System.Drawing.Point(1177, 620);
            this.btnImprimirRelMensalidades.Name = "btnImprimirRelMensalidades";
            this.btnImprimirRelMensalidades.Size = new System.Drawing.Size(75, 36);
            this.btnImprimirRelMensalidades.TabIndex = 1;
            this.btnImprimirRelMensalidades.Text = "Imprimir";
            this.btnImprimirRelMensalidades.UseVisualStyleBackColor = true;
            // 
            // btnSalvarRelMensalidades
            // 
            this.btnSalvarRelMensalidades.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSalvarRelMensalidades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarRelMensalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarRelMensalidades.Location = new System.Drawing.Point(1096, 620);
            this.btnSalvarRelMensalidades.Name = "btnSalvarRelMensalidades";
            this.btnSalvarRelMensalidades.Size = new System.Drawing.Size(75, 36);
            this.btnSalvarRelMensalidades.TabIndex = 2;
            this.btnSalvarRelMensalidades.Text = "Salvar";
            this.btnSalvarRelMensalidades.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "Relatório de Mensalidades não pagas";
            // 
            // btnGerarRelMensalidades
            // 
            this.btnGerarRelMensalidades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarRelMensalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelMensalidades.Location = new System.Drawing.Point(1177, 104);
            this.btnGerarRelMensalidades.Name = "btnGerarRelMensalidades";
            this.btnGerarRelMensalidades.Size = new System.Drawing.Size(75, 36);
            this.btnGerarRelMensalidades.TabIndex = 47;
            this.btnGerarRelMensalidades.Text = "Gerar";
            this.btnGerarRelMensalidades.UseVisualStyleBackColor = true;
            // 
            // btnFecharRelMensalidades
            // 
            this.btnFecharRelMensalidades.BackColor = System.Drawing.Color.IndianRed;
            this.btnFecharRelMensalidades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFecharRelMensalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharRelMensalidades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFecharRelMensalidades.Location = new System.Drawing.Point(1215, 12);
            this.btnFecharRelMensalidades.Name = "btnFecharRelMensalidades";
            this.btnFecharRelMensalidades.Size = new System.Drawing.Size(37, 28);
            this.btnFecharRelMensalidades.TabIndex = 73;
            this.btnFecharRelMensalidades.Text = "X";
            this.btnFecharRelMensalidades.UseVisualStyleBackColor = false;
            this.btnFecharRelMensalidades.Click += new System.EventHandler(this.btnFecharRelMensalidades_Click);
            // 
            // frmRelatorioMensalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnFecharRelMensalidades);
            this.Controls.Add(this.btnGerarRelMensalidades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvarRelMensalidades);
            this.Controls.Add(this.btnImprimirRelMensalidades);
            this.Controls.Add(this.dgvRelMensalidades);
            this.Name = "frmRelatorioMensalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioMensalidades";
            this.Load += new System.EventHandler(this.frmRelatorioMensalidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelMensalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelMensalidades;
        private System.Windows.Forms.Button btnImprimirRelMensalidades;
        private System.Windows.Forms.Button btnSalvarRelMensalidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerarRelMensalidades;
        private System.Windows.Forms.Button btnFecharRelMensalidades;
    }
}