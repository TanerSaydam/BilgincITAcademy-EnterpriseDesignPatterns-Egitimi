public class StatePattern
{
    public StatePattern()
    {
        var doc = new Document();
        doc.Publish();
        doc.Publish();
        doc.Publish();
    }

    class Document
    {
        public IDocumentState State { get; set; } = default!;

        public Document()
        {
            State = new DraftState();
        }
        public void Publish()
        {
            State.Publish(this);
        }
    }

    interface IDocumentState
    {
        void Publish(Document doc);
    }

    class DraftState : IDocumentState
    {
        public void Publish(Document doc)
        {
            Console.WriteLine("Moving to moderation");
            doc.State = new ModerationState();
        }
    }

    class ModerationState : IDocumentState
    {
        public void Publish(Document doc)
        {
            Console.WriteLine("Moving to published");
            doc.State = new PublishedState();
        }
    }

    class PublishedState : IDocumentState
    {
        public void Publish(Document doc)
        {
            Console.WriteLine("Sending email");
        }
    }
}