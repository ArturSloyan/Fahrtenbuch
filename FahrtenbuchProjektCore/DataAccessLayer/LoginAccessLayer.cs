using FahrtenbuchProjektCore.Context;

namespace FahrtenbuchProjektCore.DataAccessLayer
{
    public class LoginAccessLayer
    {
        private readonly JourneybookContext _context;

        public LoginAccessLayer(JourneybookContext context)
        {
            _context = context;
        }

        public bool Login(string email, string password)
        {
            var user = _context.Employees.FirstOrDefault(e => e.Email == email);
            return user != null && BCrypt.Net.BCrypt.Verify(password, user.Password);
        }
    }
}
