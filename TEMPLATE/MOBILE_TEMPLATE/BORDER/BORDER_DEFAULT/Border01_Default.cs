using EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.COLOR;
using Microsoft.Maui.Controls.Shapes;

namespace EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.FRAME
{
    public class Border01_Default
    {
        public void border001(Border border)
        {

            border.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[2]);
            border.StrokeShape = new RoundRectangle
            {
                CornerRadius = new CornerRadius(10)
            };
            border.VerticalOptions = LayoutOptions.Fill;
            border.HorizontalOptions = LayoutOptions.Fill;
            border.Padding = 0;
               border.Padding = new Thickness(0);

        }
        public void border002(Border border)
        {

            border.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[1]);
            border.StrokeShape = new RoundRectangle
            {
                CornerRadius = new CornerRadius(10)
            };
            border.VerticalOptions = LayoutOptions.Fill;
            border.HorizontalOptions = LayoutOptions.Fill;
            border.Padding = new Thickness(0);

        }
    }
}
