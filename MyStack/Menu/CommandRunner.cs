namespace MyStack.Menu
{
    internal class CommandRunner<T>
    {
        private readonly CommandExecutor<T> _commandExecutor;
        public CommandRunner(CommandExecutor<T> commandExecutor)
        {
            _commandExecutor = commandExecutor;
        }
        public void Runner()
        {
            Console.WriteLine("\t\tВведіть номер запиту від 1-8. Вихід - 0.");
            while (true)
            {
                Console.WriteLine("\t1-Вивести вміст стеку");
                Console.WriteLine("\t2-Метод Push (Вставляє об'єкт як верхній елемент стека Stack<T>)");
                Console.WriteLine("\t3-Метод Peek (Возвращает объект, находящийся в начале Stack<T>, без его удаления.)");
                Console.WriteLine("\t4-Метод Pop (Видаляє та повертає об'єкт, що знаходиться на початку Stack<T>.)");
                Console.WriteLine("\t5-Метод Contains (Визначає, чи входить елемент у колекцію Stack<T>.>.)");
                Console.WriteLine("\t6-Метод CopyTo (Копіює Stack у існуючий одновимірний Array, починаючи з зазначеного індексу масиву.)");
                Console.WriteLine("\t7-Метод Clear (Видаляє всі об'єкти з Stack<T>.)");
                Console.WriteLine("\t8-Метод TryPeek (Перевіряє чи у верхній частині Stack<T> об'єкт. Об'єкт не видаляється.)");
                Console.WriteLine("\t9-Метод TryPop (Перевіряє чи у верхній частині Stack<T> об'єкт. Об'єкт видаляється.)");
                Console.Write("Номер : ");
                var item = Console.ReadLine();
                if (Enum.TryParse(item, out Command command) && _commandExecutor.RunCommand().ContainsKey(command))
                {
                    _commandExecutor.RunCommand()[command]();
                }
                else
                {
                    Console.WriteLine("НЕ вірно ведене число , введіть число від 1-9");
                }
            }

        }
    }
}
