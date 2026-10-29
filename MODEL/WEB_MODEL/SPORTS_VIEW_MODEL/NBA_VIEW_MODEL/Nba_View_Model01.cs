using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace EASYPROJECT01.EASY_CALLENDER01.MODEL.WEB_MODEL.SPORTS_VIEW_MODEL.NBA_VIEW_MODEL
{
  public class Nba_View_Model01
  {

    [BindProperty]
    public string input01 { get; set; } = string.Empty;
    [BindProperty]
    public string StatusMessage01 { get; set; } = string.Empty;
    [BindProperty]
    public string? SelectedProject { get; set; }
    [BindProperty]
    public string? SelectedProject01 { get; set; }
    [BindProperty]
    public string? SelectedProject02 { get; set; }
    [BindProperty]
    public string? SelectedProject03 { get; set; }
     [BindProperty]
    public string? SelectedProject04 { get; set; }
    [BindProperty]
    public string label01 { get; set; } = string.Empty;
    [BindProperty]
    public List<SelectListItem> ProjectOptions { get; set; }
         = new List<SelectListItem>();
    [BindProperty]
    public List<SelectListItem> ProjectOptions01 { get; set; }
= new List<SelectListItem>();
    [BindProperty]
    public List<SelectListItem> ProjectOptions02 { get; set; }
    = new List<SelectListItem>();
    [BindProperty]
    public List<SelectListItem> ProjectOptions03 { get; set; }
    = new List<SelectListItem>();
        [BindProperty]
    public List<SelectListItem> ProjectOptions04 { get; set; }
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
    public DateTime? SelectedDate { get; set; }
  }
}