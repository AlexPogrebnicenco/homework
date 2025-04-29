namespace HomeworkProject.Interfaces
{
    public interface IOrderNotifier
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void Notify(string message);
    }
}
