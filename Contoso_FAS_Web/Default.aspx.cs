using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Contoso_FAS_Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            postResult.InnerHtml =
                $"<hr/><br/>First: {Request["firstName"]}<br/>Last: {Request["lastName"]}<br/>Email: {Request["Email"]}<br/><br/>";
        }
    }
}