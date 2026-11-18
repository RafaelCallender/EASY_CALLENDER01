using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.COLOR;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Text;


namespace EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT
{
    public class Background_Default01
    {
        public void background01(ContentPage page)
        {

            page.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[(int)Color01_Default.color_name.Bright_green]);

        }


        public void background02(ContentPage page)
        {

            page.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[(int)Color01_Default.color_name.White]);

        }
        public void background03(ContentPage page)
        {

            page.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[(int)Color01_Default.color_name.Black]);

        }
        public void background04(ContentPage page)
        {

            page.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[(int)Color01_Default.color_name.Light_gray]);

        }
        public void background05(ContentPage page)
        {

            page.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[(int)Color01_Default.color_name.Medium_gray]);

        }
        public void background06(ContentPage page)
        {

            page.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[(int)Color01_Default.color_name.Dark_gray]);

        }
        public void background07(ContentPage page)
        {

            page.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[(int)Color01_Default.color_name.Near_black_gray]);

        }
        public void background08(ContentPage page)
        {

            page.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[(int)Color01_Default.color_name.Transparent]);

        }
    }
}