using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.ProjectOxford.Search.Autosuggest;

namespace Microsoft.ProjectOxford.Search.Test
{
    [TestClass]
    public class AutosuggestClientTest : SearchTest
    {
        #region Test Methods

        [TestMethod]
        [TestCategory("Autosuggest")]
        [ExpectedException(typeof(QueryNotSpecifiedException))]
        public void ValidateTest_QueryNotSpecified()
        {
            var request = new AutosuggestRequest();
            request.Validate();
        }

        [TestMethod]
        [TestCategory("Autosuggest")]
        public void GetSuggestionsTest()
        {
            var request = new AutosuggestRequest();
            request.Query = "bill gates";
            request.Market = "en-us";

            var client = new AutosuggestClient(this.apiKey);

            var response = client.GetSuggestions(request);

            Assert.Inconclusive();
        }

        #endregion Test Methods
    }
}
