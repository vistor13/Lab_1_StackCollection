using MyStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Tests
{
    public class StackClearTests
    {
        [Theory]
        [MemberData(nameof(DataBaseForTesting.DataForTesting), MemberType = typeof(DataBaseForTesting))]
        public void Clear_StackShouldBeEmpty<T>(T[] values)
        {
            //Arange
            var stack = new MyStackCollection<T>(values);

            //Act
            stack.Clear();

            //Assert
            Assert.Empty(stack);
        }
    }
}
