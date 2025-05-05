public class DecoratorPattern
{
    public DecoratorPattern()
    {
        ICoffee coffee = new SimpleCoffee();
        coffee = new MilkDecorator(coffee);
        coffee = new CreamDecorator(coffee);
        coffee = new BlackDecorator(coffee);

        Console.WriteLine($"Total Cost: {coffee.Cost()}");
    }
    interface ICoffee
    {
        double Cost();
    }

    class SimpleCoffee : ICoffee
    {
        public double Cost() => 2.0;
    }

    class MilkDecorator(ICoffee coffee) : ICoffee
    {
        public double Cost() => coffee.Cost() + 0.5;
    }

    class CreamDecorator(ICoffee coffee) : ICoffee
    {
        public double Cost() => coffee.Cost() + 0.7;
    }

    class BlackDecorator(ICoffee coffee) : ICoffee
    {
        public double Cost() => coffee.Cost() + 0.3;
    }
}