using System;
using System.Collections.Generic;
using System.Text;

namespace EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGEBUTTON.IMAGEBUTTON_ANIMATION
{
    public class ImageButton_Animaiton01
    {
        public async Task imagebutton_scaleto01(ImageButton imagebutton)
        {
            await imagebutton.ScaleToAsync(1.2, 100);  // Zoom in
            await imagebutton.ScaleToAsync(1.0, 100);  // Zoom back to normal
        }
        public async Task imagebutton_fadeto01(ImageButton imagebutton)
        {
            await imagebutton.FadeToAsync(0.5, 200);   // Fade to 50%
            await imagebutton.FadeToAsync(1.0, 200);
        }
        public async Task imagebutton_rotateto01(ImageButton imagebutton)
        {
            await imagebutton.RotateToAsync(360, 1000);  // Full rotation in 1 second
            await imagebutton.RotateToAsync(0, 1000);           // Reset rotation
        }
        public async Task imagebutton_translateto(ImageButton imagebutton)
        {
            await imagebutton.TranslateToAsync(50, 0, 150);
            await imagebutton.TranslateToAsync(0, 0, 150);
        }
    }
}
