using Mvc1.MyFolder;

namespace Northwind.Mvc.Models;

public record HomeIndexViewModel
(
    int VisitorCount,
    IList<Country> Countries,
    IList<CountryStat> CountryStats,
    IList<Language> Languages,
    IList<CountryLanguage> CountryLanguages
);