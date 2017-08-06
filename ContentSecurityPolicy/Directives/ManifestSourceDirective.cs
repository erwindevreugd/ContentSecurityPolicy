namespace ContentSecurityPolicy
{
    public class ManifestSourceDirective : Directive
    {
        public ManifestSourceDirective()
            : this(Constants.SelfKeyword)
        {
        }

        public ManifestSourceDirective(params string[] values)
            : base(Constants.ManifestSourceDirectiveKey)
        {
            AddValues(values);
        }
    }
}
