using EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.COLOR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_DEFAULT
{
    public class Picker01_Default
    {

        public  void picker01(Picker picker)
        {
            picker.WidthRequest = 120;
            picker.HeightRequest = 50;
            picker.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[1]);
            picker.TextColor = Color.FromArgb(Color01_Default.Color_FromHex[0]);
            picker.FontSize = 12;
            picker.FontFamily = "matrix02";
        




        }


    }
}
