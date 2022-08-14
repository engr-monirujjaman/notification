﻿namespace Notification.Core.Services.Contracts;

public interface INotificationService
{
    void Information(string message);

    void Success(string message);
    
    void Warning(string message);
    
    void Error(string message);
}