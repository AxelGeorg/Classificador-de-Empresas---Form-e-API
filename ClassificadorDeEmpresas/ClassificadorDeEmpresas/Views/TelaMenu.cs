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
                //ListViewItem itens = new ListViewItem(empresas[i].emp_id);
                //itens.SubItems.Add(empresas[i].emp_nome);
                //itens.SubItems.Add(empresas[i].emp_indice);
                //listView.Items.Add(itens);

                listView.Items.Add(empresas[i].emp_id);
                listView.Items[i].SubItems.Add(empresas[i].emp_nome);
                listView.Items[i].SubItems.Add(empresas[i].emp_indice + "%");
                listView.Items[i].SubItems.Add(empresas[i].emp_qntdNotas);
                listView.Items[i].SubItems.Add(empresas[i].emp_qntdDebitos);
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            TelaCadastrar cad = new TelaCadastrar();
            this.Hide();
            cad.ShowDialog();
        }
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            TelaAlterar alt = new TelaAlterar();
            this.Hide();
            alt.ShowDialog();
        }

        private void btn_voltarTela_Click(object sender, EventArgs e)
        {
            TelaPainel Menu = new TelaPainel();
            this.Hide();
            Menu.ShowDialog();
        }

        
    }
}
