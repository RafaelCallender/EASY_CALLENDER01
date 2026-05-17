using System;
using System.Collections.Generic;
using System.Text;

namespace EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION
{
    public class Button_Animation01
    {
        public   async Task button_scaleto01(Button button)
        {
            await button.ScaleToAsync(1.2, 100);  // Zoom in
            await button.ScaleToAsync(1.0, 100);  // Zoom back to normal
        }
        public  async Task button_fadeto01(Button button)
        {
            await button.FadeToAsync(0.5, 200);   // Fade to 50%
            await button.FadeToAsync(1.0, 200);
        }
        public  async Task button_rotateto01(Button button)
        {
            await button.RotateToAsync(360, 1000);  // Full rotation in 1 second
            await button.RotateToAsync(0, 1000);           // Reset rotation
        }
        public  async Task button_translateto(Button button)
        {
            await button.TranslateToAsync(50, 0, 150);
            await button.TranslateToAsync(0, 0, 150);
        }
    }
}
