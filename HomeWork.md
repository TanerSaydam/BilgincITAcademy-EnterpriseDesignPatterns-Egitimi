# Ders enasında pratik yapmak için sorular

# 📑 İçindekiler

- [Singleton Design Pattern Sorusu](#-singleton-design-pattern-sorusu)
- [Factory Method Sorusu](#-factory-method-sorusu)
- [Abstract Factory Pattern Sorusu](#-abstract-factory-pattern-sorusu)
- [Builder Pattern Sorusu](#-builder-pattern-sorusu)
- [Prototype Pattern Sorusu](#-prototype-pattern-sorusu)
- [State Pattern Sorusu](#-state-pattern-sorusu)
- [Observer Pattern Sorusu](#-observer-pattern-sorusu)
- [Strategy Pattern Sorusu](#-strategy-pattern-sorusu)
- [Command Pattern Sorusu](#-command-pattern-sorusu)
- [Mediator Pattern Sorusu](#-mediator-pattern-sorusu)
- [Decorator Pattern Sorusu](#-decorator-pattern-sorusu)
- [Facade Pattern Sorusu](#-facade-pattern-sorusu)
- [Proxy Pattern Sorusu](#-proxy-pattern-sorusu)
- [Adapter Pattern Sorusu](#-adapter-pattern-sorusu)
- [Bridge Pattern Sorusu](#-bridge-pattern-sorusu)

# 📝 Singleton Design Pattern Sorusu

Bir **ConfigurationManager** sınıfı tasarlamak istiyorsun.
Bu sınıf uygulama boyunca tek bir yerde tutulacak ve `GetSetting(string key)` methoduyla ayarları döndürecek.
Singleton Pattern kullanarak nasıl yazarsın?

---

## 💡 Sorunun Cevabı

```csharp
public class ConfigurationManager
{
    private static ConfigurationManager _instance;
    private static readonly object _lock = new object();
    private Dictionary<string, string> _settings;

    private ConfigurationManager()
    {
        // Örnek sabit ayarlar
        _settings = new Dictionary<string, string>
        {
            { "AppName", "MyApp" },
            { "Version", "1.0" }
        };
    }

    public static ConfigurationManager Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                    _instance = new ConfigurationManager();
                return _instance;
            }
        }
    }

    public string GetSetting(string key)
    {
        return _settings.ContainsKey(key) ? _settings[key] : null;
    }
}

// Kullanım
string appName = ConfigurationManager.Instance.GetSetting("AppName");
Console.WriteLine(appName); // Çıktı: MyApp
```

👉 **Açıklama:** Tüm uygulama boyunca `ConfigurationManager` sadece bir kez oluşturulur ve ayarlara erişim merkezi hale gelir.

---------------------------------------------------------------------------------------------------------------------------------------

# 📝 Factory Method Sorusu

Bir **Shape Drawing** uygulaması yapıyorsun.
Kullanıcı Circle veya Rectangle seçebiliyor ve bu şekilleri ekrana çizebiliyorsun.
Factory Method Pattern kullanarak bir yapı kur.

---

## 💡 Factory Method Sorusu Cevabı

```csharp
public interface IShape
{
    void Draw();
}

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
}

public abstract class ShapeFactory
{
    public abstract IShape CreateShape();
}

public class CircleFactory : ShapeFactory
{
    public override IShape CreateShape()
    {
        return new Circle();
    }
}

public class RectangleFactory : ShapeFactory
{
    public override IShape CreateShape()
    {
        return new Rectangle();
    }
}

// Kullanım
ShapeFactory factory = new CircleFactory();
IShape shape = factory.CreateShape();
shape.Draw(); // Çıktı: Drawing Circle
```

👉 **Açıklama:** Kullanıcı yeni şekil türleri eklemek istediğinde, sadece yeni Shape ve ShapeFactory alt sınıfı yazarak genişletme yapılır; mevcut kod değişmez.

---------------------------------------------------------------------------------------------------------------------------------------

# 📘 Abstract Factory Pattern Sorusu

Bir mobilya mağazası uygulaması tasarlıyorsun.
Modern ve Viktoryan tarzda masa (`Table`) ve sandalye (`Chair`) takımları satıyorsun.
Abstract Factory Pattern kullanarak nasıl bir yapı kurarsın?

---

### 📗 Sorunun Cevabı

```csharp
public interface IChair
{
    void SitOn();
}

public interface ITable
{
    void PlaceItems();
}

public class ModernChair : IChair
{
    public void SitOn() => Console.WriteLine("Sitting on modern chair.");
}

public class VictorianChair : IChair
{
    public void SitOn() => Console.WriteLine("Sitting on victorian chair.");
}

public class ModernTable : ITable
{
    public void PlaceItems() => Console.WriteLine("Placing items on modern table.");
}

public class VictorianTable : ITable
{
    public void PlaceItems() => Console.WriteLine("Placing items on victorian table.");
}

public interface IFurnitureFactory
{
    IChair CreateChair();
    ITable CreateTable();
}

public class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new ModernChair();
    public ITable CreateTable() => new ModernTable();
}

public class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new VictorianChair();
    public ITable CreateTable() => new VictorianTable();
}

// Kullanım
IFurnitureFactory factory = new ModernFurnitureFactory();
IChair chair = factory.CreateChair();
ITable table = factory.CreateTable();
chair.SitOn();        // Çıktı: Sitting on modern chair.
table.PlaceItems();   // Çıktı: Placing items on modern table.
```

👉 **Açıklama:** Yeni bir stil (örn. Art Deco) eklemek için sadece yeni ürünler ve fabrika yazılır; mevcut yapıya dokunulmaz.

---------------------------------------------------------------------------------------------------------------------------------------

# 📘 Builder Pattern Sorusu

Bir **Burger** sınıfı tasarlıyorsun.
Burger içinde ekmek tipi, et tipi, peynir var/yok, sebzeler var/yok gibi özellikler olacak.
Builder Pattern kullanarak bir yapı nasıl kurarsın?

---

## 📗 Builder Pattern Sorunun Cevabı

```csharp
public class Burger
{
    public string BreadType { get; set; }
    public string MeatType { get; set; }
    public bool HasCheese { get; set; }
    public bool HasVegetables { get; set; }

    public override string ToString()
    {
        return $"Burger with {BreadType} bread, {MeatType} meat, Cheese: {HasCheese}, Vegetables: {HasVegetables}";
    }
}

public class BurgerBuilder
{
    private Burger _burger = new Burger();

    public BurgerBuilder SetBread(string type)
    {
        _burger.BreadType = type;
        return this;
    }

    public BurgerBuilder SetMeat(string type)
    {
        _burger.MeatType = type;
        return this;
    }

    public BurgerBuilder AddCheese(bool hasCheese)
    {
        _burger.HasCheese = hasCheese;
        return this;
    }

    public BurgerBuilder AddVegetables(bool hasVegetables)
    {
        _burger.HasVegetables = hasVegetables;
        return this;
    }

    public Burger Build()
    {
        return _burger;
    }
}

// Kullanım
var burger = new BurgerBuilder()
    .SetBread("Sesame")
    .SetMeat("Beef")
    .AddCheese(true)
    .AddVegetables(true)
    .Build();

Console.WriteLine(burger); // Çıktı: Burger with Sesame bread, Beef meat, Cheese: True, Vegetables: True
```

👉 **Açıklama:** Builder ile burger oluşturma adımları kontrol altında ve sıralı şekilde yapılır; her adım ayrı bir responsibility taşır.

---------------------------------------------------------------------------------------------------------------------------------------

# 📘 Prototype Pattern Sorusu

Bir **Shape** sınıfı tasarlıyorsun.
Bu sınıfın Circle ve Rectangle alt sınıfları var.
Her biri clone edilebilmeli ve orijinalinden bağımsız çalışmalı.
Prototype Pattern kullanarak nasıl bir yapı kurarsın?

---

## 📗 Prototype Pattern Sorunun Cevabı

```csharp
public interface IShape
{
    IShape Clone();
    void Draw();
}

public class Circle : IShape
{
    public int Radius { get; set; }

    public IShape Clone()
    {
        return (Circle)this.MemberwiseClone();
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing Circle with radius {Radius}");
    }
}

public class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public IShape Clone()
    {
        return (Rectangle)this.MemberwiseClone();
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing Rectangle {Width}x{Height}");
    }
}

// Kullanım
var circle = new Circle { Radius = 5 };
var clonedCircle = circle.Clone();
clonedCircle.Draw(); // Çıktı: Drawing Circle with radius 5

var rect = new Rectangle { Width = 10, Height = 20 };
var clonedRect = rect.Clone();
clonedRect.Draw();   // Çıktı: Drawing Rectangle 10x20
```

👉 **Açıklama:** Her shape kendi kopyasını üretebilir; klonlanan nesneler bağımsızdır ve kendi başlarına çalışabilir.

---------------------------------------------------------------------------------------------------------------------------------------

# 📘 State Pattern Sorusu

Bir **TrafficLight** (trafik lambası) sınıfı tasarlıyorsun.
Durumlar: Green → Yellow → Red → Green.
Her `Change()` çağrısında bir sonraki duruma geçmeli.
State Pattern kullanarak nasıl bir yapı kurarsın?

---

## 📗 State Pattern Sorunun Cevabı

```csharp
public class TrafficLight
{
    public ITrafficLightState State { get; set; }

    public TrafficLight()
    {
        State = new GreenState();
    }

    public void Change()
    {
        State.Change(this);
    }

    public void Report()
    {
        State.Report();
    }
}

public interface ITrafficLightState
{
    void Change(TrafficLight light);
    void Report();
}

public class GreenState : ITrafficLightState
{
    public void Change(TrafficLight light)
    {
        light.State = new YellowState();
    }

    public void Report()
    {
        Console.WriteLine("Green Light");
    }
}

public class YellowState : ITrafficLightState
{
    public void Change(TrafficLight light)
    {
        light.State = new RedState();
    }

    public void Report()
    {
        Console.WriteLine("Yellow Light");
    }
}

public class RedState : ITrafficLightState
{
    public void Change(TrafficLight light)
    {
        light.State = new GreenState();
    }

    public void Report()
    {
        Console.WriteLine("Red Light");
    }
}

// Kullanım
var light = new TrafficLight();
light.Report(); // Green Light
light.Change();
light.Report(); // Yellow Light
light.Change();
light.Report(); // Red Light
light.Change();
light.Report(); // Green Light
```

👉 **Açıklama:** Her durum (Green, Yellow, Red) kendi geçişini ve davranışını tanımlar; TrafficLight sadece çağırır.

---------------------------------------------------------------------------------------------------------------------------------------

# 📘 Observer Pattern Sorusu

Bir **Stock** sınıfın var.
Bağlı olan alıcılar (observers), stok fiyatı değiştiğinde otomatik bildirim almak istiyor.
Observer Pattern kullanarak nasıl bir yapı kurarsın?

---

## 📗 Observer Pattern Sorunun Cevabı

```csharp
public interface IInvestor
{
    void Update(decimal price);
}

public class Investor : IInvestor
{
    private string _name;

    public Investor(string name)
    {
        _name = name;
    }

    public void Update(decimal price)
    {
        Console.WriteLine($"{_name} notified: Stock price is now {price}");
    }
}

public class Stock
{
    private List<IInvestor> _investors = new List<IInvestor>();
    private decimal _price;

    public void Attach(IInvestor investor)
    {
        _investors.Add(investor);
    }

    public void Detach(IInvestor investor)
    {
        _investors.Remove(investor);
    }

    public void SetPrice(decimal price)
    {
        _price = price;
        Notify();
    }

    private void Notify()
    {
        foreach (var investor in _investors)
        {
            investor.Update(_price);
        }
    }
}

// Kullanım
var stock = new Stock();
var investor1 = new Investor("Alice");
var investor2 = new Investor("Bob");

stock.Attach(investor1);
stock.Attach(investor2);

stock.SetPrice(100m);
// Çıktı:
// Alice notified: Stock price is now 100
// Bob notified: Stock price is now 100
```

👉 **Açıklama:** Stok fiyatı değiştiğinde tüm bağlı yatırımcılar (investors) otomatik haberdar edilir.

---------------------------------------------------------------------------------------------------------------------------------------

# 📘 Strategy Pattern Sorusu

Bir **TextFormatter** sınıfı tasarlıyorsun.
Metni ya büyük harfe ya küçük harfe ya da baş harfi büyük olacak şekilde formatlaması gerekiyor.
Strategy Pattern kullanarak nasıl bir yapı kurarsın?

---

## 📗 Strategy Pattern Sorunun Cevabı

```csharp
public interface ITextFormatter
{
    string Format(string text);
}

public class UpperCaseFormatter : ITextFormatter
{
    public string Format(string text)
    {
        return text.ToUpper();
    }
}

public class LowerCaseFormatter : ITextFormatter
{
    public string Format(string text)
    {
        return text.ToLower();
    }
}

public class TitleCaseFormatter : ITextFormatter
{
    public string Format(string text)
    {
        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text);
    }
}

public class TextEditor
{
    private ITextFormatter _formatter;

    public TextEditor(ITextFormatter formatter)
    {
        _formatter = formatter;
    }

    public void Print(string text)
    {
        Console.WriteLine(_formatter.Format(text));
    }
}

// Kullanım
var editor = new TextEditor(new UpperCaseFormatter());
editor.Print("hello world"); // Çıktı: HELLO WORLD

editor = new TextEditor(new TitleCaseFormatter());
editor.Print("hello world"); // Çıktı: Hello World
```

👉 **Açıklama:** Farklı formatlama stratejileri uygulanabilir; TextEditor değişmez, strateji değişir.

---------------------------------------------------------------------------------------------------------------------------------------

# 📘 Command Pattern Sorusu

Bir **TextEditor** sınıfın var.
Yapabileceğin işlemler: `Copy`, `Paste`, `Undo`.
Command Pattern kullanarak nasıl bir yapı kurarsın?

---

## 📗 Command Pattern Sorunun Cevabı

```csharp
public interface ICommand
{
    void Execute();
}

public class TextEditor
{
    public void Copy() => Console.WriteLine("Copied text");
    public void Paste() => Console.WriteLine("Pasted text");
    public void Undo() => Console.WriteLine("Undo last action");
}

public class CopyCommand : ICommand
{
    private TextEditor _editor;

    public CopyCommand(TextEditor editor)
    {
        _editor = editor;
    }

    public void Execute()
    {
        _editor.Copy();
    }
}

public class PasteCommand : ICommand
{
    private TextEditor _editor;

    public PasteCommand(TextEditor editor)
    {
        _editor = editor;
    }

    public void Execute()
    {
        _editor.Paste();
    }
}

public class UndoCommand : ICommand
{
    private TextEditor _editor;

    public UndoCommand(TextEditor editor)
    {
        _editor = editor;
    }

    public void Execute()
    {
        _editor.Undo();
    }
}

public class EditorInvoker
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        _command.Execute();
    }
}

// Kullanım
var editor = new TextEditor();
var invoker = new EditorInvoker();

invoker.SetCommand(new CopyCommand(editor));
invoker.PressButton(); // Çıktı: Copied text

invoker.SetCommand(new PasteCommand(editor));
invoker.PressButton(); // Çıktı: Pasted text

invoker.SetCommand(new UndoCommand(editor));
invoker.PressButton(); // Çıktı: Undo last action
```

👉 **Açıklama:** Her işlem (Copy, Paste, Undo) birer command nesnesi olarak kapsüllenmiştir; EditorInvoker sadece çağırır.

---------------------------------------------------------------------------------------------------------------------------------------

# 📘 Mediator Pattern Sorusu

Bir **AirTrafficControl** (hava trafik kontrol) sistemi tasarlıyorsun.
Uçaklar (Planes) doğrudan birbirine sinyal göndermek yerine, tüm iletişimi bir `Tower` üzerinden yürütmeli.
Mediator Pattern kullanarak nasıl bir yapı kurarsın?

---

## 📗 Mediator Pattern Sorunun Cevabı

```csharp
public interface IAirTrafficControl
{
    void SendMessage(string from, string to, string message);
}

public class Tower : IAirTrafficControl
{
    public void SendMessage(string from, string to, string message)
    {
        Console.WriteLine($"Tower relays from {from} to {to}: '{message}'");
    }
}

public class Plane
{
    public string Identifier { get; }
    private IAirTrafficControl _tower;

    public Plane(string identifier, IAirTrafficControl tower)
    {
        Identifier = identifier;
        _tower = tower;
    }

    public void Send(string message, string to)
    {
        _tower.SendMessage(Identifier, to, message);
    }
}

// Kullanım
var tower = new Tower();
var plane1 = new Plane("PlaneA", tower);
var plane2 = new Plane("PlaneB", tower);

plane1.Send("Requesting landing.", "Tower"); // Çıktı: Tower relays from PlaneA to Tower: 'Requesting landing.
plane2.Send("Cleared for takeoff.", "Tower"); // Çıktı: Tower relays from PlaneB to Tower: 'Cleared for takeoff.
```

👉 **Açıklama:** Uçaklar artık doğrudan değil, kule (tower) üzerinden iletişim kurar → sistem merkezileşir ve sadeleşir.

---------------------------------------------------------------------------------------------------------------------------------------

# 📘 Decorator Pattern Sorusu

Bir **Text** sınıfın var.
Temel metni alıp, isteğe bağlı olarak onu **bold**, **italic** veya **underline** formatlarıyla genişletebileceğin bir yapı kur.
Decorator Pattern kullanarak nasıl yaparsın?

---

## 📗 Sorunun Cevabı

```csharp
public interface IText
{
    string Render();
}

public class PlainText : IText
{
    private string _content;

    public PlainText(string content)
    {
        _content = content;
    }

    public string Render() => _content;
}

public class BoldDecorator : IText
{
    private IText _text;

    public BoldDecorator(IText text)
    {
        _text = text;
    }

    public string Render() => $"<b>{_text.Render()}</b>";
}

public class ItalicDecorator : IText
{
    private IText _text;

    public ItalicDecorator(IText text)
    {
        _text = text;
    }

    public string Render() => $"<i>{_text.Render()}</i>";
}

public class UnderlineDecorator : IText
{
    private IText _text;

    public UnderlineDecorator(IText text)
    {
        _text = text;
    }

    public string Render() => $"<u>{_text.Render()}</u>";
}

// Kullanım
IText text = new PlainText("Hello World");
text = new BoldDecorator(text);
text = new ItalicDecorator(text);
text = new UnderlineDecorator(text);

Console.WriteLine(text.Render());
// Çıktı: <u><i><b>Hello World</b></i></u>
```

👉 **Açıklama:** Metin, istediğin kadar dekoratörle katmanlanabilir; her dekoratör bağımsız bir genişletme sağlar.

---------------------------------------------------------------------------------------------------------------------------------------

# 📘 Facade Pattern Sorusu

Bir **Computer** sınıfın var.
Bileşenleri: CPU, Memory, HardDrive.
Kullanıcı sadece `StartComputer()` methodunu çağırarak tüm sistemi başlatmak istiyor.
Facade Pattern kullanarak nasıl bir yapı kurarsın?

---

## 📗 Facade Pattern Sorunun Cevabı

```csharp
public class CPU
{
    public void Freeze() => Console.WriteLine("CPU Freezing");
    public void Jump(long position) => Console.WriteLine($"CPU Jumping to {position}");
    public void Execute() => Console.WriteLine("CPU Executing");
}

public class Memory
{
    public void Load(long position, string data) => Console.WriteLine($"Loading {data} at {position}");
}

public class HardDrive
{
    public string Read(long lba, int size) => "OS Boot Data";
}

public class ComputerFacade
{
    private CPU _cpu;
    private Memory _memory;
    private HardDrive _hardDrive;

    public ComputerFacade(CPU cpu, Memory memory, HardDrive hardDrive)
    {
        _cpu = cpu;
        _memory = memory;
        _hardDrive = hardDrive;
    }

    public void Start()
    {
        _cpu.Freeze();
        var data = _hardDrive.Read(0, 1024);
        _memory.Load(0, data);
        _cpu.Jump(0);
        _cpu.Execute();
        Console.WriteLine("Computer started!");
    }
}

// Kullanım
var computer = new ComputerFacade(new CPU(), new Memory(), new HardDrive());
computer.Start();
// Çıktı:
// CPU Freezing
// Loading OS Boot Data at 0
// CPU Jumping to 0
// CPU Executing
// Computer started!
```

👉 **Açıklama:** Kullanıcı sadece `ComputerFacade.Start()` çağırır; alt sistemlerin detaylarına dokunmaz.

---------------------------------------------------------------------------------------------------------------------------------------

# 📘 Proxy Pattern Sorusu

Bir **BankAccount** sınıfın var, ama bakiyeyi göstermek isteyen herkesin doğrudan erişimi olmasın.
Proxy Pattern kullanarak, sadece yetkili kullanıcıların `ShowBalance()` çağırabilmesini nasıl sağlarsın?

---

## 📗 Proxy Pattern Sorunun Cevabı

```csharp
public interface IBankAccount
{
    void ShowBalance();
}

public class RealBankAccount : IBankAccount
{
    private decimal _balance = 1000m;

    public void ShowBalance()
    {
        Console.WriteLine($"Your balance is {_balance}.");
    }
}

public class BankAccountProxy : IBankAccount
{
    private RealBankAccount _realAccount;
    private string _userRole;

    public BankAccountProxy(string userRole)
    {
        _realAccount = new RealBankAccount();
        _userRole = userRole;
    }

    public void ShowBalance()
    {
        if (_userRole == "Admin" || _userRole == "Owner")
        {
            _realAccount.ShowBalance();
        }
        else
        {
            Console.WriteLine("Access denied: insufficient permissions.");
        }
    }
}

// Kullanım
IBankAccount account = new BankAccountProxy("Owner");
account.ShowBalance(); // Çıktı: Your balance is 1000.

account = new BankAccountProxy("Guest");
account.ShowBalance(); // Çıktı: Access denied: insufficient permissions.
```

👉 **Açıklama:** Proxy, gerçek bank account’a erişim üzerinde kontrol sağlar → güvenlik veya yetki kontrolü eklenebilir.

---------------------------------------------------------------------------------------------------------------------------------------

# 📘 Adapter Pattern Sorusu

Bir **MediaPlayer** arayüzün var, sadece `PlayAudio()` methodunu bekliyor.
Ama elinde sadece `VideoPlayer` sınıfı var ve `PlayVideo()` methodu var.
Adapter Pattern ile `VideoPlayer`’ı `MediaPlayer` olarak nasıl kullanırsın?

---

## 📗 Sorunun Cevabı

```csharp
public interface IMediaPlayer
{
    void PlayAudio();
}

public class VideoPlayer
{
    public void PlayVideo()
    {
        Console.WriteLine("Playing video (with audio).");
    }
}

public class VideoPlayerAdapter : IMediaPlayer
{
    private VideoPlayer _videoPlayer;

    public VideoPlayerAdapter(VideoPlayer videoPlayer)
    {
        _videoPlayer = videoPlayer;
    }

    public void PlayAudio()
    {
        _videoPlayer.PlayVideo();
    }
}

// Kullanım
IMediaPlayer mediaPlayer = new VideoPlayerAdapter(new VideoPlayer());
mediaPlayer.PlayAudio(); // Çıktı: Playing video (with audio).
```

👉 **Açıklama:** Adapter, `VideoPlayer`’ı `IMediaPlayer` arayüzüne uydurur → video içinden ses oynatma sağlanır.

---------------------------------------------------------------------------------------------------------------------------------------

# 📘 Bridge Pattern Sorusu

Bir **RemoteControl** sınıfın var.
Televizyon (`TV`) ve Radyo (`Radio`) gibi cihazları kontrol edebilmesi gerekiyor.
Ayrıca `BasicRemote` ve `AdvancedRemote` gibi iki soyut kontrol katmanını desteklemelisin.
Bridge Pattern kullanarak nasıl kurarsın?

---

## 📗 Sorunun Cevabı

```csharp
public interface IDevice
{
    void TurnOn();
    void TurnOff();
}

public class TV : IDevice
{
    public void TurnOn() => Console.WriteLine("TV turned on");
    public void TurnOff() => Console.WriteLine("TV turned off");
}

public class Radio : IDevice
{
    public void TurnOn() => Console.WriteLine("Radio turned on");
    public void TurnOff() => Console.WriteLine("Radio turned off");
}

public abstract class RemoteControl
{
    protected IDevice Device;

    protected RemoteControl(IDevice device)
    {
        Device = device;
    }

    public abstract void TurnOn();
    public abstract void TurnOff();
}

public class BasicRemote : RemoteControl
{
    public BasicRemote(IDevice device) : base(device) { }

    public override void TurnOn() => Device.TurnOn();
    public override void TurnOff() => Device.TurnOff();
}

public class AdvancedRemote : RemoteControl
{
    public AdvancedRemote(IDevice device) : base(device) { }

    public override void TurnOn()
    {
        Console.WriteLine("Advanced features enabled.");
        Device.TurnOn();
    }

    public override void TurnOff()
    {
        Console.WriteLine("Advanced features disabled.");
        Device.TurnOff();
    }
}

// Kullanım
var tvRemote = new BasicRemote(new TV());
tvRemote.TurnOn();  // Çıktı: TV turned on

var radioRemote = new AdvancedRemote(new Radio());
radioRemote.TurnOn();  // Çıktı: Advanced features enabled. \n Radio turned on
```

👉 **Açıklama:** RemoteControl ve Device bağımsız genişleyebilir; Bridge Pattern köprü görevi görür.