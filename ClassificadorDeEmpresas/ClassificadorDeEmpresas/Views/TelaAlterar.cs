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
    public partial class TelaAlterar : Form
    {
        public TelaAlterar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaMenu Menu = new TelaMenu();
            this.Hide();
            Menu.ShowDialog();
        }
    }
}
