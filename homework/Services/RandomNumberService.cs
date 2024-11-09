using System;
using homework.Services.Interfaces;

namespace homework.Services;

public class RandomNumberService : IRandomNumberService
{
    public string GetRandomNumber()
    {
        return new Random().Next(1,100).ToString();
    }
}
