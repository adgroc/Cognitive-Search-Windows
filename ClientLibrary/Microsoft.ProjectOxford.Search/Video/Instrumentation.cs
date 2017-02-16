using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Video
{
    /// <summary>
    /// Instrumentation returned from video search API.
    /// </summary>
    public class Instrumentation
    {
        #region Properties

        /// <summary>
        /// Gets or sets the page load ping URL.
        /// </summary>
        /// <value>
        /// The page load ping URL.
        /// </value>
        [JsonProperty("pageLoadPingUrl")]
        public string PageLoadPingUrl
        {
            get;
            set;
        }

        #endregion
    }
}
