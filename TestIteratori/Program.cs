using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIteratori
{
   public static  class Program
    {

        public static IEnumerable<T> Prova<T> (T [] a)
        {
            if(a==null)
                throw new ArgumentNullException();
            return null;
        }
        public static IEnumerable<T> MacroExpansion<T>(T[] input_sequence, T value, T[] new_sequence)
        {
            if (null == input_sequence)
                throw new ArgumentNullException("the input sequence is null");
            if (null == new_sequence)
                throw new ArgumentNullException("the new sequence is null");
            if (!input_sequence.Contains(value))
                throw new ArgumentException("value isn't in the input sequence");
            int i = 0;
            while (i < input_sequence.Length  /*!= null*/)
            {
                if (input_sequence[i].Equals(value) )
                {
                    int j = 0;
                    while (j < new_sequence.Length  /*!= null*/)
                    {
                        yield return new_sequence[j];
                        ++j;
                    }
                }
                else
                {
                    yield return input_sequence[i];
                  
                }
                ++i;
                    
            }
        }

        static void Main(string[] args) { 
              try
              {
                  foreach (var i in MacroExpansion( /*new[] {1, 2, 1, 2, 3}*/null, 2, new[] {7, 8, 9}))
                  {
                      Console.WriteLine(i);
                      Console.ReadLine();
                  }
              }
              catch (ArgumentNullException ex)
              {
                  Console.WriteLine(ex.Message);
                  Console.ReadLine();
              }
        }
    }
}
