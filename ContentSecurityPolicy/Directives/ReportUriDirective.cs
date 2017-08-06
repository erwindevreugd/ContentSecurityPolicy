using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentSecurityPolicy
{
    public class ReportUriDirective : Directive
    {
        public ReportUriDirective(string uri)
            : base(Constants.ReportUriDirectiveKey)
        {
            AddValue(uri);
        }
    }
}
