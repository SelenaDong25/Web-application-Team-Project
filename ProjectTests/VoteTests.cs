using CSD412ProjectGroup00000100.Models;
using System;
using Xunit;

namespace ProjectTests
{
    public class VoteTests
    {
        [Fact]
        public void Test1()
        {
            Vote v = new Vote();
            Assert.True(v.VoteId == 0);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(37, 37)]
        [InlineData(20000000, 20000000)]
        public void Test2(int vID, int expected)
        {
            Vote v = new Vote();

            v.VoteId = vID;
            
            Assert.True(v.VoteId == expected);
        }

        [Fact]
        public void Test3()
        {
            Vote v = new Vote();
            Assert.True(v.ItemId == 0);
        }

        [Fact]
        public void Test4()
        {
            Vote v = new Vote();
            Assert.True(v.VoteDateTime == DateTime.MinValue );
        }
    }
}