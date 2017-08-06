namespace ContentSecurityPolicy
{
    public class ChildSourceDirective : Directive
    {
        public ChildSourceDirective()
            : this(Constants.SelfKeyword)
        {
        }

        public ChildSourceDirective(params string[] values)
            : base(Constants.ChildSourceDirectiveKey)
        {
            AddValues(values);
        }
    }
}
