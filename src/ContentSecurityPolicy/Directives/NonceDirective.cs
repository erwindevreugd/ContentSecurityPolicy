using System;

namespace ContentSecurityPolicy
{
    public class NonceDirective : Directive
    {
        public NonceDirective()
            : this(Constants.SelfKeyword)
        {
        }

        public NonceDirective(params string[] values)
            : base(Constants.ScriptSourceDirectiveKey)
        {
            foreach (var nonce in values)
            {
                AddValue($"'{Constants.NoncePrefix}{nonce}'");
            }
        }

        public NonceDirective(Func<string> o)
            : base(Constants.ScriptSourceDirectiveKey)
        {
            var nonce = o();
            AddValue($"'{Constants.NoncePrefix}{nonce}'");
        }
    }
}
