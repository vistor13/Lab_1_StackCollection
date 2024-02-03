using System.Collections;

namespace MyStack
{
    public class MyStackCollection<T> : IEnumerable<T>, ICollection
    {
        private int _count;

        private StackNode<T>? _first;
        public int Count { get { return _count; } }
        public StackNode<T>? First { get { return _first; } }

        public event EventHandler<StackEventArg<T>>? ItemPushed;

        public event EventHandler<StackEventArg<T>>? ItemPopped;
        public object SyncRoot => this;

        public bool IsSynchronized => false;
        public MyStackCollection(IEnumerable<T> collection)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection), "Collection is empty");
            foreach (var item in collection)
            {
                Push(item);
            }
        }
        public MyStackCollection()
        {
            _count = 0;
            _first = null;
        }
        public void Push(T item)
        {
            StackNode<T> nodePush = new StackNode<T>(item);
            nodePush.NextElement = _first;
            _first = nodePush;
            _count++;
            ItemPushed?.Invoke(this, new StackEventArg<T>(item, "Значення додано"));
        }
        public T Pop()
        {
            if (_count == 0)
                throw new InvalidOperationException("The stack is empty.");
            T item = _first!.Data;
            _first = _first.NextElement;
            _count--;
            ItemPopped?.Invoke(this, new StackEventArg<T>(item, "Значення видалено"));
            return item;
        }
        public T Peek()
        {
            if (_count == 0)
                throw new InvalidOperationException("The stack is empty.");
            return _first!.Data;
        }
        public void CopyTo(Array array, int index)
        {
            if (array == null) throw new ArgumentNullException(nameof(array), "Array is null");
            if (index < 0 || index >= array.Length) throw new ArgumentOutOfRangeException(nameof(index));
            if (Count > array.Length - index) throw new ArgumentException(nameof(Count));

            StackNode<T>? current = _first;

            while (current != null)
            {
                array.SetValue(current.Data, index++);
                current = current.NextElement;
            }
        }
        public bool Contains(T item)
        {
            StackNode<T> stackNode = _first!;
            while (stackNode != null)
            {
                if (stackNode.Data != null && stackNode.Data!.Equals(item))
                    return true;
                if (item == null && stackNode.Data == null)
                    return true;
                stackNode = stackNode.NextElement!;
            }
            return false;
        }
        public bool TryPeek(out T result)
        {
            if (_count != 0)
            {
                result = _first!.Data;
                return true;
            }
            result = default!;
            return false;
        }
        public bool TryPop(out T result)
        {
            if (_count != 0)
            {
                result = Pop();
                return true;
            }
            result = default!;
            return false;
        }
        public void Clear()
        {
            while (Count != 0)
            {
                Pop();
            }
        }
  
        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator(this);
            /* StackNode<T> stackNode= _first;
           while (stackNode != null)
           {
               yield return stackNode.Value;
               stackNode = stackNode.NextElement;

           }*/
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private sealed class MyEnumerator : IEnumerator<T>
        {
            private StackNode<T>? _current;

            private readonly MyStackCollection<T>? _stack;
            object IEnumerator.Current => Current!;
            public MyEnumerator(MyStackCollection<T> stack)
            {
                _stack = stack;
                if (_stack is not null && _stack.Count > 0)
                {
                    _current = default;
                }
            }
            public T Current
            {
                get
                {
                    if (_current == null)
                        throw new InvalidOperationException();
                    return _current.Data;
                }

            }
            public void Dispose()
            {

            }
            public void Count11()
            {
                _current = 11;
                Console.WriteLine();
            }

            public bool MoveNext()
            {
                if (_current == null)
                {
                    _current = _stack!.First;
                }
                else
                    _current = _current.NextElement;
                return _current != null;
            }

            public void Reset()
            {
                _current = default;
            }
        }

    }
}
