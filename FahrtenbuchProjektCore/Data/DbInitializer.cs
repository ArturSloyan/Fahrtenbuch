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

            if (context.Employees.Any() || context.CompanyCars.Any() || context.Journeys.Any())
                return;

            var employeeFaker = new Faker<Employee>()
                .RuleFor(e => e.Firstname, f => f.Name.FirstName())
                .RuleFor(e => e.Lastname, f => f.Name.LastName())
                .RuleFor(e => e.Password, f => f.Internet.Password())
                .RuleFor(e => e.Email, f => f.Internet.Email());

            var employees = employeeFaker.Generate(100);
            context.Employees.AddRange(employees);

            var companyCarFaker = new Faker<CompanyCar>()
                .RuleFor(e => e.Brand, f => f.Vehicle.Manufacturer())
                .RuleFor(e => e.CarType, f => f.PickRandom<CarType>())
                .RuleFor(e => e.LicencePlate, f => f.Random.Replace("???-###"));

            var companyCars = companyCarFaker.Generate(20);
            context.CompanyCars.AddRange(companyCars);

            var journeyFaker = new Faker<Journey>()
                .RuleFor(j => j.JourneyDate, f => f.Date.Between(DateTime.Now.AddMonths(-2), DateTime.Now))
                .RuleFor(j => j.TimeStampStart, f => f.Date.Between(DateTime.Today.AddHours(6), DateTime.Today.AddHours(10)))
                .RuleFor(j => j.TimeStampEnd, (f, j) => j.TimeStampStart.AddMinutes(f.Random.Int(30, 240)))
                .RuleFor(j => j.TravelRoute, f => f.Random.Int(1, 10000))
                .RuleFor(j => j.PurposeOfTheJourney, f => f.Lorem.Sentence(5))
                .RuleFor(j => j.KmDistanceDeparture, f => f.Random.Int(0, 100000))
                .RuleFor(j => j.KmDistanceArrival, (f, j) => j.KmDistanceDeparture + f.Random.Int(1, 500))
                .RuleFor(j => j.Employee, f => f.PickRandom(employees))
                .RuleFor(j => j.CompanyCar, f => f.PickRandom(companyCars));

            var journeys = journeyFaker.Generate(60);
            context.Journeys.AddRange(journeys);

            context.SaveChanges();
        }
    }
}
