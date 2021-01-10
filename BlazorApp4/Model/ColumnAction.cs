using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp4.Model
{
    public class ColumnAction
    {
        public string Name { get; set; }
        public Action<Person> Function { get; set; }
        public string Icon { get; set; }
    }
}
