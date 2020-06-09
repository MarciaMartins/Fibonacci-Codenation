using System;
using System.Collections.Generic;

class ListaFibonacci
{
    private List<int> listaFibonacci;
    private int maximoDefinidoFibonacci = 350;
    public ListaFibonacci( )
    {
        listaFibonacci = new List<int>();
        InicializaListaFibonacci();
        Fibonacci();
    }
        
    private void InicializaListaFibonacci()
    {
        listaFibonacci.Add(0);
        listaFibonacci.Add(1);
    }

    public void ImprimeListaFibonacci()
    {
        int contador = 1;
        listaFibonacci.ForEach(itemLista => {
            Console.WriteLine("Posiçao "+ contador + ": " + itemLista);
            contador++;
        });
    }
    private void Fibonacci()
    {
        int valorCalculado = 0;
        while ((valorCalculado = CalculaProximoFibonacci()) < maximoDefinidoFibonacci)
        {
           listaFibonacci.Add(valorCalculado);
        } 
    }

    private int CalculaProximoFibonacci()
    {
        return ((listaFibonacci[listaFibonacci.Count - 1]) + 
            (listaFibonacci[listaFibonacci.Count - 2]));
    }

    public bool IsFibonacci(int numero)
    {
        bool numeroIdentificado = false;
        listaFibonacci.ForEach(itemLista => {
            if (itemLista == numero)
             {
                    numeroIdentificado = true;
             }
        });
        return numeroIdentificado;
    }

    
}