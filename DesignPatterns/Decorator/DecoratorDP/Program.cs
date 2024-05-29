namespace DecoratorDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new MushroomPizza(new ExtraCheesePizza(new PlainPizza()));
            Console.WriteLine( pizza.getDescription());
            Console.WriteLine( pizza.getCost());
        }
    }

    public interface IPizza
    {
        public string getDescription();
        public string getCost();
    }

    public class PlainPizza : IPizza
    {
        public string getDescription()
        {
            return "Thin dough";
        }

        public string getCost()
        {
            return "4.00";
        }
    }

    public class ExtraCheesePizza : IPizza
    {
        private IPizza _pizza;

        public ExtraCheesePizza(IPizza pizza)
        {
                _pizza = pizza;
        }

        public string getCost()
        {
            return _pizza.getCost() + " + 0.50";
        }

        public string getDescription()
        {
            return _pizza.getDescription() + " + extra cheese";
        }
    }

    public class MushroomPizza : IPizza
    {
        private IPizza _pizza;

        public MushroomPizza(IPizza pizza)
        {
            _pizza = pizza;
        }

        public string getCost()
        {
            return _pizza.getCost() + " + 0.75";
        }

        public string getDescription()
        {
            return _pizza.getDescription() + " + mushrooms";
        }
    }

}
