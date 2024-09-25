using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_driven_development
{
    public class Calculadora
    {
        private List<string> historico;
        private string data;

        public Calculadora(string data)
        {
            historico = new List<string>();
            this.data = data;
        }

        public int Somar(int x, int y)
        {
            int resultado = x + y;

            historico.Insert(0, $"Res: {resultado} - data: {data}");

            return resultado;
        }
        public int Subtrair(int x, int y)
        {
            int resultado = x - y;
            historico.Insert(0, $"Res: {resultado} - data: {data}");
            return resultado;
        }
        public int Multiplicar(int x, int y)
        {
            int resultado = x * y;
            historico.Insert(0, $"Res: {resultado} - data: {data}");
            return resultado;
        }
        public int Dividir(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            int resultado = x / y;
            historico.Insert(0, $"Res: {resultado} - data: {data}");
            return resultado;
        }
        public List<string> HistoricoOperacoes()
        { 
            historico.RemoveRange(3, historico.Count() - 3);
            return historico;
        }
    }
}
