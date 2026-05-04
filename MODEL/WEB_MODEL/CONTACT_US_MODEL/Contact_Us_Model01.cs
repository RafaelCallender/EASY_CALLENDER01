using Microsoft.AspNetCore.Mvc;

namespace EASY_CALLENDER01.MODEL.WEB_MODEL.CONTACT_US_MODEL
{
    public class Contact_Us_Model01
    {
        [BindProperty]
        public string Name { get; set; } = string.Empty;

        [BindProperty]
        public string Email { get; set; } = string.Empty;

        [BindProperty]
        public string phonenumber { get; set; } = string.Empty;

        [BindProperty]
        public string Message { get; set; } = string.Empty;

        [BindProperty]
        public string dateSent { get; set; } = string.Empty;

        [BindProperty]
        public string client_phonenumber { get; set; } = string.Empty;

        [BindProperty]
        public string StatusMessage01 { get; set; } = string.Empty;

        [BindProperty]
        public string StatusMessage02 { get; set; } = string.Empty;

        [BindProperty]
        public string StatusMessage03 { get; set; } = string.Empty;

        [BindProperty]
        public string StatusMessage04 { get; set; } = string.Empty;
		        [BindProperty]
        public string StatusMessage05 { get; set; } = string.Empty;

        [BindProperty]
        public string image01 { get; set; } = string.Empty;

        [BindProperty]
        public string image02 { get; set; } = string.Empty;

        [BindProperty]
        public string image03 { get; set; } = string.Empty;

        [BindProperty]
        public string image04 { get; set; } = string.Empty;

        [BindProperty]
        public string image05 { get; set; } = string.Empty;

        [BindProperty]
        public string image06 { get; set; } = string.Empty;

        [BindProperty]
        public string image07 { get; set; } = string.Empty;

        [BindProperty]
        public string image08 { get; set; } = string.Empty;

        [BindProperty]
        public string image09 { get; set; } = string.Empty;

        [BindProperty]
        public string imagebutton01 { get; set; } = string.Empty;

        [BindProperty]
        public string imagebutton02 { get; set; } = string.Empty;

        [BindProperty]
        public string imagebutton03 { get; set; } = string.Empty;

        [BindProperty]
        public bool ShowZellePopup { get; set; } = false;
		    [BindProperty]
        public bool ShowPayPalPopup { get; set; } = false;
				    [BindProperty]
        public bool ShowVenmoPopup { get; set; } = false;
		        [BindProperty]
        public string cashappdata01 { get; set; } = string.Empty;
		  [BindProperty]
		  
    public bool ShowPayPal{ get; set; } = false;
		  
		  
		  
		public string zelledata01 { get; set; } = string.Empty;
		  [BindProperty]
				public string paypaldata01 { get; set; } = string.Empty;
				  [BindProperty]
				public string venmodata01 { get; set; } = string.Empty;
		
    }
}