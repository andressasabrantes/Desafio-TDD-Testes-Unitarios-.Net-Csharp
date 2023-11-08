using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        int num1 = 5;
        int num2 = 10;

        int resultado = _calc.Somar(num1, num2);

        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSubtrair100Com50ERetornar50()
    {
        int num1 = 100;
        int num2 = 50;

        int resultado = _calc.Subtrair(num1, num2);

        Assert.Equal(50, resultado);
    }

    [Fact]
    public void DeveMultiplicar10Com100ERetornar1000()
    {
        int num1 = 10;
        int num2 = 100;

        int resultado = _calc.Multiplicar(num1, num2);

        Assert.Equal(1000, resultado);
    }

    [Fact]
    public void DeveDividir100Com100ERetornar1()
    {
        int num1 = 100;
        int num2 = 100;

        int resultado = _calc.Dividir(num1, num2);

        Assert.Equal(1, resultado);
    }

    [Fact]
    public void DeveVerificarSe8EhParERetornarTrue()
    {
        int numero = 8;

        bool resultado = _calc.EhPar(numero);

        Assert.True(resultado);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerificarSeOsNumerosSaoParesERetornarTrue(int numero)
    {
        bool resultado = _calc.EhPar(numero);

        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeira(int[] numeros)
    {
        Assert.All(numeros, numero => Assert.True(_calc.EhPar(numero)));
    }
}
