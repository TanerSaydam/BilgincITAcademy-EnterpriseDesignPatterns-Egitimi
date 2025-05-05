public class Polymorphism
{
    public Polymorphism()
    {
        Test test = new();
        Console.WriteLine(test);

        Animal animal = new();
        animal.MakeSound("dog");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(Guid.NewGuid());
        }

        Console.WriteLine("--------------------------");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(Guid.CreateVersion7());
        }

        Entity entity = new();
        //İşlemler
        //İşlemler
        //İşlemler
        //İşlemler
        //İşlemler
        entity.Id = Guid.CreateVersion7();


        Guid.NewGuid();

        Entity entity2 = new(Guid.CreateVersion7());

    }
    class Entity
    {
        public Guid Id { get; set; }
        public Entity()
        {
            Console.WriteLine("Construtor 1 is working...");
        }

        public Entity(Guid id)
        {
            Id = id;
            Console.WriteLine("Construtor 2 is working...");
        }
    }
    class Animal //aynı metot ismini farklı parametreler ile kullanmaya Compile-time Polymorphism
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }

        public void MakeSound(string animalType)
        {
            Console.WriteLine("Hav hav");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound() //Runtime Polymorphism
        {
            base.MakeSound();
        }
    }

    class Test
    {
        public override string ToString()
        {
            return "base.ToString()";
        }
    }
}