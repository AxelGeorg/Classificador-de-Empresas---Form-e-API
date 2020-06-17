using ClassificadorDeEmpresas.Entities;
using ClassificadorDeEmpresas.Services;
using ClassificadorDeEmpresas.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassificadorDeEmpresas.Views
{
    public partial class TelaCadastrarComImportacao : Form
    {
        empresaService service = new empresaService();
        List<RetornoJson> jsonEmp;
        string notasAltera;
        string debitosAltera;

        public TelaCadastrarComImportacao()
        {
            InitializeComponent();

            btn_cadastrar.Enabled = false;
        }
        private void btn_voltarTela_Click(object sender, EventArgs e)
        {
            TelaMenu tela = new TelaMenu();
            this.Hide();
            tela.ShowDialog();
        }
        private void btn_buscaArquivo_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Arquivo json | *.json";
            openFile.ShowDialog();

            if (string.IsNullOrEmpty(openFile.FileName) == false)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(openFile.FileName))
                    {
                        var json = reader.ReadToEnd();
                        jsonEmp = JsonConvert.DeserializeObject<List<RetornoJson>>(json);

                        listarArquivosJson();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Não foi possível abrir o seu arquivo!! \nErro: (0)", ex.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cadastrar essa empresa com esses dados?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Empresa empCadastrar = new Empresa();

                empCadastrar.emp_nome = txtb_nomeEmpresa.Text;
                empCadastrar.emp_qntdNotas = notasAltera;
                empCadastrar.emp_qntdDebitos = debitosAltera;

                var retorno = service.Post_Empresa(empCadastrar).GetAwaiter().GetResult();

                MessageBox.Show(retorno.Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jsonEmp.RemoveAt(0);
                listarArquivosJson();
            }
        }

        /// <summary>
        /// Lista os dados do arquivo json selecionado.
        /// </summary>
        public void listarArquivosJson()
        {
            if (jsonEmp.Count != 0)
            {
                listViewJson.Items.Clear();
                for (int i = 0; i < jsonEmp.Count; i++)
                {
                    ListViewItem itens = new ListViewItem(jsonEmp[i].qntdNotas);
                    itens.SubItems.Add(jsonEmp[i].qntdDebitos);
                    listViewJson.Items.Add(itens);

                    if (i == 0)
                    {
                        listViewEmpresaJson.Items.Clear();
                        ListViewItem itensEmpresa = new ListViewItem(jsonEmp[i].qntdNotas);
                        itensEmpresa.SubItems.Add(jsonEmp[i].qntdDebitos);
                        listViewEmpresaJson.Items.Add(itensEmpresa);
                        notasAltera = jsonEmp[i].qntdNotas;
                        debitosAltera = jsonEmp[i].qntdDebitos;
                    }
                }
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
        }
    }
}
