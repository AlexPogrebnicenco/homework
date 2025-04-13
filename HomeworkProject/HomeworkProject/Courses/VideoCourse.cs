using System;

namespace HomeworkProject.Courses
{
    public class VideoCourse : Course
    {
        public string VideoUrl { get; set; }

        public override void Describe()
        {
            base.Describe();
            Console.WriteLine("This course includes video lessons");
            Console.WriteLine($"Watch here: {VideoUrl}");
        }
    }
}
