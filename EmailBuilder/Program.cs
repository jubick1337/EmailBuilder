using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StateBuilder builder = new StateBuilder();
            var mail = builder.AddReceiver("usu.courses@gmail.com").AddBody("Eto Novikov Matvey").AddTheme("Builder");
            Console.WriteLine(mail.Build());
        }
    }
}
