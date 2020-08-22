using System;

namespace ExampleFacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new RestauranteFacade();
            
            Console.WriteLine("----------------------PEDIDOS DE PIZZA DO CLIENTE----------------------------\n");
            facade.BuscarPizzaNormal();
            facade.BuscarPizzaVegana();

            Console.WriteLine("\n----------------------PEDIDOS DE PÃO DO CLIENTE----------------------------\n");
            facade.BuscarPaoDeAlho();
            facade.BuscarPaoDeAlhoComQueijo();

        }
    }
}
