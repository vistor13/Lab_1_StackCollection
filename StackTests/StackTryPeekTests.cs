using MyStack;

namespace Stack.Tests
{
    public class StackTryPeekTests
    {
        [Theory]
        [MemberData(nameof(DataBaseForTesting.EmptyStack), MemberType = typeof(DataBaseForTesting))]
        public void TryPeek_EmptyStack_ShouldReturnFalse<T>(MyStackCollection<T> stack)
        {
            var boolResult = stack.TryPeek(out T value);
            Assert.False(boolResult);
            Assert.Equal(value, default);
        }

        [Theory]
        [MemberData(nameof(DataBaseForTesting.DataForTesting), MemberType = typeof(DataBaseForTesting))]
        public void TryPeek_NotEmptyStack_ShouldReturnTrueAndDontRemoveItems<T>(T[] values)
        {
            var stack = new MyStackCollection<T>(values);

            var boolResult = stack.TryPeek(out T value);

            Assert.True(boolResult);
            Assert.Equal(value, values[values.Length-1]);
            Assert.Equal(stack.Count, values.Length);

        }
    }
}
