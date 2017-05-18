using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyWebApp.UnitTests
{
    public class MyTest
    {

        [Fact]
        public void MyFirstTest()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void MyFirstFailingTest()
        {
            Assert.Equal(1, 2);
        }


    }
}
