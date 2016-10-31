namespace ContentSecurityPolicy
{
    public class FontSourceDirective : Directive
    {
        public FontSourceDirective()
            : this(Constants.SelfKeyword)
        {
        }

        public FontSourceDirective(params string[] values)
            : base(Constants.FontSourceDirectiveKey)
        {
            AddValues(values);
        }
    }
}
