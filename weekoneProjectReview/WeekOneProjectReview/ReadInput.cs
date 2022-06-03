using System;
using System.Collections.Generic;

namespace WeekOneProjectReview
{
    public class ReadInput
    {

        public void InputCollection()
        {
            Course student = new Course();
            List<Course> list = new List<Course>();
            string courseCode;
            int courseUnit;
            int courseScore;
            bool isValid = true;
            while (isValid)
            {
               
                Console.WriteLine("Enter Course Code : ");
                courseCode = ConsolePoint.Read().ToUpper();
                
                while (Validation.CourseCodeValidation(courseCode) == false  
                    || list.Exists(Course=>Course.CourseCode.Contains(courseCode))==true)
                {
                    Console.WriteLine("Enter a valid Course Code : ");
                    courseCode = ConsolePoint.Read().ToUpper();
            
                }
                Console.WriteLine("Enter Course Unit : ");
                string courseUnitCheck = ConsolePoint.Read();
                while(int.TryParse(courseUnitCheck, out courseUnit) ==false
                    || courseUnit<1 || courseUnit > 5)
                {
                    Console.WriteLine("Enter a valid Course Unit : ");
                    courseUnitCheck = ConsolePoint.Read();
                }
                    courseUnit =Convert.ToInt32(courseUnitCheck);

                Console.WriteLine("Enter your score : ");
                string courseScoreCheck = ConsolePoint.Read();
                while (int.TryParse(courseScoreCheck, out courseScore) == false 
                    || courseScore < 0 || courseScore > 100)
                {
                    Console.WriteLine("Enter a valid score : ");
                    courseScoreCheck = ConsolePoint.Read();
                }
                courseScore = Convert.ToInt32(courseScoreCheck);

                if (courseScore >= 0 && courseScore <= 39)
                {
                    list.Add(
                        new Course
                        {
                            CourseCode = courseCode,
                            CourseUnit = courseUnit,
                            CourseScore = courseScore,
                            CourseGrade = GradeMark.F.ToString(),
                            CourseGradeUnit = (int)GradeMark.F,
                            CourseRemark = "Fail"
                        });
                }
                else if (courseScore >= 40 && courseScore <= 44)
                {
                    list.Add(
                        new Course
                        { 
                             CourseCode = courseCode,
                             CourseUnit = courseUnit,
                             CourseScore = courseScore,
                             CourseGrade = GradeMark.E.ToString(),
                             CourseGradeUnit = (int)GradeMark.E,
                             CourseRemark = "Pass"

                    });
                   
                    

                }
                else if (courseScore >= 45 && courseScore <= 49)
                {
                    list.Add(
                        new Course
                    {
                         CourseCode = courseCode,
                         CourseUnit = courseUnit,
                         CourseScore = courseScore,
                         CourseGrade = GradeMark.D.ToString(),
                         CourseGradeUnit = (int)GradeMark.D,
                         CourseRemark = "Fair"


                });
                   
                }
                else if (courseScore >= 50 && courseScore <= 59)
                {
                    list.Add(
                        new Course
                        {
                            CourseCode = courseCode,
                            CourseUnit = courseUnit,
                            CourseScore = courseScore,
                            CourseGrade = GradeMark.C.ToString(),
                            CourseGradeUnit = (int)GradeMark.C,
                            CourseRemark = "Good"

                });
                    
                    

                }
                else if (courseScore >= 60 && courseScore <= 69)
                {
                    list.Add(
                        new Course
                        {
                         CourseCode = courseCode,
                         CourseUnit = courseUnit,
                         CourseScore = courseScore,
                         CourseGrade = GradeMark.B.ToString(),
                         CourseGradeUnit = (int)GradeMark.B,
                         CourseRemark = "Very Good"

                });
                    
                    
                }
                else if (courseScore >= 70 && courseScore <= 100)
                {
                    list.Add(
                        new Course
                    {
                        CourseCode = courseCode,
                        CourseUnit = courseUnit,
                        CourseScore = courseScore,
                        CourseGrade = GradeMark.A.ToString(),
                        CourseGradeUnit = (int)GradeMark.A,
                        CourseRemark = "Excellent"

                });
                    
                    
                   
                }
                Console.WriteLine("Press \"1\" to add  \"2\"  stop");
                string command = ConsolePoint.Read();
                while (!command.Equals("1")  && !command.Equals("2") )
                {
                    Console.WriteLine("Press \"1\" to add  \"2\"  stop");
                    command = ConsolePoint.Read();
                }
                if(command.Equals("1"))
                {
                    continue;
                    
                }
                else if(command.Equals("2"))   
                {
                    Console.Clear();
                    isValid = false;
                }
            }
            PrintTable.ShowResult(list);

        }
    }
}
