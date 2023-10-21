using MyStack;

namespace Stack.Tests
{
    public class StackCopyToTests
    {

        [Theory]
        [MemberData(nameof(DataBaseForTesting.DataForTesting), MemberType = typeof(DataBaseForTesting))]
        public void CopyTo_ShouldCopiesElements<T>(T[] values)
        {
            var stack = new MyStackCollection<T>(values);
            var array = new T[values.Length];

            stack.CopyTo(array, 0);

            Assert.Equal(stack, array);
        }
        [Theory]
        [MemberData(nameof(DataBaseForTesting.DataForTesting), MemberType = typeof(DataBaseForTesting))]
        public void CopyTo_WhenArrayIsNull_ThrowsArgumentNullException_<T>(T[] values)
        {
            // Arrange
            MyStackCollection<T> stack = new MyStackCollection<T>(values);
            
            T[] array = null;

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => stack.CopyTo(array, 0));
        }

        [Theory]
        [MemberData(nameof(DataBaseForTesting.DataForTesting), MemberType = typeof(DataBaseForTesting))]
        public void CopyTo_WhenIndexIsOutOfRange_ThrowsArgumentOutOfRangeException_<T>(T[] values)
        {
            // Arrange
            MyStackCollection<T> stack = new MyStackCollection<T>(values);

            T[] array = new T[stack.Count];

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => stack.CopyTo(array, stack.Count+2));
        }

        [Theory]
        [MemberData(nameof(DataBaseForTesting.DataForTesting), MemberType = typeof(DataBaseForTesting))]
        public void CopyTo_WhenArrayIsTooSmall_ThrowsArgumentException_<T>(T[] values)
        {
            // Arrange
            MyStackCollection<T> stack = new MyStackCollection<T>(values);
          
            char[] array = new char[stack.Count-1];

            // Act and Assert
            Assert.Throws<ArgumentException>(() => stack.CopyTo(array, 0));
        }
        
    }
}
