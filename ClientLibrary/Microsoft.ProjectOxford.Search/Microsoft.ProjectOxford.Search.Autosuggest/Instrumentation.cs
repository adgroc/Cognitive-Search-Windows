using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Autosuggest
{
    public class Instrumentation
    {
        #region Properties

        [JsonProperty("pingUrlBase")]
        public string PingUrlBase
        {
            get;
            set;
        }

        [JsonProperty("pageLoadPingUrl")]
        public string PageLoadPingUrl
        {
            get;
            set;
        }

        #endregion
    }
}
