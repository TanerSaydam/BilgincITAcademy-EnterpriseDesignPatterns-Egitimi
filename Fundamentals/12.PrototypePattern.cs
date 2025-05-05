public class PrototypePattern
{
    public PrototypePattern()
    {
        Document document1 = new()
        {
            Content = "Hello world",
            Font = "Arial",
            FontSize = 20,
        };

        document1.Address.City = "Kayseri";

        Document document2 = document1.Clone();
        document2.Content = "Hello world 2";
        document2.Address = document1.Address.Clone();
        document2.Address.City = "Ankara";
    }

    interface IPrototype<T>
    {
        T Clone();
    }

    class Document : IPrototype<Document>
    {
        public string Content { get; set; } = default!;
        public string Font { get; set; } = default!;
        public int FontSize { get; set; }

        public Address Address { get; set; } = new();
        public Document Clone()
        {
            return (Document)this.MemberwiseClone();
        }
    }

    class Address : IPrototype<Address>
    {
        public string City { get; set; } = default!;

        public Address Clone()
        {
            return (Address)this.MemberwiseClone();
        }
    }
}