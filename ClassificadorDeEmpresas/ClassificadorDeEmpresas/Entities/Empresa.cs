using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificadorDeEmpresas.Entities
{
    class Empresa
    {
        public string emp_id { get; set; }
        public string emp_nome { get; set; }
        public string emp_indice { get; set; }
        public string emp_qntdNotas { get; set; }
        public string emp_qntdDebitos { get; set; }
    }
}
