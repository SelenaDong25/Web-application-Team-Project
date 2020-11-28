using CSD412ProjectGroup00000100.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace ProjectTests
{
    public class ViewPollTests
    {

        [Fact]
        public void Test1()
        {
            ViewPoll vp = new ViewPoll();
            Assert.True(vp.ShowResult == false);
        }

        [Theory]
        [InlineData( "Test", "Test", "Test", "Test")]
        [InlineData("", "", "", "")]
        [InlineData("hohohohoho", "ohohohohohoh", "hohohohoho", "ohohohohohoh")]
        [InlineData("", "poooooooooooooooooooooooooooooooooooooooooooooop"
                   , "", "poooooooooooooooooooooooooooooooooooooooooooooop")]
        [InlineData("poooooooooooooooooooooooooooooooooooooooooooooop",""
                   , "poooooooooooooooooooooooooooooooooooooooooooooop","")]
        public void Test2(string name, string description, string expectedName, string expectedDescription)
        {
            Poll p = new Poll {Name = name, Description = description}; 
            ViewPoll vp = new ViewPoll {CurrentPoll = p };
            Assert.True(vp.CurrentPoll.Description == expectedDescription && vp.CurrentPoll.Name == expectedName);
        }
    }
}