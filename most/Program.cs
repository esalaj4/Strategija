using System;
using System.Collections.Generic;

namespace RPPOON_LV5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITheme blueTheme = new BlueTheme();
            ITheme lightTheme = new LightTheme();
            List<string> names = new List<string>();
            names.Add("Ena");
            names.Add("Falko");
            names.Add("Toni");

          
            Note firstNote = new GroupNote(names,"messss",lightTheme);
            firstNote.Show();
            
        }
    }
}
