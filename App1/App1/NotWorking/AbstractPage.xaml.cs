using Windows.UI.Xaml.Controls;

namespace App1
{
    /// <summary>
    /// This page is meant to just provide a basic UI. The derived classes <see cref="AbstractPage1"/> and <see cref="AbstractPage2"/> then contain the actual content,
    /// in this case the content of the one and only textblock found in the UI.
    ///
    /// This will work in Debug builds, but not in Release builds (with either 'optimize code' or '.net native compiler' enabled or disabled).
    /// </summary>
    public partial class AbstractPage : Page//, IAbstractPage
    {
        public virtual string AbstractName { get; } = "This does NOT work in release build.";

        //public AbstractPage()
        //{
        //    this.InitializeComponent();
        //}
    }

    //public interface IAbstractPage
    //{
    //    string AbstractName { get; }
    //}
}
