using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ValidationAccount : IValidatableObject
    {
        private string _name;
        private string _surname;
        private string _email;
        private int _yearOfBirth;
        public bool IsValidated=false;

        public ValidationAccount(string newName, string surname, int yearOfBirth, string email)
        {
            _name = newName;
            _surname = surname;
            _yearOfBirth = yearOfBirth;
            _email = email;
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            if (!Validator.TryValidateObject(this, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Account {0} validated", _name);
                IsValidated = true;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(_name) || _name.All(c => char.IsDigit(c)))
            {
                errors.Add(new ValidationResult("incorrect Name"));
            }

            if (string.IsNullOrWhiteSpace(_surname) || _name.All(c => char.IsDigit(c)))
            {
                errors.Add(new ValidationResult("incorrect Surname"));
            }

            if (_yearOfBirth < 1900 || _yearOfBirth > 2017)
            {
                errors.Add(new ValidationResult("incorrect date of birth"));
            }

            if (!_email.Contains("@") || !_email.Contains("."))
            {
                errors.Add(new ValidationResult("incorrect email"));
            }
            return errors;
        }
    }
}
