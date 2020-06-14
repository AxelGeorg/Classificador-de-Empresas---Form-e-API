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
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Empresa emp = new Empresa();

            emp.emp_nome = txtb_nomeEmpresa.Text;
            emp.emp_indice = "50";
            emp.emp_qntdNotas = txtb_notasMes.Text;
            emp.emp_qntdDebitos = txtb_debitosMes.Text;
            
            //validação dos campos

            var retorno = service.Post_Empresa(emp).GetAwaiter().GetResult();

            MessageBox.Show(retorno.Mensagem, "Aviso");
        }

        private void btn_voltarTela_Click(object sender, EventArgs e)
        {
            TelaMenu Menu = new TelaMenu();
            this.Hide();
            Menu.ShowDialog();
        }
    }
}
