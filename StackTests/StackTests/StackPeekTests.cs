using MyStack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Tests.StackTests
{
    public class StackPeekTests
    {
        [Theory]
        [MemberData(nameof(DataBaseForTesting.EmptyStack), MemberType = typeof(DataBaseForTesting))]
        public void Peek_WhenEmptyCollection_ShouldInvalidOperationException<T>(MyStackCollection<T> stack)
        {
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        [Theory]
        [MemberData(nameof(DataBaseForTesting.DataForTesting), MemberType = typeof(DataBaseForTesting))]
        public void Peek_WhenStackNotEmpty_ShoudReturnFirstElementWithoutRemoving<T>(T[] values)
        {
            var stack = new MyStackCollection<T>(values);

            Assert.Equal(values[values.Length - 1], stack.Peek());
            Assert.Equal(stack.Count, values.Count());
        }
    }
}
