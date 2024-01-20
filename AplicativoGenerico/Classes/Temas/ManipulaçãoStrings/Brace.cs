using System;
using System.Text.RegularExpressions;

namespace AplicativoGenerico.Classes.Temas.ManipulaçãoStrings
{
    public class Brace
    {
               
        public static bool validBraces(string braces)
        {
            if (String.IsNullOrEmpty(braces)) { return false; }

            string pattern = @"(\(\)|\[\]|\{\})";

            string replacement = "";             
           
            while (braces.Length > 0 )
            {
               var previous = braces;
               braces =  Regex.Replace(braces, pattern, replacement);

               if (string.IsNullOrEmpty(braces))
                {                    
                    return true;
                }  
               
               if(previous == braces) { return false; }
            }
             return false;
        }
    }
}
