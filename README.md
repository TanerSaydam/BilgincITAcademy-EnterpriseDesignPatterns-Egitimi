# Bilginç IT Academy - Enterprise Desin Patterns ve Architectures Eğitimi


# 📑 İçindekiler

- [OOP (Object-Oriented Programming) Nedir?](#oop-object-oriented-programming-nedir)
  - [🕰 Tarihçesi](#-tarihçesi)
  - [🌍 Hangi Diller OOP Kullanır?](#-hangi-diller-oop-kullanır)
- [🌟 Advantages of OOP (OOP’nin Avantajları)](#-advantages-of-oop-oopnin-avantajları)
  - [🔒 Encapsulation (Kapsülleme)](#-1️⃣-encapsulation-kapsülleme)
  - [♻️ Reusability (Yeniden Kullanılabilirlik)](#-2️⃣-reusability-yeniden-kullanılabilirlik)
  - [🧩 Modularity (Modülerlik)](#-3️⃣-modularity-modülerlik)
  - [📈 Scalability (Ölçeklenebilirlik)](#-4️⃣-scalability-ölçeklenebilirlik)
  - [🔧 Maintainability (Bakım Kolaylığı)](#-5️⃣-maintainability-bakım-kolaylığı)
  - [🕶 Abstraction (Soyutlama)](#-6️⃣-abstraction-soyutlama)
  - [🎭 Flexibility & Polymorphism (Esneklik ve Çok Biçimlilik)](#-7️⃣-flexibility--polymorphism-esneklik-ve-çok-biçimlilik)
- [Encapsulation (Kapsülleme)](#-encapsulation-kapsülleme)
- [Inheritance (Kalıtım)](#-inheritance-kalıtım)
- [Polymorphism (Çok Biçimlilik)](#-flexibility--polymorphism-esneklik-ve-çok-biçimlilik)
- [Abstraction (Soyutlama)](#-abstraction-soyutlama)
- [Interface (Arayüzler)](#-interface-arayüzler)
- [Generic Class ve Static Class](#-generic-class-ve-static-class)
- [SOLID Prensipleri](#-solid-prensipleri)
- [Dependency Injection](#-dependency-injection-nedir)
- [What is the Design Pattern?](#-what-is-the-design-pattern)
- [Anti-Pattern Nedir?](#-what-is-the-anti-pattern)
- [Singleton Pattern](#-singleton-pattern)
- [Factory Method Pattern](#-factory-method-pattern)
- [Abstract Factory Pattern](#-abstract-factory-pattern)
- [Builder Pattern](#-builder-pattern)
- [Prototype Pattern](#-prototype-pattern)
- [State Pattern](#-state-pattern)
- [Observer Pattern](#-observer-pattern)
- [Strategy Pattern](#-strategy-pattern)
- [Command Pattern](#-command-pattern)
- [Mediator Pattern](#-mediator-pattern)
- [Decorator Pattern](#-decorator-pattern)
- [Facade Pattern](#-facade-pattern)
- [Proxy Pattern](#-proxy-pattern)
- [Adapter Pattern](#-adapter-pattern)
- [Bridge Pattern](#-bridge-pattern)

---------------------------------------------------------------------------------------------------------------------------------------

# OOP (Object-Oriented Programming) Nedir?

OOP, programlama yaklaşımı olarak **veriyi (state)** ve bu veriye yönelik işlemleri (behavior) **nesneler** (objects) etrafında organize eden bir paradigmadır.
Yani OOP’de her şey bir **nesne** olarak düşünülür: nesnenin özellikleri (**fields / attributes**) ve yapabildikleri (**methods**) vardır.

Bu yaklaşım, özellikle büyük ve karmaşık yazılımları küçük, modüler ve yönetilebilir birimlere ayırmak için geliştirilmiştir.

---

## 🕰 Tarihçesi

- **1960’lar:** OOP konsepti ilk kez Norveçli bilgisayar bilimci **Ole-Johan Dahl** ve **Kristen Nygaard** tarafından geliştirilen **Simula** dilinde ortaya çıktı (Simula 67).
Simula, özellikle simülasyonlar için tasarlandı ve “class” ve “object” kavramlarını tanıttı.

- **1970’ler:** Bu fikirler, Alan Kay tarafından geliştirilen **Smalltalk** dilinde genişletildi. Alan Kay, OOP’yi ilk defa geniş anlamda uygulayan ve “gerçek nesne yönelimli programlama” fikrini savunan kişidir.
Alan Kay’in ünlü sözü:
> “The big idea is 'messaging'.”

- **1980’ler ve sonrası:**
C++, Objective-C gibi diller OOP’yi C tabanlı dillere getirdi.
Java, C#, Python gibi modern dillerde OOP birincil programlama paradigması haline geldi.

---

## 🌍 Hangi Diller OOP Kullanır?

- **Tam OOP (Pure OOP) diller:**
Smalltalk, Eiffel, Ruby

- **Çok paradigmali ama güçlü OOP desteği verenler:**
Java, C#, Python, C++, Kotlin, Swift, Dart, JavaScript (ES6+), TypeScript
> **Not:** “Paradigma”, bir alanın veya disiplinin olaylara yaklaşma, düşünme ve çözüm üretme biçimi demektir.
> Programlama paradigmaları, kod yazarken problemleri nasıl çözeceğimizi belirleyen genel yaklaşımlardır (örn. nesne yönelimli, fonksiyonel, prosedürel).

- **OOP olmayan / zayıf destekli diller:**
C, Go, Rust (struct ve trait kombinasyonlarıyla kısmen destekler), Haskell (fonksiyonel ağırlıklı)

---

---------------------------------------------------------------------------------------------------------------------------------------

# 🌟 Advantages of OOP (OOP’nin Avantajları)

OOP (Object-Oriented Programming), karmaşık sistemleri daha kolay yönetilebilir ve sürdürülebilir hale getiren güçlü bir yaklaşımdır.
Aşağıda OOP’nin temel avantajlarını ve her birinin neden önemli olduğunu bulabilirsiniz.

---

## 🔒 1️⃣ Encapsulation (Kapsülleme)

Veri (field) ve davranışı (method) bir araya getirerek bir sınıfta toplar.
Veri, doğrudan dışarıdan erişilemez; sadece belirlenmiş arayüzler üzerinden erişilir.

✅ **Faydası:**
- Veriyi korur (data hiding).
- Nesnenin iç durumu üzerinde tam kontrol sağlar.
- Hatalı veya istenmeyen müdahaleleri engeller.

---

## ♻️ 2️⃣ Reusability (Yeniden Kullanılabilirlik)

Mevcut sınıflar ve bileşenler, başka yerlerde tekrar kullanılabilir.
Yeni sınıflar, mevcut sınıflardan türetilerek (inheritance) genişletilebilir.

✅ **Faydası:**
- Kod tekrarını azaltır.
- Daha az kod yazarak daha fazla iş yapılmasını sağlar.
- Hızlı geliştirme imkânı sunar.

---

## 🧩 3️⃣ Modularity (Modülerlik)

Kod, birbirinden bağımsız parçalara (modüllere) ayrılır.
Her sınıf kendi işinden sorumlu olur.

✅ **Faydası:**
- Bir modüldeki değişiklik diğerlerini etkilemez.
- Test etmek ve hata ayıklamak kolaylaşır.
- Ekipler farklı modüller üzerinde bağımsız çalışabilir.

---

## 📈 4️⃣ Scalability (Ölçeklenebilirlik)

Sistem büyüdükçe yeni özellikler eklemek veya mevcut yapıyı genişletmek kolaydır.

✅ **Faydası:**
- Büyük projelerde kodun karmaşıklaşması önlenir.
- Yeni gereksinimlere hızlı uyum sağlanır.
- Performans sorunlarına müdahale etmek daha kolaydır.

---

## 🔧 5️⃣ Maintainability (Bakım Kolaylığı)

Kodda hata bulmak, düzeltmek veya geliştirme yapmak daha kolaydır.
İyi tasarlanmış nesneler, değişikliklerin sınırlı alanda kalmasını sağlar.

✅ **Faydası:**
- Hata riskini azaltır.
- Bakım maliyetini düşürür.
- Ekipte yeni katılan kişiler kodu kolayca anlayabilir.

---

## 🕶 6️⃣ Abstraction (Soyutlama)

Karmaşık detaylar gizlenir; kullanıcıya sadece gerekli bilgiler sunulur.

✅ **Faydası:**
- Gereksiz karmaşayı ortadan kaldırır.
- Kullanıcının sadece ne yapılacağını bilmesi yeterlidir, nasıl yapıldığını öğrenmesi gerekmez.
- Kodun okunabilirliğini ve basitliğini artırır.

---

## 🎭 7️⃣ Flexibility & Polymorphism (Esneklik ve Çok Biçimlilik)

Aynı arayüz veya method adı, farklı sınıflarda farklı şekillerde çalışabilir.

✅ **Faydası:**
- Çalışma zamanında (runtime) doğru davranış seçilebilir.
- Ortak arayüzlerle esnek ve genişletilebilir mimariler kurulabilir.
- Kodun farklı senaryolarda uyarlanabilmesi kolaylaşır.

---------------------------------------------------------------------------------------------------------------------------------------

# 🔒 Encapsulation (Kapsülleme)

## 📖 Nedir?

Encapsulation, bir sınıfın verilerini (fields) ve bu verilere erişimi sağlayan davranışlarını (methods) bir araya toplar.
Amaç, **veriyi korumak (data hiding)** ve nesnenin dışarıdan kontrolsüz şekilde değiştirilmesini engellemektir.

Kullanıcı sadece sınıfın sunduğu arayüzleri (public methods/properties) kullanarak işlem yapabilir, iç detaylara erişemez.
Bu, hem **güvenlik sağlar** hem de sistemin kararlılığını artırır.

---

## 💡 Avantajları

✅ Verinin yanlış kullanılmasını engeller.
✅ Sınıf içindeki değişiklikler dışarıyı etkilemeden yapılabilir.
✅ İyi tanımlanmış arayüzler sayesinde sistem daha okunabilir ve bakımı kolay olur.

---

## 🧩 Örnek 1 — Private Field ve Public Method ile

```csharp
public class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
```

👉 Açıklama: balance değişkenine doğrudan erişim yok; sadece Deposit ve GetBalance metoduyla işlem yapılabilir.

## 🧩 Örnek 2 — Property ile Validation

```csharp
public class Person
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
                age = value;
        }
    }
}
```

👉 Açıklama: Negatif yaş atanamaz; property setter içinde validation yapılarak veri koruma sağlanır.

## 🧩 Örnek 3 — Read-Only Field

```csharp
public class Product
{
    public string Name { get; }
    public decimal Price { get; private set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void ApplyDiscount(decimal percentage)
    {
        if (percentage > 0 && percentage <= 100)
            Price -= Price * (percentage / 100);
    }
}
```

👉 Açıklama: Name sadece constructor’dan set edilir, dışarıdan değiştirilemez. Price ise sadece sınıf içinden değiştirilebilir.

---------------------------------------------------------------------------------------------------------------------------------------

# 🧬 Inheritance (Kalıtım)

## 📖 Nedir?

Inheritance, bir sınıfın (child/subclass) başka bir sınıfın (parent/superclass) özelliklerini ve davranışlarını devralmasıdır.
Bu sayede alt sınıflar, üst sınıftan gelen kodu **yeniden kullanabilir** ve gerektiğinde genişletebilir (extend).

Kalıtım, yazılımda kod tekrarını azaltır ve sınıflar arasında **“is-a” (bir türüdür)** ilişkisi kurar.

---

## 💡 Avantajları

✅ Kod tekrarını azaltır.
✅ Ortak özellik ve davranışlar üst sınıfta toplanabilir.
✅ Alt sınıflar, üst sınıfın davranışını genişletebilir veya değiştirebilir (override).

---

## 🧩 Örnek 1 — Basit Kalıtım

```csharp
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}
```

👉 **Açıklama:** `Dog`, `Animal` sınıfından miras alır ve hem `Eat` hem de kendi `Bark` metoduna sahiptir.

---

## 🧩 Örnek 2 — Virtual ve Override Kullanımı

```csharp
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows.");
    }
}
```

👉 **Açıklama:** `Cat` sınıfı, `Animal` sınıfının `Speak` metodunu kendi davranışıyla değiştirir (override).

---

## 🧩 Örnek 3 — Base Anahtar Kelimesi ile Üst Sınıf Çağırma

```csharp
public class Vehicle
{
    public virtual void Start()
    {
        Console.WriteLine("Vehicle started.");
    }
}

public class Car : Vehicle
{
    public override void Start()
    {
        base.Start();
        Console.WriteLine("Car engine is running.");
    }
}
```

👉 **Açıklama:** `Car` sınıfı, `Start` metodunu override eder ama `base.Start()` ile üst sınıfın metodunu da çağırır.

---------------------------------------------------------------------------------------------------------------------------------------

# 🎭 Polymorphism (Çok Biçimlilik)

## 📖 Nedir?

Polymorphism, aynı method veya interface’in farklı sınıflarda veya farklı bağlamlarda **farklı davranışlar** sergilemesine olanak tanır.
Bu, yazılımda **esnekliği** ve **genişletilebilirliği** artırır.

Polymorphism iki ana türde görülür:

✅ **Compile-time (Static) Polymorphism** → Aynı sınıf içinde aynı method adının farklı parametrelerle aşırı yüklenmesi (**overloading**).
✅ **Runtime (Dynamic) Polymorphism** → Üst sınıf referansının alt sınıf nesnesini işaret etmesi ve override edilmiş methodların çağrılması.

---

## 💡 Avantajları

- Kodun esnekliğini artırır.
- Ortak arayüzler üzerinden farklı davranışlar sağlayabilir.
- Sistem büyüdükçe yeni türleri kolayca entegre etmeyi mümkün kılar.

---

## 🧩 Örnek 1 — Runtime Polymorphism (Override Kullanımı)

```csharp
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}
```

👉 **Açıklama:** `Animal` sınıfının `MakeSound` metodunu `Dog` sınıfı override ederek kendi davranışını tanımlar.

---

## 🧩 Örnek 2 — Üst Sınıf Referansı ile Alt Sınıf Nesnesi

```csharp
Animal animal = new Dog();
animal.MakeSound();  // Output: Dog barks.
```

👉 **Açıklama:** `Animal` referansı, çalışma zamanında (`runtime`) `Dog` nesnesini işaret eder ve doğru method çağrılır (dynamic dispatch).

---

## 🧩 Örnek 3 — Compile-time Polymorphism (Method Overloading)

```csharp
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}
```

👉 **Açıklama:** Aynı sınıfta aynı method adı (`Add`) farklı parametre setleriyle tanımlanabilir.
Bu compile-time polymorphism olarak adlandırılır ve aşırı yükleme (overloading) ile sağlanır.

---------------------------------------------------------------------------------------------------------------------------------------

# 🕶 Abstraction (Soyutlama)

## 📖 Nedir?

Abstraction, bir nesnenin veya sistemin **karmaşık detaylarını gizleyip** dışarıya yalnızca önemli özelliklerini ve davranışlarını sunmasıdır.
Bu, kullanıcıların veya diğer sistemlerin iç mekanizmayı bilmeden sınıfı kullanabilmesini sağlar.

Abstraction genellikle **abstract sınıflar** veya **interface’ler** kullanılarak uygulanır.
Bu sayede, belirli bir işlevin **nasıl** yapıldığı değil, sadece **ne** yaptığı ön planda tutulur.

---

## 💡 Avantajları

- Karmaşık sistemleri sadeleştirir.
- Kullanıcıyı gereksiz detaylardan korur.
- Daha temiz, kolay anlaşılır kod yapısı sağlar.
- Değişiklikler yapıldığında dışarı bağımlılığı azaltır.

---

## 🧩 Örnek 1 — Abstract Sınıf Kullanarak

```csharp
public abstract class Animal
{
    public abstract void MakeSound();
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}
```

👉 **Açıklama:** `Animal` sınıfı soyuttur ve doğrudan nesnesi oluşturulamaz. `Dog` sınıfı bu soyut sınıftan türeyerek `MakeSound` metodunu somutlaştırır.

---------------------------------------------------------------------------------------------------------------------------------------

# 🔗 Interface (Arayüzler)

## 📖 Nedir?

Interface, bir sınıfın **hangi yeteneklere sahip olacağını tanımlayan bir sözleşme** veya şablondur.
Yani, bir sınıfa “şunları yapmalısın” der, **nasıl yapacağını** söylemez.

Interface’ler:
- **Sadece method ve property imzalarını** (signature) içerir, implementasyon içermez.
- Bir sınıf birden fazla interface’i implemente edebilir.
- Soyutlamayı ve esnekliği artırır, bağımlılıkları azaltır.

---

## 💡 Avantajları

- Ortak bir kontrat tanımlar, farklı sınıflar bu kurala göre çalışır.
- Kodun genişletilebilirliğini ve test edilebilirliğini artırır.
- Birden fazla interface ile çoklu yetenek kazandırılabilir.
- Dependency Injection ve DIP (Dependency Inversion Principle) gibi prensiplerin temelidir.

---

## 🧩 Örnek 1 — Basit Interface Kullanımı

```csharp
public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Logging to file: " + message);
    }
}
```

👉 **Açıklama:** `ILogger` bir kontrattır; `FileLogger` sınıfı bu kontratı uygulayarak kendi loglama davranışını tanımlar.

---

## 🧩 Örnek 2 — Birden Fazla Interface Implement Etmek

```csharp
public interface IWorker
{
    void Work();
}

public interface IManager
{
    void Manage();
}

public class TeamLead : IWorker, IManager
{
    public void Work()
    {
        Console.WriteLine("TeamLead is working.");
    }

    public void Manage()
    {
        Console.WriteLine("TeamLead is managing.");
    }
}
```

👉 **Açıklama:** `TeamLead` sınıfı hem `IWorker` hem de `IManager` arayüzlerini uygulayarak iki farklı yeteneği birleştirir.

---------------------------------------------------------------------------------------------------------------------------------------

# 🏗 Generic Class ve Static Class

## 📖 Generic Class (Jenerik Sınıf) Nedir?

Generic class, **farklı veri tipleriyle çalışabilen**, tip bağımsız (type-agnostic) sınıflardır.
Bir class veya method tanımlarken `T` gibi yer tutucular kullanırız, hangi tip ile çalışacağı kullanım sırasında belirlenir.

---

## 💡 Generic Class Avantajları

- Kod tekrarını azaltır (aynı kod farklı tiplerle çalışır).
- Tür güvenliği sağlar (type-safe).
- Performanslıdır; casting veya boxing/unboxing gerektirmez.

---

## 🧩 Örnek 1 — Basit Generic Class

```csharp
public class Box<T>
{
    public T Value { get; set; }
}
```

👉 **Açıklama:** `Box` sınıfı, içine `int`, `string`, `bool` vb. herhangi bir tip alabilir.

---

## 🧩 Örnek 2 — Generic Method ile

```csharp
public class MathHelper
{
    public T GetDefault<T>()
    {
        return default(T);
    }
}
```

👉 **Açıklama:** `GetDefault` metodu, verilen tip için default değer döner (`null`, `0`, `false` gibi).

---

## 🧩 Örnek 3 — Generic Constraint (Kısıtlama) Kullanımı

```csharp
public class Repository<T> where T : class
{
    public void Add(T entity)
    {
        Console.WriteLine("Entity added.");
    }
}
```

👉 **Açıklama:** `Repository`, sadece referans tiplerle (`class`) çalışabilir; primitive tipler (`int`, `bool` vb.) bu generic’e verilemez.

---

## 📖 Static Class (Statik Sınıf) Nedir?

Static class, **sadece statik üyeler** (methodlar, property’ler) barındırır ve asla bir nesnesi (instance) oluşturulamaz.
Genellikle yardımcı (helper) veya araç (utility) sınıflar olarak kullanılır.

---

## 💡 Static Class Avantajları

- Global mantık ve işlemler için merkezi bir yer sağlar.
- Bellekte tek bir kopya tutulur.
- Nesne oluşturmadan doğrudan kullanılabilir.

---

## 🧩 Örnek 1 — Basit Static Class

```csharp
public static class MathHelper
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}
```

👉 **Açıklama:** `MathHelper` sınıfı nesne oluşturulmadan doğrudan `MathHelper.Add()` şeklinde çağrılır.

---

## 🧩 Örnek 2 — Statik Property Kullanımı

```csharp
public static class Config
{
    public static string ApplicationName { get; set; } = "MyApp";
}
```

👉 **Açıklama:** `ApplicationName` değişkenine nesne oluşturmadan erişilir ve değiştirilir.

---

## 🧩 Örnek 3 — Statik Constructor

```csharp
public static class Logger
{
    static Logger()
    {
        Console.WriteLine("Logger initialized.");
    }

    public static void Log(string message)
    {
        Console.WriteLine(message);
    }
}
```

👉 **Açıklama:** `Logger` sınıfının static constructor’ı uygulama başladığında bir kere çalışır.

---------------------------------------------------------------------------------------------------------------------------------------

# 🏛 SOLID Prensipleri

---

## 🔹 S — Single Responsibility Principle (SRP)

### 📖 Nedir?
Bir sınıfın **yalnızca tek bir sorumluluğu** olmalı ve sadece o sorumlulukla ilgili değişikliklerden etkilenmelidir.

---

### ❌ Kötü Örnek

```csharp
public class Report
{
    public void GenerateReport() { /* rapor oluştur */ }
    public void SaveToFile() { /* dosyaya kaydet */ }
}
```

👉 **Sorun:** Hem rapor oluşturma hem dosyaya kaydetme sorumluluğu var; iki iş bir sınıfa yüklenmiş.

---

### ✅ İyi Örnek

```csharp
public class ReportGenerator
{
    public void GenerateReport() { /* rapor oluştur */ }
}

public class FileSaver
{
    public void Save(string content) { /* dosyaya kaydet */ }
}
```

👉 **Çözüm:** Her sınıfın tek sorumluluğu var; görevler ayrılmış.

---

## 🔹 O — Open/Closed Principle (OCP)

### 📖 Nedir?
Bir sınıf **geliştirmeye açık**, **değişikliğe kapalı** olmalıdır.

---

### ❌ Kötü Örnek

```csharp
public class DiscountCalculator
{
    public double CalculateDiscount(string customerType)
    {
        if (customerType == "Regular") return 0.1;
        if (customerType == "VIP") return 0.2;
        return 0;
    }
}
```

👉 **Sorun:** Yeni müşteri tipi eklersen kodu değiştirmek zorundasın.

---

### ✅ İyi Örnek

```csharp
public interface IDiscount
{
    double GetDiscount();
}

public class RegularDiscount : IDiscount
{
    public double GetDiscount() => 0.1;
}

public class VipDiscount : IDiscount
{
    public double GetDiscount() => 0.2;
}

public class DiscountCalculator
{
    public double CalculateDiscount(IDiscount discount) => discount.GetDiscount(); //computed property
}
```

👉 **Çözüm:** Yeni müşteri tipi eklemek için sadece yeni sınıf yazılır; mevcut kod değişmez.

---

## 🔹 L — Liskov Substitution Principle (LSP)

### 📖 Nedir?
Türetilmiş sınıflar, base sınıfların yerine **sorunsuzca** kullanılabilmelidir.

---

### ❌ Kötü Örnek

```csharp
public class Bird
{
    public virtual void Fly() { }
}

public class Penguin : Bird
{
    public override void Fly() { throw new NotSupportedException(); }
}
```

👉 **Sorun:** Penguin, Bird yerine geçtiğinde uygulama hata verir.

---

### ✅ İyi Örnek

```csharp
public abstract class Bird { }

public interface IFlyable
{
    void Fly();
}

public class Sparrow : Bird, IFlyable
{
    public void Fly() { }
}

public class Penguin : Bird
{
    // Uçamaz, IFlyable'ı implement etmez.
}
```

👉 **Çözüm:** Sadece uçabilen kuşlar IFlyable’ı uygular; yerine geçme problemi kalmaz.

---

## 🔹 I — Interface Segregation Principle (ISP)

### 📖 Nedir?
Kullanıcılar **kullanmayacakları methodlara** bağımlı olmamalıdır; arayüzler küçük ve özelleşmiş olmalıdır.

---

### ❌ Kötü Örnek

```csharp
public interface IMachine
{
    void Print();
    void Scan();
}

public class SimplePrinter : IMachine
{
    public void Print() { }
    public void Scan() { throw new NotImplementedException(); }
}
```

👉 **Sorun:** SimplePrinter tarama yapmaz ama interface yüzünden Scan implement etmek zorunda.

---

### ✅ İyi Örnek

```csharp
public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public class SimplePrinter : IPrinter
{
    public void Print() { }
}
```

👉 **Çözüm:** Gereksiz bağımlılıklar yok; her sınıf sadece ihtiyacı olan interface’i uygular.

---

## 🔹 D — Dependency Inversion Principle (DIP)

### 📖 Nedir?
Üst seviye modüller, alt seviye detaylara bağlı olmamalıdır; her ikisi de **soyutlamalara** bağlı olmalıdır.

---

### ❌ Kötü Örnek

```csharp
public class EmailSender
{
    public void Send(string message) { }
}

public class Notification
{
    private EmailSender _emailSender = new EmailSender();
    public void Notify(string message) => _emailSender.Send(message);
}
```

👉 **Sorun:** Notification doğrudan EmailSender’a bağımlı; başka bir mesaj tipi eklemek zordur.

---

### ✅ İyi Örnek (Dependency Injection ile)

```csharp
public interface IMessageSender
{
    void Send(string message);
}

public class EmailSender : IMessageSender
{
    public void Send(string message) { }
}

public class Notification
{
    private readonly IMessageSender _sender;

    public Notification(IMessageSender sender)
    {
        _sender = sender;
    }

    public void Notify(string message) => _sender.Send(message);
}
```

👉 **Çözüm:** Notification sadece arayüze bağlı; EmailSender veya SmsSender gibi farklı implementasyonlar kullanılabilir.
Bu yapı **Dependency Injection** ile arayüzü dışarıdan geçirerek sağlanır.

---

## 💡 Dependency Injection Nedir?

Dependency Injection (DI), bir sınıfın bağımlılıklarını kendi içinde yaratmak yerine **dışarıdan enjekte etme** yöntemidir.
Bu, Dependency Inversion Principle’ın uygulanmasını kolaylaştırır.

✅ Avantajlar:
- Test edilebilirlik artar.
- Esneklik sağlanır (örneğin mock nesneler kolayca eklenir).
- Bağımlılıklar gevşer.

---------------------------------------------------------------------------------------------------------------------------------------

# 📚 What is the Design Pattern?

### 📖 Tanım

Design Pattern (Tasarım Deseni), yazılım geliştirmede sık karşılaşılan problemler için **tekrar edilebilir, kanıtlanmış ve genel çözümler** sunan bir yaklaşımdır.
Bu desenler belirli bir dil veya framework'e özgü değildir; evrensel konseptlerdir.

Bir tasarım deseni, **nasıl bir çözüm uygulayacağımızı** tarif eder, doğrudan kod değildir.
Yani tasarım desenleri birer "şablon" gibidir: problem tipine uygun olanı seçer, kodunu ona göre şekillendirirsin.

## 📗 Popüler Kitaplar

En meşhur başvuru kaynağı:
- **"Design Patterns: Elements of Reusable Object-Oriented Software"** (Gang of Four, 1994)
  Yazarlar: Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides
  Yazılım dünyasında “GoF” (Gang of Four) kitabı olarak bilinir ve bugün hâlâ temel referans kabul edilir.

Bu kitapta desenler 3 ana kategoriye ayrılır:
### 🏗 Creational Patterns (Yaratımsal Desenler)

Amaç: Nesne yaratma sürecini esnek ve bağımsız hale getirmek.

- Singleton
- Factory Method
- Abstract Factory
- Builder
- Prototype

---

### 🏛 Structural Patterns (Yapısal Desenler)

Amaç: Sınıflar ve nesneler arasındaki ilişkileri ve yapılarını düzenlemek.

- Adapter
- Bridge
- Composite --
- Decorator
- Facade
- Flyweight
- Proxy

---

### 🎭 Behavioral Patterns (Davranışsal Desenler)

Amaç: Nesneler arası iletişim ve sorumluluk paylaşımını düzenlemek.

- Chain of Responsibility
- Command
- Interpreter
- Iterator
- Mediator
- Memento
- Observer
- State
- Strategy
- Template Method
- Visitor
---

# 🚫 What is the Anti-Pattern?

## 📖 Tanım

Anti-Pattern, yazılım geliştirmede **ilk bakışta iyi veya işe yarar gibi görünen**, ancak uzun vadede sorunlara, zorluklara veya kötü sonuçlara yol açan çözümler veya yaklaşımlardır.

Anti-pattern’ler genellikle:
- Tecrübesizlikle yapılan yanlış tercihler
- Kötü tasarım kararları
- Gereksiz karmaşıklaştırmalar
- İhmal edilen bakım veya refaktör ihtiyacı

Anti-pattern’leri tanımak, yazılım kalitesini artırmada kritik öneme sahiptir.
Çünkü bir anti-pattern’i düzeltmek, genellikle ciddi refaktör veya yeniden tasarım gerektirir.

---------------------------------------------------------------------------------------------------------------------------------------

## Design Patterns: https://refactoring.guru/

---------------------------------------------------------------------------------------------------------------------------------------

# 🏗 Singleton Pattern

## 📖 Nedir?

Singleton Pattern, bir sınıfın **yalnızca bir tane örneğe (instance)** sahip olmasını ve bu örneğe uygulamanın her yerinden erişilebilmesini sağlar.
Bu desen, global bir nesne ihtiyacı olduğunda veya paylaşılan kaynakların (örneğin bir log sistemi, konfigürasyon yöneticisi, bağlantı havuzu) yönetiminde kullanılır.

---

## 💡 Ne Zaman Kullanılır?

- Uygulama genelinde **tek bir nokta** olması gereken durumlarda.
- Kaynakların tekrarlanan nesne oluşturulmasıyla boşa harcanmasını engellemek için.
- Paylaşılan bir yapı veya durum kontrolü gerektiğinde.

---

## 🛑 Sorun Örneği (Singleton Olmadan)

Sen bir uygulama loglama sistemi yazıyorsun. Her sınıf, ihtiyacı olduğunda kendi `Logger` nesnesini oluşturuyor:

```csharp
public class Logger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

public class SomeService
{
    private Logger _logger = new Logger();

    public void DoWork()
    {
        _logger.Log("Work started.");
    }
}

public class AnotherService
{
    private Logger _logger = new Logger();

    public void Run()
    {
        _logger.Log("Running.");
    }
}
```

👉 **Sorun:** Her sınıf kendi `Logger` nesnesini yaratıyor → hem kaynak israfı hem de loglar merkezi yönetilemiyor.

---

## ✅ Singleton ile Çözüm

```csharp
public class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new object();

    private Logger() { }

    public static Logger Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                    _instance = new Logger();
                return _instance;
            }
        }
    }

    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

public class SomeService
{
    public void DoWork()
    {
        Logger.Instance.Log("Work started.");
    }
}

public class AnotherService
{
    public void Run()
    {
        Logger.Instance.Log("Running.");
    }
}
```

👉 **Çözüm:** `Logger` sınıfı sadece bir kez oluşturulur (`_instance`); herkes `Logger.Instance` üzerinden aynı nesneyi kullanır.

---

---------------------------------------------------------------------------------------------------------------------------------------

# 🏭 Factory Method Pattern

## 📖 Nedir?

Factory Method Pattern, nesne yaratma (object creation) işini doğrudan sınıfın içinde yapmak yerine, bu iş için bir **factory (fabrika) methodu** kullanarak alt sınıflara bırakır.
Amaç, kodun yaratım detaylarına bağlı kalmamasını sağlamak ve yeni türler eklenirken mevcut kodu değiştirmek zorunda kalmamaktır.

---

## 💡 Ne Zaman Kullanılır?

- Hangi sınıfın (veya nesnenin) yaratılacağının çalışma zamanında (runtime) belirlendiği durumlarda.
- Yeni tipler eklenirken mevcut sınıfları değiştirmek yerine genişletmek (Open/Closed Principle).
- Karmaşık nesne yaratımlarını merkezi bir yere toplamak.

---

## 🛑 Sorun Örneği (Factory Method Olmadan)

Sen bir bildirim sistemi yazıyorsun. Kullanıcıya Email veya SMS göndermek istiyorsun.
Ama tüm kararlar NotificationService sınıfına sıkışmış:

```csharp
public class NotificationService
{
    public void SendNotification(string type, string message)
    {
        if (type == "Email")
        {
            Console.WriteLine("Sending email: " + message);
        }
        else if (type == "SMS")
        {
            Console.WriteLine("Sending SMS: " + message);
        }
    }
}
```

👉 **Sorun:** Yeni bir bildirim tipi (örneğin Push Notification) eklediğinde `if` bloklarına müdahale etmen gerekir → değişikliğe kapalı değil.

---

## ✅ Factory Method ile Çözüm

```csharp
public interface INotification
{
    void Send(string message);
}

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Sending email: " + message);
    }
}

public class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Sending SMS: " + message);
    }
}

public abstract class NotificationFactory
{
    public abstract INotification CreateNotification();
}

public class EmailNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification()
    {
        return new EmailNotification();
    }
}

public class SmsNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification()
    {
        return new SmsNotification();
    }
}

// Kullanım
NotificationFactory factory = new EmailNotificationFactory();
INotification notification = factory.CreateNotification();
notification.Send("Hello!");
```

👉 **Çözüm:** Yeni bildirim türü eklemek için sadece yeni bir sınıf ve fabrika yazılır; mevcut kod değiştirilmez.

---------------------------------------------------------------------------------------------------------------------------------------

# 🏭 Abstract Factory Pattern

## 📖 Nedir?

Abstract Factory Pattern, ilişkili veya birbiriyle bağlantılı nesne ailelerini **belirli sınıflarını belirtmeden** yaratmamızı sağlayan bir desendir.
Factory Method Pattern bir tür nesne yaratırken, Abstract Factory birden fazla ilgili nesne türünü birlikte yaratır.

Bu desen, ürün gruplarının (örneğin: GUI widget’ları, platforma bağlı bileşenler) farklı implementasyonlarını kolayca değiştirmeyi sağlar.

---

## 💡 Ne Zaman Kullanılır?

- Birbirine bağımlı, ilişkili nesneleri bir arada yaratmanız gerektiğinde.
- Çalışma zamanında (runtime) hangi ürün ailesini kullanacağınızı seçmeniz gerektiğinde.
- Kodun platform bağımsız olmasını veya farklı sürümlere uyumlu olmasını istediğinizde.

---

## 🛑 Sorun Örneği (Abstract Factory Olmadan)

Sen bir arayüz (UI) kütüphanesi geliştiriyorsun. Hem Windows hem Mac için Button ve Checkbox nesneleri yaratıyorsun.
Ama yaratım işini NotificationService benzeri if-else’lerle yapıyorsun:

```csharp
public class UIBuilder
{
    public void CreateUI(string os)
    {
        if (os == "Windows")
        {
            Console.WriteLine("Windows Button");
            Console.WriteLine("Windows Checkbox");
        }
        else if (os == "Mac")
        {
            Console.WriteLine("Mac Button");
            Console.WriteLine("Mac Checkbox");
        }
    }
}
```

👉 **Sorun:** Yeni bir platform eklemek için sürekli if-else’lere dokunmak gerekir → esnek değil, bakım zor.

---

## ✅ Abstract Factory ile Çözüm

```csharp
public interface IButton
{
    void Render();
}

public interface ICheckbox
{
    void Render();
}

public class WindowsButton : IButton
{
    public void Render() => Console.WriteLine("Windows Button");
}

public class MacButton : IButton
{
    public void Render() => Console.WriteLine("Mac Button");
}

public class WindowsCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Windows Checkbox");
}

public class MacCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Mac Checkbox");
}

public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}

public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ICheckbox CreateCheckbox() => new WindowsCheckbox();
}

public class MacFactory : IGUIFactory
{
    public IButton CreateButton() => new MacButton();
    public ICheckbox CreateCheckbox() => new MacCheckbox();
}

// Kullanım
IGUIFactory factory = new WindowsFactory();
IButton button = factory.CreateButton();
ICheckbox checkbox = factory.CreateCheckbox();
button.Render();
checkbox.Render();
```

👉 **Çözüm:** Yeni platform eklemek için sadece yeni factory ve ürün sınıfı yazılır; mevcut kod değiştirilmez.

---------------------------------------------------------------------------------------------------------------------------------------



# 🏗 Builder Pattern

## 📖 Nedir?

Builder Pattern, karmaşık nesneleri **parça parça ve adım adım** inşa etmek için kullanılan bir tasarım desenidir.
Amaç, nesnenin oluşturma mantığını nesnenin kendisinden ayırmak ve farklı konfigürasyonlarda nesne yaratmayı kolaylaştırmaktır.

Bu desen, özellikle:
- Çok fazla constructor parametresi olduğunda,
- Nesnenin farklı varyasyonları veya opsiyonel bileşenleri varsa kullanışlıdır.

---

## 💡 Ne Zaman Kullanılır?

- Karmaşık nesnelerin okunabilir ve esnek şekilde oluşturulması gerektiğinde.
- Fluent API (zincirleme çağrı) stili isteniyorsa.
- Aynı oluşturma sürecinden farklı türde nesneler çıkarılabiliyorsa.

---

## 🛑 Sorun Örneği (Builder Pattern Olmadan)

Sen bir `House` sınıfı yaratıyorsun.
Ama her house için constructor çok karmaşık:

```csharp
public class House
{
    public House(int windows, int doors, bool hasGarage, bool hasSwimmingPool)
    {
        // ...
    }
}

// Kullanım
var house = new House(4, 2, true, false);
```

👉 **Sorun:** Parametreler büyüdükçe çağrı okunmaz hale gelir; hangi parametre neyi temsil ediyor belirsizleşir.

---

## ✅ Builder Pattern ile Çözüm

```csharp
public class House
{
    public int Windows { get; set; }
    public int Doors { get; set; }
    public bool HasGarage { get; set; }
    public bool HasSwimmingPool { get; set; }

    public override string ToString()
    {
        return $"House with {Windows} windows, {Doors} doors, Garage: {HasGarage}, Pool: {HasSwimmingPool}";
    }
}

public class HouseBuilder
{
    private House _house = new House();

    public HouseBuilder SetWindows(int count)
    {
        _house.Windows = count;
        return this;
    }

    public HouseBuilder SetDoors(int count)
    {
        _house.Doors = count;
        return this;
    }

    public HouseBuilder SetGarage(bool hasGarage)
    {
        _house.HasGarage = hasGarage;
        return this;
    }

    public HouseBuilder SetSwimmingPool(bool hasPool)
    {
        _house.HasSwimmingPool = hasPool;
        return this;
    }

    public House Build()
    {
        return _house;
    }
}

// Kullanım
var builder = new HouseBuilder();
var house = builder.SetWindows(4)
                   .SetDoors(2)
                   .SetGarage(true)
                   .SetSwimmingPool(false)
                   .Build();

Console.WriteLine(house);
```

👉 **Çözüm:** Okunabilir, esnek ve sıralı bir nesne yaratma süreci sağlanır.

---------------------------------------------------------------------------------------------------------------------------------------

# 🌀 Prototype Pattern

## 📖 Nedir?

Prototype Pattern, mevcut bir nesnenin bir **kopyasını (clone)** çıkararak yeni nesneler yaratmamıza olanak tanır.
Bu sayede, nesneyi sıfırdan yaratmak yerine hızlıca çoğaltabiliriz.

Bu desen genellikle:
- Nesne yaratımı pahalı (maliyetli) olduğunda,
- Karmaşık nesne konfigürasyonlarını kopyalamak gerektiğinde,
- Farklı durumlara göre küçük değişikliklerle klonlanmış nesneler isteniyorsa kullanılır.

---

## 💡 Ne Zaman Kullanılır?

- Aynı tipte birçok nesne gerektiğinde, her seferinde yeniden oluşturmak yerine kopyalamak için.
- Nesnelerin yaratılması yerine, mevcut bir nesne örneğinden varyasyonlar çıkarmak için.
- Prototype nesneleri çalışma zamanında belirlenecekse.

---

## 🛑 Sorun Örneği (Prototype Pattern Olmadan)

Bir `Document` sınıfın var, her defasında yeni bir doküman yaratırken tüm ayarları baştan yapmak gerekiyor:

```csharp
public class Document
{
    public string Content { get; set; }
    public string Font { get; set; }
    public int FontSize { get; set; }
}

// Kullanım
var doc1 = new Document { Content = "Hello", Font = "Arial", FontSize = 12 };
var doc2 = new Document { Content = "Hello", Font = "Arial", FontSize = 13 };
```

👉 **Sorun:** Her nesne için tekrar tekrar tüm özellikleri set etmek gerekiyor → zaman ve hata maliyeti artar.

---

## ✅ Prototype Pattern ile Çözüm

```csharp
public interface IPrototype<T>
{
    T Clone();
}

public class Document : IPrototype<Document>
{
    public string Content { get; set; }
    public string Font { get; set; }
    public int FontSize { get; set; }

    public Document Clone()
    {
        return (Document)this.MemberwiseClone(); //MemberwiseClone() → shallow copy yapar, yani içteki referansları koparmaz.
    }
}

// Kullanım
var originalDoc = new Document { Content = "Hello", Font = "Arial", FontSize = 12 };
var clonedDoc = originalDoc.Clone();
clonedDoc.Content = "Hi!";

Console.WriteLine(originalDoc.Content); // Çıktı: Hello
Console.WriteLine(clonedDoc.Content);   // Çıktı: Hi!
```

👉 **Çözüm:** `originalDoc` nesnesi klonlanarak yeni bir nesne çıkarılır; tekrarlı set işlemleri yapılmaz.

---------------------------------------------------------------------------------------------------------------------------------------

# 🔄 State Pattern

## 📖 Nedir?

State Pattern, bir nesnenin **iç durumu** değiştikçe davranışını da değiştirmesini sağlar.
Yani nesnenin davranışı, o anki **state (durum)** nesnesine bağlıdır.
Bu desen, çok fazla `if-else` veya `switch` içeren kodlarda, bu kontrol akışını daha temiz ve sürdürülebilir hale getirir.

---

## 💡 Ne Zaman Kullanılır?

- Nesne birden fazla duruma sahip ve bu durumlara göre farklı davranışlar göstermesi gerekiyorsa.
- `if-else` veya `switch` blokları kodu karmaşıklaştırıyorsa.
- Nesne, durumlar arası kolayca geçiş yapabilmeli ve bu durumların kendi sorumlulukları olmalı.

---

## 🛑 Sorun Örneği (State Pattern Olmadan)

Bir `Document` sınıfın var. Durumu Draft, Moderation veya Published olabilir.
Ama davranışlar `if-else` zincirine sıkışmış:

```csharp
public class Document
{
    public string State { get; set; }

    public void Publish()
    {
        if (State == "Draft")
            Console.WriteLine("Moving to moderation.");
        else if (State == "Moderation")
            Console.WriteLine("Publishing document.");
        else
            Console.WriteLine("Already published.");
    }
}
```

👉 **Sorun:** Durumlar arttıkça veya değiştikçe `if-else` kabarıyor; sorumluluklar Document sınıfında dağınık.

---

## ✅ State Pattern ile Çözüm

```csharp
public class Document
{
    public IDocumentState State { get; set; }

    public Document()
    {
        State = new DraftState();
    }

    public void Publish()
    {
        State.Publish(this);
    }
}

public interface IDocumentState
{
    void Publish(Document doc);
}

public class DraftState : IDocumentState
{
    public void Publish(Document doc)
    {
        Console.WriteLine("Moving to moderation.");
        doc.State = new ModerationState();
    }
}

public class ModerationState : IDocumentState
{
    public void Publish(Document doc)
    {
        Console.WriteLine("Publishing document.");
        doc.State = new PublishedState();
    }
}

public class PublishedState : IDocumentState
{
    public void Publish(Document doc)
    {
        Console.WriteLine("Already published.");
    }
}

// Kullanım
var doc = new Document();
doc.Publish(); // Moving to moderation.
doc.Publish(); // Publishing document.
doc.Publish(); // Already published.
```

👉 **Çözüm:** Her durum kendi davranışını kapsüller; Document sınıfı sadece `State.Publish(this)` der → esnek ve temiz bir yapı.

---------------------------------------------------------------------------------------------------------------------------------------

# 👀 Observer Pattern

## 📖 Nedir?

Observer Pattern, bir nesnenin durumunda bir değişiklik olduğunda, bu değişiklikten haberdar edilmesi gereken diğer nesneleri (observer/aboneler) otomatik bilgilendiren bir tasarım desenidir.
Yani bir nesne değiştiğinde, ona bağlı tüm izleyicilere bildirim gönderilir.

---

## 💡 Ne Zaman Kullanılır?

- Nesneler arası **birden fazla bağımlı** ilişki olduğunda.
- Durum değişimlerini manuel olarak takip etmek yerine **otomatik bildirim** akışı sağlanmak istendiğinde.
- Event (olay) tabanlı veya yayıncı-abone (publisher-subscriber) mimarisi gerektiğinde.

---

## 🛑 Sorun Örneği (Observer Pattern Olmadan)

Bir `WeatherStation` sınıfın var ve ekranlar bu sınıftan hava durumu bilgisi çekiyor.
Ama her ekran sürekli station’a gelip veri sorgulamak zorunda:

```csharp
public class WeatherStation
{
    public int Temperature { get; set; }
}

public class Display
{
    private WeatherStation _station;

    public Display(WeatherStation station)
    {
        _station = station;
    }

    public void Show()
    {
        Console.WriteLine($"Temperature: {_station.Temperature}");
    }
}
```

👉 **Sorun:** Her ekran sürekli manuel olarak `Show()` çağırmalı; WeatherStation güncellendiğinde ekranlar otomatik haberdar olmuyor.

---

## ✅ Observer Pattern ile Çözüm

```csharp
public interface IObserver
{
    void Update(int temperature);
}

public class Display : IObserver
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

public class WeatherStation
{
    private List<IObserver> _observers = new List<IObserver>();
    private int _temperature;

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void SetTemperature(int temperature)
    {
        _temperature = temperature;
        NotifyObservers();
    }

    private void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_temperature);
        }
    }
}

// Kullanım
var station = new WeatherStation();
var display1 = new Display("Main");
var display2 = new Display("Secondary");

station.AddObserver(display1);
station.AddObserver(display2);

station.SetTemperature(25);
// Çıktı:
// Main Display: Temperature is now 25
// Secondary Display: Temperature is now 25
```

👉 **Çözüm:** WeatherStation değiştiğinde bağlı tüm observer’lar otomatik haberdar olur.

---------------------------------------------------------------------------------------------------------------------------------------

# 🎯 Strategy Pattern

## 📖 Nedir?

Strategy Pattern, bir işlemin veya algoritmanın farklı varyasyonlarını **runtime (çalışma anında)** seçip uygulamamızı sağlayan bir tasarım desenidir.
Bu desen, değiştirilebilir algoritmaları veya davranışları kapsüller ve birbirinin yerine geçebilir hale getirir.

---

## 💡 Ne Zaman Kullanılır?

- Aynı iş için birden fazla algoritma varsa (örneğin: sıralama, ödeme yöntemi, indirim hesaplama).
- Kullanıcı veya koşullara göre algoritma seçiminde esneklik gerekiyorsa.
- `if-else` veya `switch` blokları artıyorsa, bunları temizleyip stratejiye devretmek için.

---

## 🛑 Sorun Örneği (Strategy Pattern Olmadan)

Bir ödeme sistemi yazıyorsun. Kullanıcılar kredi kartı veya PayPal ile ödeme yapabiliyor, ama ödeme mantığı sıkışık:

```csharp
public class PaymentService
{
    public void Pay(string method)
    {
        if (method == "CreditCard")
            Console.WriteLine("Paying with credit card.");
        else if (method == "PayPal")
            Console.WriteLine("Paying with PayPal.");
    }
}
```

👉 **Sorun:** Yeni ödeme yöntemi eklemek için sınıfı sürekli değiştirmek gerekiyor → genişlemeye kapalı, esnek değil.

---

## ✅ Strategy Pattern ile Çözüm

```csharp
public interface IPaymentStrategy
{
    void Pay();
}

public class CreditCardPayment : IPaymentStrategy
{
    public void Pay()
    {
        Console.WriteLine("Paying with credit card.");
    }
}

public class PayPalPayment : IPaymentStrategy
{
    public void Pay()
    {
        Console.WriteLine("Paying with PayPal.");
    }
}

public class PaymentContext
{
    private IPaymentStrategy _paymentStrategy;

    public PaymentContext(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void ExecutePayment()
    {
        _paymentStrategy.Pay();
    }
}

// Kullanım
var context = new PaymentContext(new CreditCardPayment());
context.ExecutePayment(); // Çıktı: Paying with credit card.

context = new PaymentContext(new PayPalPayment());
context.ExecutePayment(); // Çıktı: Paying with PayPal.
```

👉 **Çözüm:** Algoritmalar (stratejiler) kapsüllenmiştir; PaymentService değişmez, sadece uygun strateji enjekte edilir.

---------------------------------------------------------------------------------------------------------------------------------------

# 🕹 Command Pattern

## 📖 Nedir?

Command Pattern, bir isteği (request) veya işlemi bir nesne (command) olarak paketleyip, bu isteği başka nesnelere parametre olarak geçmemizi, kuyruklamamızı veya geri alabilir (undoable) hale getirmemizi sağlayan bir tasarım desenidir.
Yani “ne yapılacağı” ve “nasıl yapılacağı” ayrılır.

---

## 💡 Ne Zaman Kullanılır?

- İstekleri nesne şeklinde temsil etmek istiyorsan.
- İstekleri bir sırada biriktirip sırayla çalıştırmak gerekiyorsa.
- Geri alma (undo) veya yeniden yapma (redo) yeteneği gerekiyorsa.
- İşlem gönderen (invoker) ve işlem yapan (receiver) nesneleri gevşek bağlı hale getirmek istiyorsan.

---

## 🛑 Sorun Örneği (Command Pattern Olmadan)

Bir `RemoteControl` sınıfın var ve ışık açma/kapatma işlevi doğrudan burada kodlanmış:

```csharp
public class RemoteControl
{
    public void PressButton(string action)
    {
        if (action == "ON")
            Console.WriteLine("Light is ON");
        else if (action == "OFF")
            Console.WriteLine("Light is OFF");
    }
}
```

👉 **Sorun:** Yeni cihaz veya işlem eklemek için sürekli `RemoteControl` sınıfına müdahale etmek gerekiyor → esnek değil, büyüyemez.

---

## ✅ Command Pattern ile Çözüm

```csharp
public interface ICommand
{
    void Execute();
}

public class Light
{
    public void On() => Console.WriteLine("Light is ON");
    public void Off() => Console.WriteLine("Light is OFF");
}

public class LightOnCommand : ICommand
{
    private Light _light;

    public LightOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.On();
    }
}

public class LightOffCommand : ICommand
{
    private Light _light;

    public LightOffCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.Off();
    }
}

public class RemoteControl
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
var light = new Light();
var remote = new RemoteControl();

remote.SetCommand(new LightOnCommand(light));
remote.PressButton(); // Çıktı: Light is ON

remote.SetCommand(new LightOffCommand(light));
remote.PressButton(); // Çıktı: Light is OFF
```

👉 **Çözüm:** Her işlem (command) nesne olarak temsil edilir; `RemoteControl` sadece bu nesneyi çalıştırır, ne yaptığına karışmaz.

---------------------------------------------------------------------------------------------------------------------------------------

# 🗣 Mediator Pattern

## 📖 Nedir?

Mediator Pattern, nesneler arasındaki karmaşık iletişimi **merkezi bir arabulucu (mediator)** nesnesine taşıyarak, nesnelerin doğrudan birbirine bağımlılığını azaltan bir tasarım desenidir.
Yani nesneler, doğrudan birbirleriyle haberleşmek yerine, arabulucu üzerinden haberleşir.

---

## 💡 Ne Zaman Kullanılır?

- Birbiriyle çok sayıda haberleşen nesne olduğunda (ağ gibi karmaşık yapı).
- Nesneler arası bağımlılığı azaltmak ve merkezileştirmek istediğinde.
- İletişimi merkezi bir yerden kontrol etmek gerektiğinde.

---

## 🛑 Sorun Örneği (Mediator Pattern Olmadan)

Bir chat uygulaması yazıyorsun. Kullanıcılar birbirlerine doğrudan mesaj gönderiyor:

```csharp
public class User
{
    public string Name { get; }

    public User(string name)
    {
        Name = name;
    }

    public void SendMessage(string message, User to)
    {
        Console.WriteLine($"{Name} sends '{message}' to {to.Name}");
    }
}
```

👉 **Sorun:** Her kullanıcı diğer kullanıcıların detayını bilmek zorunda → sistem büyüdükçe karmaşa artar.

---

## ✅ Mediator Pattern ile Çözüm

```csharp
public interface IChatRoom
{
    void ShowMessage(string from, string to, string message);
}

public class ChatRoom : IChatRoom
{
    public void ShowMessage(string from, string to, string message)
    {
        Console.WriteLine($"{from} sends '{message}' to {to}");
    }
}

public class User
{
    public string Name { get; }
    private IChatRoom _chatRoom;

    public User(string name, IChatRoom chatRoom)
    {
        Name = name;
        _chatRoom = chatRoom;
    }

    public void Send(string message, string to)
    {
        _chatRoom.ShowMessage(Name, to, message);
    }
}

// Kullanım
var chatRoom = new ChatRoom();
var user1 = new User("Alice", chatRoom);
var user2 = new User("Bob", chatRoom);

user1.Send("Hi Bob!", "Bob");   // Çıktı: Alice sends 'Hi Bob!' to Bob
user2.Send("Hello Alice!", "Alice"); // Çıktı: Bob sends 'Hello Alice!' to Alice
```

👉 **Çözüm:** Kullanıcılar artık birbirini doğrudan bilmez; tüm iletişim ChatRoom (mediator) üzerinden yürür.

---------------------------------------------------------------------------------------------------------------------------------------

# 🎀 Decorator Pattern

## 📖 Nedir?

Decorator Pattern, var olan bir nesnenin davranışını değiştirmeden, ona **dinamik olarak yeni özellikler veya davranışlar eklemeyi** sağlayan bir yapısal tasarım desenidir.
Yani, sınıfın kendisini değiştirmek yerine, nesne etrafına “sarmalayıcı” (decorator) nesneler ekleyerek genişletme yapılır.

---

## 💡 Ne Zaman Kullanılır?

- Bir nesneye yeni işlevler eklemek istiyorsan ama kalıtım (inheritance) kullanmak istemiyorsan.
- Bir nesnenin sınıfını değiştirmeden, çalışma anında (runtime) özelliklerini genişletmek istiyorsan.
- Birçok farklı kombinasyonlu yetenek eklemenin gerektiği senaryolarda.

---

## 🛑 Sorun Örneği (Decorator Pattern Olmadan)

Bir `Coffee` sınıfın var, ve küçük, orta, büyük boylar için ayrı sınıflar, sütlü veya kremalı türler için ayrı sınıflar yazıyorsun:

```csharp
public class SmallCoffee
{
    public double Cost() => 2.0;
}

public class SmallCoffeeWithMilk
{
    public double Cost() => 2.5;
}

public class SmallCoffeeWithCream
{
    public double Cost() => 2.7;
}

// Böyle devam eder...
```

👉 **Sorun:** Her kombinasyon için yeni sınıf yazmak gerekiyor → sınıf patlaması (class explosion) yaşanır, bakım zorlaşır.

---

## ✅ Decorator Pattern ile Çözüm

```csharp
public interface ICoffee
{
    double Cost();
}

public class SimpleCoffee : ICoffee
{
    public double Cost() => 2.0;
}

public class MilkDecorator : ICoffee
{
    private ICoffee _coffee;

    public MilkDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public double Cost() => _coffee.Cost() + 0.5;
}

public class CreamDecorator : ICoffee
{
    private ICoffee _coffee;

    public CreamDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public double Cost() => _coffee.Cost() + 0.7;
}

// Kullanım
ICoffee coffee = new SimpleCoffee();
coffee = new MilkDecorator(coffee);
coffee = new CreamDecorator(coffee);

Console.WriteLine($"Total Cost: {coffee.Cost()}"); // Çıktı: Total Cost: 3.2
```

👉 **Çözüm:** Farklı dekoratörler (Milk, Cream) birbirine eklenebilir; sınıf patlaması yerine esnek ve genişletilebilir bir yapı sağlanır.

---------------------------------------------------------------------------------------------------------------------------------------

# 🏠 Facade Pattern

## 📖 Nedir?

Facade Pattern, karmaşık bir sistemin altındaki birden fazla sınıf ve bileşeni **tek bir basit arayüz (facade)** ile sunan bir yapısal tasarım desenidir.
Bu desen, kullanıcının sistemin iç detaylarını bilmeden çalışabilmesini sağlar → sistemi sadeleştirir, karmaşık ilişkileri gizler.

---

## 💡 Ne Zaman Kullanılır?

- Karmaşık bir alt sistemin basitleştirilmiş bir erişim kapısı gerekiyorsa.
- Alt sistemin kullanımını kolaylaştırmak, dışa basit bir API sunmak istiyorsan.
- Sistemin iç yapılarını dış kullanıcıdan gizlemek istiyorsan.

---

## 🛑 Sorun Örneği (Facade Pattern Olmadan)

Bir ev sinema sistemi yazıyorsun; kullanıcı hoparlörleri, projeksiyonu ve DVD oynatıcıyı ayrı ayrı kontrol etmek zorunda:

```csharp
public class Projector
{
    public void On() => Console.WriteLine("Projector On");
}

public class SoundSystem
{
    public void On() => Console.WriteLine("Sound System On");
}

public class DvdPlayer
{
    public void Play() => Console.WriteLine("DVD Playing");
}

// Kullanım
var projector = new Projector();
var soundSystem = new SoundSystem();
var dvdPlayer = new DvdPlayer();

projector.On();
soundSystem.On();
dvdPlayer.Play();
```

👉 **Sorun:** Kullanıcı, tüm detayları bilmek ve sırayla kontrol etmek zorunda → kullanım karmaşık.

---

## ✅ Facade Pattern ile Çözüm

```csharp
public class HomeTheaterFacade
{
    private Projector _projector;
    private SoundSystem _soundSystem;
    private DvdPlayer _dvdPlayer;

    public HomeTheaterFacade(Projector projector, SoundSystem soundSystem, DvdPlayer dvdPlayer)
    {
        _projector = projector;
        _soundSystem = soundSystem;
        _dvdPlayer = dvdPlayer;
    }

    public void WatchMovie()
    {
        _projector.On();
        _soundSystem.On();
        _dvdPlayer.Play();
        Console.WriteLine("Enjoy the movie!");
    }
}

// Kullanım
var facade = new HomeTheaterFacade(new Projector(), new SoundSystem(), new DvdPlayer());
facade.WatchMovie();
// Çıktı:
// Projector On
// Sound System On
// DVD Playing
// Enjoy the movie!
```

👉 **Çözüm:** Kullanıcı sadece `HomeTheaterFacade` arayüzünü kullanır → alt sistemin karmaşıklığı gizlenir.

---------------------------------------------------------------------------------------------------------------------------------------

# 🛡 Proxy Pattern

## 📖 Nedir?

Proxy Pattern, başka bir nesnenin (gerçek nesnenin) yerini alarak onunla aynı arayüzü sunan ve gerçek nesneye erişimi **kontrol eden** bir nesne (proxy) sağlar.
Bu desen, gerçek nesneye doğrudan erişimi kısıtlamak, yönetmek veya geciktirmek için kullanılır.

---

## 💡 Ne Zaman Kullanılır?

- Nesneye erişimi kontrol etmek gerektiğinde (örneğin: erişim yetkisi, yük dengeleme, loglama).
- Ağır nesneleri (heavy object) yalnızca gerçekten ihtiyaç duyulduğunda oluşturmak için (lazy loading).
- Nesnelerin uzaktaki (remote) sistemlerde temsil edilmesi gerektiğinde (remote proxy).

---

## 🛑 Sorun Örneği (Proxy Pattern Olmadan)

Bir `Image` sınıfın var, her yükleme (load) işlemi pahalı ve uzun sürüyor:

```csharp
public class Image
{
    private string _fileName;

    public Image(string fileName)
    {
        _fileName = fileName;
        LoadFromDisk();
    }

    private void LoadFromDisk()
    {
        Console.WriteLine($"Loading {_fileName} from disk...");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying {_fileName}");
    }
}

// Kullanım
var image = new Image("photo.jpg");
image.Display();
```

👉 **Sorun:** `Image` nesnesi her çağrıda hemen yükleniyor, hatta `Display()` bile yapılmadan → gereksiz maliyet.

---

## ✅ Proxy Pattern ile Çözüm

```csharp
public interface IImage
{
    void Display();
}

public class RealImage : IImage
{
    private string _fileName;

    public RealImage(string fileName)
    {
        _fileName = fileName;
        LoadFromDisk();
    }

    private void LoadFromDisk()
    {
        Console.WriteLine($"Loading {_fileName} from disk...");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying {_fileName}");
    }
}

public class ProxyImage : IImage
{
    private RealImage _realImage;
    private string _fileName;

    public ProxyImage(string fileName)
    {
        _fileName = fileName;
    }

    public void Display()
    {
        if (_realImage == null)
        {
            _realImage = new RealImage(_fileName);
        }
        _realImage.Display();
    }
}

// Kullanım
IImage image = new ProxyImage("photo.jpg");
image.Display(); // Çıktı: Loading photo.jpg from disk... \n Displaying photo.jpg
image.Display(); // Çıktı: Displaying photo.jpg (yeniden yüklemez)
```

👉 **Çözüm:** Gerçek `RealImage` yalnızca ilk ihtiyaç duyulduğunda yaratılır → lazy loading sağlanır.

---------------------------------------------------------------------------------------------------------------------------------------

# 🔌 Adapter Pattern

## 📖 Nedir?

Adapter Pattern, uyumsuz iki arayüzü **birlikte çalışabilir hale getiren** bir yapısal tasarım desenidir.
Yani, bir nesneyi başka bir arayüze **adapt** ederek, onu beklenen arayüze uydurur.

Bunu bir elektrik adaptörü gibi düşünebilirsin: prizle cihazın uyumsuzsa araya bir adaptör takarsın.

---

## 💡 Ne Zaman Kullanılır?

- Mevcut bir sınıfın arayüzü, ihtiyaç duyulan başka bir arayüzle uyuşmadığında.
- Eski (legacy) kodları veya kütüphaneleri yeni sistemlerle uyumlu hale getirmek istediğinde.
- Kodun yeniden yazılmadan kullanılabilir olmasını sağlamak istediğinde.

---

## 🛑 Sorun Örneği (Adapter Pattern Olmadan)

Senin sistemin sadece `ICardReader` arayüzüyle çalışıyor, ama elinde `UsbCardReader` var; arayüzleri uyuşmuyor:

```csharp
public interface ICardReader
{
    void ReadCard();
}

public class UsbCardReader
{
    public void ConnectAndRead()
    {
        Console.WriteLine("Reading card via USB.");
    }
}
```

👉 **Sorun:** `UsbCardReader`, `ICardReader` bekleyen yerlere doğrudan verilemez → arayüz uyumsuz.

---

## ✅ Adapter Pattern ile Çözüm

```csharp
public class UsbCardReaderAdapter : ICardReader
{
    private UsbCardReader _usbCardReader;

    public UsbCardReaderAdapter(UsbCardReader usbCardReader)
    {
        _usbCardReader = usbCardReader;
    }

    public void ReadCard()
    {
        _usbCardReader.ConnectAndRead();
    }
}

// Kullanım
ICardReader reader = new UsbCardReaderAdapter(new UsbCardReader());
reader.ReadCard(); // Çıktı: Reading card via USB.
```

👉 **Çözüm:** Adapter, `UsbCardReader`’ı `ICardReader` arayüzüne uydurur → sistemin beklediği şekilde çalıştırabiliriz.

---------------------------------------------------------------------------------------------------------------------------------------

# 🌉 Bridge Pattern

## 📖 Nedir?

Bridge Pattern, bir nesnenin soyutlamasını (abstraction) ve implementasyonunu **birbirinden ayırarak** bunların bağımsız olarak geliştirilmesini sağlayan bir yapısal tasarım desenidir.
Yani, **“ne” yapıldığı** ile **“nasıl” yapıldığı** birbirinden ayrılır ve köprü (bridge) ile bağlanır.

Bu desen genellikle:
- Sınıf patlamasını (class explosion) önlemek,
- Kombinasyonlu büyüyen hiyerarşileri sadeleştirmek için kullanılır.

---

## 💡 Ne Zaman Kullanılır?

- Bir soyutlama ile birden fazla implementasyonu birbirinden ayırmak istediğinde.
- Hem soyutlama hem de implementasyon tarafı zamanla değişebilir veya genişleyebilir.
- İkili sınıf hiyerarşilerini (örn. Şekiller × Renkler) sadeleştirmek gerektiğinde.

---

## 🛑 Sorun Örneği (Bridge Pattern Olmadan)

Sen `Shape` sınıfın içinde hem şekil tipini hem de rengini yönetiyorsun, her kombinasyon için ayrı sınıf yazıyorsun:

```csharp
public class RedCircle
{
    public void Draw() => Console.WriteLine("Drawing Red Circle");
}

public class BlueCircle
{
    public void Draw() => Console.WriteLine("Drawing Blue Circle");
}

public class RedSquare
{
    public void Draw() => Console.WriteLine("Drawing Red Square");
}

// ve böyle devam eder...
```

👉 **Sorun:** Yeni şekil veya renk eklendikçe sınıf sayısı katlanarak artar → sınıf patlaması.

---

## ✅ Bridge Pattern ile Çözüm

```csharp
public interface IColor
{
    string Fill();
}

public class Red : IColor
{
    public string Fill() => "Red";
}

public class Blue : IColor
{
    public string Fill() => "Blue";
}

public abstract class Shape
{
    protected IColor Color;

    protected Shape(IColor color)
    {
        Color = color;
    }

    public abstract void Draw();
}

public class Circle : Shape
{
    public Circle(IColor color) : base(color) { }

    public override void Draw()
    {
        Console.WriteLine($"Drawing Circle in {Color.Fill()} color");
    }
}

public class Square : Shape
{
    public Square(IColor color) : base(color) { }

    public override void Draw()
    {
        Console.WriteLine($"Drawing Square in {Color.Fill()} color");
    }
}

// Kullanım
Shape shape1 = new Circle(new Red());
shape1.Draw(); // Çıktı: Drawing Circle in Red color

Shape shape2 = new Square(new Blue());
shape2.Draw(); // Çıktı: Drawing Square in Blue color
```

👉 **Çözüm:** Shape ve Color ayrı bağımsız hiyerarşiler olarak genişleyebilir; her kombinasyon için yeni sınıf yazmaya gerek kalmaz.