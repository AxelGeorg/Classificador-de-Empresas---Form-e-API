using ClassificadorDeEmpresas.API.Entities;
using ClassificadorDeEmpresas.API.Controllers;
using System;
using Xunit;
using System.Runtime.InteropServices;
using FluentAssertions;
using ClassificadorDeEmpresas.API.Models;

namespace ClassificadorDeEmpresas.Tests
{
    public class EmpresaDaoTest
    {
        //Quando executar esses tests, tenha ctz todos os dados do banco, caso desejado execute no mysql -> truncate table empresas;

        [Theory]
        [InlineData("NomeTest1", "50", "0", "0")]
        [InlineData("NomeTest2", "43", "4", "8")]
        [InlineData("NomeTest3", "49", "5", "1")]
        public void DeveRetornarTrueQuandoCadastrarEmpresa(string nome, string indice, string qntdNotas, string qntdDebitos)
        {
            EmpresaDAO empresaDAO = new EmpresaDAO();
            bool resposta;

            resposta = empresaDAO.cadastrarEmpresa(nome, indice, qntdNotas, qntdDebitos);
            resposta.Should().BeTrue();
        }

        [Theory]
        [InlineData("1", "Novonome1", "59", "8", "2")]
        [InlineData("2", "Novonome2", "49", "3", "1")]
        [InlineData("3", "Novonome3", "60", "9", "2")]
        public void DeveRetornarTrueQuandoAlterarEmpresa(string id,string nome, string indice, string qntdNotas, string qntdDebitos)
        {
            EmpresaDAO empresaDAO = new EmpresaDAO();
            bool resposta;

            resposta = empresaDAO.alterarEmpresa(id,nome, indice, qntdNotas, qntdDebitos);
            resposta.Should().BeTrue();
        }

        [Theory]
        [InlineData("1")]
        [InlineData("2")]
        [InlineData("3")]
        public void DeveRetornarTrueQuandoDeletarEmpresa(string id)
        {
            EmpresaDAO empresaDAO = new EmpresaDAO();
            bool resposta;

            resposta = empresaDAO.deletarEmpresa(id);
            resposta.Should().BeTrue();
        }
    }
}
