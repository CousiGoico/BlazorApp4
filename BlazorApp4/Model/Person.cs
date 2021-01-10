using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp4.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Nombre: {Name}, Apellidos: {Surname}, Edad: {Age}";
        }
    }
}
