using EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.COLOR;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.SCROLLVIEW_DEFAULT
{
    public class ScrollView_Default
    {
        public  void scrollview01(ScrollView scrollview)
        {
            scrollview.VerticalOptions = LayoutOptions.Fill;
            scrollview.HorizontalOptions = LayoutOptions.Fill;
            scrollview.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[2]);
            scrollview.Padding = new Thickness(0);

        }
        public  void scrollview02(ScrollView scrollview)
        {
            scrollview.WidthRequest = 120;
            scrollview.HeightRequest = 50;
            scrollview.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[2]);
            scrollview.Padding = new Thickness(0);

        }
    }
}
