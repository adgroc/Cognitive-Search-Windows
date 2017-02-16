using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Autosuggest
{
    public class SuggestionGroups
    {
        #region Constructors

        public SuggestionGroups()
        {
            this.SearchSuggestions = new List<SearchSuggestion>();
        }

        #endregion Constructors

        #region Properties

        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("searchSuggestions")]
        public List<SearchSuggestion> SearchSuggestions
        {
            get;
            set;
        }

        #endregion Properties
    }
}
