using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanjeZadatak9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 6, 37, 25, 13, 1, 75, 7 };
            lista = lista.OrderBy(i => i).ToList();

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.ReadKey();
        }
    }
}
