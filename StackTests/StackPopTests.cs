using MyStack;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public void Pop_WhenStackNotEmpty_ShoudReturnFirstElementAndRemoving<T>(T[] values)
        {
            var stack = new MyStackCollection<T>(values);
            var eventTriger = false;

            for (int i = values.Length - 1; i >= 0; i--)
            {
                Assert.Equal(values[i], stack.Pop());
                stack.ItemPopped += (sender, e) =>
                {
                    eventTriger = true;
                    Assert.True(eventTriger);
                };
            }

            Assert.Empty(stack);
        }
    }
}
