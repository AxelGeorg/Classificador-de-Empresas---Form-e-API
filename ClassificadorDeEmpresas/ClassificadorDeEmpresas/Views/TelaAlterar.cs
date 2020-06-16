using ClassificadorDeEmpresas.Entities;
using ClassificadorDeEmpresas.Services;
using ClassificadorDeEmpresas.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassificadorDeEmpresas.Views
{
    public partial class TelaAlterar : Form
    {
        empresaService service = new empresaService();
        Empresa emp = new Empresa();

        public TelaAlterar()
        {
            InitializeComponent();

            btn_pesquisar.Enabled = false;
            btn_alterar.Enabled = false;
            txtb_novoNome.Enabled = false;
            txtb_novoNotas.Enabled = false;
            txtb_novoDebitos.Enabled = false;

            txtb_empresaAlterar.Text = "";
            rdb_nome.Enabled = false;
            rdb_notas.Enabled = false;
            rdb_debitos.Enabled = false;
            rdb_todos.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaMenu tela = new TelaMenu();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            int verificaSeRetornou = 0;

            listViewAlterar.Items.Clear();
            var empresas = service.GetEmpresas().GetAwaiter().GetResult();

            for (int i = 0; i < empresas.Count; i++)
            {
                if (txtb_empresaAlterar.Text.Trim() == empresas[i].emp_nome)
                {
                   ListViewItem itens = new ListViewItem(empresas[i].emp_id);
                   //Empresa emp = new Empresa();

                   itens.SubItems.Add(empresas[i].emp_nome);
                   itens.SubItems.Add(empresas[i].emp_indice + "%");
                   itens.SubItems.Add(empresas[i].emp_qntdNotas);
                   itens.SubItems.Add(empresas[i].emp_qntdDebitos);                                               
                   listViewAlterar.Items.Add(itens);

                   emp.emp_id = empresas[i].emp_id;
                   emp.emp_nome = empresas[i].emp_nome;
                   emp.emp_indice = empresas[i].emp_indice;
                   emp.emp_qntdNotas = empresas[i].emp_qntdNotas;
                   emp.emp_qntdDebitos = empresas[i].emp_qntdDebitos;

                   rdb_nome.Enabled = true;
                   rdb_notas.Enabled = true;
                   rdb_debitos.Enabled = true;
                   rdb_todos.Enabled = true;

                   verificaSeRetornou = 1;
                }
            }

            if (verificaSeRetornou == 0)
            {
                MessageBox.Show("Não foi possìvel encontrar nenhuma empresa com esse nome!! \nDigite novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            TelaMenu tela = new TelaMenu();
            int verificaSeRetornou = 0;
            var empresas = service.GetEmpresas().GetAwaiter().GetResult();

            if ((txtb_novoNome.Enabled == true) &&
            (txtb_novoNotas.Enabled != true) &&
            (txtb_novoDebitos.Enabled != true))
            {
                for (int i = 0; i < empresas.Count; i++)
                {
                    if (txtb_novoNome.Text.Trim() == empresas[i].emp_nome)
                    {
                        verificaSeRetornou = 1;
                        MessageBox.Show("Não é possível alterar o nome dessa empresa, pois já há uma empresa com esse nome!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (verificaSeRetornou == 0)
                {
                    emp.emp_nome = txtb_novoNome.Text;

                    if (MessageBox.Show("Deseja alterar o nome dessa empresa?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        var retorno = service.Put_Empresa(emp).GetAwaiter().GetResult();

                        MessageBox.Show(retorno.Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tela.listar(tela.rankingParaSerExibido());
                        this.Hide();
                        tela.ShowDialog();
                    }
                }
            }
            else if ((txtb_novoNome.Enabled != true) &&
            (txtb_novoNotas.Enabled == true) &&
            (txtb_novoDebitos.Enabled != true))
            {
                emp.emp_qntdNotas = txtb_novoNotas.Text;

                if (MessageBox.Show("Deseja alterar a quantidade de notas dessa empresa?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    var retorno = service.Put_Empresa(emp).GetAwaiter().GetResult();

                    MessageBox.Show(retorno.Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tela.listar(tela.rankingParaSerExibido());
                    this.Hide();
                    tela.ShowDialog();
                }
            }
            else if ((txtb_novoNome.Enabled != true) &&
            (txtb_novoNotas.Enabled != true) &&
            (txtb_novoDebitos.Enabled == true))
            {
                emp.emp_qntdDebitos = txtb_novoDebitos.Text;

                if (MessageBox.Show("Deseja alterar a quantidade de debitos dessa empresa?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    var retorno = service.Put_Empresa(emp).GetAwaiter().GetResult();

                    MessageBox.Show(retorno.Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tela.listar(tela.rankingParaSerExibido());
                    this.Hide();
                    tela.ShowDialog();
                }
            }
            else if ((txtb_novoNome.Enabled == true) &&
            (txtb_novoNotas.Enabled == true) &&
            (txtb_novoDebitos.Enabled == true))
            {
                for (int i = 0; i < empresas.Count; i++)
                {
                    if (txtb_novoNome.Text.Trim() == empresas[i].emp_nome)
                    {
                        verificaSeRetornou = 1;
                        MessageBox.Show("Não é possível alterar o nome dessa empresa, pois já há uma empresa com esse nome!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (verificaSeRetornou == 0)
                {
                    emp.emp_nome = txtb_novoNome.Text;
                    emp.emp_qntdNotas = txtb_novoNotas.Text;
                    emp.emp_qntdDebitos = txtb_novoDebitos.Text;

                    if (MessageBox.Show("Deseja alterar todos os dados dessa empresa?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        var retorno = service.Put_Empresa(emp).GetAwaiter().GetResult();

                        MessageBox.Show(retorno.Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tela.listar(tela.rankingParaSerExibido());
                        this.Hide();
                        tela.ShowDialog();
                    }
                }
            }
        }

        private void rdb_nome_CheckedChanged(object sender, EventArgs e)
        {
            txtb_novoNome.Enabled = true;
            txtb_novoNotas.Enabled = false;
            txtb_novoNotas.Text = "";
            txtb_novoDebitos.Enabled = false;
            txtb_novoDebitos.Text = "";
        }

        private void rdb_notas_CheckedChanged(object sender, EventArgs e)
        {
            txtb_novoNotas.Enabled = true;
            txtb_novoNome.Enabled = false;
            txtb_novoNome.Text = "";
            txtb_novoDebitos.Enabled = false;
            txtb_novoDebitos.Text = "";
        }

        private void rdb_debitos_CheckedChanged(object sender, EventArgs e)
        {
            txtb_novoDebitos.Enabled = true;
            txtb_novoNome.Enabled = false;
            txtb_novoNome.Text = "";
            txtb_novoNotas.Enabled = false;
            txtb_novoNotas.Text = "";
        }

        private void rdb_todos_CheckedChanged(object sender, EventArgs e)
        {
            txtb_novoNome.Enabled = true;
            txtb_novoNotas.Enabled = true;
            txtb_novoDebitos.Enabled = true;
        }

        private void txtb_empresaAlterar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtb_empresaAlterar.Text))
            {
                btn_pesquisar.Enabled = true;
            }
            else
            {
                listViewAlterar.Items.Clear();
                btn_alterar.Enabled = false;
                btn_pesquisar.Enabled = false;
                txtb_novoNome.Enabled = false;
                txtb_novoNotas.Enabled = false;
                txtb_novoDebitos.Enabled = false;
                rdb_nome.Enabled = false;
                rdb_notas.Enabled = false;
                rdb_debitos.Enabled = false;
                rdb_todos.Enabled = false;
            }
        }

        private void txtb_novoNome_TextChanged(object sender, EventArgs e)
        {
            verificacaoRadioAndText();
        }

        private void txtb_novoNotas_TextChanged(object sender, EventArgs e)
        {
            verificacaoRadioAndText();
        }

        private void txtb_novoDebitos_TextChanged(object sender, EventArgs e)
        {
            verificacaoRadioAndText();
        }

        public void verificacaoRadioAndText()
        {
            if (rdb_todos.Checked == true)
            {
                if ((!string.IsNullOrWhiteSpace(txtb_novoNome.Text)) && (!string.IsNullOrWhiteSpace(txtb_novoNotas.Text)) && (!string.IsNullOrWhiteSpace(txtb_novoDebitos.Text)))
                {
                    btn_alterar.Enabled = true;
                }
                else
                {
                    btn_alterar.Enabled = false;
                }
            }
            else if (rdb_todos.Checked == false)
            {
                if ((!string.IsNullOrWhiteSpace(txtb_novoNome.Text)) || (!string.IsNullOrWhiteSpace(txtb_novoNotas.Text)) || (!string.IsNullOrWhiteSpace(txtb_novoDebitos.Text)))
                {
                    btn_alterar.Enabled = true;
                }
                else
                {
                    btn_alterar.Enabled = false;
                }
            }
        }
    }
}
