using ExampleFacadePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleFacadePattern
{
    public class FornecedorPao : IPao
    {
        public void BuscarPaoDeAlho()
        {
            Console.WriteLine("Obtendo Pão De Alho.");
        }

        public void BuscarPaoDeAlhoComQueijo()
        {
            ObterQueijo();
            Console.WriteLine("Obtendo Pão De Alho com Queijo.");
        }
        private void ObterQueijo() 
        {
            Console.WriteLine("Obtendo Queijo.");
        }
    }
}
