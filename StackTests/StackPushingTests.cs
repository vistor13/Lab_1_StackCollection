
using MyStack;

namespace Stack.Tests
{
    public class StackPushingTests
    {
        [Theory]
        [MemberData(nameof(DataBaseForTesting.DataForTesting), MemberType = typeof(DataBaseForTesting))]
        public void Push_EmptyCollection_ShouldAddToElement<T>(T[] values)
        {
            //Arange
            var stack=new MyStackCollection<T>();

            //Act
            foreach (var item in values)
            {
                stack.Push(item);
            }
            //Assert

            Assert.Equal(values.Length, stack.Count);
        }

        [Theory]
        [MemberData(nameof(DataBaseForTesting.DataForTesting), MemberType = typeof(DataBaseForTesting))]
        public void Push_NotEmptyCollection_ShouldAddToElement<T>(T[] values)
        {
            //Arange
            var stack = new MyStackCollection<T>(values);

            //Act
            foreach (var item in values)
            {
                stack.Push(item);
            }
            //Assert

            Assert.Equal(values.Length*2, stack.Count);
        }
        [Theory]
        [MemberData(nameof(DataBaseForTesting.DataForTesting), MemberType = typeof(DataBaseForTesting))]
        public void Push_WhenPopingLastElement_ShouldAddToElement<T>(T[] values)
        {
            //Arange
            var stack = new MyStackCollection<T>(values);

            //Act
            stack.Pop();
            foreach (var item in values)
            {
                stack.Push(item);
            }
            //Assert

            Assert.Equal((values.Length * 2)-1, stack.Count);
        }

    }
}
