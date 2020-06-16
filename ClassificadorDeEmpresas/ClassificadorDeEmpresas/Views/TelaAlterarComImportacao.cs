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
    public partial class TelaAlterarComImportacao : Form
    {
        empresaService service = new empresaService();
        List<RetornoJson> jsonEmp;
        List<Empresa> listaEmpresasNoCmoboBox;
        string notasAltera;
        string debitosAltera;

        public TelaAlterarComImportacao()
        {
            InitializeComponent();
            listaComboBox();

            cbox_alterar.Enabled = false;
            btn_alterar.Enabled = false;
        }

        private void btn_voltarTela_Click(object sender, EventArgs e)
        {
            TelaMenu tela = new TelaMenu();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_buscaArquivo_Click(object sender, EventArgs e)
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
                    MessageBox.Show(string.Format("Não foi possível abrir o seu arquivo!! \nErro: (0)",ex.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja alterar os dados dessa empresa?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Empresa empAltera = new Empresa();

                empAltera.emp_id = listaEmpresasNoCmoboBox[cbox_alterar.SelectedIndex].emp_id;
                empAltera.emp_nome = listaEmpresasNoCmoboBox[cbox_alterar.SelectedIndex].emp_nome;
                empAltera.emp_qntdNotas = notasAltera;
                empAltera.emp_qntdDebitos = debitosAltera;

                var retorno = service.Put_Empresa(empAltera).GetAwaiter().GetResult();

                MessageBox.Show(retorno.Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jsonEmp.RemoveAt(0);
                listarArquivosJson();
            }
        }

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
                btn_alterar.Enabled = true;
                cbox_alterar.Enabled = true;
            }
            else
            {
                btn_alterar.Enabled = false;
                cbox_alterar.Enabled = false;
            }
        }

        private void cbox_alterar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void listaComboBox()
        {
            var empresas = service.GetEmpresas().GetAwaiter().GetResult();
            listaEmpresasNoCmoboBox = new List<Empresa>();

            if (empresas.Count != 0)
            {
                for (int i = 0; i < empresas.Count; i++)
                {
                    cbox_alterar.Items.Add(empresas[i].emp_nome);
                    listaEmpresasNoCmoboBox.Add(empresas[i]);
                }
            }
        }
    }
}
