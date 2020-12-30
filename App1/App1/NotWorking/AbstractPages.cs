namespace App1
{
    public partial class AbstractPage1 : AbstractPage
    {
        public override string AbstractName => $"[{this.GetType().Name}] {base.AbstractName}";

        public AbstractPage1()
        {
            this.InitializeComponent();
        }
    }
    public partial class AbstractPage2 : AbstractPage
    {
        public override string AbstractName => $"[{this.GetType().Name}] {base.AbstractName}";

        public AbstractPage2()
        {
            this.InitializeComponent();
        }
    }
}
