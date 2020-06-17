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
    [Route("api/[controller]")] //[controller] ==  'Empresa'Controller, por isso no route bota-se empresa, sendo indiferente o tamanho da letra
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
        [Route("obterEmpresasRankingIndice")]
        public async Task<IActionResult> GetAllEmpresasIndices()
        {
            try
            {
                // retorna uma lista simples de empresas.
                List<Empresa> empresas = new List<Empresa>();
                empresas = dao.BuscarEmpresasIndices();

                return Ok(empresas);
            }
            catch (Exception ex)
            {
                // se houver alguma exceção ele retorna o erro 500 e uma mensagem do erro.
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("obterEmpresasRankingNotas")]
        public async Task<IActionResult> GetAllEmpresasNotas()
        {
            try
            {
                // retorna uma lista simples de empresas.
                List<Empresa> empresas = new List<Empresa>();
                empresas = dao.BuscarEmpresasNotas();

                return Ok(empresas);
            }
            catch (Exception ex)
            {
                // se houver alguma exceção ele retorna o erro 500 e uma mensagem do erro.
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("obterEmpresasRankingDebitos")]
        public async Task<IActionResult> GetAllEmpresasDebitos()
        {
            try
            {
                // retorna uma lista simples de empresas.
                List<Empresa> empresas = new List<Empresa>();
                empresas = dao.BuscarEmpresasDebitos();

                return Ok(empresas);
            }
            catch (Exception ex)
            {
                // se houver alguma exceção ele retorna o erro 500 e uma mensagem do erro.
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("cadastrarEmpresa")]
        public async Task<IActionResult> PostEmpresa([FromBody] Empresa empresa)
        {
            var novoIndice = "";

            try
            {
                if (empresa == null)
                    throw new Exception("O objeto empresa não pode ser nulo.");

                novoIndice = calculoDeConfiabilidade(empresa.emp_qntdNotas, empresa.emp_qntdDebitos);

                // faz a inserção na base de dados...
                dao.cadastrarEmpresa(empresa.emp_nome, novoIndice, empresa.emp_qntdNotas, empresa.emp_qntdDebitos) ;

                // fez a inserção na base de dados com sucesso, então retorna uma resposta de ok.
                var resposta = new Resposta { Status = true, Mensagem = "Empresa cadastrado com sucesso." };

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("alterarEmpresa")]
        public async Task<IActionResult> PutEmpresa([FromBody] Empresa empresa)
        {
            var novoIndice = "";

            try
            {
                if (empresa == null)
                    throw new Exception("O objeto empresa não pode ser nulo.");

                // faz a alteração na base de dados...

                novoIndice = calculoDeConfiabilidade(empresa.emp_qntdNotas, empresa.emp_qntdDebitos);

                dao.alterarEmpresa(empresa.emp_id, empresa.emp_nome, novoIndice, empresa.emp_qntdNotas, empresa.emp_qntdDebitos);

                // fez a inserção na base de dados com sucesso, então retorna uma resposta de ok. 
                var resposta = new Resposta { Status = true, Mensagem = "Empresa alterado com sucesso." };

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("deletarEmpresa")]
        public async Task<IActionResult> DeletarEmpresa([FromBody] Empresa empresa)
        {
            try
            {
                if (empresa == null)
                    throw new Exception("O objeto empresa não pode ser nulo.");

                // deleta na base de dados...
                dao.deletarEmpresa(empresa.emp_id);

                // deletou na base de dados com sucesso, então retorna uma resposta de ok.
                var resposta = new Resposta { Status = true, Mensagem = "Empresa deletada com sucesso." };

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        /// <summary>
        /// Através dos parâmetros pode-se calcular o índice de confiabilidade.
        /// </summary>
        /// <param name="totalNotas"></param>
        /// <param name="totalDebitos"></param>
        /// <returns></returns>
        public string calculoDeConfiabilidade(string totalNotas, string totalDebitos)
        {
            var empresaCal = new Empresa();

            double porcIndice = 50;
            int qntdNotas = Convert.ToInt32(totalNotas);
            int qntdDebitos = Convert.ToInt32(totalDebitos);

            for (int i = 0; i <= qntdNotas; i++)
            {
                porcIndice = porcIndice + (porcIndice * 0.02);
                porcIndice = Math.Floor(porcIndice);
            }
            for (int i = 0; i <= qntdDebitos; i++)
            {
                porcIndice = porcIndice - (porcIndice * 0.04);
                porcIndice = Math.Ceiling(porcIndice);
            }
            if (porcIndice < 1)
            {
                porcIndice = 1;
            }
            if (porcIndice > 100)
            {
                porcIndice = 100;
            }

            return empresaCal.emp_indice = Convert.ToString(porcIndice);
        }
    }
}
