using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ProjectOxford.Search.Core;
using Newtonsoft.Json;
using System.Net;

namespace Microsoft.ProjectOxford.Search.Autosuggest
{
    public class AutosuggestClient : SearchClient
    {
        #region Constructors

        public AutosuggestClient(string apiKey)
            : base(apiKey)
        {
            this.Url = "https://api.cognitive.microsoft.com/bing/v5.0/suggestions";
        }

        #endregion Constructors

        #region Methods

        public AutosuggestResponse GetSuggestions(AutosuggestRequest request)
        {
            return GetSuggestionsAsync(request).Result;
        }

        public async Task<AutosuggestResponse> GetSuggestionsAsync(AutosuggestRequest request)
        {
            var requestUrl = string.Format("{0}/?q={1}", this.Url, WebUtility.UrlEncode(request.Query));

            if (!string.IsNullOrEmpty(request.Market))
                requestUrl = string.Format("{0}&mkt={1}", requestUrl, request.Market);

            var responseJson = await this.SendGetAsync(requestUrl);
            var response = JsonConvert.DeserializeObject<AutosuggestResponse>(responseJson);

            return response;
        }

        #endregion Methods
    }
}
