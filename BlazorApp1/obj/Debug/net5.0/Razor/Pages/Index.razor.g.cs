#pragma checksum "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\Index.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "264da4ee8303f48de331d042411284e3eb729ac200548f028a7577d5a9b0d786"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http.Json

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\Index.razor"
      "/"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login</h3>");
#nullable restore
#line 7 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\Index.razor"
 if (!string.IsNullOrEmpty(ErrorMessage))
{

#line default
#line hidden
#nullable disable

            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert alert-danger");
            __builder.AddContent(3, 
#nullable restore
#line 9 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\Index.razor"
                                     ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable

            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 12 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\Index.razor"
                 loginModel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\Index.razor"
                                            HandleLogin

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(7, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\r\n    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "<label for=\"id\">Student ID</label>\r\n        ");
                global::__Blazor.BlazorApp1.Pages.Index.TypeInference.CreateInputNumber_0(__builder2, 15, 16, "form-control", 17, "id", 18, 
#nullable restore
#line 18 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\Index.razor"
                                  loginModel.Id

#line default
#line hidden
#nullable disable
                , 19, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginModel.Id = __value, loginModel.Id)), 20, () => loginModel.Id);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n\r\n    ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "<label for=\"password\">Password</label>\r\n        ");
                global::__Blazor.BlazorApp1.Pages.Index.TypeInference.CreateInputNumber_1(__builder2, 25, 26, "form-control", 27, "password", 28, 
#nullable restore
#line 23 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\Index.razor"
                                  loginModel.Password

#line default
#line hidden
#nullable disable
                , 29, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginModel.Password = __value, loginModel.Password)), 30, () => loginModel.Password);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n\r\n    ");
                __builder2.AddMarkupContent(32, "<button type=\"submit\" class=\"btn btn-primary\">Login</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\Index.razor"
       
    private LoginModel loginModel = new LoginModel();
    private string ErrorMessage;

    private async Task HandleLogin()
    {
        try
        {
            var student = await StudentConsumer.GetStudent(loginModel.Id, loginModel.Password);
            if (student != null)
            {
                // Navigate to dashboard with URL-encoded student details
                Navigation.NavigateTo($"/student-dashboard/{student.Id}/{Uri.EscapeDataString(student.Name)}/{student.Age}/{student.GPA}/{student.tot_achived}/{student.term}/{Uri.EscapeDataString(student.departmentName)}/{Uri.EscapeDataString(student.sponser)}/{Uri.EscapeDataString(student.collegeName)}/{student.hasSchedule}");
            }
        }
        catch (Exception ex)
        {
            ErrorMessage = ex.Message;
        }
    }

    public class LoginModel
    {
        public int Id { get; set; }
        public int Password { get; set; }
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 3 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\Index.razor"
        NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 3 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\Index.razor"
                          Navigation

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 2 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\Index.razor"
        BlazorApp1.DataConsumers.StudentConsumer

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 2 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\Index.razor"
                                                 StudentConsumer

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
namespace __Blazor.BlazorApp1.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", (object)__arg0);
        __builder.AddAttribute(__seq1, "id", (object)__arg1);
        __builder.AddAttribute(__seq2, "Value", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", (object)__arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", (object)__arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", (object)__arg0);
        __builder.AddAttribute(__seq1, "id", (object)__arg1);
        __builder.AddAttribute(__seq2, "Value", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", (object)__arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", (object)__arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
