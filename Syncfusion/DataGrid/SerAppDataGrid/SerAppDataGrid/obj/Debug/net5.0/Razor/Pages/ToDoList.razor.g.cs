#pragma checksum "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\ToDoList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "249c1bc61703210b6070ab700ced2f9bd6326f21"
// <auto-generated/>
#pragma warning disable 1591
namespace SerAppDataGrid.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using SerAppDataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using SerAppDataGrid.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\_Imports.razor"
using Syncfusion.Blazor.PivotView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\ToDoList.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\ToDoList.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\ToDoList.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
    public partial class ToDoList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Todo List</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(3);
            __builder.AddAttribute(4, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\ToDoList.razor"
                         UpdateItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Placeholder", "Add new   item");
            __builder.AddAttribute(6, "Width", "200px");
            __builder.AddAttribute(7, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\ToDoList.razor"
                                                   item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item = __value, item))));
            __builder.AddAttribute(9, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => item));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n\r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(11);
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\ToDoList.razor"
                        AddItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(14, "Add");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 15 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\ToDoList.razor"
 if (items.Count > 0)
{

#line default
#line hidden
#nullable disable
            __Blazor.SerAppDataGrid.Pages.ToDoList.TypeInference.CreateSfListView_0(__builder, 15, 16, 
#nullable restore
#line 17 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\ToDoList.razor"
                             items

#line default
#line hidden
#nullable disable
            , 17, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Lists.ListViewFieldSettings<ItemModel>>(18);
                __builder2.AddAttribute(19, "Id", "Id");
                __builder2.AddAttribute(20, "Text", "Text");
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 20 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\ToDoList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\Program\SamplesOnGit\Syncfusion\DataGrid\SerAppDataGrid\SerAppDataGrid\Pages\ToDoList.razor"
       
    private string item;
    private List<ItemModel> items = new List<ItemModel>();

    private void UpdateItem(Microsoft.AspNetCore.Components.ChangeEventArgs args)
    {
        item = args.Value.ToString();
    }

    // Add new items on button click.
    private void AddItem()
    {
        if (item != null && item.Length > 0)
        {
            var newItem = new ItemModel(items.Count + 1, item);
            items.Add(newItem);
            item = null;
        }
    }

    // List view data source model.
    public class ItemModel
    {
        public ItemModel(int id, string text)
        {
            Id = id;
            Text = text;
        }
        public int Id { get; set; }
        public string Text { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.SerAppDataGrid.Pages.ToDoList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfListView_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Lists.SfListView<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591