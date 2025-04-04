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
            this.btnImprimirRelMensalidades = new System.Windows.Forms.Button();
            this.btnSalvarRelMensalidades = new System.Windows.Forms.Button();
            this.btnGerarRelMensalidades = new System.Windows.Forms.Button();
            this.btnFecharRelMensalidades = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
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
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sistemaGymLine.relatorios.relMensalidades.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(262, 143);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(990, 471);
            this.reportViewer1.TabIndex = 74;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // frmRelatorioMensalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnFecharRelMensalidades);
            this.Controls.Add(this.btnGerarRelMensalidades);
            this.Controls.Add(this.btnSalvarRelMensalidades);
            this.Controls.Add(this.btnImprimirRelMensalidades);
            this.Name = "frmRelatorioMensalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioMensalidades";
            this.Load += new System.EventHandler(this.frmRelatorioMensalidades_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnImprimirRelMensalidades;
        private System.Windows.Forms.Button btnSalvarRelMensalidades;
        private System.Windows.Forms.Button btnGerarRelMensalidades;
        private System.Windows.Forms.Button btnFecharRelMensalidades;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}