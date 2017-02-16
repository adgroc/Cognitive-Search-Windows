using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.ProjectOxford.Search.Autosuggest;
using System.Configuration;

namespace Microsoft.ProjectOxford.Search.Test
{
    [TestClass]
    public class AutosuggestClientTest
    {
        #region Fields

        protected string apiKey = "";

        #endregion Fields

        #region Test Initialization

        /// <summary>
        /// Intializes this instance.
        /// </summary>
        [TestInitialize]
        public void Intialize()
        {
            apiKey = ConfigurationManager.AppSettings["autosuggestApiKey"];
        }

        #endregion Test Initialization

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

            Assert.IsTrue(response.SuggestionGroups.Count >= 0);
            Assert.IsTrue(response.SuggestionGroups[0].SearchSuggestions.Count >= 0);
        }

        #endregion Test Methods
    }
}
