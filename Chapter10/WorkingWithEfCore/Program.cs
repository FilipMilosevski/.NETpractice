using Packt.Shared;

Northwind db = new Northwind();

WriteLine($"Filename ={db.Database.ProviderName}");


Northwind db1 = new Northwind();

WriteLine($"Proba {db1.Database.ProviderName}");