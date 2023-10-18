using MyStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Tests
{
    public class StackCopyToTests
    {

        [Theory]
        [MemberData(nameof(DataBaseForTesting.DataForTesting), MemberType = typeof(DataBaseForTesting))]
        public void CopyTo_NotEmptyStack_ShouldReturnTrueAndDontRemoveItems<T>(T[] values)
        {
            
        }
    }
}
