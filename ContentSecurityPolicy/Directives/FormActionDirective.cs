namespace ContentSecurityPolicy
{
    public class FormActionDirective : Directive
    {
        public FormActionDirective()
            : this(Constants.SelfKeyword)
        {
        }

        public FormActionDirective(params string[] values)
            : base(Constants.FormActionDirectiveKey)
        {
            AddValues(values);
        }
    }
}
