using MyStack;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Tests
{
    public class StackPopTests
    {
        [Theory]
        [MemberData(nameof(DataBaseForTesting.EmptyStack), MemberType = typeof(DataBaseForTesting))]
        public void Pop_WhenEmptyCollection_ShouldInvalidOperationException<T>(MyStackCollection<T> stack)
        {

            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Theory]
        [MemberData(nameof(DataBaseForTesting.DataForTesting), MemberType = typeof(DataBaseForTesting))]
        public void Peek_WhenStackNotEmpty_ShoudReturnFirstElementAndRemoving<T>(T[] values)
        {
            var stack = new MyStackCollection<T>(values);

            for (int i = values.Length - 1; i >= 0; i--)
            {
                Assert.Equal(values[i], stack.Pop());
            }

            Assert.Empty(stack);
        }
    }
}
