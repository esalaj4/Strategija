using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV5_3
{
    class GroupNote:Note
    {
        private List<string> names=new List<string>();

        public GroupNote(string message,ITheme theme):base(message,theme)
        {
           
            names = new List<string>();
            names.Add(message);
        }

        public GroupNote(List<string> names,string message, ITheme theme) : base(message, theme)
        {
            this.names= names;
            message = String.Join(Environment.NewLine, names.ToArray());
        }


        public void Add(string name)
        {
            names.Add(name);
        }

        public void Remove(string name)
        {
            names.RemoveAll(x => x == name);
        }

        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("Group of people: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
        }
    }
}
