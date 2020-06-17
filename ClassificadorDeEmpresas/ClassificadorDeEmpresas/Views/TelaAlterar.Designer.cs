namespace ClassificadorDeEmpresas.Views
{
    partial class TelaAlterar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_empresaAlterar = new System.Windows.Forms.Label();
            this.txtb_empresaAlterar = new System.Windows.Forms.TextBox();
            this.listViewAlterar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.lbl_novoNome = new System.Windows.Forms.Label();
            this.txtb_novoNome = new System.Windows.Forms.TextBox();
            this.lbl_novoNotas = new System.Windows.Forms.Label();
            this.txtb_novoNotas = new System.Windows.Forms.TextBox();
            this.lbl_novoDebitos = new System.Windows.Forms.Label();
            this.txtb_novoDebitos = new System.Windows.Forms.TextBox();
            this.rdb_nome = new System.Windows.Forms.RadioButton();
            this.rdb_notas = new System.Windows.Forms.RadioButton();
            this.rdb_debitos = new System.Windows.Forms.RadioButton();
            this.rdb_todos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_voltarTela
            // 
            this.btn_voltarTela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltarTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_voltarTela.Location = new System.Drawing.Point(2, 1);
            this.btn_voltarTela.Name = "btn_voltarTela";
            this.btn_voltarTela.Size = new System.Drawing.Size(92, 33);
            this.btn_voltarTela.TabIndex = 0;
            this.btn_voltarTela.Text = "<---";
            this.btn_voltarTela.UseVisualStyleBackColor = true;
            this.btn_voltarTela.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(307, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tela de Alteração";
            // 
            // lbl_empresaAlterar
            // 
            this.lbl_empresaAlterar.AutoSize = true;
            this.lbl_empresaAlterar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_empresaAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_empresaAlterar.Location = new System.Drawing.Point(12, 99);
            this.lbl_empresaAlterar.Name = "lbl_empresaAlterar";
            this.lbl_empresaAlterar.Size = new System.Drawing.Size(297, 17);
            this.lbl_empresaAlterar.TabIndex = 2;
            this.lbl_empresaAlterar.Text = "Digite o nome da empresa que deseja alterar:";
            // 
            // txtb_empresaAlterar
            // 
            this.txtb_empresaAlterar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_empresaAlterar.Location = new System.Drawing.Point(46, 134);
            this.txtb_empresaAlterar.Name = "txtb_empresaAlterar";
            this.txtb_empresaAlterar.Size = new System.Drawing.Size(217, 20);
            this.txtb_empresaAlterar.TabIndex = 3;
            this.txtb_empresaAlterar.TextChanged += new System.EventHandler(this.txtb_empresaAlterar_TextChanged);
            // 
            // listViewAlterar
            // 
            this.listViewAlterar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAlterar.GridLines = true;
            this.listViewAlterar.HideSelection = false;
            this.listViewAlterar.Location = new System.Drawing.Point(327, 108);
            this.listViewAlterar.Name = "listViewAlterar";
            this.listViewAlterar.Scrollable = false;
            this.listViewAlterar.Size = new System.Drawing.Size(461, 63);
            this.listViewAlterar.TabIndex = 4;
            this.listViewAlterar.UseCompatibleStateImageBehavior = false;
            this.listViewAlterar.View = System.Windows.Forms.View.Details;
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
            // btn_pesquisar
            // 
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_pesquisar.Location = new System.Drawing.Point(69, 170);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(161, 23);
            this.btn_pesquisar.TabIndex = 5;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alterar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btn_alterar.Location = new System.Drawing.Point(247, 393);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(317, 29);
            this.btn_alterar.TabIndex = 6;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // lbl_novoNome
            // 
            this.lbl_novoNome.AutoSize = true;
            this.lbl_novoNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_novoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_novoNome.Location = new System.Drawing.Point(113, 251);
            this.lbl_novoNome.Name = "lbl_novoNome";
            this.lbl_novoNome.Size = new System.Drawing.Size(38, 13);
            this.lbl_novoNome.TabIndex = 7;
            this.lbl_novoNome.Text = "Nome:";
            // 
            // txtb_novoNome
            // 
            this.txtb_novoNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_novoNome.Location = new System.Drawing.Point(157, 248);
            this.txtb_novoNome.Name = "txtb_novoNome";
            this.txtb_novoNome.Size = new System.Drawing.Size(185, 20);
            this.txtb_novoNome.TabIndex = 8;
            this.txtb_novoNome.TextChanged += new System.EventHandler(this.txtb_novoNome_TextChanged);
            // 
            // lbl_novoNotas
            // 
            this.lbl_novoNotas.AutoSize = true;
            this.lbl_novoNotas.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_novoNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_novoNotas.Location = new System.Drawing.Point(438, 251);
            this.lbl_novoNotas.Name = "lbl_novoNotas";
            this.lbl_novoNotas.Size = new System.Drawing.Size(76, 13);
            this.lbl_novoNotas.TabIndex = 11;
            this.lbl_novoNotas.Text = "Notas do Mês:";
            // 
            // txtb_novoNotas
            // 
            this.txtb_novoNotas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_novoNotas.Location = new System.Drawing.Point(530, 248);
            this.txtb_novoNotas.Name = "txtb_novoNotas";
            this.txtb_novoNotas.Size = new System.Drawing.Size(185, 20);
            this.txtb_novoNotas.TabIndex = 12;
            this.txtb_novoNotas.TextChanged += new System.EventHandler(this.txtb_novoNotas_TextChanged);
            // 
            // lbl_novoDebitos
            // 
            this.lbl_novoDebitos.AutoSize = true;
            this.lbl_novoDebitos.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_novoDebitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_novoDebitos.Location = new System.Drawing.Point(438, 304);
            this.lbl_novoDebitos.Name = "lbl_novoDebitos";
            this.lbl_novoDebitos.Size = new System.Drawing.Size(84, 13);
            this.lbl_novoDebitos.TabIndex = 13;
            this.lbl_novoDebitos.Text = "Debitos do Mês:";
            // 
            // txtb_novoDebitos
            // 
            this.txtb_novoDebitos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_novoDebitos.Location = new System.Drawing.Point(530, 299);
            this.txtb_novoDebitos.Name = "txtb_novoDebitos";
            this.txtb_novoDebitos.Size = new System.Drawing.Size(185, 20);
            this.txtb_novoDebitos.TabIndex = 14;
            this.txtb_novoDebitos.TextChanged += new System.EventHandler(this.txtb_novoDebitos_TextChanged);
            // 
            // rdb_nome
            // 
            this.rdb_nome.AutoSize = true;
            this.rdb_nome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_nome.Location = new System.Drawing.Point(91, 251);
            this.rdb_nome.Name = "rdb_nome";
            this.rdb_nome.Size = new System.Drawing.Size(14, 13);
            this.rdb_nome.TabIndex = 15;
            this.rdb_nome.TabStop = true;
            this.rdb_nome.UseVisualStyleBackColor = true;
            this.rdb_nome.CheckedChanged += new System.EventHandler(this.rdb_nome_CheckedChanged);
            // 
            // rdb_notas
            // 
            this.rdb_notas.AutoSize = true;
            this.rdb_notas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_notas.Location = new System.Drawing.Point(418, 251);
            this.rdb_notas.Name = "rdb_notas";
            this.rdb_notas.Size = new System.Drawing.Size(14, 13);
            this.rdb_notas.TabIndex = 17;
            this.rdb_notas.TabStop = true;
            this.rdb_notas.UseVisualStyleBackColor = true;
            this.rdb_notas.CheckedChanged += new System.EventHandler(this.rdb_notas_CheckedChanged);
            // 
            // rdb_debitos
            // 
            this.rdb_debitos.AutoSize = true;
            this.rdb_debitos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_debitos.Location = new System.Drawing.Point(418, 304);
            this.rdb_debitos.Name = "rdb_debitos";
            this.rdb_debitos.Size = new System.Drawing.Size(14, 13);
            this.rdb_debitos.TabIndex = 18;
            this.rdb_debitos.TabStop = true;
            this.rdb_debitos.UseVisualStyleBackColor = true;
            this.rdb_debitos.CheckedChanged += new System.EventHandler(this.rdb_debitos_CheckedChanged);
            // 
            // rdb_todos
            // 
            this.rdb_todos.AutoSize = true;
            this.rdb_todos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_todos.Location = new System.Drawing.Point(91, 302);
            this.rdb_todos.Name = "rdb_todos";
            this.rdb_todos.Size = new System.Drawing.Size(14, 13);
            this.rdb_todos.TabIndex = 19;
            this.rdb_todos.TabStop = true;
            this.rdb_todos.UseVisualStyleBackColor = true;
            this.rdb_todos.CheckedChanged += new System.EventHandler(this.rdb_todos_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Selecionar todos.";
            // 
            // TelaAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdb_todos);
            this.Controls.Add(this.txtb_novoDebitos);
            this.Controls.Add(this.rdb_debitos);
            this.Controls.Add(this.lbl_novoDebitos);
            this.Controls.Add(this.txtb_novoNotas);
            this.Controls.Add(this.lbl_novoNotas);
            this.Controls.Add(this.rdb_notas);
            this.Controls.Add(this.txtb_novoNome);
            this.Controls.Add(this.rdb_nome);
            this.Controls.Add(this.lbl_novoNome);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.listViewAlterar);
            this.Controls.Add(this.txtb_empresaAlterar);
            this.Controls.Add(this.lbl_empresaAlterar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_voltarTela);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "TelaAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaAlterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltarTela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_empresaAlterar;
        private System.Windows.Forms.TextBox txtb_empresaAlterar;
        private System.Windows.Forms.ListView listViewAlterar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label lbl_novoNome;
        private System.Windows.Forms.TextBox txtb_novoNome;
        private System.Windows.Forms.Label lbl_novoNotas;
        private System.Windows.Forms.TextBox txtb_novoNotas;
        private System.Windows.Forms.Label lbl_novoDebitos;
        private System.Windows.Forms.TextBox txtb_novoDebitos;
        private System.Windows.Forms.RadioButton rdb_nome;
        private System.Windows.Forms.RadioButton rdb_notas;
        private System.Windows.Forms.RadioButton rdb_debitos;
        private System.Windows.Forms.RadioButton rdb_todos;
        private System.Windows.Forms.Label label2;
    }
}