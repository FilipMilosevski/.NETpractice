//Create account
using LoginProject;


SeedToLoginDB db = new SeedToLoginDB();

db.Seed();

LoginOrCreateUser.Login();

