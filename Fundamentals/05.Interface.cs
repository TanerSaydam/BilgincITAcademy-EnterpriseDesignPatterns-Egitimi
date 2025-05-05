public class Interface
{
    public Interface()
    {
        ILogger logger = new FileLogger();

        logger.Log("Hello world");
    }
    interface ILogger
    {
        Guid Id { get; set; }
        void Log(string message);
        void Show()
        {
            Console.WriteLine("Hello world");
        }
    }

    interface ITest
    {

    }

    abstract class Logger : ILogger
    {
        public Guid Id { get; set; }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    class FileLogger : Logger
    {
        //public Guid Id { get; set; }

        //public void Log(string message)
        //{
        //    Console.WriteLine(message);
        //}
    }

    class DbLogger : ILogger
    {
        public Guid Id { get; set; }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    class CacheLogger : ILogger
    {
        public Guid Id { get; set; }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}


