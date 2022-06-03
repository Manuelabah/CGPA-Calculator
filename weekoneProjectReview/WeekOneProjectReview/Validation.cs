
using System.Text.RegularExpressions;

namespace WeekOneProjectReview
{
    public class Validation
    {
       static string pattern = "^[A-Z]{3}[0-9]{3}$";
        public static bool CourseCodeValidation(string check)
        {
            if(Regex.IsMatch(check, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
               
        }
    }
}
