using System;
using Xunit;

namespace Todsphol.Myname.Tests
{
    public class TestName
    {
        [Fact]
        public void TestGetNameShouldReturnMyName()
        {
            Name myName = new Name();
            string result = myName.Get();

            Assert.Equal("Todsphol", result);
        }
    }
}
