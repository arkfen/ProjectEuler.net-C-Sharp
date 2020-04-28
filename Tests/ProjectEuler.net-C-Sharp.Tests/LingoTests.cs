using Xunit;
using ProjectEuler.net_C_Sharp.Helpers;

namespace ProjectEuler.net_C_Sharp.Tests
{
    public class LingoTests
    {
        [Fact]
        public void IsPalindrome_ShouldReturnTrueIfItIs()
        {
            bool expected = true;
            bool actual = Lingo.CheckIfPalindrome("a78087a");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsPalindrome_ShouldReturnTrueIfItIsNot()
        {
            bool expected = false;
            bool actual = Lingo.CheckIfPalindrome("78sdfssaa!3s87");
            Assert.Equal(expected, actual);
        }
    }
}
