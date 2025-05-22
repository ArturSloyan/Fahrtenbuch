using FahrtenbuchProjektCore.Context;
using FahrtenbuchProjektCore.Models;
using Bogus;

namespace FahrtenbuchProjektCore.Data
{
    public static class DbInitializer
    {
        public static void Initialize(JourneybookContext context)
        {
            context.Database.EnsureCreated();

            if (context.Employees.Any()) return;

            var faker = new Faker<Employee>()
                .RuleFor(e => e.Firstname, f => f.Name.FirstName())
                .RuleFor(e => e.Lastname, f => f.Name.LastName())
                .RuleFor(e => e.Password, f => f.Internet.Password())
                .RuleFor(e => e.Email, f => f.Internet.Email());

            var employees = faker.Generate(100);

            context.Employees.AddRange(employees);
            context.SaveChanges();
        }
    }
}
