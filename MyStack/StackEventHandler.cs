namespace MyStack
{
    public class StackEventHandler<T>
    {
        public void Subscribe(MyStackCollection<T> stack)
        {
            stack.ItemPushed += AddedEvent!;
            stack.ItemPopped += AddedEvent!;
        }

        public void Unsubscribe(MyStackCollection<T> stack)
        {
            stack.ItemPopped -= RemovedEvent!;
            stack.ItemPopped -= RemovedEvent!;
        }

        private void AddedEvent(object sender, StackEventArg<T> e)
        {
            if (sender == null) return;
            Console.WriteLine("Item was added: " + e.Value + "; " + e.Time);
        }

        private void RemovedEvent(object sender, StackEventArg<T> e)
        {
            if (sender == null) return;
            Console.WriteLine("Item was removed: " + e.Value + "; " + e.Time);
        }
    }
}
