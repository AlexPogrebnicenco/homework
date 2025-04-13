using HomeworkProject.Courses;
using HomeworkProject.Enums;

namespace HomeworkProject.Factories
{
    public static class CourseFactory
    {
        public static TextCourse CreateTextCourse(int id, string title, CourseCategory category, CourseLevel level, string content) 
        {
            return new TextCourse
            {
                Id = id,
                Title = title,
                Category = category,
                Level = level,
                Content = content
            };
        }

        public static VideoCourse CreateVideoCourse(int id, string title, CourseCategory category, CourseLevel level, string videoUrl) 
        {
            return new VideoCourse
            {
                Id= id,
                Title = title,
                Category= category,
                Level = level,
                VideoUrl = videoUrl
            };
        }
    }
}
