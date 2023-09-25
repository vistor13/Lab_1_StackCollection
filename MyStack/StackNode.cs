
namespace MyStack
{
    public class StackNode<T>
    {
        public T Data { get; set; }
        public StackNode<T>? NextElement { get; set; }
        public StackNode(T data)
        {
            Data = data;
            NextElement = default;
        }
    }
}
