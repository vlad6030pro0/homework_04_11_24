using System;
using homework.Services.Interfaces;

namespace homework.Services;

public class RandomNumberService : IRandomNumberService
{
    public int GetRandomNumber()
    {
        return new Random().Next(1,101);
    }
}
