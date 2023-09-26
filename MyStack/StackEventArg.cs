namespace MyStack
{
    public class StackEventArg<T>
    {
        public T? Value { get; private set; }
        public string? Message { get; private set; }
        public DateTime Time { get; private set; }
        public StackEventArg(T value, string message)
        {
            this.Value = value;
            this.Message = message;
            this.Time = DateTime.Now;
        }
    }
}
