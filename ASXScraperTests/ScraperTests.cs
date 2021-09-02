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
        [InlineData("VDHG")]
        public void RetrieveDataFromAsxTest(string value)
        {
            ASXScrapper.Scraper scraper = new Scraper();
            Assert.True(scraper.GetData(value).Code == value );
        }
    }
}