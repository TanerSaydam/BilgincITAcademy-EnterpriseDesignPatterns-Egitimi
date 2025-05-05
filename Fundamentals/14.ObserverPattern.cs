public class ObserverPattern
{
    public ObserverPattern()
    {
        var station = new WeaterStation();
        var display1 = new Display("Main");
        var display2 = new Display("Secondary");
        var display3 = new Display("Third");

        station.AddObserver(display1);
        station.AddObserver(display2);
        station.AddObserver(display3);

        station.setTemperature(25);
    }

    interface IObserver
    {
        void Update(int temperature);
    }

    class Display : IObserver
    {
        private string _name;

        public Display(string name)
        {
            _name = name;
        }

        public void Update(int temperature)
        {
            Console.WriteLine($"{_name} Display: Temperature is now {temperature}");
        }
    }

    class WeaterStation
    {
        private List<IObserver> _observers = new();
        private int _temperature;

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void setTemperature(int temperature)
        {
            _temperature = temperature;
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature);
            }
        }
    }
}