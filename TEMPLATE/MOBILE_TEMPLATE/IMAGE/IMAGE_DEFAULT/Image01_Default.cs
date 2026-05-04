
using EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.COLOR;
using Microsoft.Maui.Controls;
using System.Reflection;


namespace EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT
{
    public class Image01_Default
    {
        public void image01(Image image)
        {
            image.WidthRequest = 120;
            image.HeightRequest = 120;
            image.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[2]);
            image.VerticalOptions = LayoutOptions.Center;
            image.HorizontalOptions = LayoutOptions.Center;
        }
    }
}
