namespace AplicativoGenerico.Classes.Temas.ManipulaçãoStrings
{
    public class Persist
    {
        public static int Persistence(long n)
        {
            if (n.ToString().Length == 1) return 0;
            int lenthOfCurrentList = n.ToString().Length;
            int count = 0;
            var list = getCharsFromString(n.ToString());

            while (lenthOfCurrentList > 1)
            {
                var temp = multiplyDigits(list);

                count++;

                list = getCharsFromString(temp);

                lenthOfCurrentList = temp.Length;
            }

            return count;
        }
        private static List<string> getCharsFromString(string str)
        {
            List<string> result = new List<string>();
            foreach (char c in str)
            {
                result.Add(c.ToString());
            }
            return result;
        }

        private static string multiplyDigits(List<string> list)
        {
            long result = 1;
            List<string> listResult = new List<string>();

            foreach (string s in list)
            {
                long temp = long.Parse(s);
                result *= temp;
            }

            return result.ToString();
        }
    }
}
