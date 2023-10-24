
using MyStack;

namespace Stack.Tests
{
    public class StackPushTests
    {
        [Theory]
        [MemberData(nameof(DataBaseForTesting.DataForTesting), MemberType = typeof(DataBaseForTesting))]
        public void Push_EmptyCollection_ShouldAddToElement<T>(T[] values)
        {
            var eventTriger = true;
            var stack=new MyStackCollection<T>();

         
            foreach (var item in values)
            {
                stack.Push(item);
            }

            stack.ItemPushed += (sender, e) =>eventTriger = true;

            Assert.Equal(values.Length, stack.Count);
            Assert.True(eventTriger);
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
    }
}
