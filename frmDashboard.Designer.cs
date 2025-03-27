namespace sistemaGymLine
{
    partial class frmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnRelatorioMensalidades = new System.Windows.Forms.Button();
            this.dgvDashboard = new System.Windows.Forms.DataGridView();
            this.btnRelatorioVendas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(255, 339);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(940, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // btnAlunos
            // 
            this.btnAlunos.Location = new System.Drawing.Point(70, 182);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(120, 37);
            this.btnAlunos.TabIndex = 4;
            this.btnAlunos.Text = "Alunos";
            this.btnAlunos.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(70, 240);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(120, 37);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnServicos
            // 
            this.btnServicos.Location = new System.Drawing.Point(70, 298);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(120, 37);
            this.btnServicos.TabIndex = 8;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.UseVisualStyleBackColor = true;
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(70, 356);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(120, 37);
            this.btnVendas.TabIndex = 10;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            // 
            // btnRelatorioMensalidades
            // 
            this.btnRelatorioMensalidades.Location = new System.Drawing.Point(70, 414);
            this.btnRelatorioMensalidades.Name = "btnRelatorioMensalidades";
            this.btnRelatorioMensalidades.Size = new System.Drawing.Size(120, 52);
            this.btnRelatorioMensalidades.TabIndex = 12;
            this.btnRelatorioMensalidades.Text = "Relatório de Mensalidades não pagas";
            this.btnRelatorioMensalidades.UseVisualStyleBackColor = true;
            // 
            // dgvDashboard
            // 
            this.dgvDashboard.BackgroundColor = System.Drawing.Color.White;
            this.dgvDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashboard.Location = new System.Drawing.Point(345, 138);
            this.dgvDashboard.Name = "dgvDashboard";
            this.dgvDashboard.Size = new System.Drawing.Size(289, 197);
            this.dgvDashboard.TabIndex = 13;
            // 
            // btnRelatorioVendas
            // 
            this.btnRelatorioVendas.Location = new System.Drawing.Point(70, 488);
            this.btnRelatorioVendas.Name = "btnRelatorioVendas";
            this.btnRelatorioVendas.Size = new System.Drawing.Size(120, 37);
            this.btnRelatorioVendas.TabIndex = 14;
            this.btnRelatorioVendas.Text = "Relatório de Vendas realizadas no mês";
            this.btnRelatorioVendas.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnRelatorioVendas);
            this.Controls.Add(this.dgvDashboard);
            this.Controls.Add(this.btnRelatorioMensalidades);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnServicos);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnAlunos);
            this.Controls.Add(this.chart1);
            this.DoubleBuffered = true;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnRelatorioMensalidades;
        private System.Windows.Forms.DataGridView dgvDashboard;
        private System.Windows.Forms.Button btnRelatorioVendas;
    }
}