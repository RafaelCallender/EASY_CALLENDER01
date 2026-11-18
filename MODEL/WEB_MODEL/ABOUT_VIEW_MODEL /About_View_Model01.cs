using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EASYPROJECT01.EASY_CALLENDER01.MODEL.WEB_MODEL.ABOUT_VIEW_MODEL
{
  public class About_View_Model01
  {

    [BindProperty]
    public string input01 { get; set; } = string.Empty;

    [BindProperty]
    public string input02 { get; set; } = string.Empty;

    [BindProperty]
    public string input03 { get; set; } = string.Empty;

    [BindProperty]
    public string input04 { get; set; } = string.Empty;

    [BindProperty]
    public string input05 { get; set; } = string.Empty;

    [BindProperty]
    public string input06 { get; set; } = string.Empty;
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
    public string StatusMessage06 { get; set; } = string.Empty;


    [BindProperty]
    public string? SelectedProject { get; set; }
    [BindProperty]
    public string? SelectedProject01 { get; set; }
    [BindProperty]
    public string label01 { get; set; } = string.Empty;
    [BindProperty]
    public string label02 { get; set; } = string.Empty;
    [BindProperty]
    public string label03 { get; set; } = string.Empty;
    [BindProperty]
    public string label04 { get; set; } = string.Empty;
    [BindProperty]
    public string label05 { get; set; } = string.Empty;

    [BindProperty]
    public string label06 { get; set; } = string.Empty;
    [BindProperty]
    public List<SelectListItem> ProjectOptions { get; set; }
         = new List<SelectListItem>();
    [BindProperty]
    public List<SelectListItem> ProjectOptions01 { get; set; }
= new List<SelectListItem>();

    [BindProperty]
    public bool ShowInput01 { get; set; }
    [BindProperty]
    public bool ShowInput02 { get; set; }
    [BindProperty]
    public bool ShowInput03 { get; set; }
    [BindProperty]
    public bool ShowInput04 { get; set; }
    [BindProperty]
    public bool ShowInput05 { get; set; }
    [BindProperty]
    public bool ShowInput06 { get; set; }
    [BindProperty]
    public bool ShowInput07 { get; set; }

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
    public string imagebutton01 { get; set; } = string.Empty;




  }
}