using System;
using System.Collections.Generic;
using System.Text;

namespace PractiseNewStuff
{
          
    public class Generics <T>: IGenerics<T> 
      
      
    {

        public void PrintType(T input)
        {

            Console.WriteLine(typeof(T).Name);
        }

        public void PrintType2(T input)
        {
            
            var a = default(T);
            if(a== null)
            {
                Console.WriteLine("null");
            }
            Console.WriteLine(a);

        }
    }
}
