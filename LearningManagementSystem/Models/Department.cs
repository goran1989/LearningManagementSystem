using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningManagementSystem.Models
{
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(6)]
        public string DepCode { get; set; }
        public string DepName { get; set; }
        public int NoOfStage { get; set; }

        [ForeignKey("Institute")]
        public string InstCode { get; set; }
        public Institute Institute { get; set; }
    }
}
