using MyStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Tests
{
    public class StackContainsTests
    {

        [Theory]
        [MemberData(nameof(DataBaseForTesting.DataForTesting), MemberType = typeof(DataBaseForTesting))]
        public void Contains_WhenNotElement_ShouldReturFalse<T>(T[] values)
        {
            var stack = new MyStackCollection<T>(values);

            for (int i = values.Length - 1; i >= 0; i--)
            {
                stack.Pop();

                Assert.False(stack.Contains(values[i]));
            }
        }
        [Theory]
        [MemberData(nameof(DataBaseForTesting.DataForTesting), MemberType = typeof(DataBaseForTesting))]
        public void Contains_WhenHasElement_ShouldReturTrue<T>(T[] values)
        {
            var stack = new MyStackCollection<T>(values);

            for (int i = values.Length - 1; i >= 0; i--)
            {
                Assert.True(stack.Contains(values[i]));
                stack.Pop();
            }
        }
    }
}
