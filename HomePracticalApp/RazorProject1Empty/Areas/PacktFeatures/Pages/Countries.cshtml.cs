using Microsoft.AspNetCore.Mvc.RazorPages; // PageModel
using Filip; // Employee, NorthwindContext
namespace PacktFeatures.Pages;
public class CountriesPageModel : PageModel
{
	private SimpleDbgegoraphyContext db;
	public CountriesPageModel(SimpleDbgegoraphyContext injectedContext)
	{
		db = injectedContext;	
	}
    public Country[] Countries { get; set; } = null!;
	public void OnGet()
	{
		ViewData["Title"] = "Northwind B2B - Employees";
		Countries = db.Countries.OrderBy(e => e.Name).ThenBy(e => e.Area).ToArray();
	}
} 