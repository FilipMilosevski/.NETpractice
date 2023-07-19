
using Filip;
using Microsoft.EntityFrameworkCore;

static void Filter1()
{
    using (SimpleDbgegoraphyContext db = new SimpleDbgegoraphyContext())
    {
        DbSet<Country> countries = db.Countries;
        DbSet<Language> languages = db.Languages;
        foreach (Country p in countries)
        {
            Console.WriteLine(p.Name);
           
        }
        foreach (Language l in languages)
        {
            Console.WriteLine(l.Language1) ;
        }
    }
}
Filter1();