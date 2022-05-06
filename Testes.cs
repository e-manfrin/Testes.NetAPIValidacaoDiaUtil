using DataAPI.Services;
using System;
using Xunit;

namespace TestesUnitarios
{
    public class Testes
    {
        [Fact]
        public void TesteFeriadoFixoNatal()
        {
            var feriadoFixo = FeriadosFixo.ConsultarFeriadoFixo(25, 12);
            Assert.True(feriadoFixo.Feriado == true);
        }

        [Fact]
        public void TesteFeriadoMovelPascoa()
        {
            var feriadoMovel = FeriadoMovel.ConsultarFeriadoMovel(17, 04, 2022);
            Assert.True(feriadoMovel.Feriado == true);
            Assert.NotEmpty(feriadoMovel.NomeFeriado);
        }

        [Fact]
        public void TesteConversorDiasDaSemana()
        {
            DataService dataService = new DataService();
            var validar = dataService.ConversorDiasDaSemana(new DateTime(2022, 5, 5));
            Assert.True(validar.Equals("Quinta-feira"));
        }

        [Fact]
        public void TesteValidarDataDiaUtil()
        {
            DataService dataService = new DataService();
            var diaUtil = dataService.VerificarDiaUtil(new DateTime(2022, 5, 5));
            Assert.True(diaUtil.DiaUtil == true);
        }

        [Fact]
        public void TesteValidarDataFinalDeSemanaSabado()
        {
            DataService dataService = new DataService();
            var diaUtil = dataService.VerificarDiaUtil(new DateTime(2022, 5, 7));
            Assert.True(diaUtil.DiaUtil == false);
        }

        [Fact]
        public void TesteValidarDataFinalDeSemanaDomingo()
        {
            DataService dataService = new DataService();
            var diaUtil = dataService.VerificarDiaUtil(new DateTime(2022, 5, 8));
            Assert.True(diaUtil.DiaUtil == false);
        }
    }
}
