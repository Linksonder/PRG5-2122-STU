# PRG5-2122-STU.

Stappen om DB toe te voegen

1. Installeer EF 
	- install-package Microsoft.EntityFrameworkCore
	- install-package Microsoft.EntityFrameworkCore.SqlServer
	- install-package Microsoft.EntityFrameworkCore.Tools


2. Maak een klasse MyContext : DbContext met een DbSet

```
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public DbSet<ContactFormulier> Berichten { get; set; }
    }
```

3. Registreer je Context bij ASP in de Startup.cs

```
    public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<MyContext>(options =>
                options.UseSqlServer("name=ConnectionStrings:default"));
        }
```

4. Voeg een connectionstring toe naar een al bestaande database
- Tip: Maak hem aan via mysql server management studio en zoek de connectionstring op via Server Explorer > properties

```
 "ConnectionStrings": {
    "default": "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Week6;Integrated Security=True"
  }
```

5. Injecteer de context in de controller

```
    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }
```

6. Gebruik de context om een bericht op te halen of weg te schrijven

- Index

```
    var berichten = _context.Berichten.ToList();
    return View(berichten);
```

- Contact

```
    _context.Add(formulier);
    _context.SaveChanges();
```