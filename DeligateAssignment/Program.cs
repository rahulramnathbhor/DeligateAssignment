using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateAssignment
{
    public delegate void StringDelegate(string name);
    public class Program
    {
        static void Main(string[]args)
        {
            StringDelegate stringDelegate = ToUpperCase;
            stringDelegate("akole");
            stringDelegate.Invoke("akole");

            StringDelegate stringDelegate2 = ToLowerCase;
            stringDelegate2("AKOLE");
            stringDelegate2.Invoke("AKOLE");



        }
       static void ToUpperCase(string name)=> Console.WriteLine(name.ToUpper());
        static void ToLowerCase(string name)=> Console.WriteLine(name.ToLower());

       
        
    }
    
}
