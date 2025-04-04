namespace sistemaGymLine
{
    partial class frmAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlunos));
            this.dgvAlunosCadastrados = new System.Windows.Forms.DataGridView();
            this.txtBuscarAluno = new System.Windows.Forms.TextBox();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.btnBuscarAluno = new System.Windows.Forms.Button();
            this.btnFecharAluno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlunosCadastrados
            // 
            this.dgvAlunosCadastrados.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlunosCadastrados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAlunosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunosCadastrados.Location = new System.Drawing.Point(339, 292);
            this.dgvAlunosCadastrados.Name = "dgvAlunosCadastrados";
            this.dgvAlunosCadastrados.Size = new System.Drawing.Size(852, 273);
            this.dgvAlunosCadastrados.TabIndex = 0;
            // 
            // txtBuscarAluno
            // 
            this.txtBuscarAluno.Location = new System.Drawing.Point(545, 251);
            this.txtBuscarAluno.Multiline = true;
            this.txtBuscarAluno.Name = "txtBuscarAluno";
            this.txtBuscarAluno.Size = new System.Drawing.Size(449, 35);
            this.txtBuscarAluno.TabIndex = 1;
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCadastrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAluno.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarAluno.Location = new System.Drawing.Point(437, 251);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(102, 35);
            this.btnCadastrarAluno.TabIndex = 2;
            this.btnCadastrarAluno.Text = "+ Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = false;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar Alunos Cadastrados";
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAluno.ForeColor = System.Drawing.Color.Blue;
            this.btnEditarAluno.Location = new System.Drawing.Point(1024, 583);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(75, 33);
            this.btnEditarAluno.TabIndex = 4;
            this.btnEditarAluno.Text = "Editar";
            this.btnEditarAluno.UseVisualStyleBackColor = true;
            this.btnEditarAluno.Click += new System.EventHandler(this.btnEditarAluno_Click);
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAluno.ForeColor = System.Drawing.Color.Blue;
            this.btnExcluirAluno.Location = new System.Drawing.Point(1116, 583);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(75, 33);
            this.btnExcluirAluno.TabIndex = 5;
            this.btnExcluirAluno.Text = "Excluir";
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAluno
            // 
            this.btnBuscarAluno.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAluno.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAluno.Location = new System.Drawing.Point(1000, 252);
            this.btnBuscarAluno.Name = "btnBuscarAluno";
            this.btnBuscarAluno.Size = new System.Drawing.Size(67, 33);
            this.btnBuscarAluno.TabIndex = 6;
            this.btnBuscarAluno.Text = "Buscar";
            this.btnBuscarAluno.UseVisualStyleBackColor = false;
            this.btnBuscarAluno.Click += new System.EventHandler(this.btnBuscarAluno_Click);
            // 
            // btnFecharAluno
            // 
            this.btnFecharAluno.BackColor = System.Drawing.Color.IndianRed;
            this.btnFecharAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFecharAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharAluno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFecharAluno.Location = new System.Drawing.Point(1215, 12);
            this.btnFecharAluno.Name = "btnFecharAluno";
            this.btnFecharAluno.Size = new System.Drawing.Size(37, 28);
            this.btnFecharAluno.TabIndex = 8;
            this.btnFecharAluno.Text = "X";
            this.btnFecharAluno.UseVisualStyleBackColor = false;
            this.btnFecharAluno.Click += new System.EventHandler(this.btnFecharAluno_Click);
            // 
            // frmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnFecharAluno);
            this.Controls.Add(this.btnBuscarAluno);
            this.Controls.Add(this.btnExcluirAluno);
            this.Controls.Add(this.btnEditarAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.txtBuscarAluno);
            this.Controls.Add(this.dgvAlunosCadastrados);
            this.Name = "frmAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosCadastrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlunosCadastrados;
        private System.Windows.Forms.TextBox txtBuscarAluno;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditarAluno;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.Button btnBuscarAluno;
        private System.Windows.Forms.Button btnFecharAluno;
    }
}