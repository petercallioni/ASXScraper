using Xunit;
using ASXScrapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASXScrapper.Tests
{
    public class ScraperTests
    {
        [Theory]
        [InlineData("DSK")]
        [InlineData("ASIA")]
        public void RetrieveObjectFromAsxTest(string value)
        {
            ASXScrapper.Scraper scrpaer = new Scraper();
            Assert.True(scrpaer.GetData(value).Code == value );
        }
    }
}