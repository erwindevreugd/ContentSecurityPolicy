namespace ContentSecurityPolicy
{
    public class ObjectSourceDirective : Directive
    {
        public ObjectSourceDirective()
            : this(Constants.SelfKeyword)
        {
        }

        public ObjectSourceDirective(params string[] values)
            : base(Constants.ObjectSourceDirectiveKey)
        {
            AddValues(values);
        }
    }
}
