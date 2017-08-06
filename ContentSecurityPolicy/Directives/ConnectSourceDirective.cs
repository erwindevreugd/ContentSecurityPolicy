namespace ContentSecurityPolicy
{
    public class ConnectSourceDirective : Directive
    {
        public ConnectSourceDirective()
            : this(Constants.SelfKeyword)
        {
        }

        public ConnectSourceDirective(params string[] values)
            : base(Constants.ConnectSourceDirectiveKey)
        {
            AddValues(values);
        }
    }
}
