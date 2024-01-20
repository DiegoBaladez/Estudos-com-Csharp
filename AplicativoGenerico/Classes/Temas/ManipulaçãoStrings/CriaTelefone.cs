using System.Text;

namespace AplicativoGenerico.Classes.Temas.ManipulaçãoStrings
{
    public static class CriaTelefone
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            return "(" + returnNumbersByRange(numbers, 0, 2) + ")" +
                   " " + returnNumbersByRange(numbers, 3, 5) +
                   "-" +
                   returnNumbersByRange(numbers, 6, 9);
        }

        private static string returnNumbersByRange(int[] numbers, int from, int to)
        {
            var stringBuilder = new StringBuilder();
            for (int i = from; i <= to; i++)
            {
                stringBuilder.Append(numbers[i].ToString());
            }
            return stringBuilder.ToString();
        }
    }
}
