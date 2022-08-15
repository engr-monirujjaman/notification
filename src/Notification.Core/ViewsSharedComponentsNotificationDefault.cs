﻿using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Razor.Hosting;

namespace Notification.Core;

[RazorSourceChecksum("SHA1", "CA254A1CFC664B70A030C4F84961CD03", "/Views/Shared/Components/Notification/Default.cshtml" )]
public class  ViewsSharedComponentsNotificationDefault : RazorPage<NotificationViewModel>
{
    public override async Task ExecuteAsync()
    {
        Write("<div>Hello World!</div>");
        await Task.CompletedTask;
    }
}