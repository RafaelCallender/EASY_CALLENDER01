using EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.COLOR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.EDITOR.EDITOR_DEFAULT
{
    public class Editor01_default
    {
        public void Editors01(Editor editor)
        {
            editor.WidthRequest = 120;
            editor.HeightRequest = 250;
            editor.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[2]);
            editor.FontSize = 12;
            editor.TextColor = Color.FromArgb(Color01_Default.Color_FromHex[0]);
            editor.PlaceholderColor = Color.FromArgb(Color01_Default.Color_FromHex[0]);
            editor.FontFamily = "matrix02";
            editor.VerticalOptions = LayoutOptions.Start; // ensures layout starts at top
        }
    }
}
