using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassificadorDeEmpresas.API.Entities
{
    public class Empresa
    {
        public string emp_id { get; set; }
        public string emp_nome { get; set; }
        public string emp_indice { get; set; }
        public string emp_qntdNotas { get; set; }
        public string emp_qntdDebitos { get; set; }
    }
}
