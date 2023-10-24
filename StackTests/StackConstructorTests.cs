
using MyStack;

using System.Collections.Generic;

namespace Stack.Tests
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
