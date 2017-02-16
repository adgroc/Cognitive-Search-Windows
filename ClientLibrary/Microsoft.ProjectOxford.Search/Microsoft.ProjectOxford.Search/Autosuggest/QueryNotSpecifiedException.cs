using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Autosuggest
{
    public class QueryNotSpecifiedException : ApplicationException
    {
        #region Properties

        public override string Message
        {
            get
            {
                return "Query not specified.";
            }
        }

        #endregion Properties
    }
}
