using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Autosuggest
{
    public class AutosuggestResponse
    {
        #region Constructors

        public AutosuggestResponse()
        {
            this.Instrumentation = new Instrumentation();
            this.QueryContext = new QueryContext();
            this.SuggestionGroups = new SuggestionGroups();
        }

        #endregion Constructors

        #region Properties

        [JsonProperty("_type")]
        public string Type
        {
            get;
            set;
        }

        [JsonProperty("instrumentation")]
        public Instrumentation Instrumentation
        {
            get;
            set;
        }

        [JsonProperty("queryConext")]
        public QueryContext QueryContext
        {
            get;
            set;
        }

        [JsonProperty("suggestionGroups")]
        public SuggestionGroups SuggestionGroups
        {
            get;
            set;
        }

        #endregion Properties
    }
}
