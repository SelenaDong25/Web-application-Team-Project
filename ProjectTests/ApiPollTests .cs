using CSD412ProjectGroup00000100.Models;
using System;
using Xunit;

namespace ProjectTests
{
    public class ApiPollTests
    {
        [Fact]
        public void Test1()
        {
            ApiPoll ap = new ApiPoll();
            Assert.True(ap.Name == "");
        }
        [Theory]
        [InlineData("Test String", "Test String")]
        [InlineData("", "")]
        [InlineData("q43t2te65hw45buut wmgh/jhk!@#$%^&*()-=_+", "q43t2te65hw45buut wmgh/jhk!@#$%^&*()-=_+")]
        public void Test2(string description, string expected)
        {
            ApiPoll ap = new ApiPoll();
            ap.Description = description;
            Assert.True(ap.Description == expected);
        }

        [Fact]
        public void Test3()
        {
            ApiPoll ap = new ApiPoll();
            Assert.True(ap.PollId == 0);
        }

    }
}