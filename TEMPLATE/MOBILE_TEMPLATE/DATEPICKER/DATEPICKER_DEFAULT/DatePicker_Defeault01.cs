using EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.COLOR;


namespace EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.DATEPICKER.DATEPICKER_DEFAULT
{
    public class DatePicker_Defeault01
    {
        public  void datepicker01(DatePicker datepicker)
        {
            datepicker.WidthRequest = 120;
            datepicker.HeightRequest = 50;
            datepicker.BackgroundColor = Color.FromArgb(Color01_Default.Color_FromHex[1]);
            datepicker.TextColor = Color.FromArgb(Color01_Default.Color_FromHex[0]);
            datepicker.FontSize = 12;
        }
    }
}
