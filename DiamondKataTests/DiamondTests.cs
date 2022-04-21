using Xunit;
using FluentAssertions;
using DiamondKataLib;

namespace DiamondKataTests
{
    public class DiamondTests
    {
        const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        [Fact]
        public void DiamondAIsOnlyOneLineLong()
        {
            var result = Diamond.Create('A');

            result.Should().HaveCount(1);
        }

        [Fact]
        public void DiamondBIsAsExpected()
        {
            var result = Diamond.Create('B');

            result.Should().HaveCount(3);
            result[0].Should().Be(" A ");
            result[1].Should().Be("B B");
            result[2].Should().Be(" A ");
        }

        [Theory]
        [InlineData('A',"A")]
        [InlineData('B', " A ")]
        [InlineData('C', "  A  ")]
        public void FirstLineOfDiamondContainsExpectedString(char to, string expected)
        {
            var result = Diamond.Create(to);

            result[0].Should().Be(expected);
        }

        [Theory]
        [InlineData('B')]
        [InlineData('C')]
        [InlineData('D')]
        [InlineData('E')]
        public void AllRowsAreSameLength(char to)
        {
            var result = Diamond.Create(to);

            result.Should().AllSatisfy(x => x.Should().HaveLength(result[0].Length));
        }

        [Theory]
        [InlineData('B')]
        [InlineData('C')]
        [InlineData('D')]
        [InlineData('E')]
        public void TopOfDiamondIsMirrored(char to)
        {
            var pos = Alphabet.IndexOf(to);
            var result = Diamond.Create(to);

            for(var i = 0; i < pos; i++)
            {
                result[i].Should().Be(result[result.Length - 1 - i]);
            }
        }


    }
}