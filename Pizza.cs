using DecoratorPattern.Interfaces;

namespace DecoratorPattern
{
    public class Pizza : IPizza
    {
        public string BuscarTipoPizza()
        {
            var pizza = " Esta é uma pizza normal!";
            return pizza;
        }
    }
}
