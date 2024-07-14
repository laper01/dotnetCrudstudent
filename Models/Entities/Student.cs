using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace schoolportal.Models.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public Boolean Subscribe { get; set; }
    }
}