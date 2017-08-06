namespace ContentSecurityPolicy
{
    public class StyleSourceDirective : Directive
    {
        public StyleSourceDirective()
            : this(Constants.SelfKeyword)
        {
        }

        public StyleSourceDirective(params string[] values)
            : base(Constants.StyleSourceDirectiveKey)
        {
            AddValues(values);
        }
    }
}
