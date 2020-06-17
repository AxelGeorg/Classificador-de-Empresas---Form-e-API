using ClassificadorDeEmpresas.API.Entities;
using ClassificadorDeEmpresas.API.Controllers;
using System;
using Xunit;
using System.Runtime.InteropServices;
using FluentAssertions;

namespace ClassificadorDeEmpresas.Tests
{
    public class EmpresaControllerTest
    {
        [Theory]
        [InlineData("4","8","43")]
        [InlineData("7","1","54")]
        [InlineData("5","6","45")]
        public void DeveCalcularCorretamente(string qntdNotas, string qntdDebitos,string resultado)
        {
            EmpresaController controller = new EmpresaController();
            var resposta = "";

            resposta = controller.calculoDeConfiabilidade(qntdNotas, qntdDebitos);

            resultado.Should().Be(resultado, $"O Índice não corresponde ao valor esperado ({resultado})");
        }

        [Theory]
        [InlineData("4", "2", "43")]
        [InlineData("7", "1", "70")]
        [InlineData("6", "3", "35")]
        public void DeveCalcularErroneamente(string qntdNotas, string qntdDebitos, string resultado)
        {
            EmpresaController controller = new EmpresaController();
            var resposta = "";

            resposta = controller.calculoDeConfiabilidade(qntdNotas, qntdDebitos);

            Assert.NotEqual(resultado, resposta);
        }
    }
}
