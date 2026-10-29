using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EASYPROJECT01.EASY_CALLENDER01.MODEL.WEB_MODEL.UPLOAD_VIEW_MODEL
{
  public class Upload_View_Model01
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
  }
}