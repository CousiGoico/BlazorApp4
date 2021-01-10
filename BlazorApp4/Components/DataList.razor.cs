using BlazorApp4.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp4.Helper;

namespace BlazorApp4.Components
{
    public partial class DataList: ComponentBase
    {
        [Parameter]
        public List<Column> Columns { get; set; }

        [Parameter]
        public List<Person> Data { get; set; }

        [Parameter]
        public List<ColumnAction> Actions { get; set; }

        [Inject]
        public IJSRuntime js { get; set; }

        public int scroll { get; set; }

        public int width { get; set; }

        public bool IsResizing { get; set; } = false;
        public Column ColumnSelected { get; set; }
        
        public double InitialPosition { get; set; } = 0;
        public double ControlWidth { get; set; } = 0;
        public double Position { get; set; }

        public void Scrolling(EventArgs args) {
            var topValue = js.SetScrollTop();
        }
        public void ScrollingLeft(EventArgs args) {
            var leftValue = js.SetScrollLeft();
        }

        public void OnMouseDown(Column column, MouseEventArgs args) {
            ColumnSelected = column;
            InitialPosition = args.ClientX;
            IsResizing = true;

        }

        public void OnMouseMove(MouseEventArgs args) {
            if (IsResizing == true) {
                var initialWidth = 250;
                Position = args.ClientX;
                double width = initialWidth + (Position - InitialPosition);
                ControlWidth = width;
                ColumnSelected.Width = Convert.ToInt32(width);
            }
        }

        public void OnMouseUp(MouseEventArgs args) {
            IsResizing = false;
            InitialPosition = 0;
        }
    }
}
