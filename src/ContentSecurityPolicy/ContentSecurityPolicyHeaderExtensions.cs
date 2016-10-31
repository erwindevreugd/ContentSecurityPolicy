using System;

namespace ContentSecurityPolicy
{
    public static class ContentSecurityPolicyHeaderExtensions
    {
        public static ContentSecurityPolicyHeader AddDefaultContentSecurityPolicyDirectives(this ContentSecurityPolicyHeader header)
        {
            return header
                .AddDirective(new DefaultSourceDirective(Constants.NoneKeyword))
                .AddDirective(new ScriptSourceDirective(Constants.SelfKeyword))
                .AddDirective(new ConnectSourceDirective(Constants.SelfKeyword))
                .AddDirective(new ImageSourceDirective(Constants.SelfKeyword))
                .AddDirective(new StyleSourceDirective(Constants.SelfKeyword));
        }

        public static ContentSecurityPolicyHeader SetBaseUris(this ContentSecurityPolicyHeader header, params string[] uris)
        {
            return header.AddDirective(new BaseUriDirective(uris));
        }

        public static ContentSecurityPolicyHeader AllowScriptSources(this ContentSecurityPolicyHeader header, params string[] sources)
        {
            return header.AddDirective(new ScriptSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeader AllowStyleSources(this ContentSecurityPolicyHeader header, params string[] sources)
        {
            return header.AddDirective(new StyleSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeader AllowImageSources(this ContentSecurityPolicyHeader header, params string[] sources)
        {
            return header.AddDirective(new ImageSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeader AllowConnectSources(this ContentSecurityPolicyHeader header, params string[] sources)
        {
            return header.AddDirective(new ConnectSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeader AllowFontSources(this ContentSecurityPolicyHeader header, params string[] sources)
        {
            return header.AddDirective(new FontSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeader AllowObjectSources(this ContentSecurityPolicyHeader header, params string[] sources)
        {
            return header.AddDirective(new ObjectSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeader AllowMediaSources(this ContentSecurityPolicyHeader header, params string[] sources)
        {
            return header.AddDirective(new MediaSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeader AllowChildSources(this ContentSecurityPolicyHeader header, params string[] sources)
        {
            return header.AddDirective(new ChildSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeader AllowFormActions(this ContentSecurityPolicyHeader header, params string[] sources)
        {
            return header.AddDirective(new FormActionDirective(sources));
        }

        public static ContentSecurityPolicyHeader AllowFrameAncestors(this ContentSecurityPolicyHeader header, params string[] sources)
        {
            return header.AddDirective(new FrameAncestorsDirective(sources));
        }

        public static ContentSecurityPolicyHeader AllowManifestSource(this ContentSecurityPolicyHeader header, params string[] sources)
        {
            return header.AddDirective(new ManifestSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeader UpgradeInsecureRequests(this ContentSecurityPolicyHeader header)
        {
            return header.AddDirective(new UpgradeInsecureRequestsDirective());
        }

        public static ContentSecurityPolicyHeader AllowUnsafeInlineScripts(this ContentSecurityPolicyHeader header)
        {
            return header.AddDirective(new ScriptSourceDirective(Constants.UnsafeInlineKeyword));
        }

        public static ContentSecurityPolicyHeader AllowUnsafeInlineStyles(this ContentSecurityPolicyHeader header)
        {
            return header.AddDirective(new StyleSourceDirective(Constants.UnsafeInlineKeyword));
        }

        public static ContentSecurityPolicyHeader AllowUnsafeEvalScripts(this ContentSecurityPolicyHeader header)
        {
            return header.AddDirective(new ScriptSourceDirective(Constants.UnsafeEvalKeyword));
        }

        public static ContentSecurityPolicyHeader AddScriptNonce(this ContentSecurityPolicyHeader header, string nonce)
        {
            return header.AddDirective(new NonceDirective(nonce));
        }

        public static ContentSecurityPolicyHeader AddScriptNonce(this ContentSecurityPolicyHeader header, Func<string> nonce)
        {
            return header.AddDirective(new NonceDirective(nonce));
        }
    }
}
