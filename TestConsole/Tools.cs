using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public static class Tools
    {
        public static string GetRandomItemFromArray (string[] array){
            Random rng = new Random();
            return array[rng.Next(0, array.Length)];
        }
    }
}
