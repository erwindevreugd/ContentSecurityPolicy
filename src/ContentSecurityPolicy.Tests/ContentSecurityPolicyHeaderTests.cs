using Xunit;

namespace ContentSecurityPolicy.Tests
{
    public class ContentSecurityPolicyHeaderTests
    {
        [Fact]
        public void AddingDefaultContentSecurityPolicyDirectivesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            policy.AddDefaultContentSecurityPolicyDirectives();

            var expected = "default-src 'none'; script-src 'self'; connect-src 'self'; img-src 'self'; style-src 'self'; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetBaseUrisAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            policy.SetBaseUris("example.com");

            var expected = "base-uri example.com; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowScriptSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            policy.AllowScriptSources("example.com");

            var expected = "script-src example.com; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowStyleSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            policy.AllowStyleSources("example.com");

            var expected = "style-src example.com; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowImageSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            policy.AllowImageSources("example.com");

            var expected = "img-src example.com; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowConnectSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            policy.AllowConnectSources("example.com");

            var expected = "connect-src example.com; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowFontSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            policy.AllowFontSources("example.com");

            var expected = "font-src example.com; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowObjectSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            policy.AllowObjectSources("example.com");

            var expected = "object-src example.com; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowMediaSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            policy.AllowMediaSources("example.com");

            var expected = "media-src example.com; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowChildSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            policy.AllowChildSources("example.com");

            var expected = "child-src example.com; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowFormActionsAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            policy.AllowFormActions("example.com");

            var expected = "form-action example.com; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowFrameAncestorsAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            policy.AllowFrameAncestors("example.com");

            var expected = "frame-ancestors example.com; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowManifestSourcesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            policy.AllowManifestSources("example.com");

            var expected = "manifest-src example.com; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UpgradeInsecureRequestsAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            policy.UpgradeInsecureRequests();

            var expected = "upgrade-insecure-requests; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddScriptNonceAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            var nonce = "14D0F2FF-CDBF-47CF-8A4C-1BE3D77D0679";
            policy.AddScriptNonce(nonce);

            var expected = "script-src 'nonce-14D0F2FF-CDBF-47CF-8A4C-1BE3D77D0679'; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowUnsafeInlineStylesAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            policy.AllowUnsafeInlineStyles();

            var expected = "style-src 'unsafe-inline'; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowUnsafeInlineScriptsAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            policy.AllowUnsafeInlineScripts();

            var expected = "script-src 'unsafe-inline'; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllowUnsafeInlineEvalAddsExpectedValues()
        {
            var policy = new ContentSecurityPolicyHeader();
            policy.AllowUnsafeEvalScripts();

            var expected = "script-src 'unsafe-eval'; ";
            var actual = policy.Compose();

            Assert.Equal(expected, actual);
        }
    }
}
