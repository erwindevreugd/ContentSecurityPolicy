using System;

namespace ContentSecurityPolicy
{
    public static class ContentSecurityPolicyHeaderExtensions
    {
        public static ContentSecurityPolicyHeaderBuilder AddDefaultContentSecurityPolicyDirectives(this ContentSecurityPolicyHeaderBuilder header)
        {
            return header
                .AddDirective(new DefaultSourceDirective(Constants.NoneKeyword))
                .AddDirective(new ScriptSourceDirective(Constants.SelfKeyword))
                .AddDirective(new ConnectSourceDirective(Constants.SelfKeyword))
                .AddDirective(new ImageSourceDirective(Constants.SelfKeyword))
                .AddDirective(new StyleSourceDirective(Constants.SelfKeyword));
        }

        public static ContentSecurityPolicyHeaderBuilder ReportOnly(this ContentSecurityPolicyHeaderBuilder header)
        {
            header.ReportOnly = true;

            return header;
        }

        public static ContentSecurityPolicyHeaderBuilder AddDirective(this ContentSecurityPolicyHeaderBuilder header, BaseUriDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeaderBuilder AddDirective(this ContentSecurityPolicyHeaderBuilder header, ChildSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeaderBuilder AddDirective(this ContentSecurityPolicyHeaderBuilder header, ConnectSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeaderBuilder AddDirective(this ContentSecurityPolicyHeaderBuilder header, DefaultSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeaderBuilder AddDirective(this ContentSecurityPolicyHeaderBuilder header, FontSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeaderBuilder AddDirective(this ContentSecurityPolicyHeaderBuilder header, FormActionDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeaderBuilder AddDirective(this ContentSecurityPolicyHeaderBuilder header, FrameAncestorsDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeaderBuilder AddDirective(this ContentSecurityPolicyHeaderBuilder header, ImageSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeaderBuilder AddDirective(this ContentSecurityPolicyHeaderBuilder header, ManifestSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeaderBuilder AddDirective(this ContentSecurityPolicyHeaderBuilder header, MediaSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeaderBuilder AddDirective(this ContentSecurityPolicyHeaderBuilder header, NonceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeaderBuilder AddDirective(this ContentSecurityPolicyHeaderBuilder header, ObjectSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeaderBuilder AddDirective(this ContentSecurityPolicyHeaderBuilder header, ScriptSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeaderBuilder AddDirective(this ContentSecurityPolicyHeaderBuilder header, Sha256Directive directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeaderBuilder AddDirective(this ContentSecurityPolicyHeaderBuilder header, StyleSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeaderBuilder AddDirective(this ContentSecurityPolicyHeaderBuilder header, UpgradeInsecureRequestsDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeaderBuilder ClearDirectives(this ContentSecurityPolicyHeaderBuilder header)
        {
            return header.ClearDirectives();
        }

        public static ContentSecurityPolicyHeaderBuilder SetBaseUris(this ContentSecurityPolicyHeaderBuilder header, params string[] uris)
        {
            return header.AddDirective(new BaseUriDirective(uris));
        }

        public static ContentSecurityPolicyHeaderBuilder AllowScriptSources(this ContentSecurityPolicyHeaderBuilder header, params string[] sources)
        {
            return header.AddDirective(new ScriptSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeaderBuilder AllowStyleSources(this ContentSecurityPolicyHeaderBuilder header, params string[] sources)
        {
            return header.AddDirective(new StyleSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeaderBuilder AllowImageSources(this ContentSecurityPolicyHeaderBuilder header, params string[] sources)
        {
            return header.AddDirective(new ImageSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeaderBuilder AllowConnectSources(this ContentSecurityPolicyHeaderBuilder header, params string[] sources)
        {
            return header.AddDirective(new ConnectSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeaderBuilder AllowFontSources(this ContentSecurityPolicyHeaderBuilder header, params string[] sources)
        {
            return header.AddDirective(new FontSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeaderBuilder AllowObjectSources(this ContentSecurityPolicyHeaderBuilder header, params string[] sources)
        {
            return header.AddDirective(new ObjectSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeaderBuilder AllowMediaSources(this ContentSecurityPolicyHeaderBuilder header, params string[] sources)
        {
            return header.AddDirective(new MediaSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeaderBuilder AllowChildSources(this ContentSecurityPolicyHeaderBuilder header, params string[] sources)
        {
            return header.AddDirective(new ChildSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeaderBuilder AllowFormActions(this ContentSecurityPolicyHeaderBuilder header, params string[] sources)
        {
            return header.AddDirective(new FormActionDirective(sources));
        }

        public static ContentSecurityPolicyHeaderBuilder AllowFrameAncestors(this ContentSecurityPolicyHeaderBuilder header, params string[] sources)
        {
            return header.AddDirective(new FrameAncestorsDirective(sources));
        }

        public static ContentSecurityPolicyHeaderBuilder AllowManifestSources(this ContentSecurityPolicyHeaderBuilder header, params string[] sources)
        {
            return header.AddDirective(new ManifestSourceDirective(sources));
        }

        public static ContentSecurityPolicyHeaderBuilder UpgradeInsecureRequests(this ContentSecurityPolicyHeaderBuilder header)
        {
            return header.AddDirective(new UpgradeInsecureRequestsDirective());
        }

        public static ContentSecurityPolicyHeaderBuilder AllowUnsafeInlineScripts(this ContentSecurityPolicyHeaderBuilder header)
        {
            return header.AddDirective(new ScriptSourceDirective(Constants.UnsafeInlineKeyword));
        }

        public static ContentSecurityPolicyHeaderBuilder AllowUnsafeInlineStyles(this ContentSecurityPolicyHeaderBuilder header)
        {
            return header.AddDirective(new StyleSourceDirective(Constants.UnsafeInlineKeyword));
        }

        public static ContentSecurityPolicyHeaderBuilder AllowUnsafeEvalScripts(this ContentSecurityPolicyHeaderBuilder header)
        {
            return header.AddDirective(new ScriptSourceDirective(Constants.UnsafeEvalKeyword));
        }

        public static ContentSecurityPolicyHeaderBuilder SetStrictDynamic(this ContentSecurityPolicyHeaderBuilder header)
        {
            return header.AddDirective(new ScriptSourceDirective(Constants.StrictDynamicKeyword));
        }

        public static ContentSecurityPolicyHeaderBuilder AddScriptNonce(this ContentSecurityPolicyHeaderBuilder header, string nonce)
        {
            return header.AddDirective(new NonceDirective(nonce));
        }

        public static ContentSecurityPolicyHeaderBuilder AddScriptNonce(this ContentSecurityPolicyHeaderBuilder header, Func<string> nonce)
        {
            return header.AddDirective(new NonceDirective(nonce));
        }

        public static ContentSecurityPolicyHeaderBuilder AddScriptSha256(this ContentSecurityPolicyHeaderBuilder header, string sha)
        {
            return header.AddDirective(new Sha256Directive(sha));
        }

        public static ContentSecurityPolicyHeaderBuilder AddScriptSha256(this ContentSecurityPolicyHeaderBuilder header, Func<string> sha)
        {
            return header.AddDirective(new Sha256Directive(sha));
        }

        public static ContentSecurityPolicyHeaderBuilder AddReportUri(this ContentSecurityPolicyHeaderBuilder header, string uri)
        {
            return header.AddDirective(new ReportUriDirective(uri));
        }
    }
}
