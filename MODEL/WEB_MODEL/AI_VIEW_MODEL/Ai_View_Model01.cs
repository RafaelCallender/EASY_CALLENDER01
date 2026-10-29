using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EASYPROJECT01.EASY_CALLENDER01.MODEL.WEB_MODEL.AI_VIEW_MODEL
{
  public class Ai_View_Model01
  {

    [BindProperty]
    public string input01 { get; set; } = string.Empty;
    [BindProperty]
    public string StatusMessage01 { get; set; } = string.Empty;
    [BindProperty]
    public string? SelectedProject { get; set; }
    [BindProperty]
    public string label01 { get; set; } = string.Empty;
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
    public string image01 { get; set; } = string.Empty;
    [BindProperty]
    public string[] button_text { get; set; }=[];
  }
}