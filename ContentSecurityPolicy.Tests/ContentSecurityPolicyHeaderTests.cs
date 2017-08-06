using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace ContentSecurityPolicy.Tests
{
    public class ContentSecurityPolicyHeaderTests
    {
        [Fact]
        public void AddingDefaultContentSecurityPolicyDirectivesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.AddDefaultContentSecurityPolicyDirectives();

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "default-src 'none'; script-src 'self'; connect-src 'self'; img-src 'self'; style-src 'self'; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetBaseUrisAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.SetBaseUris("example.com");

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "base-uri example.com; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowScriptSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.AllowScriptSources("example.com");

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "script-src example.com; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowStyleSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.AllowStyleSources("example.com");

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "style-src example.com; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowImageSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.AllowImageSources("example.com");

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "img-src example.com; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowConnectSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.AllowConnectSources("example.com");

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "connect-src example.com; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowFontSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.AllowFontSources("example.com");

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "font-src example.com; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowObjectSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.AllowObjectSources("example.com");

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "object-src example.com; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowMediaSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.AllowMediaSources("example.com");

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "media-src example.com; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowChildSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.AllowChildSources("example.com");

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "child-src example.com; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowFormActionsAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.AllowFormActions("example.com");

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "form-action example.com; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowFrameAncestorsAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.AllowFrameAncestors("example.com");

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "frame-ancestors example.com; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowManifestSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.AllowManifestSources("example.com");

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "manifest-src example.com; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UpgradeInsecureRequestsAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.UpgradeInsecureRequests();

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "upgrade-insecure-requests; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddScriptNonceAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            var nonce = "14D0F2FF-CDBF-47CF-8A4C-1BE3D77D0679";
            policy.AddScriptNonce(nonce);

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "script-src 'nonce-14D0F2FF-CDBF-47CF-8A4C-1BE3D77D0679'; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddScriptNonceWithStrictDynamicAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            var nonce = "14D0F2FF-CDBF-47CF-8A4C-1BE3D77D0679";
            policy.AddScriptNonce(nonce);
            policy.SetStrictDynamic();

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "script-src 'nonce-14D0F2FF-CDBF-47CF-8A4C-1BE3D77D0679' 'strict-dynamic'; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddScriptSha256AddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            var sha = "9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08";
            policy.AddScriptSha256(sha);

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "script-src 'sha256-9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08'; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddScriptSha256WithStrictDynamicAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            var sha = "9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08";
            policy.AddScriptSha256(sha);
            policy.SetStrictDynamic();

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "script-src 'sha256-9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08' 'strict-dynamic'; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetStrictDynamicAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.SetStrictDynamic();

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "script-src 'strict-dynamic'; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowUnsafeInlineStylesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.AllowUnsafeInlineStyles();

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "style-src 'unsafe-inline'; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowUnsafeInlineScriptsAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.AllowUnsafeInlineScripts();

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "script-src 'unsafe-inline'; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowUnsafeInlineEvalAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeaderBuilder();
            policy.AllowUnsafeEvalScripts();

            var expected = new KeyValuePair<string, string>("Content-Security-Policy", "script-src 'unsafe-eval'; ");
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        private class KeyValuePairComparer : IEqualityComparer<KeyValuePair<string, string>>
        {
            public KeyValuePairComparer()
            {
            }

            public bool Equals(KeyValuePair<string, string> x, KeyValuePair<string, string> y)
            {
            return x.Key == y.Key && x.Value == y.Value;
            }

            public int GetHashCode(KeyValuePair<string, string> obj)
            {
                return obj.GetHashCode();
            }
        }
    }
}
