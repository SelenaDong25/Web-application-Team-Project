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
            Assert.True(v.voter_id == 0);
        }
        
        [Theory]

        [InlineData(37, 37)]
        public void Test2(int vID, int expected)
        {
            Vote v = new Vote();

            v.voter_id = vID;
            
            Assert.True(v.voter_id == expected);
        }
    }
}