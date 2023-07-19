
using Filip;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

static void Filter3()
{
    using (SimpleDbgegoraphyContext db = new SimpleDbgegoraphyContext())
    {
        DbSet<Country> countries = db.Countries;
        DbSet<Language> languages = db.Languages;
        foreach (Country p in countries)
        {
            Console.WriteLine(p.Name,p.Region);
           
        }

        foreach (Language l in languages)
        {
            Console.WriteLine(l.Language1) ;
        }
    }
}
Filter3();

Console.WriteLine("-------------------------------------------");
static void Filter4()
{
    using(SimpleDbgegoraphyContext db = new SimpleDbgegoraphyContext())
    {
        DbSet<Country> countries = db.Countries;
        IQueryable<Country> filterCountries = countries.Where(p => p.Name.Contains("m"));
        foreach (Country c in filterCountries)
        {
            Console.WriteLine(c.Name);
        }
    }
}

Filter4();


Console.WriteLine("------------------------------------------------");

static void Filter5()
{
    using(SimpleDbgegoraphyContext db = new SimpleDbgegoraphyContext())
    {
        DbSet<CountryStat> countryStats = db.CountryStats;
        IQueryable<CountryStat> allCountryStats = countryStats.Where(c => c.Population < 50000000);
        foreach (CountryStat cs in allCountryStats)
        {
            Console.WriteLine(cs.Population);

        }
    }
}

Filter5();