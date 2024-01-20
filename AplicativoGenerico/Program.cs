using AplicativoGenerico.Classes.Temas.ManipulaçãoStrings;

namespace AplicativoGenerico
{
    public class Program
    {
        static void Main(string[] args)
        {
            string valor = "([)]";

            Console.WriteLine(Brace.validBraces(valor));
        }
    }
}