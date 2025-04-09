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
            this.btnSalvarRelMensalidades = new System.Windows.Forms.Button();
            this.btnFecharRelMensalidades = new System.Windows.Forms.Button();
            this.btnImprimirRelMensalidades = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRelMensalidades = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelMensalidades)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvRelMensalidades);
            this.panel1.Location = new System.Drawing.Point(251, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 579);
            this.panel1.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(654, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 81;
            this.label1.Text = "Relatório de Alunos";
            // 
            // dgvRelMensalidades
            // 
            this.dgvRelMensalidades.BackgroundColor = System.Drawing.Color.White;
            this.dgvRelMensalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelMensalidades.Location = new System.Drawing.Point(11, 42);
            this.dgvRelMensalidades.Name = "dgvRelMensalidades";
            this.dgvRelMensalidades.Size = new System.Drawing.Size(990, 471);
            this.dgvRelMensalidades.TabIndex = 82;
            // 
            // frmRelatorioMensalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFecharRelMensalidades);
            this.Controls.Add(this.btnSalvarRelMensalidades);
            this.Controls.Add(this.btnImprimirRelMensalidades);
            this.Controls.Add(this.panel1);
            this.Name = "frmRelatorioMensalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioMensalidades";
            this.Load += new System.EventHandler(this.frmRelatorioMensalidades_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelMensalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvarRelMensalidades;
        private System.Windows.Forms.Button btnFecharRelMensalidades;
        private System.Windows.Forms.Button btnImprimirRelMensalidades;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRelMensalidades;
        private System.Windows.Forms.Label label1;
    }
}