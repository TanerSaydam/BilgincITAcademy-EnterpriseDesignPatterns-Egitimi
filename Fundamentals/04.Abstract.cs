public class Abstract
{
    public Abstract()
    {
        Product Product = new();
        //Test Test = new(); // abstract class newlenemez
    }

    //abstract class Test
    //{
    //    public Guid Id { get; set; }
    //    public void Method()
    //    {

    //    }
    //}

    //class Dog : Test
    //{
    //}

    abstract class Entity //Audit
    {
        protected Entity()
        {
            Id = Guid.CreateVersion7();
        }
        public Guid Id { get; set; } //0000-0000-000-000
        public Guid CreatedById { get; set; }
        public DateTimeOffset CreatedOn { get; set; } // 01.01.00001 00:00:00
        public Guid? UpdatedById { get; set; }
        public DateTimeOffset? UpdateOn { get; set; }
    }

    class Product : Entity
    {

    }
}