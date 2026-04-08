using System;
using System.Collections.Generic;
using System.Text;

namespace EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_ANIMATION
{
    public class Label01_Animation01
    {
        public async Task Label_scaleto01(Label label)
        {
            await label.ScaleToAsync(1.2, 100);  // Zoom in
            await label.ScaleToAsync(1.0, 100);  // Zoom back to normal
        }
        public async Task Label_fadeto01(Label label)
        {
            await label.FadeToAsync(0.5, 200);   // Fade to 50%
            await label.FadeToAsync(1.0, 200);
        }
        public async Task Label_rotateto01(Label label)
        {
            await label.RotateToAsync(360, 1000);  // Full rotation in 1 second
            await label.RotateToAsync(0, 1000);           // Reset rotation
        }
        public async Task Label_translateto(Label label)
        {
            await label.TranslateToAsync(100, 0, 500);  // Move right
            await label.TranslateToAsync(0, 0, 500);    // Move back
        }
    }
}
