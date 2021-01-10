using BlazorApp4.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp4.Components
{
    public partial class Table<TItem>: ComponentBase
    {
        [Parameter]
        public List<TItem> Data { get; set; }

        [Parameter]
        public RenderFragment TableHeader { get; set; }

        [Parameter]
        public RenderFragment<TItem> TableRow { get; set; }

    }
}
