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
        TelaMenu Menu = new TelaMenu();

        public TelaAlterar()
        {
            InitializeComponent();
            btn_alterar.Enabled = false;
            txtb_novoNome.Enabled = false;
            txtb_novoIndice.Enabled = false;
            txtb_novoNotas.Enabled = false;
            txtb_novoDebitos.Enabled = false;

            txtb_empresaAlterar.Text = "";
            rdb_nome.Enabled = false;
            rdb_indice.Enabled = false;
            rdb_notas.Enabled = false;
            rdb_debitos.Enabled = false;
            rdb_todos.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu.ShowDialog();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            //melhorar a validação...
            if (txtb_empresaAlterar.Text.Trim()=="")
            {
                MessageBox.Show("Não é possível pesquisar empresas sem nenhum caractere!!", "Aviso");
            }
            else
            {
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

                        rdb_nome.Enabled = true;
                        rdb_indice.Enabled = true;
                        rdb_notas.Enabled = true;
                        rdb_debitos.Enabled = true;
                        rdb_todos.Enabled = true;
                    }
                 }
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

            if ((txtb_novoNome.Enabled == true) &&
            (txtb_novoIndice.Enabled != true) &&
            (txtb_novoNotas.Enabled != true) &&
            (txtb_novoDebitos.Enabled != true))
            {
                emp.emp_nome = txtb_novoNome.Text;

                var retorno = service.Put_Empresa(emp).GetAwaiter().GetResult();

                MessageBox.Show(retorno.Mensagem, "Aviso");
            }
            else if ((txtb_novoNome.Enabled != true) &&
            (txtb_novoIndice.Enabled == true) &&
            (txtb_novoNotas.Enabled != true) &&
            (txtb_novoDebitos.Enabled != true))
            {
                emp.emp_indice = txtb_novoIndice.Text;

                var retorno = service.Put_Empresa(emp).GetAwaiter().GetResult();

                MessageBox.Show(retorno.Mensagem, "Aviso");
            }
            else if ((txtb_novoNome.Enabled != true) &&
            (txtb_novoIndice.Enabled != true) &&
            (txtb_novoNotas.Enabled == true) &&
            (txtb_novoDebitos.Enabled != true))
            {
                emp.emp_qntdNotas = txtb_novoNotas.Text;

                var retorno = service.Put_Empresa(emp).GetAwaiter().GetResult();

                MessageBox.Show(retorno.Mensagem, "Aviso");
            }
            else if ((txtb_novoNome.Enabled != true) &&
            (txtb_novoIndice.Enabled != true) &&
            (txtb_novoNotas.Enabled != true) &&
            (txtb_novoDebitos.Enabled == true))
            {
                emp.emp_qntdDebitos = txtb_novoDebitos.Text;

                var retorno = service.Put_Empresa(emp).GetAwaiter().GetResult();

                MessageBox.Show(retorno.Mensagem, "Aviso");
            }
            else if ((txtb_novoNome.Enabled == true) &&
            (txtb_novoIndice.Enabled == true) &&
            (txtb_novoNotas.Enabled == true) &&
            (txtb_novoDebitos.Enabled == true))
            {
                emp.emp_nome = txtb_novoNome.Text;
                emp.emp_indice = txtb_novoIndice.Text;
                emp.emp_qntdNotas = txtb_novoNotas.Text;
                emp.emp_qntdDebitos = txtb_novoDebitos.Text;

                var retorno = service.Put_Empresa(emp).GetAwaiter().GetResult();

                MessageBox.Show(retorno.Mensagem, "Aviso");
            }

            Menu.listar();
            this.Hide();
            Menu.ShowDialog();
        }

        private void rdb_nome_CheckedChanged(object sender, EventArgs e)
        {
            txtb_novoNome.Enabled = true;
            txtb_novoIndice.Enabled = false;
            txtb_novoIndice.Text = "";
            txtb_novoNotas.Enabled = false;
            txtb_novoNotas.Text = "";
            txtb_novoDebitos.Enabled = false;
            txtb_novoDebitos.Text = "";

            if (btn_alterar.Enabled == false)
            {
                btn_alterar.Enabled = true;
            }
        }

        private void rdb_notas_CheckedChanged(object sender, EventArgs e)
        {
            txtb_novoNotas.Enabled = true;
            txtb_novoNome.Enabled = false;
            txtb_novoNome.Text = "";
            txtb_novoIndice.Enabled = false;
            txtb_novoIndice.Text = "";
            txtb_novoDebitos.Enabled = false;
            txtb_novoDebitos.Text = "";

            if (btn_alterar.Enabled == false)
            {
                btn_alterar.Enabled = true;
            }
        }

        private void rdb_indice_CheckedChanged(object sender, EventArgs e)
        {
            txtb_novoIndice.Enabled = true;
            txtb_novoNome.Enabled = false;
            txtb_novoNome.Text = "";
            txtb_novoNotas.Enabled = false;
            txtb_novoNotas.Text = "";
            txtb_novoDebitos.Enabled = false; 
            txtb_novoDebitos.Text = "";

            if (btn_alterar.Enabled == false)
            {
                btn_alterar.Enabled = true;
            }
        }

        private void rdb_debitos_CheckedChanged(object sender, EventArgs e)
        {
            txtb_novoDebitos.Enabled = true;
            txtb_novoNome.Enabled = false;
            txtb_novoNome.Text = "";
            txtb_novoIndice.Enabled = false;
            txtb_novoIndice.Text = "";
            txtb_novoNotas.Enabled = false;
            txtb_novoNotas.Text = "";

            if (btn_alterar.Enabled == false)
            {
                btn_alterar.Enabled = true;
            }
        }

        private void rdb_todos_CheckedChanged(object sender, EventArgs e)
        {
            txtb_novoNome.Enabled = true;
            txtb_novoIndice.Enabled = true;
            txtb_novoNotas.Enabled = true;
            txtb_novoDebitos.Enabled = true;

            if (btn_alterar.Enabled == false)
            {
                btn_alterar.Enabled = true;
            }
        }
    }
}
