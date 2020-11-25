using System.ComponentModel.DataAnnotations;

namespace ContosoUni.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        #region Properties
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }
        #endregion


        #region Navigation Properties
        public Course Course { get; set; }
        public Student Student { get; set; } 
        #endregion
    }
}