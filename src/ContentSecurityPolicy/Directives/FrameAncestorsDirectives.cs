namespace ContentSecurityPolicy
{
    public class FrameAncestorsDirective : Directive
    {
        public FrameAncestorsDirective()
            : this(Constants.SelfKeyword)
        {
        }

        public FrameAncestorsDirective(params string[] values)
            : base(Constants.FrameAncestorsDirectiveKey)
        {
            AddValues(values);
        }
    }
}
