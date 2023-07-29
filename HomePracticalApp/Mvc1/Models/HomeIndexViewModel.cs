using Mvc1.MyFolder;

namespace Mvc1.Models
{
    public record HomeIndexViewModel
    {
        int VisitorCount;
       
        public IList<Country> Countries;
        public IList<CountryStat> CountryStats;


    }
}
