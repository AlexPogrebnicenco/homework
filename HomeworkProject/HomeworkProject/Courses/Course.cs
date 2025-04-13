using System;
using HomeworkProject.Enums;

namespace HomeworkProject.Courses
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public CourseCategory Category { get; set; }
        public CourseLevel Level { get; set; }

        public virtual void Describe()
        {
            Console.WriteLine($"Course: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Level: {Level}");
        }

        public void Describe (string prefix)
        {
            Console.WriteLine($"{prefix} {Title} ({Category}, {Level})");
        }

    }
}
