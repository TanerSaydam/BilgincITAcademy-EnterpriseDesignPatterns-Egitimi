namespace Fundamentals;
public class Encapsulation
{

    Test test = new(); // class => instance => nesne
                       //test.Name = "Taner Saydam";
                       //test.name = "Tugay Saydam";
                       //test.Method();

    decimal number = 1;

    public Encapsulation()
    {
        test.Amount = number;
        Console.WriteLine(number);
        //test.SetAmount(number);
        //Console.WriteLine(test.GetAmount());
        //if(number >= 0)
        //{
        //    test.amount = number;
        //}
    }

    class Test
    {
        public Test(int age)
        {
            Age = age;
        }
        //değişken
        private string name = "Taner Saydam";
        private decimal _amount = 0;
        public decimal Amount
        {
            get { return _amount; }
            set
            {
                if (value >= 0) { _amount += value; }
            }
        }
        public int Age { get; } //readonly
                                //property
        public string Name
        {
            get { return name; }
            set
            {
                name = "Mr. " + value;
            }
        }

        //metot

        public decimal GetAmount()
        {
            return _amount;
        }

        public void SetAmount(decimal val)
        {
            if (val >= 0)
            {
                _amount += val;
            }
        }

        public void Method()
        {

        }

        //constructor
        public Test()
        {

        }
    }
}
