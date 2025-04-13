using System;
using HomeworkProject.Factories;
using HomeworkProject.Courses;
using HomeworkProject.Enums;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace HomeworkProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            WorkWithUser();
            WorkWithCourses();
            Console.ReadLine();
        }
            
        public static void WorkWithUser()
        {
            var user = UserFactory.CreateUser(1, "Alexandru", UserCategory.Admin, "Not needed");
            user.PrintInfo();
        }

        public static void WorkWithCourses()
        {
            var textCourse = CourseFactory.CreateTextCourse(
                1, "HTMl course from Amdaris", Enums.CourseCategory.Frontend, Enums.CourseLevel.Beginner,
                "In this course we'll speak about HTML"
            );

            var videoCourse = CourseFactory.CreateVideoCourse(
                2, "React Crash Course", CourseCategory.Frontend, CourseLevel.Intermediate,
                "https://www.youtube.com/watch?v=x4rFhThSX04&t=304s&ab_channel=freeCodeCamp.org"
                );

            List<Course> courses = new List<Course> {textCourse, videoCourse};

            foreach (var course in courses)
            {
                Console.WriteLine("-----COURSE-----");

                if (course is VideoCourse)
                {
                    Console.WriteLine("[Video]");
                    videoCourse.Describe();
                }
                else if (course is TextCourse) 
                {
                    Console.WriteLine("[Text]");
                    textCourse.Describe();
                }
                else
                {
                    Console.WriteLine("This course is deleted");
                }
            }

        }

       
    }
}
