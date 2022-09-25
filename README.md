# Notification
This package is an asp net core mvc toaster notificaton helping tool.
## Why you are use this package?
- Provide dependency Injection
- Ajax request support
- Customizable settings

## Install

    Install-Package Monirujjaman.AspNetCore.Mvc.Toaster.Notification

## Installation In MVC Project

 **Step-1**
 -
 > Add dependency Injection in the program.cs file
 > Example: builder.Services.AddNotification();

**Step-2**
-
> Add middleware in the program.cs file
> Example: app.UseNotification();

**Step-3**
-
> Add the component end of the layout body which layout pages you want to use
> Example: @await Component.InvokeAsync("Notification") 

## Example

**Setp-1 & Step-2**
```csharp
using Notification.Extensions;  
  
var builder = WebApplication.CreateBuilder(args);  
  
builder.Services.AddControllersWithViews(); 
  
builder.Services.AddNotification();  
  
var app = builder.Build();  

app.UseNotification();

app.MapControllerRoute(  
 name: "default",  
 pattern: "{controller=Home}/{action=Index}/{id?}");  
  
app.Run();
```
**Setp-3**

```html
<!DOCTYPE html>  
<html lang="en">  
<head>  
 <title>Title</title>  
 <link rel="stylesheet" href="~/css/site.css" asp-append-version="true"/>  
  @await RenderSectionAsync("Links", required: false)  
</head>  
<body>  
  
@RenderBody()  
  
<script src="~/js/site.js" asp-append-version="true"></script>  
  
@await RenderSectionAsync("Scripts", required: false)  
  
@await Component.InvokeAsync("Notification")  
  
</body>  
</html>
```
## Usage
```csharp
using Microsoft.AspNetCore.Mvc;  
using Notification.Services.Contracts;  
  
namespace HostelApp.Web.Controllers;  
  
public class HomeController : Controller  
{  
	  private readonly INotificationService _notificationService;  
  
	  public HomeController(INotificationService notificationService)  
	  {  _notificationService = notificationService;  
	  }  
	  
	  public IActionResult Index()  
	  {  
		  _notificationService.Success("My success message", "Success Title!");  
		  _notificationService.Error("My Error message", "Error Title!");  
		  _notificationService.Information("My Information message", "Information Title!");  
		  _notificationService.Warning("My Warning message", "Warning Title!");  
		  return View();  
	  }
}
```
## Output
![image](https://user-images.githubusercontent.com/81045179/192157949-2489f677-fe56-42c4-9a32-29ee67602703.png)

## Customization Settings
```csharp
using Notification.Extensions;  
  
var builder = WebApplication.CreateBuilder(args);  
  
builder.Services.AddControllersWithViews(); 
  
builder.Services.AddNotification(config =>  
{  
 config.Debug = false;  
 config.CloseButton = false;  
 config.ShowEasing = EasingType.Swing;  
 config.CloseEasing = EasingType.Linear;  
 config.HideEasing = EasingType.Linear;  
 config.ShowMethod = AnimationMethod.SlideDown;  
 config.HideMethod = AnimationMethod.SlideUp;  
 config.CloseMethod = AnimationMethod.SlideUp;  
 config.PositionClass = NotificationPosition.TopRight;  
 config.PreventDuplicates = false;  
 config.ProgressBar = true;  
 config.NewestOnTop = false;  
 config.TimeOutInSecond = 5;  
});  
  
var app = builder.Build();  

app.UseNotification();

app.MapControllerRoute(  
 name: "default",  
 pattern: "{controller=Home}/{action=Index}/{id?}");  
  
app.Run();
```

# Thank You!
