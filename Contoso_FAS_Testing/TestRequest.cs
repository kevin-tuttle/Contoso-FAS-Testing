using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.WebTesting;
using Microsoft.VisualStudio.TestTools.WebTesting.Rules;

namespace Contoso_FAS_Testing
{
    public class TestRequest : WebTestRequest
    {
        public TestRequest(string url) : base(url) { }

        public TestRequest(string url, string referer) : this(url)
        {
            Headers.Add(new WebTestRequestHeader("Referer", referer));
        }

        public TestRequest(string url, string referer, string bodyText) : this(url, referer)
        {
            Body = new StringHttpBody
            {
                ContentType = "application/json;charset=utf-8",
                InsertByteOrderMark = false,
                BodyString = bodyText
            };
        }

        public TestRequest(string url, string referer, string bodyText, ICollection<ExtractionRule> extractions) : this(url, referer, bodyText)
        {
            foreach (var extract in extractions)
            {
                ExtractValues += extract.Extract;
            }
        }
    }
}