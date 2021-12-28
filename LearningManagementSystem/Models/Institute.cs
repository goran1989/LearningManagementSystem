using System.ComponentModel.DataAnnotations;

namespace LearningManagementSystem.Models
{
    public class Institute
    {
       [Key]
        public int InstituteId { get; set; }
        public string InstituteName { get; set;} 

    }
}
