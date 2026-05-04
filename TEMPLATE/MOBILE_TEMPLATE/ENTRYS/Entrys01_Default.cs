using EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.COLOR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS
{
    public class Entrys01_Default
    {
        public  void Entrys01(Entry entry)
        {
            entry.WidthRequest = 120;
            entry.HeightRequest = 50;
            entry.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[1]);
            entry.FontSize = 12;
            entry.TextColor = Color.FromArgb(Color01_Default.Color_FromHex[0]);
            entry.PlaceholderColor = Color.FromArgb(Color01_Default.Color_FromHex[0]);
            entry.FontFamily = "matrix01";
  


        }
        public void Entrys02(Entry entry)
        {
            entry.WidthRequest = 120;
            entry.HeightRequest = 250;
            entry.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[1]);
            entry.FontSize = 12;
            entry.TextColor = Color.FromArgb(Color01_Default.Color_FromHex[0]);
            entry.PlaceholderColor = Color.FromArgb(Color01_Default.Color_FromHex[0]);
            entry.FontFamily = "matrix02";



        }
    }
}
