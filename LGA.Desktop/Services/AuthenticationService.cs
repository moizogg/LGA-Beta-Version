using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Desktop.Services
{
    public class AuthenticationService
    {

        private readonly Dictionary<string, string> _users
            = new()
            {
            {
                "info@intuitivebmi.com",
                "admin@intuitivebmi"
            }
            };



        public bool Authenticate(
            string email,
            string password
        )
        {

            email =
                email.ToLower();



            if (_users.TryGetValue(
                email,
                out string? savedPassword))
            {

                return savedPassword == password;

            }


            return false;

        }

    }
}
