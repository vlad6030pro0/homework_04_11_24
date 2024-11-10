using System;
using System.Text;
using homework.Services.Interfaces;

namespace homework.Services;

public class Visits : IVisits
{
    public string ViewingVisits(StreamReader reader)
    {
        var text = reader.ReadToEnd();
        var result = "";
        foreach(var line in text.Split("\r"))
        {
            result += line + "\n";
        } 
        reader.Close();
        return result;
    }
}
