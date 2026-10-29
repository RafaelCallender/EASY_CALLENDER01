using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EASYPROJECT01.EASY_CALLENDER01.MODEL.WEB_MODEL.LOCATION_VIEW_MODEL
{
  public class Location_View_Model01
  {

    [BindProperty]
    public string input01 { get; set; } = string.Empty;
    [BindProperty]
    public string StatusMessage01 { get; set; } = string.Empty;
    [BindProperty]
    public string StatusMessage02 { get; set; } = string.Empty;
    [BindProperty]
    public string? SelectedProject { get; set; }
    [BindProperty]
    public string? SelectedProject01 { get; set; }
    [BindProperty]
    public string label01 { get; set; } = string.Empty;
    [BindProperty]
    public string label02 { get; set; } = string.Empty;
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
    public double Latitude { get; set; }
    [BindProperty]
    public double Longitude { get; set; }
  }
}