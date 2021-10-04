# PRG5-2122-STU.

Stappen om DB toe te voegen

1. Installeer EF 
	- install-package Microsoft.EntityFrameworkCore
	- install-package Microsoft.EntityFrameworkCore.SqlServer
	- install-package Microsoft.EntityFrameworkCore.Tools


2. Maak een klasse MyContext : DbContext

3. Registreer je Context bij ASP in de Startup.cs

4. Voeg een connectionstring toe naar een al bestaande database
- Tip: Maak hem aan via mysql server management studio en zoek de connectionstring op via Server Explorer > properties