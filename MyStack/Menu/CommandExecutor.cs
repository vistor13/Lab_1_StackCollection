

namespace MyStack.Menu
{
    public class CommandExecutor<T>
    {
        private readonly StackOperationsManager<T> _stackOperationsManager;
        public CommandExecutor(StackOperationsManager<T> stackOperationsManager)
        {
            _stackOperationsManager = stackOperationsManager;
        }

        public Dictionary<Command, Action> RunCommand()
        {
            var dictionaryCommand = new Dictionary<Command, Action>()
            {
               { Command.Exit, _stackOperationsManager.Exit},
               { Command.WriteStack,_stackOperationsManager.WriteStack },
               { Command.Push,  _stackOperationsManager.Push },
               { Command.Peek, _stackOperationsManager.Peek },
               { Command.Pop, _stackOperationsManager.Pop },
               { Command.Contains, _stackOperationsManager.Contains },
               { Command.CopyTo, _stackOperationsManager.CopyTo },
               { Command.Clear, _stackOperationsManager.Clear },
               { Command.TryPeek, _stackOperationsManager.TryPeek },
               { Command.TryPop, _stackOperationsManager.TryPop },
            };
            return dictionaryCommand;
        }
    }
}
