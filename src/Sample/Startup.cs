using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentSecurityPolicy;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Sample
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {

            }

            app.UseContentSecurityPolicy(
                new ContentSecurityPolicyHeader()
                    .AddDefaultContentSecurityPolicyDirectives()
                    .AddScriptNonce(this.GenerateNonce)
                    .AddReportUri("http://localhost:62891/CSP")
                    .ReportOnly()
                //.AllowScriptSources("ajax.googleapis.com")
                //.AllowUnsafeInlineStyles()
                //.UpgradeInsecureRequests()
                );

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello Content Security Policy!");
            });
        }

        public string GenerateNonce()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
