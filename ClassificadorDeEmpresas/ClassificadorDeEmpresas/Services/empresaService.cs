using ClassificadorDeEmpresas.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassificadorDeEmpresas.Services
{
    class empresaService
    {
        private const string urlWebApi = @"http://localhost:5000/api/";

        /// <summary>
        /// Através do parametro Empresa utilizado nesse método solicita-se uma deleção via API.
        /// </summary>
        /// <param name="empresa"></param>
        /// <returns></returns>
        public async Task<Resposta> Delete_Empresa(Empresa empresa)
        {
            var retorno = new Resposta();

            var json = JsonConvert.SerializeObject(empresa);
            var dados = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                var tdelete = client.PostAsync(string.Concat(urlWebApi, "empresa/deletarEmpresa"),dados);
                tdelete.Wait();

                var resposta = tdelete.Result;

                if (resposta.IsSuccessStatusCode)
                {
                    var respostaComoString = await resposta.Content.ReadAsStringAsync();

                    retorno = JsonConvert.DeserializeObject<Resposta>(respostaComoString);
                }
                else
                {
                    var respostaComoString = await resposta.Content.ReadAsStringAsync();

                    retorno.Status = false;
                    retorno.Mensagem = string.Concat(resposta.ReasonPhrase, " - ", respostaComoString);
                }
            }

            return retorno;
        }

        /// <summary>
        /// Através do parametro Empresa utilizado nesse método solicita-se uma alteração via API.
        /// </summary>
        /// <param name="empresa"></param>
        /// <returns></returns>
        public async Task<Resposta> Put_Empresa(Empresa empresa)
        {
            var retorno = new Resposta();

            var json = JsonConvert.SerializeObject(empresa);
            var dados = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                var tput = client.PutAsync(string.Concat(urlWebApi, "empresa/alterarEmpresa"), dados);
                tput.Wait();

                var resposta = tput.Result;

                if (resposta.IsSuccessStatusCode)
                {
                    var respostaComoString = await resposta.Content.ReadAsStringAsync();

                    retorno = JsonConvert.DeserializeObject<Resposta>(respostaComoString);
                }
                else
                {
                    var respostaComoString = await resposta.Content.ReadAsStringAsync();

                    retorno.Status = false;
                    retorno.Mensagem = string.Concat(resposta.ReasonPhrase, " - ", respostaComoString);
                }
            }

            return retorno;
        }

        /// <summary>
        /// Através do parametro Empresa utilizado nesse método solicita-se um cadastro via API.
        /// </summary>
        /// <param name="empresa"></param>
        /// <returns></returns>
        public async Task<Resposta> Post_Empresa(Empresa empresa)
        {
            var retorno = new Resposta();


            var json = JsonConvert.SerializeObject(empresa);
            var dados = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                var tpost = client.PostAsync(string.Concat(urlWebApi, "empresa/cadastrarEmpresa"), dados);
                tpost.Wait();

                var resposta = tpost.Result;

                if (resposta.IsSuccessStatusCode)
                {
                    var respostaComoString = await resposta.Content.ReadAsStringAsync();

                    retorno = JsonConvert.DeserializeObject<Resposta>(respostaComoString);
                }
                else
                {
                    var respostaComoString = await resposta.Content.ReadAsStringAsync();

                    retorno.Status = false;
                    retorno.Mensagem = string.Concat(resposta.ReasonPhrase, " - ", respostaComoString);
                }
            }

            return retorno;
        }

        /// <summary>
        /// Através desse método solicita-se via API um retorno das empresas, de modo que essas estejam ordenadas pelos ids.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Empresa>> GetEmpresas()//por padrão retorna o ranking por id
        {
            var retorno = new List<Empresa>();

            using (HttpClient client = new HttpClient())
            {
                var tget = client.GetAsync(string.Concat(urlWebApi, "empresa/obterEmpresas"));       
                tget.Wait();

                var resposta = tget.Result;

                if (resposta.IsSuccessStatusCode)
                {
                    var respostaComoString = await resposta.Content.ReadAsStringAsync();

                    retorno = JsonConvert.DeserializeObject<List<Empresa>>(respostaComoString);
                }
            }

            return retorno;
        }

        /// <summary>
        /// Através desse método solicita-se via API um retorno das empresas, de modo que essas estejam ordenadas pelos indices.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Empresa>> GetEmpresasRankingIndice()
        {
            var retorno = new List<Empresa>();

            using (HttpClient client = new HttpClient())
            {
                var tget = client.GetAsync(string.Concat(urlWebApi, "empresa/obterEmpresasRankingIndice"));
                tget.Wait();

                var resposta = tget.Result;

                if (resposta.IsSuccessStatusCode)
                {
                    var respostaComoString = await resposta.Content.ReadAsStringAsync();

                    retorno = JsonConvert.DeserializeObject<List<Empresa>>(respostaComoString);
                }
            }

            return retorno;
        }

        /// <summary>
        /// Através desse método solicita-se via API um retorno das empresas, de modo que essas estejam ordenadas pelas notas.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Empresa>> GetEmpresasRankingNotas()
        {
            var retorno = new List<Empresa>();

            using (HttpClient client = new HttpClient())
            {
                var tget = client.GetAsync(string.Concat(urlWebApi, "empresa/obterEmpresasRankingNotas"));
                tget.Wait();

                var resposta = tget.Result;

                if (resposta.IsSuccessStatusCode)
                {
                    var respostaComoString = await resposta.Content.ReadAsStringAsync();

                    retorno = JsonConvert.DeserializeObject<List<Empresa>>(respostaComoString);
                }
            }

            return retorno;
        }

        /// <summary>
        /// Através desse método solicita-se via API um retorno das empresas, de modo que essas estejam ordenadas pelos debitos.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Empresa>> GetEmpresasRankingDebitos()
        {
            var retorno = new List<Empresa>();

            using (HttpClient client = new HttpClient())
            {
                var tget = client.GetAsync(string.Concat(urlWebApi, "empresa/obterEmpresasRankingDebitos"));
                tget.Wait();

                var resposta = tget.Result;

                if (resposta.IsSuccessStatusCode)
                {
                    var respostaComoString = await resposta.Content.ReadAsStringAsync();

                    retorno = JsonConvert.DeserializeObject<List<Empresa>>(respostaComoString);
                }
            }

            return retorno;
        }
    }
}
