using ExampleFacadePattern.Interfaces;
using System;

namespace ExampleFacadePattern
{
    public class FornecedorPizza : IPizza
    {
        public void BuscarPizzaNormal()
        {
            ObterCoberturaNaoVegana();
            Console.WriteLine("Buscando a Pizza Normal.");
        }

        public void BuscarPizzaVegana()
        {
            Console.WriteLine("Buscando a Pizza Vegana.");
        }

        private void ObterCoberturaNaoVegana()
        {
            Console.WriteLine("Obtendo coberturas de pizza não vegetais.");
        }
    }
}