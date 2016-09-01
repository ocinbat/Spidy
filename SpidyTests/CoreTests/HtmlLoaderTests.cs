using HtmlAgilityPack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpidyCore;
using FluentAssertions;

namespace SpidyTests.CoreTests
{
    [TestClass]
    public class HtmlLoaderTests
    {
        private HtmlLoader _htmlLoader;

        [TestInitialize]
        public void TestInit()
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            _htmlLoader = new HtmlLoader(htmlWeb);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Load_With_Invalid_Url_Should_Throw_Argument_Exception_Test()
        {
            string url = "www.invalidUrl.com";

            HtmlDocument result = _htmlLoader.Load(url);

            result.Should().BeNull();

        }

        [TestMethod]
        public void Load_With_Invalid_Url_Should_Test()
        {
            string url = "http://www.validUrl.com";

            HtmlDocument result = _htmlLoader.Load(url);

            result.Should().NotBeNull();
        }
    }
}
