namespace ClassificadorDeEmpresas.Views
{
    partial class TelaAlterarComImportacao
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
            this.lbl_tituloAltetarComImport = new System.Windows.Forms.Label();
            this.btn_voltarTela = new System.Windows.Forms.Button();
            this.btn_buscaArquivo = new System.Windows.Forms.Button();
            this.listViewJson = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewEmpresaJson = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_alterar = new System.Windows.Forms.Button();
            this.cbox_alterar = new System.Windows.Forms.ComboBox();
            this.lbl_arquivoBusca = new System.Windows.Forms.Label();
            this.lbl_comboBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_tituloAltetarComImport
            // 
            this.lbl_tituloAltetarComImport.AutoSize = true;
            this.lbl_tituloAltetarComImport.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_tituloAltetarComImport.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_tituloAltetarComImport.Location = new System.Drawing.Point(227, 17);
            this.lbl_tituloAltetarComImport.Name = "lbl_tituloAltetarComImport";
            this.lbl_tituloAltetarComImport.Size = new System.Drawing.Size(361, 19);
            this.lbl_tituloAltetarComImport.TabIndex = 3;
            this.lbl_tituloAltetarComImport.Text = "Tela de Alteração com Importação";
            // 
            // btn_voltarTela
            // 
            this.btn_voltarTela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltarTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_voltarTela.Location = new System.Drawing.Point(3, 3);
            this.btn_voltarTela.Name = "btn_voltarTela";
            this.btn_voltarTela.Size = new System.Drawing.Size(92, 33);
            this.btn_voltarTela.TabIndex = 2;
            this.btn_voltarTela.Text = "<---";
            this.btn_voltarTela.UseVisualStyleBackColor = true;
            this.btn_voltarTela.Click += new System.EventHandler(this.btn_voltarTela_Click);
            // 
            // btn_buscaArquivo
            // 
            this.btn_buscaArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscaArquivo.Location = new System.Drawing.Point(84, 112);
            this.btn_buscaArquivo.Name = "btn_buscaArquivo";
            this.btn_buscaArquivo.Size = new System.Drawing.Size(223, 23);
            this.btn_buscaArquivo.TabIndex = 4;
            this.btn_buscaArquivo.Text = "Buscar arquivo";
            this.btn_buscaArquivo.UseVisualStyleBackColor = true;
            this.btn_buscaArquivo.Click += new System.EventHandler(this.btn_buscaArquivo_Click);
            // 
            // listViewJson
            // 
            this.listViewJson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listViewJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewJson.GridLines = true;
            this.listViewJson.HideSelection = false;
            this.listViewJson.Location = new System.Drawing.Point(425, 64);
            this.listViewJson.Name = "listViewJson";
            this.listViewJson.Scrollable = false;
            this.listViewJson.Size = new System.Drawing.Size(352, 311);
            this.listViewJson.TabIndex = 5;
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
            // listViewEmpresaJson
            // 
            this.listViewEmpresaJson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewEmpresaJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewEmpresaJson.HideSelection = false;
            this.listViewEmpresaJson.Location = new System.Drawing.Point(28, 177);
            this.listViewEmpresaJson.Name = "listViewEmpresaJson";
            this.listViewEmpresaJson.Scrollable = false;
            this.listViewEmpresaJson.Size = new System.Drawing.Size(349, 75);
            this.listViewEmpresaJson.TabIndex = 6;
            this.listViewEmpresaJson.UseCompatibleStateImageBehavior = false;
            this.listViewEmpresaJson.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Notas do Mês";
            this.columnHeader1.Width = 167;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Debitos no Mês";
            this.columnHeader2.Width = 176;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alterar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Location = new System.Drawing.Point(252, 393);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(284, 28);
            this.btn_alterar.TabIndex = 7;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // cbox_alterar
            // 
            this.cbox_alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbox_alterar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_alterar.FormattingEnabled = true;
            this.cbox_alterar.Location = new System.Drawing.Point(84, 354);
            this.cbox_alterar.Name = "cbox_alterar";
            this.cbox_alterar.Size = new System.Drawing.Size(223, 21);
            this.cbox_alterar.TabIndex = 8;
            this.cbox_alterar.SelectedIndexChanged += new System.EventHandler(this.cbox_alterar_SelectedIndexChanged);
            // 
            // lbl_arquivoBusca
            // 
            this.lbl_arquivoBusca.AutoSize = true;
            this.lbl_arquivoBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arquivoBusca.Location = new System.Drawing.Point(19, 80);
            this.lbl_arquivoBusca.Name = "lbl_arquivoBusca";
            this.lbl_arquivoBusca.Size = new System.Drawing.Size(332, 16);
            this.lbl_arquivoBusca.TabIndex = 9;
            this.lbl_arquivoBusca.Text = "Para procurar um arquivo .json clique no botão abaixo:\n";
            // 
            // lbl_comboBox
            // 
            this.lbl_comboBox.AutoSize = true;
            this.lbl_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_comboBox.Location = new System.Drawing.Point(25, 306);
            this.lbl_comboBox.Name = "lbl_comboBox";
            this.lbl_comboBox.Size = new System.Drawing.Size(345, 32);
            this.lbl_comboBox.TabIndex = 10;
            this.lbl_comboBox.Text = "Selecione a empresa o qual deseja alterar os dados de \r\nacordo com a tabela a cim" +
    "a:\r\n";
            // 
            // TelaAlterarComImportacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_comboBox);
            this.Controls.Add(this.lbl_arquivoBusca);
            this.Controls.Add(this.cbox_alterar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.listViewEmpresaJson);
            this.Controls.Add(this.listViewJson);
            this.Controls.Add(this.btn_buscaArquivo);
            this.Controls.Add(this.lbl_tituloAltetarComImport);
            this.Controls.Add(this.btn_voltarTela);
            this.Name = "TelaAlterarComImportacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaAlterarComImportacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tituloAltetarComImport;
        private System.Windows.Forms.Button btn_voltarTela;
        private System.Windows.Forms.Button btn_buscaArquivo;
        private System.Windows.Forms.ListView listViewJson;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listViewEmpresaJson;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.ComboBox cbox_alterar;
        private System.Windows.Forms.Label lbl_arquivoBusca;
        private System.Windows.Forms.Label lbl_comboBox;
    }
}