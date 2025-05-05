public class Inheritance
{
    public Inheritance()
    {
        Dog dog = new();
        dog.Speak();

    }
    class Animal
    {
        public Animal(int age)
        {

        }
        public int _id;
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }

        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public Dog(int age = 5) : base(age)
        {
            _id = 5;
        }
        public void Test()
        {

        }

        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("hav hav");
        }
    }

    class Test : Dog
    {
        public string Name { get; set; } = default!;
    }
}