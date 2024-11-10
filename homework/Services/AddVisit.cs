using System;
using System.Text;
using homework.Services.Interfaces;

namespace homework.Services;

public class AddVisit : IAddVisit
{
    public void AddingVisit(StreamWriter writer)
    {
        writer.WriteLine(DateTime.Now.ToString("G"));
        writer.Close();
    }
}
