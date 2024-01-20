using System.Text;

namespace AplicativoGenerico.Classes.Temas.ManipulaçãoStrings
{
    public static class Kata
    {
        public static string Order(string words)
        {
            List<int> orderedNumbers = findNumbers(words);

            string[] splitedInPieces = splitInPieces(words);

            return sortWords(orderedNumbers, splitedInPieces);
        }

        private static string[] splitInPieces(string words)
        {
            string stringSeparator = " ";

            string[] pieces = words.Split(stringSeparator);

            return pieces;
        }

        private static List<int> findNumbers(string words)
        {
            List<int> sortedNumbers = new List<int>();
            
            for (int i = 0; i < words.Length; i++)
            {
                if (char.IsDigit(words[i]))
                {
                    int numericValue = (int)char.GetNumericValue(words[i]);
                    sortedNumbers.Add(numericValue);
                }
            }

            sortedNumbers.Sort();

            return sortedNumbers;
        }

        private static string sortWords(List<int> sortedNumbers, string[] wordPieces)
        {
            int count = 0;
            var sortedStringBuilder = new StringBuilder();

            for (int i = 0; i < sortedNumbers.Count; i++)
            {
                for (int j = 0; j < wordPieces.Length; j++)
                {
                    if (wordPieces[j].Contains(sortedNumbers[i].ToString()))
                    {
                        sortedStringBuilder.Append(wordPieces[j] + " ");
                    }
                }
                    
            }
            return sortedStringBuilder.ToString().Trim();
        }
    }
}
