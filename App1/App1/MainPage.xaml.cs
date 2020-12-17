using System;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class MainPage : Page
    {
        private Type[] AbstractPages = { typeof(AbstractPage1), typeof(AbstractPage2) };
        private Type[] TemplatePages = { typeof(TemplatePage1), typeof(TemplatePage2) };
        private Random rnd = new Random();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MainNavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            // Find out which item is invoked and navigate to a randomly picked page of this type
            switch (args.InvokedItem)
            {
                case "Working page in release":
                    MainFrame.Navigate(TemplatePages[rnd.Next(2)]);
                    break;
                case "Not working page in release":
                    MainFrame.Navigate(AbstractPages[rnd.Next(2)]);
                    break;
            }
        }
    }
}
