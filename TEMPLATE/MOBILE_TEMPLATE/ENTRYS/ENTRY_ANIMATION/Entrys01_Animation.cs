using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.COLOR;
using System;
using System.Collections.Generic;
using System.Text;


namespace EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS
{
    public class Entrys01_Animation
    {
        public async Task entry_scaleto01(Entry entry)
        {
            await entry.ScaleToAsync(1.2, 100);  // Zoom in
            await entry.ScaleToAsync(1.0, 100);  // Zoom back to normal
        }
        public async Task entry_fadeto01(Entry entry)
        {
            await entry.FadeToAsync(0.5, 200);   // Fade to 50%
            await entry.FadeToAsync(1.0, 200);
        }
        public async Task entry_rotateto01(Entry entry)
        {
            await entry.RotateToAsync(360, 1000);  // Full rotation in 1 second
            await entry.RotateToAsync(0, 1000);           // Reset rotation
        }
        public async Task entry_translateto(Entry entry)
        {
            await entry.TranslateToAsync(50, 0, 150);
            await entry.TranslateToAsync(0, 0, 150);
        }
    }
}