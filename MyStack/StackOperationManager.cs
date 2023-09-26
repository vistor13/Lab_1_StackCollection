using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public class StackOperationsManager<T>
    {
        private readonly MyStackCollection<T> _stack;
        public StackOperationsManager(MyStackCollection<T> stack)
        {
            _stack = stack;
        }
        public void WriteStack()
        {
            ExceptionCountIsNull();
            foreach (var item in _stack)
            {
                Console.WriteLine($"\t{item}");
            }

        }
        public void Peek()
        {
            ExceptionCountIsNull();
            Console.WriteLine("  Peek at next item to destack: {0}",
            _stack.Peek());
        }
        public void Pop()
        {
            ExceptionCountIsNull();
            Console.WriteLine(" Popping '{0}'", _stack.Pop());
        }

        public void Clear()
        {
            _stack.Clear();
            Console.WriteLine("  Stack.Count = {0}", _stack.Count);
        }
        public void CopyTo()
        {
            Console.Write("  Ведіть індекс у масиві array, що вказує на початок копіювання : ");
            var input = Convert.ToInt32(Console.ReadLine());
            T[] array2 = new T[_stack.Count * 2];
            _stack.CopyTo(array2, input);
            Console.WriteLine("  Вивести цей масив");
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }
        }
        public void TryPeek()
        {
            Console.WriteLine($"  У верхній частині є об'єкт ? - {_stack.TryPeek(out T result)} . Об'єкт - {result}");
        }
        public void TryPop()
        {
            Console.WriteLine($"  У верхній частині є об'єкт ? - {_stack.TryPeek(out T result)} . Об'єкт - {result} видаляєтся");
        }
        public void Push()
        {
            Console.Write("  Ведіть значення яке ви хочете додати ");
            var input = Console.ReadLine();

            T item = (T)Convert.ChangeType(input!, typeof(T));
            _stack.Push(item);
        }
        public void Contains()
        {
            Console.Write("  Ведіть значення яке ви хочете перевірити чи є в стеці : ");
            var input = Console.ReadLine();
            ExceptionCountIsNull();
            T item = (T)Convert.ChangeType(input!, typeof(T));
            Console.WriteLine($"  Stack.Contains({item}) = {_stack.Contains(item)}");
        }
        public void Exit()
        {
            Environment.Exit(0);
        }
        private void ExceptionCountIsNull()
        {
            if (_stack.Count == 0)
            {
                Console.WriteLine("  В стеці 0 значень.Викорастайте метод Push для добавлення елементу в стек ");
                return;
            }
        }
    }
}
