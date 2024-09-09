using System;
using System.Collections.Generic;

namespace BarProject.Src
{
    public class LoginManager
    {
        private List<Admin> admins;
        private List<Waiter> waiters;

        public LoginManager()
        {
            admins = new List<Admin>();
            waiters = new List<Waiter>();
        }

        public void Login()
        {
            // Implement login logic here
        }

        public void Logout()
        {
            // Implement logout logic here
        }



        public void ValidateUser(int id, string password)
        {
            // Implement user validation logic here
        }
    }
}