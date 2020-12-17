namespace App1
{
    public sealed class AbstractPage1 : AbstractPage
    {
        public override string AbstractName => $"[{GetType().Name}] {base.AbstractName}";
    }
    public sealed class AbstractPage2 : AbstractPage
    {
        public override string AbstractName => $"[{GetType().Name}] {base.AbstractName}";
    }
}
