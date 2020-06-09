using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodenationFibonacci
{
    class ValidaDados
    {
        
        public int Valida(ListaFibonacci listaFibonacci)
        {
            string informacao = RecebeInformacao();
            int numeroValidado = ValidaNumero(informacao);
            if (numeroValidado >= 0)
            {
               ImprimeResultado(listaFibonacci.IsFibonacci(numeroValidado));
            }
            else Console.Write("Informaçao invalida");
            return ValidaNumero(informacao);
        }

        private void ImprimeResultado(bool resultado)
        {
            if (resultado) 
            {
                Console.Write("Numero existente na lista Fibonacci.");
            }
            else
            {
                Console.Write("Numero inexistente na lista Fibonacci.");
            }
        }

        private string RecebeInformacao()
        {
            Console.Write("Informe numero a ser pesquisado: ");
            string informacao = Console.ReadLine().Trim();
            return informacao;
         }

        private int ValidaNumero(string informacao)
        {
            int numero;
            bool canConvert = int.TryParse(informacao, out numero);
            if (canConvert == true)
            {
                return numero;
            }
            else return numero = -1;
        }

    }
}
