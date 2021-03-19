using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiExercise1.Models
{
    public partial class StudentTable
    {
        public int Id { get; set; }
        public string Sname { get; set; }
        public DateTime Age { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
    }
}
