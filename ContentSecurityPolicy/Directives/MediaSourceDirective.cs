namespace ContentSecurityPolicy
{
    public class MediaSourceDirective : Directive
    {
        public MediaSourceDirective()
            : this(Constants.SelfKeyword)
        {
        }

        public MediaSourceDirective(params string[] values)
            : base(Constants.MediaSourceDirectiveKey)
        {
            AddValues(values);
        }
    }
}
