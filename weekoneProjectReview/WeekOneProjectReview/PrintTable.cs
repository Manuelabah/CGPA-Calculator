using System;
using System.Collections.Generic;

namespace WeekOneProjectReview
{
    public class PrintTable
    {
        static double weightPt;
        static double totalWeightPoint=0;
        static double totalGradeUnit = 0;
        static double GPA;
        static int totalCourseUnitRegistered = 0; 
        static int totalCourseUnitPassed  = 0;
       public static void ShowResult(List<Course> listOfcourses)
        {
            Console.WriteLine("\n\n\t\t----------------------------------------GPA CALCULATOR-----------------------------------------------\n\n\n\n");



            Console.WriteLine("\t\t|---------------|---------------|-------------|--------------|----------------|---------------|");
            Console.WriteLine("\t\t|               |               |             |              |                |               |");
            Console.WriteLine("\t\t|  COURSE CODE  |  COURSE UNIT  |    GRADE    |  GRADE UNIT  |  WEIGHTED POINT|    REMARK     |");
            Console.WriteLine("\t\t|               |               |             |              |                |               |");
            Console.WriteLine("\t\t|---------------|---------------|-------------|--------------|----------------|---------------|");

            foreach (Course course in listOfcourses)
            {
                weightPt = course.CourseUnit * course.CourseGradeUnit;
                Console.WriteLine("\t\t|    " + course.CourseCode + new string(' ', (11 - course.CourseCode.Length)) + "|      " +
                       course.CourseUnit + new String(' ', 8) +
                       "|      " + course.CourseGrade + new String(' ', 6) + "|       " +
                       course.CourseGradeUnit + new String(' ', 6) + "|        " +
               +weightPt + new String(' ', 7 - weightPt.ToString().Length) + " |   "
               + course.CourseRemark + new String(' ', (12 - course.CourseRemark.Length)) + "|");

                Console.WriteLine("\t\t|---------------|---------------|-------------|--------------|----------------|---------------|");


                totalCourseUnitRegistered += Convert.ToInt32(course.CourseUnit);
                totalWeightPoint += Convert.ToDouble(weightPt);
                totalGradeUnit += Convert.ToDouble(course.CourseGradeUnit);
                GPA = Math.Round((totalWeightPoint / totalCourseUnitRegistered),2);
                if (course.CourseGrade == "F")
                {
                    course.CourseUnit = 0;
                    totalCourseUnitPassed += Convert.ToInt32(course.CourseUnit);
                }
                else
                {
                    totalCourseUnitPassed += Convert.ToInt32(course.CourseUnit);
                }
                
               
            }


               
               Console.WriteLine($"\n\t\tTotal Course Unit Registered: {Convert.ToInt32(totalCourseUnitRegistered )}");
               Console.WriteLine($"\n\t\tTotal Course Unit Passed is  :{totalCourseUnitPassed}");
               Console.WriteLine($"\n\t\tTotal Weight Point is :{totalWeightPoint}");
               Console.WriteLine($"\n\t\tYour GPA is:{GPA}");

        }
    }
}
