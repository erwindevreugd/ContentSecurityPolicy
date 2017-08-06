namespace ContentSecurityPolicy
{
    public class ImageSourceDirective : Directive
    {
        public ImageSourceDirective()
            : this(Constants.SelfKeyword)
        {
        }

        public ImageSourceDirective(params string[] values)
            : base(Constants.ImageSourceDirectiveKey)
        {
            AddValues(values);
        }
    }
}
