using MyStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Tests.StackTests
{
    public class StackTryPopTests
    {
        [Theory]
        [MemberData(nameof(DataBaseForTesting.EmptyStack), MemberType = typeof(DataBaseForTesting))]
        public void TryPop_EmptyStack_ShouldReturnFalse<T>(MyStackCollection<T> stack)
        {
            var boolResult = stack.TryPop(out T value);
            Assert.False(boolResult);
            Assert.Equal(value, default);
        }


        [Theory]
        [MemberData(nameof(DataBaseForTesting.DataForTesting), MemberType = typeof(DataBaseForTesting))]
        public void TryPop_NotEmptyStack_ShouldReturnTrueAndRemoveItems<T>(T[] values)
        {
            var stack = new MyStackCollection<T>(values);


            for (int i = values.Length - 1; i >= 0; i--)
            {
                var boolResult = stack.TryPop(out T value);
                Assert.Equal(values[i], value);
                Assert.True(boolResult);
            }

            Assert.Empty(stack);
        }
    }
}
