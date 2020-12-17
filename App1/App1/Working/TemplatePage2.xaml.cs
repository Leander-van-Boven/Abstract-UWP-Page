namespace App1
{
    public sealed partial class TemplatePage2 : TemplatePage
    {
        public override string TemplateString => $"[{GetType().Name}] {base.TemplateString}";

        public TemplatePage2()
        {
            this.InitializeComponent();
        }
    }
}
