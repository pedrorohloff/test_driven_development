using test_driven_development;

namespace teste_test_driven_development
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "02/02/2020";
            Calculadora calc = new Calculadora(data);
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            //Arrange
            Calculadora calc = construirClasse();
            //Act
            int resultadoCalculadora = calc.Somar(val1, val2);
            //Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            //Arrange
            Calculadora calc = construirClasse();
            //Act
            int resultadoCalculadora = calc.Multiplicar(val1, val2);
            //Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            //Arrange
            Calculadora calc = construirClasse();
            //Act
            int resultadoCalculadora = calc.Subtrair(val1, val2);
            //Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            //Arrange
            Calculadora calc = construirClasse();
            //Act
            int resultadoCalculadora = calc.Dividir(val1, val2);
            //Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Fact]
        public void TestarDivisaoPor0()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
             );
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();

            calc.Somar(1, 2);
            calc.Somar(2, 8);
            calc.Somar(4, 7);
            calc.Somar(4, 1);

            var lista = calc.HistoricoOperacoes();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count());
        }

    }
}