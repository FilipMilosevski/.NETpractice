
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

 static void ExecuteQueryAndPrintResults(string connectionString)
{
    string sqlQuery = @"
            SELECT
                Regions.continentID,
                Continents.name,
                Countries.name,
                Countries.countryCode2,
                CountryLanguages.official,
                Languages.languageID,
                CountryStats.year,
                CountryStats.population,
                CountryStats.gdp
            FROM Continents
            INNER JOIN Regions ON Continents.continentID = Regions.continentID
            INNER JOIN Countries ON Regions.regionID = Countries.regionID
            INNER JOIN CountryLanguages ON Countries.countryID = CountryLanguages.countryID
            INNER JOIN Languages ON CountryLanguages.languageID = Languages.languageID
            INNER JOIN CountryStats ON Countries.countryID = CountryStats.countryID";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        SqlCommand command = new SqlCommand(sqlQuery, connection);

        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int continentID = reader.GetInt32(0);
                string continentName = reader.GetString(1);
                string countryName = reader.GetString(2);
                string countryCode2 = reader.GetString(3);
                bool isOfficial = reader.GetBoolean(4);
                int languageID = reader.GetInt32(5);
                int year = reader.GetInt32(6);
                long population = reader.GetInt64(7);
                decimal gdp = reader.GetDecimal(8);

                Console.WriteLine($"Continent: {continentName}, Country: {countryName}, Population: {population}, GDP: {gdp}");
            }

            reader.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

