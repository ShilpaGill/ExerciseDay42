using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExercise1.Models
{
    [Table("Student")]
    public class Passport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)", Order = 1)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)", Order = 2)]
        public string Age { get; set; }
        [Required]
        [Column(TypeName = "varchar(6)", Order = 3)]
        public string Course { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)", Order = 4)]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)", Order = 4)]
        public string Contact { get; set; }
    }
}
