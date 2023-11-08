using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {   
            string texto = "Olá";

            int resultado = _validacoes.ContarCaracteres(texto);

            Assert.Equal(3, resultado);
        }

        [Fact]
        public void DeveContar8CaracteresEmAndressaERetornar8()
        {   
            string texto = "Andressa";

            int resultado = _validacoes.ContarCaracteres(texto);

            Assert.Equal(8, resultado);
        }
    }
}
