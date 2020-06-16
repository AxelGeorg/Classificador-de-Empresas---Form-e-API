namespace ClassificadorDeEmpresas.Views
{
    partial class TelaDeletar
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
            this.btn_voltarTela = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.listViewDeletar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtb_empresaDeletar = new System.Windows.Forms.TextBox();
            this.lbl_empresaDeletar = new System.Windows.Forms.Label();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_voltarTela
            // 
            this.btn_voltarTela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltarTela.Location = new System.Drawing.Point(3, 4);
            this.btn_voltarTela.Name = "btn_voltarTela";
            this.btn_voltarTela.Size = new System.Drawing.Size(93, 34);
            this.btn_voltarTela.TabIndex = 0;
            this.btn_voltarTela.Text = "<---\r\n";
            this.btn_voltarTela.UseVisualStyleBackColor = true;
            this.btn_voltarTela.Click += new System.EventHandler(this.btn_voltarTela_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_pesquisar.Location = new System.Drawing.Point(54, 175);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(187, 23);
            this.btn_pesquisar.TabIndex = 9;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // listViewDeletar
            // 
            this.listViewDeletar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDeletar.HideSelection = false;
            this.listViewDeletar.Location = new System.Drawing.Point(329, 102);
            this.listViewDeletar.Name = "listViewDeletar";
            this.listViewDeletar.Scrollable = false;
            this.listViewDeletar.Size = new System.Drawing.Size(459, 69);
            this.listViewDeletar.TabIndex = 8;
            this.listViewDeletar.UseCompatibleStateImageBehavior = false;
            this.listViewDeletar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Empresa ID";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Indice";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Notas do Mês";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Debitos no Mês";
            this.columnHeader5.Width = 93;
            // 
            // txtb_empresaDeletar
            // 
            this.txtb_empresaDeletar.Location = new System.Drawing.Point(38, 138);
            this.txtb_empresaDeletar.Name = "txtb_empresaDeletar";
            this.txtb_empresaDeletar.Size = new System.Drawing.Size(217, 20);
            this.txtb_empresaDeletar.TabIndex = 7;
            this.txtb_empresaDeletar.TextChanged += new System.EventHandler(this.txtb_empresaDeletar_TextChanged);
            // 
            // lbl_empresaDeletar
            // 
            this.lbl_empresaDeletar.AutoSize = true;
            this.lbl_empresaDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empresaDeletar.Location = new System.Drawing.Point(35, 111);
            this.lbl_empresaDeletar.Name = "lbl_empresaDeletar";
            this.lbl_empresaDeletar.Size = new System.Drawing.Size(223, 13);
            this.lbl_empresaDeletar.TabIndex = 6;
            this.lbl_empresaDeletar.Text = "Digite o nome da empresa que deseja deletar:";
            // 
            // btn_deletar
            // 
            this.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btn_deletar.Location = new System.Drawing.Point(232, 378);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(317, 29);
            this.btn_deletar.TabIndex = 11;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // TelaDeletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.listViewDeletar);
            this.Controls.Add(this.txtb_empresaDeletar);
            this.Controls.Add(this.lbl_empresaDeletar);
            this.Controls.Add(this.btn_voltarTela);
            this.Name = "TelaDeletar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaDeletar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltarTela;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.ListView listViewDeletar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtb_empresaDeletar;
        private System.Windows.Forms.Label lbl_empresaDeletar;
        private System.Windows.Forms.Button btn_deletar;
    }
}