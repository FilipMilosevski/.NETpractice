


using Filip;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;
using System.ComponentModel;
using System.Diagnostics.Metrics;

static void SectionTitle(string title)
{
    ConsoleColor previousColor = ForegroundColor;
    ForegroundColor = ConsoleColor.Yellow;
    WriteLine("*");
    WriteLine($"* {title}");
    WriteLine("*");
    ForegroundColor = previousColor;
}
static void Fail(string message)
{
    ConsoleColor previousColor = ForegroundColor;
    ForegroundColor = ConsoleColor.Red;
    WriteLine($"Fail > {message}");
    ForegroundColor = previousColor;
}
static void Info(string message)
{
    ConsoleColor previousColor = ForegroundColor;
    ForegroundColor = ConsoleColor.Cyan;
    WriteLine($"Info > {message}");
    ForegroundColor = previousColor;
}



static void Filter1()
{
    using (FmContext db = new FmContext())
    {
        DbSet<Manager> allWithA = db.Managers;
        IQueryable<Manager> man = allWithA.Where(m => m.Mfname.Contains("o"));
        SectionTitle("These are the names that contains letter O: ");

        foreach (Manager m in man)
        {
            WriteLine(m.Mfname);
        }
    }
}

static void Filter2()
{
    using (FmContext db = new FmContext())
    {
        DbSet<Player> allPlayers = db.Players;
        IQueryable<Player> filterAllPlayers = allPlayers.Where(p => p.City.Contains("s"));
        SectionTitle("The all player who have letter S in their Last names are: ");

        foreach (Player p in filterAllPlayers)
        {
            WriteLine(p.Fname);
        }
    }
}

static void Filter3()
{
    using(FmContext db = new FmContext())
    {
        DbSet<Manager> allManagers = db.Managers;
        IQueryable<Manager> filterAllManagers = allManagers.Where(m => m.Mcountry.Contains("n"));
        SectionTitle("All managers that have letter N in their countries: ");
        foreach (Manager m in filterAllManagers)
        {
            Console.WriteLine(m.Mcountry);
        }
    }
}

Filter1();
Filter2();
Filter3();


