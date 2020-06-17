namespace ClassificadorDeEmpresas.Views
{
    partial class TelaCadastrarComImportacao
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
            this.lbl_tituloCadastrarComImport = new System.Windows.Forms.Label();
            this.btn_voltarTela = new System.Windows.Forms.Button();
            this.lbl_arquivoBusca = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.listViewEmpresaJson = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewJson = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_buscaArquivo = new System.Windows.Forms.Button();
            this.lbl_nomeEmpresa = new System.Windows.Forms.Label();
            this.txtb_nomeEmpresa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_tituloCadastrarComImport
            // 
            this.lbl_tituloCadastrarComImport.AutoSize = true;
            this.lbl_tituloCadastrarComImport.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_tituloCadastrarComImport.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_tituloCadastrarComImport.Location = new System.Drawing.Point(226, 16);
            this.lbl_tituloCadastrarComImport.Name = "lbl_tituloCadastrarComImport";
            this.lbl_tituloCadastrarComImport.Size = new System.Drawing.Size(350, 19);
            this.lbl_tituloCadastrarComImport.TabIndex = 5;
            this.lbl_tituloCadastrarComImport.Text = "Tela de Cadastro com Importação";
            // 
            // btn_voltarTela
            // 
            this.btn_voltarTela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltarTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_voltarTela.Location = new System.Drawing.Point(2, 2);
            this.btn_voltarTela.Name = "btn_voltarTela";
            this.btn_voltarTela.Size = new System.Drawing.Size(92, 33);
            this.btn_voltarTela.TabIndex = 4;
            this.btn_voltarTela.Text = "<---";
            this.btn_voltarTela.UseVisualStyleBackColor = true;
            this.btn_voltarTela.Click += new System.EventHandler(this.btn_voltarTela_Click);
            // 
            // lbl_arquivoBusca
            // 
            this.lbl_arquivoBusca.AutoSize = true;
            this.lbl_arquivoBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_arquivoBusca.Location = new System.Drawing.Point(30, 190);
            this.lbl_arquivoBusca.Name = "lbl_arquivoBusca";
            this.lbl_arquivoBusca.Size = new System.Drawing.Size(309, 17);
            this.lbl_arquivoBusca.TabIndex = 14;
            this.lbl_arquivoBusca.Text = "Para procurar um arquivo .json clique no botão:\n";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(253, 398);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(284, 28);
            this.btn_cadastrar.TabIndex = 13;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // listViewEmpresaJson
            // 
            this.listViewEmpresaJson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewEmpresaJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewEmpresaJson.HideSelection = false;
            this.listViewEmpresaJson.Location = new System.Drawing.Point(33, 305);
            this.listViewEmpresaJson.Name = "listViewEmpresaJson";
            this.listViewEmpresaJson.Scrollable = false;
            this.listViewEmpresaJson.Size = new System.Drawing.Size(349, 75);
            this.listViewEmpresaJson.TabIndex = 12;
            this.listViewEmpresaJson.UseCompatibleStateImageBehavior = false;
            this.listViewEmpresaJson.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Notas do Mês";
            this.columnHeader1.Width = 166;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Debitos no Mês";
            this.columnHeader2.Width = 176;
            // 
            // listViewJson
            // 
            this.listViewJson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listViewJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewJson.GridLines = true;
            this.listViewJson.HideSelection = false;
            this.listViewJson.Location = new System.Drawing.Point(426, 69);
            this.listViewJson.Name = "listViewJson";
            this.listViewJson.Scrollable = false;
            this.listViewJson.Size = new System.Drawing.Size(352, 311);
            this.listViewJson.TabIndex = 11;
            this.listViewJson.UseCompatibleStateImageBehavior = false;
            this.listViewJson.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Notas do Mês";
            this.columnHeader4.Width = 176;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Debitos no Mês";
            this.columnHeader5.Width = 176;
            // 
            // btn_buscaArquivo
            // 
            this.btn_buscaArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscaArquivo.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 8F, System.Drawing.FontStyle.Bold);
            this.btn_buscaArquivo.Location = new System.Drawing.Point(92, 230);
            this.btn_buscaArquivo.Name = "btn_buscaArquivo";
            this.btn_buscaArquivo.Size = new System.Drawing.Size(223, 23);
            this.btn_buscaArquivo.TabIndex = 10;
            this.btn_buscaArquivo.Text = "Buscar arquivo";
            this.btn_buscaArquivo.UseVisualStyleBackColor = true;
            this.btn_buscaArquivo.Click += new System.EventHandler(this.btn_buscaArquivo_Click_1);
            // 
            // lbl_nomeEmpresa
            // 
            this.lbl_nomeEmpresa.AutoSize = true;
            this.lbl_nomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_nomeEmpresa.Location = new System.Drawing.Point(30, 80);
            this.lbl_nomeEmpresa.Name = "lbl_nomeEmpresa";
            this.lbl_nomeEmpresa.Size = new System.Drawing.Size(129, 17);
            this.lbl_nomeEmpresa.TabIndex = 15;
            this.lbl_nomeEmpresa.Text = "Nome da Empresa:";
            // 
            // txtb_nomeEmpresa
            // 
            this.txtb_nomeEmpresa.Location = new System.Drawing.Point(33, 115);
            this.txtb_nomeEmpresa.Name = "txtb_nomeEmpresa";
            this.txtb_nomeEmpresa.Size = new System.Drawing.Size(349, 20);
            this.txtb_nomeEmpresa.TabIndex = 16;
            // 
            // TelaCadastrarComImportacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtb_nomeEmpresa);
            this.Controls.Add(this.lbl_nomeEmpresa);
            this.Controls.Add(this.lbl_arquivoBusca);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.listViewEmpresaJson);
            this.Controls.Add(this.listViewJson);
            this.Controls.Add(this.btn_buscaArquivo);
            this.Controls.Add(this.lbl_tituloCadastrarComImport);
            this.Controls.Add(this.btn_voltarTela);
            this.Name = "TelaCadastrarComImportacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastrarComImportacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tituloCadastrarComImport;
        private System.Windows.Forms.Button btn_voltarTela;
        private System.Windows.Forms.Label lbl_arquivoBusca;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.ListView listViewEmpresaJson;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listViewJson;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_buscaArquivo;
        private System.Windows.Forms.Label lbl_nomeEmpresa;
        private System.Windows.Forms.TextBox txtb_nomeEmpresa;
    }
}