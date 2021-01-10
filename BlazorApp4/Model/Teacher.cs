using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp4.Model
{
    public class Teacher: IPeople
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Teacher Name: {Name}, Surname: {Surname}, Age: {Age}";
        }
    }
}
