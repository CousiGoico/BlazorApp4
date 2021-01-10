using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp4.Helper
{
    public static class Extension
    {
        public static Task<int> SetScrollTop(this IJSRuntime js) => js.InvokeAsync<int>("setScrollTop").AsTask();

        public static Task<int> SetScrollLeft(this IJSRuntime js) => js.InvokeAsync<int>("setScrollLeft").AsTask();

        public static Task<int> SetColumnWidth(this IJSRuntime js, ElementReference element, int Width) => js.InvokeAsync<int>("setColumnWidth", new object[] { element, Width }).AsTask();
    }
}
