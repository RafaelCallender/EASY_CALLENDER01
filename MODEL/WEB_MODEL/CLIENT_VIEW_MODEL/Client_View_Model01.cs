using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace EASYPROJECT01.EASY_CALLENDER01.MODEL.WEB_MODEL.CLIENT_VIEW_MODEL
{
  public class Client_View_Model01
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
    public string input07 { get; set; } = string.Empty;
    [BindProperty]
    public string input08 { get; set; } = string.Empty;

    [BindProperty]
    public string input09 { get; set; } = string.Empty;
    [BindProperty]
    public string input10 { get; set; } = string.Empty;
    [BindProperty]
    public string input11 { get; set; } = string.Empty;
    [BindProperty]
    public string input12 { get; set; } = string.Empty;
    [BindProperty]
    public string input13 { get; set; } = string.Empty;
    [BindProperty]
    public string input14 { get; set; } = string.Empty;


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
    public string StatusMessage07 { get; set; } = string.Empty;
    [BindProperty]
    public string StatusMessage08 { get; set; } = string.Empty;
    [BindProperty]
    public string StatusMessage09 { get; set; } = string.Empty;
    [BindProperty]
    public string StatusMessage10 { get; set; } = string.Empty;
    [BindProperty]
    public string StatusMessage11 { get; set; } = string.Empty;
    [BindProperty]
    public string StatusMessage12 { get; set; } = string.Empty;
    [BindProperty]
    public string StatusMessage13 { get; set; } = string.Empty;
    [BindProperty]
    public string StatusMessage14 { get; set; } = string.Empty;

    [BindProperty]
    public string? SelectedProject { get; set; }
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
    public string label07 { get; set; } = string.Empty;
    [BindProperty]
    public string label08 { get; set; } = string.Empty;
    [BindProperty]
    public string label09 { get; set; } = string.Empty;

    [BindProperty]
    public string label10 { get; set; } = string.Empty;
    [BindProperty]
    public string label11 { get; set; } = string.Empty;
    [BindProperty]
    public string label12 { get; set; } = string.Empty;
    [BindProperty]
    public string label13 { get; set; } = string.Empty;

    [BindProperty]
    public string label14 { get; set; } = string.Empty;
    [BindProperty]
    public List<SelectListItem> ProjectOptions { get; set; }
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
    public bool ShowInput08 { get; set; }
    [BindProperty]
    public bool ShowInput09 { get; set; }
    [BindProperty]
    public bool ShowInput10 { get; set; }
    [BindProperty]
    public bool ShowInput11 { get; set; }
    [BindProperty]
    public bool ShowInput12 { get; set; }
    [BindProperty]
    public bool ShowInput13 { get; set; }
    [BindProperty]
    public bool ShowInput14 { get; set; }
  }
}