using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;

namespace ModelsAndModelBinding.Models
{
    /// <summary>
    /// Represents an individual Student
    /// </summary>
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Enter full name to continue.")]
        [Display(Name = "Full Legal Name")]
        public string FullName { get; set; }

        [Required()]
        [Display(Name = "Choose Program")]
        public string ProgramOfChoice { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        // Max 30  characters for demo
        [StringLength(30, MinimumLength = 5)]
        public string HomeAddress { get; set; }
    }
}
