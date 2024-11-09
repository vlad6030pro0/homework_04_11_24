using System;
using homework.Services.Interfaces;

namespace homework.Services;

public class TimeService : ITimeService
{
    public string GetCurrentTime()
    {
        return DateTime.Now.ToString("HH:mm:ss");
    }
}
