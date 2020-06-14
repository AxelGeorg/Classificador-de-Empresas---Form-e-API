using ClassificadorDeEmpresas.API.Entities;
using ClassificadorDeEmpresas.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassificadorDeEmpresas.API.Controllers
{
    //http://localhost:50412/api/empresa/cadastrarempresa
    [Route("api/[controller]")] //[controller] ==  'Empresa' Controller, por isso no route bota-se empresa, tanto faz o tamanho da letra
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        EmpresaDAO dao = new EmpresaDAO();

        [HttpGet]
        [Route("obterEmpresas")]
        public async Task<IActionResult> GetAllEmpresas()
        {
            try
            {
                // retorna uma lista simples de empresas.
                List<Empresa> empresas = new List<Empresa>();
                empresas = dao.BuscarEmpresas();

                return Ok(empresas);
            }
            catch (Exception ex)
            {
                // se houver alguma exceção ele retorna o erro 500 e uma mensagem do erro.
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("obterTamenhoBD")]
        public async Task<int> Getqntd()
        {
            int tamanho = dao.qntdBanco();

            return tamanho;
        }

        [HttpPost]
        [Route("cadastrarEmpresa")]
        public async Task<IActionResult> PostEmpresa([FromBody] Empresa empresa)
        {
            try
            {
                if (empresa == null)
                    throw new Exception("O objeto empresa não pode ser nulo.");

                // faz a inserção na base de dados...
                dao.cadastrarEmpresa(empresa.emp_nome, empresa.emp_indice, empresa.emp_qntdNotas, empresa.emp_qntdDebitos) ;

                // fez a inserção na base de dados com sucesso, então retorna uma resposta de ok.
                var resposta = new Resposta { Status = true, Mensagem = "Cliente cadastrado com sucesso." };

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
