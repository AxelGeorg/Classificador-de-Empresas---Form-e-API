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
    public partial class TelaCadastrar : Form
    {
        empresaService service = new empresaService();

        public TelaCadastrar()
        {
            InitializeComponent();

            btn_cadastrar.Enabled = false;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            TelaMenu tela = new TelaMenu();
            Empresa emp = new Empresa();
            int verificaSeRetornou = 0;

            //valida se há outra empresa com msm nome
            var empresas = service.GetEmpresas().GetAwaiter().GetResult();

            for (int i = 0; i < empresas.Count; i++)
            {
                if (txtb_nomeEmpresa.Text.Trim() == empresas[i].emp_nome)
                {
                    verificaSeRetornou = 1;
                    MessageBox.Show("Não é possível cadastrar essa empresa, pois já há uma empresa com esse nome!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (verificaSeRetornou == 0)
            {
                emp.emp_nome = txtb_nomeEmpresa.Text;
                emp.emp_indice = "50";
                emp.emp_qntdNotas = txtb_notasMes.Text;
                emp.emp_qntdDebitos = txtb_debitosMes.Text;

                if (MessageBox.Show("Deseja cadastrar essa empresa?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {

                    var retorno = service.Post_Empresa(emp).GetAwaiter().GetResult();

                    MessageBox.Show(retorno.Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    tela.listar(tela.rankingParaSerExibido());
                    this.Hide();
                    tela.ShowDialog();
                }
            }
        }

        private void btn_voltarTela_Click(object sender, EventArgs e)
        {
            TelaMenu tela = new TelaMenu();
            this.Hide();
            tela.ShowDialog();
        }

        private void txtb_nomeEmpresa_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nomeEmpresa.Text)) && (!string.IsNullOrWhiteSpace(txtb_notasMes.Text)) && (!string.IsNullOrWhiteSpace(txtb_debitosMes.Text)))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
        }

        private void txtb_notasMes_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nomeEmpresa.Text)) && (!string.IsNullOrWhiteSpace(txtb_notasMes.Text)) && (!string.IsNullOrWhiteSpace(txtb_debitosMes.Text)))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
        }

        private void txtb_debitosMes_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nomeEmpresa.Text)) && (!string.IsNullOrWhiteSpace(txtb_notasMes.Text)) && (!string.IsNullOrWhiteSpace(txtb_debitosMes.Text)))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
        }
    }
}
