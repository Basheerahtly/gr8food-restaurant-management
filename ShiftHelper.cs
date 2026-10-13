using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHEF
{
    public class ShiftHelper
    {
        // getting current shift
        public string GetCurrentShift()
        {
            // Current system time
            TimeSpan currentTime =DateTime.Now.TimeOfDay;

            // Breakfast Shift
            if (currentTime >=TimeSpan.Parse("07:00")&& currentTime < TimeSpan.Parse("11:00"))
            {
                return "Breakfast";
            }

            // Lunch Shift
            else if (currentTime >= TimeSpan.Parse("12:00") && currentTime < TimeSpan.Parse("16:00"))
            {
                return "Lunch";
            }

            // Dinner Shift
            else
            {
                return "Dinner";
            }
        }

        // Getting active ChefID
        public string GetActiveChefID()
        {
            // Current active shift
            string shift =GetCurrentShift();

            // Breakfast Chef
            if (shift == "Breakfast")
            {
                return "Chef1";
            }

            // Lunch Chef
            else if (shift == "Lunch")
            {
                return "Chef2";
            }

            // Dinner Chef
            else
            {
                return "Chef3";
            }
        }

        // Method to get chef shift
        public  string GetChefShift(string chefID)
        {
            // Breakfast chef
            if (chefID =="Chef1")
            {
                return "Breakfast";
            }

            // Lunch chef
            else if (chefID == "Chef2")
            {
                return "Lunch";
            }

            // Dinner chef
            else if (chefID == "Chef3")
            {
                return "Dinner";
            }
            return "";
        }

        // Method to get shift start time
        public TimeSpan GetShiftStartTime(string chefID)
        {
            // Breakfast
            if (chefID == "Chef1")
            {
                return TimeSpan.Parse("07:00");
            }

            // Lunchr
            else if (chefID == "Chef2")
            {
                return TimeSpan.Parse("12:00");
            }

            // Dinner
            else if (chefID == "Chef3")
            {
                return TimeSpan.Parse("16:00");
            }
            return TimeSpan.Zero;
        }
        public string GetChefShiftTime(string chefID)
        {
            // Breakfast shift
            if (chefID =="Chef1" )
            {
                return "7:00 AM - 11:59 AM";
            }

            // Lunch shift
            else if (chefID == "Chef2")
            {
                return "12:00 PM - 4:59 PM";
            }

            // Dinner shift
            else if (chefID == "Chef3")
            {
                return "5:00 PM - 11:59 PM";
            }
            return "";
        }

        // Method to get shift end time
        public TimeSpan GetShiftEndTime(string chefID)
        {
            // Breakfast
            if (chefID == "Chef1")
            {
                return TimeSpan.Parse("11:59");
            }

            // Lunch
            else if (chefID == "Chef2")
            {
                return TimeSpan.Parse("16:59");
            }

            // Dinner
            else if (chefID == "Chef3")
            {
                return TimeSpan.Parse("23:59");
            }
            return TimeSpan.Zero;
        }



        public  bool CanChefAccessCategory(string chefID,string category) // Method to check if chef can access category
        {
            // Shared categories
            if (category == "Snacks" || category == "Drinks")
            {
                return true;
            }

            // Breakfast Chef
            if (chefID == "Chef1"  && category == "Breakfast")
            {
                return true;
            }

            // Lunch Chef
            if (chefID == "Chef2" && category == "Lunch")
            {
                return true;
            }

            // Dinner Chef
            if (chefID == "Chef3" && category == "Dinner")
            {
                return true;
            }
            // Otherwise deny access
            return false;
        }
    }
}

