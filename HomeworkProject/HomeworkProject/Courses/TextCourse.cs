using System;


namespace HomeworkProject.Courses
{
    public class TextCourse : Course 
    {
        public string Content { get; set; }
        public override void Describe()
        {
            base.Describe();
            Console.WriteLine("This is a text-only course.");
            Console.WriteLine($"Content preview: {Content.Substring(0, Math.Min(30, Content.Length))}...");

        }
    }
}
