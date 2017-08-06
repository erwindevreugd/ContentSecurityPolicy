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

        public static ContentSecurityPolicyHeader ReportOnly(this ContentSecurityPolicyHeader header)
        {
            header.ReportOnly = true;

            return header;
        }

        public static ContentSecurityPolicyHeader AddDirective(this ContentSecurityPolicyHeader header, BaseUriDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeader AddDirective(this ContentSecurityPolicyHeader header, ChildSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeader AddDirective(this ContentSecurityPolicyHeader header, ConnectSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeader AddDirective(this ContentSecurityPolicyHeader header, DefaultSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeader AddDirective(this ContentSecurityPolicyHeader header, FontSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeader AddDirective(this ContentSecurityPolicyHeader header, FormActionDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeader AddDirective(this ContentSecurityPolicyHeader header, FrameAncestorsDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeader AddDirective(this ContentSecurityPolicyHeader header, ImageSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeader AddDirective(this ContentSecurityPolicyHeader header, ManifestSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeader AddDirective(this ContentSecurityPolicyHeader header, MediaSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeader AddDirective(this ContentSecurityPolicyHeader header, NonceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeader AddDirective(this ContentSecurityPolicyHeader header, ObjectSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeader AddDirective(this ContentSecurityPolicyHeader header, ScriptSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeader AddDirective(this ContentSecurityPolicyHeader header, Sha256Directive directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeader AddDirective(this ContentSecurityPolicyHeader header, StyleSourceDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeader AddDirective(this ContentSecurityPolicyHeader header, UpgradeInsecureRequestsDirective directive)
        {
            return header.AddDirective(directive);
        }

        public static ContentSecurityPolicyHeader ClearDirectives(this ContentSecurityPolicyHeader header)
        {
            return header.ClearDirectives();
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

        public static ContentSecurityPolicyHeader AllowManifestSources(this ContentSecurityPolicyHeader header, params string[] sources)
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

        public static ContentSecurityPolicyHeader SetStrictDynamic(this ContentSecurityPolicyHeader header)
        {
            return header.AddDirective(new ScriptSourceDirective(Constants.StrictDynamicKeyword));
        }

        public static ContentSecurityPolicyHeader AddScriptNonce(this ContentSecurityPolicyHeader header, string nonce)
        {
            return header.AddDirective(new NonceDirective(nonce));
        }

        public static ContentSecurityPolicyHeader AddScriptNonce(this ContentSecurityPolicyHeader header, Func<string> nonce)
        {
            return header.AddDirective(new NonceDirective(nonce));
        }

        public static ContentSecurityPolicyHeader AddScriptSha256(this ContentSecurityPolicyHeader header, string sha)
        {
            return header.AddDirective(new Sha256Directive(sha));
        }

        public static ContentSecurityPolicyHeader AddScriptSha256(this ContentSecurityPolicyHeader header, Func<string> sha)
        {
            return header.AddDirective(new Sha256Directive(sha));
        }

        public static ContentSecurityPolicyHeader AddReportUri(this ContentSecurityPolicyHeader header, string uri)
        {
            return header.AddDirective(new ReportUriDirective(uri));
        }
    }
}
