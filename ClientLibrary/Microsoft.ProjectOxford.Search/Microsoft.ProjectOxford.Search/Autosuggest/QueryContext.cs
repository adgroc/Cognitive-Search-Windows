using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Autosuggest
{
    public class QueryContext
    {
        #region Properties

        [JsonProperty("originalQuery")]
        public string OriginalQuery
        {
            get;
            set;
        }

        #endregion Properties
    }
}
