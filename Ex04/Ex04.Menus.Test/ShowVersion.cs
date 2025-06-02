using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces; 

namespace Ex04.Menus.Test
{
    internal class ShowVersion : IMenuItemExecutable
    {
        public void Execute()
        {
            Console.WriteLine("App Version: 25.2.4.4480");
        }
    }
}