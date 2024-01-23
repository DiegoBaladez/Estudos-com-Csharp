namespace AplicativoGenerico.Classes.Temas.ManipulaçãoStrings.IsValidIp

{
    public class Kata
    {
        public static bool is_valid_IP(string ipAddres)
        {
            int ipSections = 4;
            string dotSeparator = ".";
            
            if (string.IsNullOrEmpty(ipAddres)) { return false; }

            if(ipAddres.Any(Char.IsWhiteSpace)) { return false; }

            string[] ipArray = ipAddres.Split(dotSeparator);

            if(ipArray.Length != ipSections) return false;

            foreach(var ipSection in ipArray)
            {
                if (!checkIpRange(ipSection)) return false;
            }

            return true;
        }

        private static bool checkIpRange(string ipSlice)
        {
            int ipUpperRange = 255;
            int ipLowerRange = 0;

            if (ipSlice.StartsWith("0") && ipSlice.Length > 1) return false;

            try
            {
                if (int.Parse(ipSlice) < ipLowerRange || int.Parse(ipSlice) > ipUpperRange)
                {
                    return false;
                }
            }
            catch(FormatException e)
            {
                return false;
            }            

            return true;
        }
    }
}
