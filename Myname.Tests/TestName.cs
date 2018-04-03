using System;
using Xunit;

namespace Todsphol.Myname.Tests
{
    public class TestName
    {
        private Name myName;
        public TestName() {
            myName = new Name();
        }
        [Fact]
        public void TestGetNameWithoutLangugeShouldReturnMyNameInEnglish()
        {
            string result = myName.Get();

            Assert.Equal("Todsphol", result);
        }

        [Fact]
        public void TestGetnameWithEnglishLanguageShouldReturnMyNameInEnglish() 
        {
            string result = myName.Get("e");
            Assert.Equal("Todsphol", result);
        }

        [Fact]
        public void TestGetNameWithThaiLanguageShoudReturnMyNameInThai() 
        {
            string result = myName.Get("t");
            Assert.Equal("ทศพล", result);
        }

        [Theory]
        [InlineData ("e", "Todsphol")]
        [InlineData ("t", "ทศพล")]

        public void TestGetNameWithLanguageShouldRerurnMyNameInGivenLanguage(string inputLanguage, string expectedResult) 
        {
            string result = myName.Get(inputLanguage);
            Assert.Equal(expectedResult, result);
        }
    }

}
