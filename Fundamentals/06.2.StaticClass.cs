public class StaticClass
{
    public StaticClass()
    {
        //for (int i = 0; i < 100000000; i++)
        //{
        //    Calculate.Numbers.Add(Guid.NewGuid());
        //}

        Console.ReadLine();

        ////Calculate calculate = new();
        //Calculate.Result += 5;
        //Calculate.Result += 5;
        //Calculate.Result -= 3;
        //Calculate.Result *= 2;
        //Calculate.Id = Guid.CreateVersion7();
        //Calculate.Method();
    }

    static class Calculate
    {
        public static List<Guid> Numbers = new();
        public static int Result { get; set; } //0

        public static Guid Id { get; set; }
        public static void Method()
        {

        }
    }

    public class Product
    {
        public static List<Product> Products = new();
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
    }
}