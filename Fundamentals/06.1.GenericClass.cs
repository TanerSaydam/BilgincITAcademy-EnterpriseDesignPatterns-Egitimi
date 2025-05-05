public class GenericClass
{
    public GenericClass()
    {
        //Repository<User> userRepository = new();
        UserRepository userRepository = new();
        Repository<Product> productRepository = new();

        userRepository.Create(new User() { Id = Guid.NewGuid() });
    }

    class Repository<T>
        where T : Entity
    {
        public void Create(T user)
        {
            user.Id = Guid.NewGuid();
        }
        public List<T> GetAll()
        {
            return new();
        }
    }

    class UserRepository : Repository<User>
    {

    }

    class Entity
    {
        public Guid Id { get; set; }
    }

    class User : Entity
    {

    }

    class Product : Entity
    {

    }
}

