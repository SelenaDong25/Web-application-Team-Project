﻿using CSD412ProjectGroup00000100.Models;
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
            Assert.False(p.name == "");
        }
        [Theory]
        [InlineData("Test String", "Test String")]
        [InlineData("", "")]
        [InlineData("q43t2te65hw45buut wmgh/jhk!@#$%^&*()-=_+", "q43t2te65hw45buut wmgh/jhk!@#$%^&*()-=_+")]
        public void Test2(string description, string expected)
        {
            Poll p = new Poll();
            p.description = description;
            Assert.True(p.description == expected);
        }
    }
}