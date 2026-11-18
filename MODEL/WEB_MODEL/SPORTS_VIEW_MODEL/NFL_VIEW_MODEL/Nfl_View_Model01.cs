using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EASYPROJECT01.EASY_CALLENDER01.MODEL.WEB_MODEL.SPORTS_VIEW_MODEL.NFL_VIEW_MODEL
{
  public class Nfl_View_Model01
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

    public bool ShowInput01 { get; set; }
  }
}