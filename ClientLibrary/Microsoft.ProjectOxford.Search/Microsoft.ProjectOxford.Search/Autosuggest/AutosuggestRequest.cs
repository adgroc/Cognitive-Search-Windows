using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Autosuggest
{
    public class AutosuggestRequest
    {
        #region Properties

        public string Query
        {
            get;
            set;
        }

        public string Market
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        public void Validate()
        {
            if (String.IsNullOrWhiteSpace(this.Query))
            {
                throw new QueryNotSpecifiedException();
            }
        }

        #endregion Methods
    }
}
