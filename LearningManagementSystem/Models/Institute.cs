using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningManagementSystem.Models
{
    public class Institute
    {
       [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InsCode { get; set; }
        public string InstituteName { get; set;}


        public List<Department> Departments { get; set; }

    }
}
