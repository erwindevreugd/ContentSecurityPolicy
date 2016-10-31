# Content Security Policy Middleware for ASP.NET Core

The Content Security Policy middleware for ASP.NET Core adds the Content-Security-Policy HTTP response header to reduce the risks of XSS attacks on modern browsers.

How to use Content Security Policy middleware for ASP.NET Core
--------------------------------
* Include the **ContentSecurityPolicy** package in the **project.json**.
```Javascript
"dependencies": {
        "Microsoft.AspNetCore.Server.IISIntegration": "1.0.0",
        "Microsoft.AspNetCore.Server.Kestrel": "1.0.1",
        "Microsoft.Extensions.Logging.Console": "1.0.0",
        "ContentSecurityPolicy": "1.0.0.*"
    }
```
* Modify the **Configure** method in **startup.cs**.
```Javascript
public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
{
    app.UseContentSecurityPolicy(
        new ContentSecurityPolicyHeader()
            .AddDefaultContentSecurityPolicyDirectives()
        );

    app.Run(async (context) =>
    {
        await context.Response.WriteAsync("Hello Content Security Policy!");
    });
}
```
**AddDefaultContentSecurityPolicyDirectives** is a extension method on the **ContentSecurityPolicyHeader** class that adds a **Content-Security-Policy** with a default set of directives.
```Javascript
Content-Security-Policy:default-src 'none'; script-src 'self'; connect-src 'self'; img-src 'self'; style-src 'self';
```
