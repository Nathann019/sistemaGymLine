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
            this.btnFecharRelVendas = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            // btnFecharRelVendas
            // 
            this.btnFecharRelVendas.BackColor = System.Drawing.Color.IndianRed;
            this.btnFecharRelVendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFecharRelVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharRelVendas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFecharRelVendas.Location = new System.Drawing.Point(1215, 12);
            this.btnFecharRelVendas.Name = "btnFecharRelVendas";
            this.btnFecharRelVendas.Size = new System.Drawing.Size(37, 28);
            this.btnFecharRelVendas.TabIndex = 73;
            this.btnFecharRelVendas.Text = "X";
            this.btnFecharRelVendas.UseVisualStyleBackColor = false;
            this.btnFecharRelVendas.Click += new System.EventHandler(this.btnFecharRelVendas_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sistemaGymLine.relatorios.relMensalidades.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(262, 143);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(990, 471);
            this.reportViewer1.TabIndex = 76;
            // 
            // frmRelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnFecharRelVendas);
            this.Controls.Add(this.btnSalvarRelVendas);
            this.Controls.Add(this.btnImprimirRelVendas);
            this.Name = "frmRelatorioVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioVendas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarRelVendas;
        private System.Windows.Forms.Button btnImprimirRelVendas;
        private System.Windows.Forms.Button btnFecharRelVendas;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}