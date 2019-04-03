using System;
using Mission2;
using Xunit;

namespace Test
{
    public class Mission2
    {
        [Fact]
        public void Should_Transform_Roman_Number_Into_Integer()
        {
            var romanInInteger1 = Program.RomanToInteger("XVI");
            var romanInInteger2 = Program.RomanToInteger("DCXL");
            Assert.Equal(16, romanInInteger1);
            Assert.Equal(640, romanInInteger2);
        }

        [Fact]
        public void Should_Sum_All_Lines()
        {
            var romanNumbers = new string[] {"XIV", "XXIII"};
            Assert.Equal(37, Program.SumAllLines(romanNumbers));
        }
    }
}
