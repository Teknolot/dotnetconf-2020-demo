using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace SPA
{
    //Workaround for issue #3986 
    //https://github.com/Azure/azure-functions-host/issues/3986
    public class CustomRedirectResult : StatusCodeResult
    {
        public string Url { get; set; }

        public CustomRedirectResult(string url) : base(307)
        {
            Url = url;
        }

        public override void ExecuteResult(ActionContext context)
        {
            base.ExecuteResult(context);
            context.HttpContext.Response.Redirect(Url, false);
        }
    }
}
