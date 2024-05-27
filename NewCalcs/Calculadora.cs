using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalcs
{
    public class Calculadora
    {
        private List<string> listaHistorico;

        public Calculadora()
        {
            listaHistorico = new List<string>();
        }
        public int Somar(int n1, int n2)
        {
            int res = n1 + n2;

            listaHistorico.Insert(0, "Res:" + res);
            return res;
        }
        public int Subtrair(int n1, int n2)
        {
            int res = n1 - n2;

            listaHistorico.Insert(0, "Res:" + res);
            return res;
        }
        public int Multiplicar(int n1, int n2)
        {
            int res = n1 * n2;

            listaHistorico.Insert(0, "Res:" + res);
            return res;
        }
        public int Dividir(int n1, int n2)
        {
            int res = n1 / n2;

            listaHistorico.Insert(0, "Res:" + res);
            return res;
        }
        public List<string> Historico()
        {
            //Remove todos os tres primeiros e deixa o resto dentro da lista
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
