using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment.Models;

namespace assignment.Helpers
{
    // Stores the currently logged-in user for the duration of the session
    // Static class means only one instance exists across the entire application
    // Any form can access SessionManager.CurrentUser without needing it passed manually
    
    public class SessionManager
    {
       
        public  static User CurrentUser { get; private set; }

        public static void Login(User user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }

        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }
    }
}

