public class FactoryMethodPattern
{
    public FactoryMethodPattern()
    {
        NotificationFactory factory = new EmailNotificationFactory();
        INotification notification = factory.CreateNotification();
        notification.Send("hello world");
    }

    interface INotification
    {
        void Send(string message);
    }

    class EmailNotification : INotification
    {
        public void Send(string message)
        {
            //Send email
        }
    }

    class HotmailNotification : INotification
    {
        public void Send(string message)
        {
            //Send email
        }
    }

    class SmsNotification : INotification
    {
        public void Send(string message)
        {
            //Send email
        }
    }

    abstract class NotificationFactory
    {
        public abstract INotification CreateNotification();
    }

    class EmailNotificationFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new HotmailNotification();
        }
    }

    class SmsNotificationFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new SmsNotification();
        }
    }
}


