using EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.COLOR;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT
{
    public class Button01_Default
    {
        public void button01(Button button)
        {
            button.WidthRequest = 160;
            button.HeightRequest = 50;
            button.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[1]);
            button.TextColor = Color.FromArgb(Color01_Default.Color_FromHex[0]);
            button.CornerRadius = 10;     
            button.FontSize = 12;
            button.FontFamily = "matrix02";

        }
        public void button02(Button button)
        {
            button.WidthRequest = 160;
            button.HeightRequest = 50;
            button.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[2]);
            button.TextColor = Color.FromArgb(Color01_Default.Color_FromHex[1]);
            button.CornerRadius = 10;
            button.FontSize = 12;
            button.FontFamily = "matrix02";

        }   

    }
}
