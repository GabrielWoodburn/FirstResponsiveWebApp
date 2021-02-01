using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstResponsiveWebAppWoodburn.Models
{
    public class AgeModel
    {
        const int DAYS_IN_YEAR = 365;  // Const to hold days a in year
        const int ONE_YEAR = 1;        // Const to hold value for one year

        public string Name { get; set; }         // Name attribute

        // Validation for BirthDate is on the label within the form
        public DateTime BirthDate { get; set; }  // Birthdate attribute
        public int AgeThisYear()  // Function to calculate current age
        {
            int age = DateTime.Now.Subtract(BirthDate).Days;  // Assign age
            age = age / DAYS_IN_YEAR;  // Divide by 365
            return age;  // Return age
        }
        public int AgeByEndOfYear() // Function to calculate age by December 31st
        {
            int age = DateTime.Now.Subtract(BirthDate).Days;  // Assign age
            age = age / DAYS_IN_YEAR;  // Divide by 365
            return age + ONE_YEAR;     // Return age + 1
        }
    }
}
