using CSD412ProjectGroup00000100.Models;
using System;
using Xunit;
//This should work, other may not, as it is not the default creation.
namespace ProjectTests
{
    public class ItemTests
    {
        [Fact]
        public void Test1()
        {
            Item i = new Item();
            Assert.False(i.name == "");
        }
        [Theory]
        [InlineData("Test String", "Test String")]
        [InlineData("", "")]
        [InlineData("q43t2te65hw45buut wmgh/jhk!@#$%^&*()-=_+", "q43t2te65hw45buut wmgh/jhk!@#$%^&*()-=_+")]
        public void Test2(string description, string expected)
        {
            Item i = new Item();
            i.description = description;
            Assert.True(i.description == expected);
        }
    }
}
