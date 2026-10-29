using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.COLOR;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS
{
    public class Labels01_Default
    {
        public void label01(Label label)
        {
            label.TextColor = Color.FromArgb(Color01_Default.Color_FromHex[(int)Color01_Default.color_name.Bright_green]);
            label.FontSize = 12;
            label.FontFamily = "matrix02";
        }

        public void label02(Label label)
        {
            label.TextColor = Color.FromArgb(Color01_Default.Color_FromHex[(int)Color01_Default.color_name.Bright_green]);
            label.FontSize = 12;
            label.FontFamily = "matrix02";
        }
        public void label03(Label label)
        {
            label.TextColor = Color.FromArgb(Color01_Default.Color_FromHex[(int)Color01_Default.color_name.White]);
            label.FontSize = 12;
            label.FontFamily = "matrix02";
        }
        public void label04(Label label)
        {
            label.TextColor = Color.FromArgb(Color01_Default.Color_FromHex[(int)Color01_Default.color_name.Black]);
            label.FontSize = 12;
            label.FontFamily = "matrix02";
        }
        public void label05(Label label)
        {
            label.TextColor = Color.FromArgb(Color01_Default.Color_FromHex[(int)Color01_Default.color_name.Light_gray]);
            label.FontSize = 12;
            label.FontFamily = "matrix02";
        }
        public void label06(Label label)
        {
            label.TextColor = Color.FromArgb(Color01_Default.Color_FromHex[(int)Color01_Default.color_name.Medium_gray]);
            label.FontSize = 12;
            label.FontFamily = "matrix02";
        }
        public void label07(Label label)
        {
            label.TextColor = Color.FromArgb(Color01_Default.Color_FromHex[(int)Color01_Default.color_name.Dark_gray]);
            label.FontSize = 12;
            label.FontFamily = "matrix02";
        }
        public void label08(Label label)
        {
            label.TextColor = Color.FromArgb(Color01_Default.Color_FromHex[(int)Color01_Default.color_name.Near_black_gray]);
            label.FontSize = 12;
            label.FontFamily = "matrix02";
        }

        public void label09(Label label)
        {

            label.TextColor = Color.FromArgb("#F1F5F9");
            label.BackgroundColor = Color.FromArgb("#151E2E");
            label.FontSize = 22;
            label.LineHeight = 1.7;
            label.HorizontalTextAlignment = TextAlignment.Start;
            label.VerticalTextAlignment = TextAlignment.Start;
            label.LineBreakMode = LineBreakMode.WordWrap;
            label.Padding = new Thickness(22);
            label.Margin = new Thickness(10, 15, 10, 15);
            label.CharacterSpacing = 0.3;

        }














    }
}
