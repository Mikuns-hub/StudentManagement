namespace Studentmanagement
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set;}
        public DateTime Birthdate{ get; set;}
        public int Age
        {
            get
            { 
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }
        }
        public int Grade { get; set;}



    }
}


