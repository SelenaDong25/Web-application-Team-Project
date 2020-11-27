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
            Assert.True(i.Name == "");
        }
        [Theory]
        [InlineData("Test String", "Test String")]
        [InlineData("", "")]
        [InlineData("q43t2te65hw45buut wmgh/jhk!@#$%^&*()-=_+", "q43t2te65hw45buut wmgh/jhk!@#$%^&*()-=_+")]
        public void Test2(string description, string expected)
        {
            Item i = new Item();
            i.Description = description;
            Assert.True(i.Description == expected);
        }

        [Fact]
        public void Test3()
        {
            Item i = new Item();
            Assert.True(i.ItemId == 0);
        }

        [Fact]
        public void Test4()
        {
            Item i = new Item();
            Assert.True(i.PollId == 0);
        }

    }
}
