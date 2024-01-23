using AplicativoGenerico.Classes.Temas.ManipulaçãoStrings.IsValidIp;

namespace AplicativoGenerico
{
    public class Program
    {
        static void Main(string[] args)
        {
            string valor = "1.2.3.4";

            List<string> invalidList = new List<string> {"1.2.3",
                                                         "1.2.3.4.5",
                                                         "123.456.78.90",
                                                         "123.045.067.089",
                                                         "abc.def.ghi.jkl",
                                                         "pr12.34.56.78"
                                                        };


            foreach(string invalidIp in invalidList) 
            {
                Console.WriteLine(Kata.is_valid_IP(invalidIp));
            }
            
        }
    }
}