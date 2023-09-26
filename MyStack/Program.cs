using MyStack;
using MyStack.Menu;
using System.Text;

namespace MyCollection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            StackEventHandler<string> handler = new StackEventHandler<string>();
            MyStackCollection<string> strings = new MyStackCollection<string>();
            handler.Subscribe(strings);
            StackOperationsManager<string> stackOperation = new StackOperationsManager<string>();
            CommandExecutor<string> commandExecutor = new CommandExecutor<string>(stackOperation);
            CommandRunner<string> commandRuner = new CommandRunner<string>(commandExecutor);
            commandRuner.Runner();
        }
    }
}