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
        public TelaPainel()
        {
            InitializeComponent();
        }

        public void btn_entrar_Click(object sender, EventArgs e)
        {
            TelaMenu Menu = new TelaMenu();
            this.Hide();
            Menu.ShowDialog();
        }
    }
}
