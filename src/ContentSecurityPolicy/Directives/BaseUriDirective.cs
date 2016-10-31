namespace ContentSecurityPolicy
{
    public class BaseUriDirective : Directive
    {
        public BaseUriDirective()
            : this(Constants.SelfKeyword)
        {
        }

        public BaseUriDirective(params string[] values)
            : base(Constants.BaseUriDirectiveKey)
        {
            AddValues(values);
        }
    }
}
