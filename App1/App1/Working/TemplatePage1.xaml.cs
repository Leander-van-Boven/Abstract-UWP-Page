namespace App1
{
    public sealed partial class TemplatePage1 : TemplatePage
    {
        public override string TemplateString => $"[{GetType().Name}] {base.TemplateString}";

        public TemplatePage1()
        {
            this.InitializeComponent();
        }
    }
}
