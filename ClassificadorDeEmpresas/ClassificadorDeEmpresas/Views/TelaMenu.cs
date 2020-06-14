using ClassificadorDeEmpresas.Entities;
using ClassificadorDeEmpresas.Services;
using ClassificadorDeEmpresas.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassificadorDeEmpresas.View
{
    public partial class TelaMenu : Form
    {
        empresaService service = new empresaService();

        public TelaMenu()
        {
            InitializeComponent();
            listar();
        }

        public void listar()
        {
            listView.Items.Clear();
            var empresas = service.GetEmpresas().GetAwaiter().GetResult();

            for (int i = 0; i < empresas.Count; i++)
            {
                listView.Items.Add(empresas[i].emp_id);
                listView.Items[i].SubItems.Add(empresas[i].emp_nome);
                listView.Items[i].SubItems.Add(empresas[i].emp_indice + "%");
                listView.Items[i].SubItems.Add(empresas[i].emp_qntdNotas);
                listView.Items[i].SubItems.Add(empresas[i].emp_qntdDebitos);
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            TelaCadastrar tela = new TelaCadastrar();
            this.Hide();
            tela.ShowDialog();
        }
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            TelaAlterar tela = new TelaAlterar();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_voltarTela_Click(object sender, EventArgs e)
        {
            TelaPainel tela = new TelaPainel();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            TelaDeletar tela = new TelaDeletar();
            this.Hide();
            tela.ShowDialog();
        }
    }
}
