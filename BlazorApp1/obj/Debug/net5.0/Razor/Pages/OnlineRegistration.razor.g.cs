#pragma checksum "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6cc2902e84e2c0820f3c15f251e1f742c64be053c430e89745328d152fdbfe05"
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
#line 1 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
      "/online-registration"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class OnlineRegistration : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    /* Animation */\r\n    .modal {\r\n        position: fixed;\r\n        top: 0;\r\n        left: 25%;\r\n        width: 50%;\r\n        height: 100%;\r\n       \r\n        display: flex;\r\n        justify-content: center;\r\n        align-items: center;\r\n        z-index: 1000;\r\n    }\r\n\r\n    .modal-content {\r\n        background-color: white;\r\n        padding: 20px;\r\n        border-radius: 8px;\r\n        text-align: center;\r\n        box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);\r\n    }\r\n\r\n\r\n    /* Dashboard header */\r\n    .dashboard-header {\r\n        text-align: center;\r\n        color: #34495e;\r\n        font-size: 2em;\r\n        margin-bottom: 20px;\r\n        animation: fadeIn 1s ease-in-out;\r\n    }\r\n\r\n    /* Student info container */\r\n    .student-info {\r\n        display: grid;\r\n        grid-template-columns: 1fr 1fr;\r\n        gap: 15px;\r\n        width: 70%;\r\n        margin: 20px auto;\r\n        background-color: #f9fafb;\r\n        padding: 25px;\r\n        border-radius: 10px;\r\n        box-shadow: 0 6px 12px rgba(0, 0, 0, 0.15);\r\n        animation: scaleUp 0.6s ease-in-out;\r\n    }\r\n\r\n    /* Info item style */\r\n    .info-item {\r\n        font-size: 1.2em;\r\n        color: #555;\r\n        display: flex;\r\n        justify-content: space-between;\r\n    }\r\n\r\n    /* Table style */\r\n    .days-table {\r\n        width: 80%;\r\n        margin: 20px auto;\r\n        border-collapse: collapse;\r\n        box-shadow: 0 3px 6px rgba(0, 0, 0, 0.1);\r\n        animation: fadeIn 1s ease-in-out;\r\n    }\r\n    .days-table th, .days-table td {\r\n        border: 1px solid #ddd;\r\n        padding: 12px;\r\n        text-align: center;\r\n        font-size: 1.1em;\r\n    }\r\n    .days-table th {\r\n        background-color: #4CAF50;\r\n        color: white;\r\n        font-size: 1.15em;\r\n        text-transform: uppercase;\r\n    }\r\n    .days-table td {\r\n        background-color: #fdfdfd;\r\n    }\r\n    .days-table td:hover {\r\n        background-color: #f1f8ff;\r\n        transition: background-color 0.3s;\r\n    }\r\n\r\n    /* Select dropdown */\r\n    select {\r\n        padding: 5px;\r\n        border-radius: 5px;\r\n        border: 1px solid #ccc;\r\n        background-color: #f1f1f1;\r\n        transition: 0.3s;\r\n    }\r\n    select:hover {\r\n        background-color: #e2e2e2;\r\n    }\r\n\r\n    /* Button container */\r\n    .button-container {\r\n        display: flex;\r\n        justify-content: center;\r\n        margin-top: 25px;\r\n    }\r\n\r\n    /* Confirm button */\r\n    .btn-success {\r\n        padding: 12px 25px;\r\n        font-size: 1.2em;\r\n        color: #fff;\r\n        background-color: #28a745;\r\n        border: none;\r\n        border-radius: 5px;\r\n        box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);\r\n        cursor: pointer;\r\n        transition: transform 0.3s ease, box-shadow 0.3s ease;\r\n        animation: scaleUp 0.6s ease-in-out;\r\n    }\r\n    .btn-success:hover {\r\n        background-color: #218838;\r\n        transform: scale(1.05);\r\n        box-shadow: 0 6px 12px rgba(0, 0, 0, 0.2);\r\n    }\r\n\r\n    /* Delete button */\r\n    .btn-danger {\r\n        padding: 5px 12px;\r\n        color: #fff;\r\n        background-color: #dc3545;\r\n        border: none;\r\n        border-radius: 4px;\r\n        cursor: pointer;\r\n        transition: background-color 0.3s;\r\n    }\r\n    .btn-danger:hover {\r\n        background-color: #c82333;\r\n    }\r\n</style>\r\n");
            __builder.AddMarkupContent(1, "<h3 class=\"dashboard-header\">Online Registration</h3>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "student-info");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "info-item");
            __builder.AddMarkupContent(6, "<strong>ID:</strong> ");
            __builder.AddContent(7, 
#nullable restore
#line 144 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                                                 Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "info-item");
            __builder.AddMarkupContent(11, "<strong>Name:</strong> ");
            __builder.AddContent(12, 
#nullable restore
#line 145 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                                                   Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "info-item");
            __builder.AddMarkupContent(16, "<strong>Age:</strong> ");
            __builder.AddContent(17, 
#nullable restore
#line 146 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                                                  Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "info-item");
            __builder.AddMarkupContent(21, "<strong>GPA:</strong> ");
            __builder.AddContent(22, 
#nullable restore
#line 147 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                                                  GPA

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "info-item");
            __builder.AddMarkupContent(26, "<strong>Total Achieved:</strong> ");
            __builder.AddContent(27, 
#nullable restore
#line 148 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                                                             TotAchieved

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "info-item");
            __builder.AddMarkupContent(31, "<strong>Term:</strong> ");
            __builder.AddContent(32, 
#nullable restore
#line 149 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                                                   Term

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "info-item");
            __builder.AddMarkupContent(36, "<strong>Department Name:</strong> ");
            __builder.AddContent(37, 
#nullable restore
#line 150 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                                                              DepName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "info-item");
            __builder.AddMarkupContent(41, "<strong>Sponsor:</strong> ");
            __builder.AddContent(42, 
#nullable restore
#line 151 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                                                      Sponser

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "info-item");
            __builder.AddMarkupContent(46, "<strong>College:</strong> ");
            __builder.AddContent(47, 
#nullable restore
#line 152 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                                                      College

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "info-item");
            __builder.AddMarkupContent(51, "<strong>Total Crd Hours:</strong> ");
            __builder.AddContent(52, 
#nullable restore
#line 153 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                                                               selectedGroups.Keys.Count * 3

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n");
            __builder.OpenElement(54, "table");
            __builder.AddAttribute(55, "class", "days-table");
            __builder.AddMarkupContent(56, "<thead><tr><th>Course Id</th>\r\n            <th>Course Name</th>\r\n            <th>Credit Hours</th>\r\n            <th>Course Period</th>\r\n            <th>Group</th>\r\n            <th>Grade</th>\r\n            \r\n            <th>Delete</th></tr></thead>\r\n    ");
            __builder.OpenElement(57, "tbody");
#nullable restore
#line 173 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
         foreach (var group in a)
        {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(58, "tr");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 176 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                     group.CourseId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 177 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                     group.CourseName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 178 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                     group.CourseCreditHours

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 179 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                     group.CoursePeriod

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.OpenElement(71, "td");
            __builder.OpenElement(72, "select");
            __builder.AddAttribute(73, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 181 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                                       (e) => OnGroupSelected(e, group)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(74, "option");
            __builder.AddAttribute(75, "value", "0");
            __builder.AddContent(76, "Select Class");
            __builder.CloseElement();
#nullable restore
#line 183 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                         foreach (var schedule in group.Schedules)
                        {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(77, "option");
            __builder.AddAttribute(78, "value", 
#nullable restore
#line 185 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                                            schedule.CourseGroupId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(79, 
#nullable restore
#line 185 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                                                                     schedule.CourseGroupId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 186 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                        }

#line default
#line hidden
#nullable disable

            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.AddMarkupContent(81, "<td>U</td>\r\n                ");
            __builder.OpenElement(82, "td");
            __builder.OpenElement(83, "button");
            __builder.AddAttribute(84, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 191 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                                      () => DeleteCourse(group.CourseName,group.CourseId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "class", "btn btn-danger");
            __builder.AddContent(86, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 194 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
        }

#line default
#line hidden
#nullable disable

            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\r\n    ");
            __builder.OpenElement(88, "table");
            __builder.AddAttribute(89, "class", "days-table");
            __builder.AddMarkupContent(90, "<thead><tr><th>Day</th>\r\n                <th>1</th>\r\n                <th>2</th>\r\n                <th>3</th>\r\n                <th>4</th></tr></thead>\r\n        ");
            __builder.OpenElement(91, "tbody");
#nullable restore
#line 215 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
             foreach (var day in daysOfWeek)
            {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(92, "tr");
            __builder.OpenElement(93, "td");
            __builder.AddContent(94, 
#nullable restore
#line 218 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                         day

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 219 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                     for (int slot = 1; slot <= 4; slot++)
                    {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(95, "td");
            __builder.AddContent(96, 
#nullable restore
#line 221 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                          (MarkupString)daySlots[day][slot - 1]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 222 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                    }

#line default
#line hidden
#nullable disable

            __builder.CloseElement();
#nullable restore
#line 224 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
            }

#line default
#line hidden
#nullable disable

            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 227 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
 if (isRegistrationSuccessful)
{

#line default
#line hidden
#nullable disable

            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "modal");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "modal-content");
            __builder.AddMarkupContent(101, "<h3>Registration Successful!</h3>\r\n            ");
            __builder.AddMarkupContent(102, "<p>Your courses have been successfully registered.</p>\r\n            ");
            __builder.OpenElement(103, "button");
            __builder.AddAttribute(104, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 233 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                              NavigateToConfirmationPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(105, "Go to Confirmation");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 236 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
}

#line default
#line hidden
#nullable disable

            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "button-container margin");
            __builder.OpenElement(108, "button");
            __builder.AddAttribute(109, "class", "btn btn-success");
            __builder.AddAttribute(110, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 238 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                                              ConfirmRegistration

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(111, "Confirm Registration");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 243 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
       

    // Properties to hold student data
    private int Id { get; set; }
    private string Name { get; set; }
    private int Age { get; set; }
    private float GPA { get; set; }
    private int TotAchieved { get; set; }
    private int Term { get; set; }
    private string DepName { get; set; }
    private string Sponser { get; set; }
    private string College { get; set; }
    private string NumberofCredit { get; set; }
    private bool Registered { get; set; }
    private List<ScheduleGroupViewModel> a { get; set; }
    private List<ClassLibrary1.RegisteredCourseDto> c { get; set; }
    private bool isRegistrationSuccessful = false;
    private Dictionary<int, int> selectedGroups = new Dictionary<int, int>(); // CourseId -> CourseGroupId
    private List<string> daysOfWeek = new List<string> { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
    private Dictionary<string, string[]> daySlots = new Dictionary<string, string[]>
{
    { "Saturday", new string[4] { "", "", "", "" } },
    { "Sunday", new string[4] { "", "", "", "" } },
    { "Monday", new string[4] { "", "", "", "" } },
    { "Tuesday", new string[4] { "", "", "", "" } },
    { "Wednesday", new string[4] { "", "", "", "" } },
    { "Thursday", new string[4] { "", "", "", "" } },
    { "Friday", new string[4] { "", "", "", "" } }
};

    protected override async Task OnInitializedAsync()
    {
        // Retrieve query parameters from the URL
        var uri = new Uri(UriHelper.Uri);
        var queryParams = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(uri.Query);

        Id = int.Parse(queryParams["id"]);
        Name = queryParams["name"];
        Age = int.Parse(queryParams["age"]);
        GPA = float.Parse(queryParams["gpa"]);
        TotAchieved = int.Parse(queryParams["totAchieved"]);
        Term = int.Parse(queryParams["term"]);
        DepName = queryParams["depName"];
        Sponser = queryParams["sponser"];
        College = queryParams["college"];
        Registered = queryParams["registered"] == "True" ?  true :false ;
        a = System.Text.Json.JsonSerializer.Deserialize<List<ScheduleGroupViewModel>>(queryParams["schedule"]);
        if (Registered )
        {try
            {c = (await StudentConsumer.GetRegisteredCourses(Id)).ToList();
                if(c != null)
                {
                    foreach(var x in c)
                    {
                        selectedGroups[x.CourseId] = x.GroupId;
                        UpdateDaySlots(x.GroupId, x.CourseId, "Add");
                    }
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
    }
    private void NavigateToConfirmationPage()
    {
        isRegistrationSuccessful = false;
        Navigation.NavigateTo("/");
    }
    private async Task ConfirmRegistration()
    {
        // Create a new instance of addSchedule

        var addedd = new List<ClassLibrary1.addSchedule>();

        foreach (var dataEntry in selectedGroups)
        {
            var selected = new ClassLibrary1.addSchedule
            {
                studentId =Id,
                CourseId=dataEntry.Key,
                GroupId = dataEntry.Value
            };
            addedd.Add(selected);
        }
        try
        {
            var response = await StudentConsumer.PostRegisteredCourses(addedd);
            isRegistrationSuccessful = true;
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }





        // Logic to handle navigation or save data can go here
        // For example, you could pass this data to another component, save it to a database, or serialize it as needed.
        //Navigation.NavigateTo("/confirmation");
    }

    public class ScheduleviewModel
    {
        public string CourseName { get; set; }
        public int CourseId { get; set; }
        public string CoursePeriod { get; set; }
        public int CourseGroupId { get; set; }
        public string DoctorName { get; set; }
        public string TAName { get; set; }
        public string Lecday { get; set; }
        public string Secday { get; set; }
        public int LecSlot { get; set; }
        public int SecSlot { get; set; }
        public int CourseCreditHours { get; set; }
        public int Id { get; set; }
        public int capacity { get; set; }
    }
    private void OnGroupSelected(ChangeEventArgs e, ScheduleGroupViewModel group)
    {
        int selectedGroupId = int.Parse(e.Value.ToString());
        if (selectedGroupId == 0)
        {
            //Console.WriteLine('0');
            //selectedGroups.Remove(group.CourseId);
            UpdateDaySlots(0, group.CourseId, "Delete");
        }
        else if(selectedGroups.Count == 6)
        {
            JS.InvokeVoidAsync("alert", "Max 18 Credit Hours ");

        }
        else
        {
            selectedGroups[group.CourseId] = selectedGroupId;
            if (selectedGroups.Keys.Contains(group.CourseId))
            {
                UpdateDaySlots(selectedGroupId, group.CourseId, "Update");
            }
            else
            {

                UpdateDaySlots(selectedGroupId, group.CourseId, "Add");
            }
        }
        //foreach (var kvp in selectedGroups)
        //{
        //  Console.WriteLine($"Key: {kvp.Key}");
        // Console.WriteLine("Values: " + string.Join(", ", kvp.Value));
        //}
        // Update daySlots when a group is selected


    }
    private void UpdateDaySlots(int groupid,int courseid,string mode)
    {
        var group = a.FirstOrDefault(g => g.CourseId == courseid);
        if (group == null) return;

        var schedule = group.Schedules.FirstOrDefault(s => s.CourseGroupId == groupid);
        if (schedule == null) return;

        // Remove existing course entry if updating
        if (mode == "Update")
        {
            foreach (var day in daysOfWeek)
            {
                for (int slot = 0; slot < daySlots[day].Length; slot++)
                {
                    if (daySlots[day][slot].StartsWith(group.CourseName))
                    {
                        daySlots[day][slot] = ""; // Clear the slot
                    }
                }
            }
        }

        // Add course name to new slots if no conflict
        if (daySlots[schedule.Lecday][schedule.LecSlot - 1] == "" && daySlots[schedule.Secday][schedule.SecSlot - 1] == ""  )
        {
            if (schedule.capacity > 0)
            {
                daySlots[schedule.Lecday][schedule.LecSlot - 1] = $"{group.CourseName} <br/> {schedule.DoctorName} <br/> Lecture";
                daySlots[schedule.Secday][schedule.SecSlot - 1] = $"{group.CourseName} <br/> {schedule.TAName} <br/> Section";
                Console.WriteLine(schedule.capacity);
            }
            else
            {
                JS.InvokeVoidAsync("alert", "No Available Capacity");
                selectedGroups.Remove(courseid);
                return;
            }

        }
        else
        {
            JS.InvokeVoidAsync("alert", "Course Crashh");
            selectedGroups.Remove(courseid);
        }

        // Optional: Debug output to console
        foreach (var kvp in daySlots)
        {
            // Console.WriteLine($"Key: {kvp.Key}");
            // Console.WriteLine("Values: " + string.Join(", ", kvp.Value));
        }



    }
    private void DeleteCourse(string CourseName ,int CourseId)
    {
        foreach (var day in daysOfWeek)
        {
            for (int slot = 0; slot < daySlots[day].Length; slot++)
            {
                if (daySlots[day][slot].StartsWith(CourseName))
                {
                    daySlots[day][slot] = ""; // Clear the slot
                }
            }
        }
        selectedGroups.Remove(CourseId);
    }


    public class ScheduleGroupViewModel
    {
        public int CourseCreditHours { get; set; }
        public string CourseName { get; set; }
        public string CoursePeriod { get; set; }

        public int CourseId { get; set; } 
        public List<ScheduleviewModel> Schedules { get; set; }
    }
    public class addSchedule
    {
        public int studentId { get; set; }
        public int GroupId { get; set; }
        public int CourseId { get; set; }

    }
    public class RegisteredCourseDto
    {
        public int CourseId { get; set; }
        public int GroupId { get; set; }
    }
    

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 5 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
        IJSRuntime

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 5 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                   JS

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 4 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
        BlazorApp1.DataConsumers.StudentConsumer

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                                                 StudentConsumer

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 3 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
        Microsoft.AspNetCore.Components.NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 3 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                                                          UriHelper

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 2 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
        NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 2 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Pages\OnlineRegistration.razor"
                          Navigation

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591