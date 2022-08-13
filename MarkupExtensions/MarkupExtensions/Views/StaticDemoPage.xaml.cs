using System;
using Xamarin.Forms;

namespace MarkupExtensions.Views
{
    public partial class StaticDemoPage : ContentPage
    {
        int count = 0;
        public StaticDemoPage()
        {
            InitializeComponent();
            var pi = Math.PI;
        }

        private void Counter_Clicked(object sender, EventArgs e)
        {
            lblCounter.Text = $"{MarkupExtensions.RegionalGreeting.Greeting} {count}";
            count++;
        }
    }
}