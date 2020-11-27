using CSD412ProjectGroup00000100.Models;
using System;
using Xunit;

namespace ProjectTests
{
    public class PollTests
    {
        [Fact]
        public void Test1()
        {
            Poll p = new Poll();
            Assert.True(p.Name == "");
        }
        [Theory]
        [InlineData("Test String", "Test String")]
        [InlineData("", "")]
        [InlineData("q43t2te65hw45buut wmgh/jhk!@#$%^&*()-=_+", "q43t2te65hw45buut wmgh/jhk!@#$%^&*()-=_+")]
        public void Test2(string description, string expected)
        {
            Poll p = new Poll();
            p.Description = description;
            Assert.True(p.Description == expected);
        }

        [Fact]
        public void Test3()
        {
            Poll p = new Poll();
            Assert.True(p.PollId == 0);
        }

        [Fact]
        public void Test4()
        {
            Poll p = new Poll();
            Assert.True(p.UserId == "");
        }
    }
}