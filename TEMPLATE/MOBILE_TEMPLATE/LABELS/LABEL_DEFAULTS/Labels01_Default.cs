using EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.COLOR;


namespace EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS
{
    public class Labels01_Default
    {
        public void label01(Label label)
        {
        
            label.TextColor = Color.FromArgb(Color01_Default.Color_FromHex[0]);
            label.FontSize = 12;
            label.FontFamily = "matrix02";

        }

    }
}
