using System;

namespace Gpa
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = "Ike Martha";

            string firstCourse  = "English 101";
            string secondCourse = "Algebra 101 ";
            string thirdCourse  = "Biology 101";
            string fourthCourse = "ComputerScience 1";
            string fifthCourse  = "Psycology 101";

            //Create a variable to store the credit hour of each course
            int firstCourseCredit  = 3;
            int secondCourseCredit = 3;
            int thirdCourseCredit  = 4;
            int fourthCourseCredit = 4;
            int fifthCourseCredit  = 3;


            //create a variable to store the grade values
            int gradeA = 4;
            int gradeB = 3;


            int firstCourseGrade = gradeA;
            int secondCourseGrade = gradeB;
            int thirdCourseGrade = gradeB;
            int fourthCourseGrade = gradeB;
            int fifthCourseGrade = gradeA;

            //Console.WriteLine("Courses\t\tCourseGrade\t\tCourseCredit\n");
            //Console.WriteLine($"{firstCourse}\t\t{firstCourseGrade}\t\t{firstCourseCredit}\t");
            //Console.WriteLine($"{secondCourse}\t\t{secondCourseGrade}\t\t{secondCourseCredit}\t");
            //Console.WriteLine($"{thirdCourse}\t\t{thirdCourseGrade}\t\t{thirdCourseCredit}\t");
            //Console.WriteLine($"{fourthCourse}\t\t{fourthCourseGrade}\t\t{fourthCourseCredit}\t");
            //Console.WriteLine($"{fifthCourse}\t\t{fifthCourseGrade}\t\t{fifthCourseCredit}\t");
            

            //Calculate the sums of credit hours and grade points
            int totalCreditHours = 0;

             totalCreditHours += firstCourseCredit ;
             totalCreditHours += secondCourseCredit;
             totalCreditHours += thirdCourseCredit;
             totalCreditHours += fourthCourseCredit;
             totalCreditHours += fifthCourseCredit;
          
            int totalGradePoint = 0;

            totalGradePoint += firstCourseCredit * firstCourseGrade ;
            totalGradePoint += secondCourseCredit * secondCourseGrade;
            totalGradePoint += thirdCourseCredit * thirdCourseGrade;
            totalGradePoint += fourthCourseCredit * fourthCourseGrade;
            totalGradePoint += fifthCourseCredit * fifthCourseGrade;

           // Console.WriteLine("TotalGradePoint\t\tTotalCreditHours\t\t");
            Console.WriteLine($"{totalGradePoint}   {totalCreditHours}");


            Console.WriteLine("Courses\t\tCourseGrade\t\tCourseCredit\n");
            Console.WriteLine($"{firstCourse}\t\t{firstCourseGrade}\t\t{firstCourseCredit}\t");
            Console.WriteLine($"{secondCourse}\t\t{secondCourseGrade}\t\t{secondCourseCredit}\t");
            Console.WriteLine($"{thirdCourse}\t\t{thirdCourseGrade}\t\t{thirdCourseCredit}\t");
            Console.WriteLine($"{fourthCourse}\t\t{fourthCourseGrade}\t\t{fourthCourseCredit}\t");
            Console.WriteLine($"{fifthCourse}\t\t{fifthCourseGrade}\t\t{fifthCourseCredit}\t");

        }
    }
}
