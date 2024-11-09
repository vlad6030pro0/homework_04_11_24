using System;
using System.Text;
using homework.Services.Interfaces;

namespace homework.Services;

public class AddVisit : IAddVisit
{
    public void AddingVisit(FileStream file)
    {
        byte[] buffer = Encoding.UTF8.GetBytes(DateTime.Now.ToString("G")+"\n");
        file.Write(buffer, 0, buffer.Length);    
        file.Close();
    }
}
