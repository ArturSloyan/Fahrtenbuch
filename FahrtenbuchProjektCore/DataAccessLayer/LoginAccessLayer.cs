using FahrtenbuchProjektCore.Context;
using FahrtenbuchProjektCore.Models;

namespace FahrtenbuchProjektCore.DataAccessLayer
{
    public class LoginAccessLayer
    {
        private readonly JourneybookContext _context;

        public LoginAccessLayer(JourneybookContext context)
        {
            _context = context;
        }

        public Employee GetLoggedInEmployee(string email)
        {
            return _context.Employees.FirstOrDefault(e => e.Email == email);
        }

        public bool Login(string email, string password)
        {
            var user = _context.Employees.FirstOrDefault(e => e.Email == email);
            return user != null && BCrypt.Net.BCrypt.Verify(password, user.Password);
        }
    }
}
