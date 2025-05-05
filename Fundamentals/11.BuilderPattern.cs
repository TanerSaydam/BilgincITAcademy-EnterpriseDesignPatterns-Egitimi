public class BuilderPattern
{
    public BuilderPattern()
    {
        HouseBuilder houseBuilder = new();
        House house = houseBuilder
            .SetWindows(4)
            .SetDoors(2)
            //.SetHasGarage(true)
            //.SetHasSwimmingPool(false)
            .Build();
    }

    class House
    {
        public int Windows { get; set; }
        public int Doors { get; set; }
        public bool HasGarage { get; set; } = true;
        public bool HasSwimmingPool { get; set; } //false
    }

    class HouseBuilder
    {
        private House _house = new();

        public HouseBuilder SetWindows(int windows)
        {
            _house.Windows = windows;
            return this;
        }

        public HouseBuilder SetDoors(int doors)
        {
            _house.Doors = doors;
            return this;
        }

        public HouseBuilder SetHasGarage(bool hasGarage)
        {
            _house.HasGarage = hasGarage;
            return this;
        }

        public HouseBuilder SetHasSwimmingPool(bool hasSwimmingPool)
        {
            _house.HasSwimmingPool = hasSwimmingPool;
            return this;
        }

        public House Build()
        {
            return _house;
        }
    }
}