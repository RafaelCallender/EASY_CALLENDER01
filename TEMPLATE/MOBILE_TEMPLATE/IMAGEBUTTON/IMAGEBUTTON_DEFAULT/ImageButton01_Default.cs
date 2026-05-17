using EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.COLOR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGEBUTTON.IMAGEBUTTON_DEFAULT
{
    public class ImageButton01_Default
    {

        public void ImageButton01(ImageButton imagebutton)
        {
            imagebutton.WidthRequest = 50;
            imagebutton.HeightRequest = 50;
            imagebutton.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[2]);
            imagebutton.CornerRadius = 15;
        }


    }
}
