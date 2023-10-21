using MyStack;
namespace Stack.Tests
{
    public class DataBaseForTesting
    {
        private static readonly int[] integers = new int[] { 9, 2, 32, 4, 6, 7, 3, 22 };
        private static readonly string[] strings = new string[] { null, "sfdf" };
        private static readonly char[] chars = new char[] { '1', '2', '5' };
        public static IEnumerable<object[]> EmptyStack()
        {
            yield return new object[] { new MyStackCollection<int>() };
            yield return new object[] { new MyStackCollection<string>() };
            yield return new object[] { new MyStackCollection<char>() };
        }

        public static IEnumerable<object[]> DataForTesting()
        {
            yield return new object[] { integers };
            yield return new object[] { strings };
            yield return new object[] { chars };
        }
    }
}
