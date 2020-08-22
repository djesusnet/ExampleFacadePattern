using ExampleFacadePattern.Interfaces;

namespace ExampleFacadePattern
{
    public class RestauranteFacade
    {
        private IPizza _FornecedorPizza;
        private IPao _FornecedorPao;

        public RestauranteFacade()
        {
            _FornecedorPizza = new FornecedorPizza();
            _FornecedorPao = new FornecedorPao();
        }

        public void BuscarPizzaNormal()
        {
            _FornecedorPizza.BuscarPizzaNormal();
        }

        public void BuscarPizzaVegana()
        {
            _FornecedorPizza.BuscarPizzaVegana();
        }

        public void BuscarPaoDeAlho()
        {
            _FornecedorPao.BuscarPaoDeAlho();
        }

        public void BuscarPaoDeAlhoComQueijo()
        {
            _FornecedorPao.BuscarPaoDeAlhoComQueijo();
        }
    }
}