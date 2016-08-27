using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlugDemo.Components
{
    public class AcceptedActionResult : IActionResult
    {
        public string RefId { get; set; }

        public Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.StatusCode = 202; // Accept
            context.HttpContext.Response.Headers.Add("X-RefId", this.RefId);

            return Task.FromResult<object>(null);
        }
    }
}
