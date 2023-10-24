using MyStack;

namespace Stack.Tests.StackTests
{
    public class StackConstructorTests
    {
        [Fact]
        public void MyStackConsturctor_WhenAddEmptyCollection_ShouldArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new MyStackCollection<object>(null));
        }

    }
}
