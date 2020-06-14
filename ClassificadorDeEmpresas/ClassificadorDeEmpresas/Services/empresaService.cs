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

        public async Task<List<Empresa>> GetEmpresas()
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

        public async Task<int> GetTamenhoBD()
        {
            int retorno = 0;

            using (HttpClient client = new HttpClient())
            {
                var tget = client.GetAsync(string.Concat(urlWebApi, "empresa/obterTamenhoBD"));
                tget.Wait();

                var resposta = tget.Result;

                if (resposta.IsSuccessStatusCode)
                {
                    var respostaComoString = await resposta.Content.ReadAsStringAsync();

                    retorno = JsonConvert.DeserializeObject<int>(respostaComoString);
                }
            }

            return retorno;
        }
    }
}
