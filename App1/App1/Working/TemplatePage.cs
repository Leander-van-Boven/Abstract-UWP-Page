using Windows.UI.Xaml.Controls;

namespace App1
{
    /// <summary>
    /// This is the workaround to the problem presented by <see cref="AbstractPage"/>:
    /// Just define an abstract class inheriting <see cref="Page"/> and then create an xaml file per implementation/occurence of this TemplatePage.
    /// </summary>
    public abstract class TemplatePage : Page
    {
        public virtual string TemplateString { get; } = "This works in release build.";
    }
}
