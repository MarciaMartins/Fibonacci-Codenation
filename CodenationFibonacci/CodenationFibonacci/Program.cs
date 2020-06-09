using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodenationFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaFibonacci lista = new ListaFibonacci();

            ValidaDados validacao = new ValidaDados();

            validacao.Valida(lista);

            Console.ReadLine();




        }




    }
}
