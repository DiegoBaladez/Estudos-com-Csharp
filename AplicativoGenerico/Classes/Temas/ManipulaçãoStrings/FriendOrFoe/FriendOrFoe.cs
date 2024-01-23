using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoGenerico.Classes.Temas.ManipulaçãoStrings.FriendOrFoe
{
    public static class Kata
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            List<string> friends = new List<string>();
            foreach (string name in names) 
            {
                if(name.Length == 4) friends.Add(name);
            }

            return friends;
        }
    }
}
