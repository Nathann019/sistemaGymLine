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
            this.dgvRelVendas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btnImprimirRelVendas.Click += new System.EventHandler(this.btnImprimirRelVendas_Click);
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
            // dgvRelVendas
            // 
            this.dgvRelVendas.BackgroundColor = System.Drawing.Color.White;
            this.dgvRelVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelVendas.Location = new System.Drawing.Point(262, 143);
            this.dgvRelVendas.Name = "dgvRelVendas";
            this.dgvRelVendas.Size = new System.Drawing.Size(990, 471);
            this.dgvRelVendas.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(654, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório de Vendas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(251, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 579);
            this.panel1.TabIndex = 82;
            // 
            // frmRelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFecharRelVendas);
            this.Controls.Add(this.btnSalvarRelVendas);
            this.Controls.Add(this.btnImprimirRelVendas);
            this.Controls.Add(this.dgvRelVendas);
            this.Controls.Add(this.panel1);
            this.Name = "frmRelatorioVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioVendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarRelVendas;
        private System.Windows.Forms.Button btnImprimirRelVendas;
        private System.Windows.Forms.Button btnFecharRelVendas;
        private System.Windows.Forms.DataGridView dgvRelVendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}