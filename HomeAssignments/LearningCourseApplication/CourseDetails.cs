namespace LearningCourseApplication
{
    public class CourseDetails
    {
        private static int s_courseId=1000;
        public string CourseId { get;  }
        public string CourseType { get; set; }
        public string CourseName { get; set; }
        public string Language { get; set; }
        public double Price { get; set; }

        public CourseDetails(string courseType,string courseName,string language,double price)
        {
            s_courseId++;
            CourseId="CID"+s_courseId;
            CourseType=courseType;
            CourseName=courseName;
            Language=language;
            Price=price;
        }
        
        
        
        

        
        
        
    }
}