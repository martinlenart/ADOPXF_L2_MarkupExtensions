using Xamarin.Forms;

namespace MarkupExtensions.Views
{
    public partial class ImageResourceDemoPage : ContentPage
    {
        public ImageResourceDemoPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            var ext = new ImageResourceExtension();

        }
    }
}