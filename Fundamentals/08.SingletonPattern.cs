public class SingletonPattern
{
    public SingletonPattern()
    {
        SomeService someService = new();
        someService.DoWork();

        AnotherService anotherService = new();
        anotherService.Run();
    }

    class Logger
    {
        public static Logger? logger;
        private static readonly object _lock = new();
        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                lock (_lock) //=> async
                {
                    if (logger is null) logger = new Logger();

                    return logger;
                }
            }
        }
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    class SomeService
    {
        public void DoWork()
        {
            //Metot ile alakalı işlemler
            Logger.Instance.Log("Work started");
        }
    }

    class AnotherService
    {
        public void Run()
        {
            //Metot ile alakalı işlemler
            Logger.Instance.Log("Running");
        }
    }
}