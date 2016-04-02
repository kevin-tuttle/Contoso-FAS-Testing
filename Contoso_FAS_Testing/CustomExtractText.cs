using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.WebTesting.Rules;

namespace Contoso_FAS_Testing
{
    public sealed class CustomExtractText: ExtractText
    {
        public CustomExtractText(string start, string end, string context)
        {
            StartsWith = start;
            EndsWith = end;
            ContextParameterName = context;
            IgnoreCase = false;
            UseRegularExpression = false;
            Required = true;
            ExtractRandomMatch = false;
            Index = 0;
            HtmlDecode = true;
            SearchInHeaders = false;
        }
    }
}
