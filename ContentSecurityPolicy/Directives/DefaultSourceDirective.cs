namespace ContentSecurityPolicy
{
    public class DefaultSourceDirective : Directive
    {
        public DefaultSourceDirective()
            : this(Constants.SelfKeyword)
        {
        }

        public DefaultSourceDirective(params string[] values)
            : base(Constants.DefaultSourceDirectiveKey)
        {
            AddValues(values);
        }
    }
}
