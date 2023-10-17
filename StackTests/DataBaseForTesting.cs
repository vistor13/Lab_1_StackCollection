using MyStack;
namespace Stack.Tests
{
    public class DataBaseForTesting
    {
        public static IEnumerable<object[]> EmptyStack()
        {
            yield return new object[] { new MyStackCollection<int>() };
            yield return new object[] { new MyStackCollection<string>() };
            yield return new object[] { new MyStackCollection<char>() };
        }

        public static IEnumerable<object[]> DataForTesting()
        {
            yield return new object[] { new int[] { 9, 2, 32, 4, 6, 7, 3, 22 } };
            yield return new object[] { new string[] { "Mother", "Father" } };
            yield return new object[] { new char[] { '1', '2','5'} };
        }
    }
}
