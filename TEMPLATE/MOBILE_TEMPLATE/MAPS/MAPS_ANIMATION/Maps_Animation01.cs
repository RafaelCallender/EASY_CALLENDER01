using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.MAPS.MAPS_ANIMATION
{
    public class Maps_Animation01
    {
        public async Task maps_scaleto01(Microsoft.Maui.Controls.Maps.Map maps)
        {
            await maps.ScaleToAsync(1.2, 100);  // Zoom in
            await maps.ScaleToAsync(1.0, 100);  // Zoom back to normal
        }
        public async Task maps_fadeto01(Microsoft.Maui.Controls.Maps.Map maps)
        {
            await maps.FadeToAsync(0.5, 200);   // Fade to 50%
            await maps.FadeToAsync(1.0, 200);
        }
        public async Task maps_rotateto01(Microsoft.Maui.Controls.Maps.Map maps)
        {
            await maps.RotateToAsync(360, 1000);  // Full rotation in 1 second
            await maps.RotateToAsync(0, 1000);           // Reset rotation
        }
        public async Task maps_translateto(Microsoft.Maui.Controls.Maps.Map maps)
        {
            await maps.TranslateToAsync(50, 0, 150);
            await maps.TranslateToAsync(0, 0, 150);
        }
    }
}
