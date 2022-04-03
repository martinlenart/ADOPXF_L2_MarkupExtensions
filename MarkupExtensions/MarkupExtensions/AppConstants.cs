using Xamarin.Forms;
using System;
namespace MarkupExtensions
{
    static class AppConstants
    {
        public static double NormalFontSize { get; set; } = 18;
        public static string Idiom = Device.Idiom.ToString();
    }
}
