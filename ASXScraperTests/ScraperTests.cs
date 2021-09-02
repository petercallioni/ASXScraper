using Xunit;
using ASXScraper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASXScraper.Tests
{
    public class ScraperTests
    {
        [Theory]
        [InlineData("VDHG")]
        public void RetrieveDataFromAsxTest(string value)
        {
            ASXScraper.Scraper scraper = new Scraper();
            Assert.True(scraper.GetData(value).Code == value );
        }
    }
}