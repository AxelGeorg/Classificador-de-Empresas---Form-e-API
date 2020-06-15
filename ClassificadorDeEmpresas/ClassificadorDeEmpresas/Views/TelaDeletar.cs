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
    public partial class TelaDeletar : Form
    {
        empresaService service = new empresaService();
        Empresa emp = new Empresa();
        TelaMenu tela = new TelaMenu();

        public TelaDeletar()
        {
            InitializeComponent();

            btn_deletar.Enabled = false;
            txtb_empresaDeletar.Text = "";
        }

        private void btn_voltarTela_Click(object sender, EventArgs e)
        {
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            //melhorar a validação...
            if (txtb_empresaDeletar.Text.Trim() == "")
            {
                MessageBox.Show("Não é possível pesquisar empresas sem nenhum caractere!!", "Aviso");
            }
            else
            {
                listViewDeletar.Items.Clear();
                var empresas = service.GetEmpresas().GetAwaiter().GetResult();

                for (int i = 0; i < empresas.Count; i++)
                {
                    if (txtb_empresaDeletar.Text.Trim() == empresas[i].emp_nome)
                    {
                        ListViewItem itens = new ListViewItem(empresas[i].emp_id);
                        //Empresa emp = new Empresa();
                        
                        itens.SubItems.Add(empresas[i].emp_nome);
                        itens.SubItems.Add(empresas[i].emp_indice + "%");
                        itens.SubItems.Add(empresas[i].emp_qntdNotas);
                        itens.SubItems.Add(empresas[i].emp_qntdDebitos);
                        listViewDeletar.Items.Add(itens);
                                                                                    
                        emp = empresas[i];

                        btn_deletar.Enabled = true;
                    }
                }
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            var retorno = service.Delete_Empresa(emp).GetAwaiter().GetResult();

            MessageBox.Show(retorno.Mensagem, "Aviso");

            tela.listar();
            this.Hide();
            tela.ShowDialog();
        }
    }
}
