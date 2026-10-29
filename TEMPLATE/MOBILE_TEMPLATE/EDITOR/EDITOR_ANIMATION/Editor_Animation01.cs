using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.COLOR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.EDITOR.EDITOR_ANIMATION
{
    public class Editor_Animation01
    {
        public async Task editor_scaleto01(Editor editor)
        {
            await editor.ScaleToAsync(1.2, 100);  // Zoom in
            await editor.ScaleToAsync(1.0, 100);  // Zoom back to normal
        }
        public async Task editor_fadeto01(Editor editor)
        {
            await editor.FadeToAsync(0.5, 200);   // Fade to 50%
            await editor.FadeToAsync(1.0, 200);
        }
        public async Task editor_rotateto01(Editor editor)
        {
            await editor.RotateToAsync(360, 1000);  // Full rotation in 1 second
            await editor.RotateToAsync(0, 1000);           // Reset rotation
        }
        public async Task editor_translateto(Editor editor)
        {
            await editor.TranslateToAsync(50, 0, 150);
            await editor.TranslateToAsync(0, 0, 150);
        }

    }
}
