// a string array is a sequence that implements IEnumerable<string>
string[] names = new[] { "Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed" };

SectionTitle("Defered execution");

IEnumerable<string>query1 = names.Where(name => name.EndsWith("m"));
SectionTitle("LINQ METHOD");
foreach (string name in query1)
{
    Console.WriteLine(name);
}

IEnumerable<string>query2 = from name in names where name.EndsWith("m") select name;
SectionTitle("LINQ QUERY");
foreach (string name in query2)
{
    Console.WriteLine(name);
}

IEnumerable<string> query3 = names.Where(name => name.Contains("a"));
SectionTitle("LINQ METHOD    contains  A");

foreach (string name in query3)
{
    Console.WriteLine(name);
}