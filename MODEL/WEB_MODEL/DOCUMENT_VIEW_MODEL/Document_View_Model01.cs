using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace EASYPROJECT01.EASY_CALLENDER01.MODEL.WEB_MODEL.DOCUMENT_VIEW_MODEL
{
  public class Document_View_Model01
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
    public string label01 { get; set; } = string.Empty;
    [BindProperty]
    public string label02 { get; set; } = string.Empty;
    [BindProperty]
    public string image01 { get; set; } = string.Empty;
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
    public IFormFile? Upload { get; set; }
  }
}