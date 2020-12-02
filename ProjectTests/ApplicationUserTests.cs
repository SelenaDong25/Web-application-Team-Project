using CSD412ProjectGroup00000100.Models;
using System;
using Xunit;

namespace ProjectTests
{
    public class ApplicationUserTests
    {
        [Fact]
        public void Test1()
        {
            ApplicationUser au = new ApplicationUser();
            Assert.False(au.Id == "");
        }

        [Theory]

        [InlineData("", "")]
        [InlineData("hahfhfafahfhadfahh", "hahfhfafahfhadfahh")]
        [InlineData("pop1-pop2-pop3-pop4", "pop1-pop2-pop3-pop4")]
        public void Test2(string email, string expected)
        {
            ApplicationUser au = new ApplicationUser();
            au.Email = email;
            Assert.True(au.Email == expected);
        }

       
    }
}