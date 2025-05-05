public class AbstractFactoryPattern
{
    public AbstractFactoryPattern()
    {
        UIFactory factory = new WindowsFactory();
        IButton button = factory.CreateButton();
        ICheckbox checkbox = factory.CreateCheckbox();
        button.Render();
        checkbox.Render();
    }

    interface IButton
    {
        void Render();
    }

    interface ICheckbox
    {
        void Render();
    }

    class WindowsButton : IButton
    {
        public void Render() => Console.WriteLine("Windows button");
    }

    class WindowsCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Windows checkbox");
    }

    class MacButton : IButton
    {
        public void Render() => Console.WriteLine("Mac button");
    }

    class MacCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Mac checkbox");
    }

    interface UIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }

    class WindowsFactory : UIFactory
    {
        public IButton CreateButton() => new WindowsButton();

        public ICheckbox CreateCheckbox() => new WindowsCheckbox();
    }

    class MacFactory : UIFactory
    {
        public IButton CreateButton() => new MacButton();

        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }
}




