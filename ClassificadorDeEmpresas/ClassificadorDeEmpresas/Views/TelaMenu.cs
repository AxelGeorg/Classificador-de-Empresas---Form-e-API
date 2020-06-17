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
        int rankingExibido = 0;

        public TelaMenu()
        {
            InitializeComponent();
            listar(rankingExibido);
        }

        /// <summary>
        /// Lista as empresas na listview de acordo com a opção selecionada na combobox, caso não selecionado, será listado o ranking pelo id.
        /// </summary>
        /// <param name="opcao"></param>
        public void listar(int opcao)
        {
            listView.Items.Clear();
            var empresas = new List<Empresa>();

            //ranking pelo ID
            if (rankingExibido==0)
            {
                empresas = service.GetEmpresas().GetAwaiter().GetResult();
            }

            //ranking pelo indice
            if (rankingExibido == 1)
            {
                empresas = service.GetEmpresasRankingIndice().GetAwaiter().GetResult();
            }

            //ranking pelo qntdNotas
            if (rankingExibido == 2)
            {
                empresas = service.GetEmpresasRankingNotas().GetAwaiter().GetResult();
            }

            //ranking pelo qntdDebitos
            if (rankingExibido == 3)
            {
                empresas = service.GetEmpresasRankingDebitos().GetAwaiter().GetResult();
            }

            for (int i = 0; i < empresas.Count; i++)
            {
                listView.Items.Add(empresas[i].emp_id);
                listView.Items[i].SubItems.Add(empresas[i].emp_nome);
                listView.Items[i].SubItems.Add(empresas[i].emp_indice + "%");
                listView.Items[i].SubItems.Add(empresas[i].emp_qntdNotas);
                listView.Items[i].SubItems.Add(empresas[i].emp_qntdDebitos);
            }
        }

        /// <summary>
        /// retorna a opção selecionada na combobox.
        /// </summary>
        /// <returns></returns>
        public int rankingParaSerExibido()
        {
            return rankingExibido;
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

        private void cbo_ranking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_ranking.SelectedIndex == 0) //ID
            {
                rankingExibido = 0;
                listar(rankingExibido);
            }
            else if (cbo_ranking.SelectedIndex == 1) //Indice
            {
                rankingExibido = 1;
                listar(rankingExibido);
            }
            else if (cbo_ranking.SelectedIndex == 2) //quantidade de notas
            {
                rankingExibido = 2;
                listar(rankingExibido);
            }
            else if (cbo_ranking.SelectedIndex == 3) //quantidade de debitos
            {
                rankingExibido = 3; 
                listar(rankingExibido);
            }    
        }

        private void btn_alterarComImportacao_Click(object sender, EventArgs e)
        {
            TelaAlterarComImportacao tela = new TelaAlterarComImportacao();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_cadastrarComImportação_Click(object sender, EventArgs e)
        {
            TelaCadastrarComImportacao tela = new TelaCadastrarComImportacao();
            this.Hide();
            tela.ShowDialog();
        }
    }
}
