using OSWebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OsTest
{

    public class StringServiceTest 
    {
        private readonly ICustomStringService _customStringService;
        public StringServiceTest()
        {
            _customStringService = new  CustomStringService();
        }

        [Theory]
        [InlineData("Test string", "gnirts tseT")]
        [InlineData("Hello", "olleH")]
        public void ReverseStringTest(string inputString, string expectedString)
        {
            string resultString = _customStringService.ReverseString(inputString);
            Assert.Equal(expectedString, resultString);
        }

        [Theory]
        [InlineData("TEST STRING", "TeST STRiNG")]
        [InlineData("HELLO", "HeLLo")]
        public void ConvertVowelsToLowercaseTest(string inputString, string expectedString)
        {
            string resultString = _customStringService.ConvertVowelsToLowercase(inputString);
            Assert.Equal(expectedString, resultString);
        }

        [Theory]
        [InlineData("test string", "TeST STRiNG")]
        [InlineData("HEllo", "HELLo")]
        public void ConvertConsonantsToUppercaseTest(string inputString, string expectedString)
        {
            string resultString = _customStringService.ConvertConsonantsToUppercase(inputString);
            Assert.Equal(expectedString, resultString);
        }

        [Theory]
        [InlineData("0Test22 5st3ring44", "Test string")]
        [InlineData("He23LLo!", "HeLLo!")]
        public void IgnoreNumbersInWordTest(string inputString, string expectedString)
        {
            string resultString = _customStringService.IgnoreNumbersInWord(inputString);
            Assert.Equal(expectedString, resultString);
        }
    }
}

//Hre is the reason i used IClassFixture<CustomStringService>
//https://stackoverflow.com/questions/51155987/the-following-constructor-parameters-did-not-have-matching-fixture-data


