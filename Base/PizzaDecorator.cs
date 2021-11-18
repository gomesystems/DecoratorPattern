using DecoratorPattern.Interfaces;

namespace DecoratorPattern
{

    //Base Decorator
    public class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        // Virtual para sobrescrever (poliformismo).
        public virtual string BuscarTipoPizza()
        {
            var pizza = _pizza.BuscarTipoPizza();
            return pizza;
        }
    }
}
