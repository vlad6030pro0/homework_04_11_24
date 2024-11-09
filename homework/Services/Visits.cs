using System;
using System.Text;
using homework.Services.Interfaces;

namespace homework.Services;

public class Visits : IVisits
{
    public string ViewingVisits(StreamReader reader)
    {
        var text = reader.ReadToEnd();
        reader.Close();
        return text;
    }
}
