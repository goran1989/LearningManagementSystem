﻿using System.ComponentModel.DataAnnotations;

namespace LearningManagementSystem.Models
{
    public class Department
    {
        [Key]
        public int DepId { get; set; }
        public string DepName { get; set; }
        public int DepCode { get; set; }
        public int NoOfStage { get; set; }
    }
}
