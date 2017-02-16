using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Autosuggest
{
    public class SearchSuggestion
    {
        #region Properties

        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }

        [JsonProperty("urlPingSuffix")]
        public string UrlPingSuffix
        {
            get;
            set;
        }

        [JsonProperty("displayText")]
        public string DisplayText
        {
            get;
            set;
        }

        [JsonProperty("query")]
        public string Query
        {
            get;
            set;
        }

        [JsonProperty("documents")]
        public string SearchKind
        {
            get;
            set;
        }

        #endregion Properties
    }
}
