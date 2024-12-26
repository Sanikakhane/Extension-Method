using System;
using System.Collections.Generic;
using System.Linq;

namespace sample
{
    class Program
    {
        public static void Main(string[] args)
        {
             List<int> list = new List<int>() { 1, 2, 3 };
            list.Average();
            // printElement(list);
            list.printElement();
            Console.WriteLine(list.Average()); 

            dog d= new dog();
            d.sleeping();
            
        }
        
    }
    
}
