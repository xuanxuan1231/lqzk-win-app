using Microsoft.UI.Xaml;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace lqzk
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            Title = "ÁùÆßÖÜ¿¯";
        }

        private void main_Click(object sender, RoutedEventArgs e)
        {
            Uri targetUri = new Uri("https://xuanxuan1231.tk");
            MyWebView.Source = targetUri;
        }
        private void md_Click(object sender, RoutedEventArgs e)
        {
            Uri targetUri = new Uri("https://md.app.xuanxuan1231.tk");
            MyWebView.Source = targetUri;
        }
        private void jekyll_Click(object sender, RoutedEventArgs e)
        {
            Uri targetUri = new Uri("https://jekyll.app.xuanxuan1231.tk");
            MyWebView.Source = targetUri;
        }
    }
}
