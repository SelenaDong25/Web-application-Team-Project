using CSD412ProjectGroup00000100.Models;
using System;
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
  
    }
}