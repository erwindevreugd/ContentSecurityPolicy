namespace ContentSecurityPolicy
{
    public class ScriptSourceDirective : Directive
    {
        public ScriptSourceDirective()
            : this(Constants.SelfKeyword)
        {
        }

        public ScriptSourceDirective(params string[] values)
            : base(Constants.ScriptSourceDirectiveKey)
        {
            AddValues(values);
        }
    }
}
