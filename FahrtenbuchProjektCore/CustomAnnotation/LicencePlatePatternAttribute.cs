using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace FahrtenbuchProjektCore.CustomAnnotation
{
    public class LicencePlatePatternAttribute : ValidationAttribute
    {
        private readonly string _pattern = @"^[A-Za-z]{3}-\d{3}$";

        public LicencePlatePatternAttribute() : base()
        {}

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }

            string licencePlate = value.ToString();
            return Regex.IsMatch(licencePlate, _pattern);
        }
    }
}
