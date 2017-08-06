using System;

namespace ContentSecurityPolicy
{
    public class Sha256Directive : Directive
    {
        public Sha256Directive()
            : this(Constants.SelfKeyword)
        {
        }

        public Sha256Directive(params string[] values)
            : base(Constants.ScriptSourceDirectiveKey)
        {
            foreach (var sha in values)
            {
                AddValue($"'{Constants.Sha256Prefix}{sha}'");
            }
        }

        public Sha256Directive(Func<string> o)
            : base(Constants.ScriptSourceDirectiveKey)
        {
            var sha = o();
            AddValue($"'{Constants.Sha256Prefix}{sha}'");
        }
    }
}
