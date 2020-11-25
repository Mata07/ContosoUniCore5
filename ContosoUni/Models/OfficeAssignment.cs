using System.ComponentModel.DataAnnotations;

namespace ContosoUni.Models
{
    public class OfficeAssignment
    {
        #region Properties
        [Key]
        public int InstructorID { get; set; }

        [StringLength(50)]
        [Display(Name = "Office location")]
        public string Location { get; set; }
        #endregion


        #region Navigation Properties
        public Instructor Instructor { get; set; }
        #endregion

    }
}