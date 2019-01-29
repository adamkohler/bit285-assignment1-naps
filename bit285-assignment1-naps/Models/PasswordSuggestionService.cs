using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bit285_assignment1_naps.Models
{
    public class PasswordSuggestionService
    {
        public string generatePassword(User user)
        {
            Random rand = new Random();

            string[] userEntry = new string [5];
            userEntry[0] = user.FirstName;
            userEntry[1] = user.LastName;
            userEntry[2] = user.Birthyr;
            userEntry[3] = user.FavColor;
            userEntry[4] = user.EmailAdd;           

            string password = null;
            for (int i = 0; i < 3; i++)
            {
                //int num = rand.Next(0, 7);
                //password += userEntry[rand.Next(0, 6)];
                password = string.Concat(userEntry[rand.Next(0, 6)]);
            }     
            return password;
        }
    }
}
