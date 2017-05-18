using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp
{
    public class RequestCultureMiddleware
    {
        private readonly RequestDelegate next;

        private readonly RequestCultureOptions options;

        public RequestCultureMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public Task Invoke(HttpContext context)
        {
            CultureInfo requestCulture = null;

            var cultureQuery = context.Request.Query["culture"];
            if (!string.IsNullOrWhiteSpace(cultureQuery))
            {
                requestCulture = new CultureInfo(cultureQuery);
            }
            else
            {
                requestCulture = this.options.DefaultCulture;
            }

            if (requestCulture != null)
            {
                CultureInfo.CurrentCulture = requestCulture;
                CultureInfo.CurrentUICulture = requestCulture;
            }

            return this.next(context);

        }
    }

}
