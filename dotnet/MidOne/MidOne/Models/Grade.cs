using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidOne.Models
{
    public class Grade
    {
        public int Id { get; set; }

        public int Points { get; set; }

        public int StudentId { get; set; }
        public Student Student;

        public int SubjectId { get; set; }
        public Subject Subject;
    }
}
