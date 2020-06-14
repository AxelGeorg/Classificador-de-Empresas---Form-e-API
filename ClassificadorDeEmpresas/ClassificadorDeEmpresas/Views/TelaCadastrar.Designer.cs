namespace ClassificadorDeEmpresas.Views
{
    partial class TelaCadastrar
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
            this.txtb_nomeEmpresa = new System.Windows.Forms.TextBox();
            this.lbl_nomeEmpresa = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_voltarTela = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_notas = new System.Windows.Forms.Label();
            this.txtb_notasMes = new System.Windows.Forms.TextBox();
            this.lbl_debitosMes = new System.Windows.Forms.Label();
            this.txtb_debitosMes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtb_nomeEmpresa
            // 
            this.txtb_nomeEmpresa.Location = new System.Drawing.Point(42, 89);
            this.txtb_nomeEmpresa.Name = "txtb_nomeEmpresa";
            this.txtb_nomeEmpresa.Size = new System.Drawing.Size(210, 20);
            this.txtb_nomeEmpresa.TabIndex = 0;
            // 
            // lbl_nomeEmpresa
            // 
            this.lbl_nomeEmpresa.AutoSize = true;
            this.lbl_nomeEmpresa.Location = new System.Drawing.Point(39, 64);
            this.lbl_nomeEmpresa.Name = "lbl_nomeEmpresa";
            this.lbl_nomeEmpresa.Size = new System.Drawing.Size(97, 13);
            this.lbl_nomeEmpresa.TabIndex = 1;
            this.lbl_nomeEmpresa.Text = "Nome da Empresa:";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(294, 227);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(161, 23);
            this.btn_cadastrar.TabIndex = 2;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_voltarTela
            // 
            this.btn_voltarTela.Location = new System.Drawing.Point(0, 0);
            this.btn_voltarTela.Name = "btn_voltarTela";
            this.btn_voltarTela.Size = new System.Drawing.Size(87, 30);
            this.btn_voltarTela.TabIndex = 3;
            this.btn_voltarTela.Text = "<---";
            this.btn_voltarTela.UseVisualStyleBackColor = true;
            this.btn_voltarTela.Click += new System.EventHandler(this.btn_voltarTela_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(367, 29);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(88, 13);
            this.lbl_titulo.TabIndex = 4;
            this.lbl_titulo.Text = "Tela de Cadastro";
            // 
            // lbl_notas
            // 
            this.lbl_notas.AutoSize = true;
            this.lbl_notas.Location = new System.Drawing.Point(39, 132);
            this.lbl_notas.Name = "lbl_notas";
            this.lbl_notas.Size = new System.Drawing.Size(191, 13);
            this.lbl_notas.TabIndex = 5;
            this.lbl_notas.Text = "Quantidade de Notas Emitidas no Mês:";
            // 
            // txtb_notasMes
            // 
            this.txtb_notasMes.Location = new System.Drawing.Point(42, 160);
            this.txtb_notasMes.Name = "txtb_notasMes";
            this.txtb_notasMes.Size = new System.Drawing.Size(210, 20);
            this.txtb_notasMes.TabIndex = 6;
            // 
            // lbl_debitosMes
            // 
            this.lbl_debitosMes.AutoSize = true;
            this.lbl_debitosMes.Location = new System.Drawing.Point(42, 199);
            this.lbl_debitosMes.Name = "lbl_debitosMes";
            this.lbl_debitosMes.Size = new System.Drawing.Size(199, 13);
            this.lbl_debitosMes.TabIndex = 7;
            this.lbl_debitosMes.Text = "Quantidade de Debitos Emitidos no Mês:";
            // 
            // txtb_debitosMes
            // 
            this.txtb_debitosMes.Location = new System.Drawing.Point(42, 227);
            this.txtb_debitosMes.Name = "txtb_debitosMes";
            this.txtb_debitosMes.Size = new System.Drawing.Size(210, 20);
            this.txtb_debitosMes.TabIndex = 8;
            // 
            // TelaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtb_debitosMes);
            this.Controls.Add(this.lbl_debitosMes);
            this.Controls.Add(this.txtb_notasMes);
            this.Controls.Add(this.lbl_notas);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_voltarTela);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.lbl_nomeEmpresa);
            this.Controls.Add(this.txtb_nomeEmpresa);
            this.Name = "TelaCadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_nomeEmpresa;
        private System.Windows.Forms.Label lbl_nomeEmpresa;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_voltarTela;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_notas;
        private System.Windows.Forms.TextBox txtb_notasMes;
        private System.Windows.Forms.Label lbl_debitosMes;
        private System.Windows.Forms.TextBox txtb_debitosMes;
    }
}