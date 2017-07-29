# Content Security Policy Middleware for ASP.NET Core

[Build status](https://erwindevreugd.visualstudio.com/_apis/public/build/definitions/566f2eff-9991-4643-9a77-4e84bdb1cd31/1/badge)

The Content Security Policy middleware for ASP.NET Core adds the Content-Security-Policy HTTP response header to reduce the risks of XSS attacks on modern browsers.

How to use Content Security Policy middleware for ASP.NET Core
--------------------------------
* Include the **ContentSecurityPolicy** package in the **project.json**.
```Javascript
"dependencies": {
        "ContentSecurityPolicy": ""
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
