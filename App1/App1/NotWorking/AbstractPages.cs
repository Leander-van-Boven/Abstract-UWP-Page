namespace App1
{
    public class AbstractPage1 : AbstractPage
    {
        public override string AbstractName => $"[{GetType().Name}] {base.AbstractName}";
    }
    public class AbstractPage2 : AbstractPage
    {
        public override string AbstractName => $"[{GetType().Name}] {base.AbstractName}";
    }
}
