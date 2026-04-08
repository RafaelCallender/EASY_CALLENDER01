using System;
using System.Collections.Generic;
using System.Text;

namespace EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION
{
    public class Picker01_Animation
    {
        public async Task Picker_scaleto01(Picker picker)
        {
            await picker.ScaleToAsync(1.2, 100);  // Zoom in
            await picker.ScaleToAsync(1.0, 100);  // Zoom back to normal
        }
        public async Task Picker_fadeto01(Picker picker)
        {
            await picker.FadeToAsync(0.5, 200);   // Fade to 50%
            await picker.FadeToAsync(1.0, 200);
        }
        public async Task Picker_rotateto01(Picker picker)
        {
            await picker.RotateToAsync(360, 1000);  // Full rotation in 1 second
            await picker.RotateToAsync(0, 1000);           // Reset rotation
        }
        public async Task Picker_translateto(Picker picker)
        {
            await picker.TranslateToAsync(100, 0, 500);  // Move right
            await picker.TranslateToAsync(0, 0, 500);    // Move back
        }
    }
}
