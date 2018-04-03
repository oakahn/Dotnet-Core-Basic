using System;
using Xunit;

namespace Myname.Tests
{
    public class TestYourName
    {
        [Fact]
        public void TestGetYourNameShouldReturnJin() 
        {
            YourNames yourName = new YourNames();
            string result = yourName.Get();
            
            Assert.Equal("Jin", result);
        }

        [Fact]
        public void TestCase()
        {
            //Give
            //When
            //Then
            
        }
    }
}