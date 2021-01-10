using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp4.Model
{
    public class Column
    {
        public string Title { get; set; }
        public int Order { get; set; }
        public string Field { get; set; }
        public int Width { get; set; }
        public ElementReference Element { get; set; }
    }
}
