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

namespace ClassificadorDeEmpresas
{
    public partial class TelaPainel : Form
    {
        TelaMenu Menu = new TelaMenu();
        public TelaPainel()
        {
            InitializeComponent();
            Menu.listar();
        }

        public void btn_entrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu.ShowDialog();
        }
    }
}
