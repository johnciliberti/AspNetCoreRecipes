using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AspNetCoreMvcRecipes.Shared.DataAccess.Util
{
    /// <summary>
    /// Helpers that can be used to aid in local testing where entire media base is not available on the local machine
    /// </summary>
    public static class DebugDataSubstitute
    {
        /// <summary>
        /// Gets a random image from groups of 20. Useful for inserting avatar pictures in test environment 
        /// where you do not have full image repository
        /// </summary>
        /// <returns></returns>
        public static string GetRandomImagePath(){
            string pattern = "/Media/Avatars/Sample{0}.jpg";
            return string.Format(pattern, RndBetween1And20());
        }

        private static int RndBetween1And20()
        {
            byte[] randomNumber = new byte[1];
            Random rnd = new Random();
            rnd.NextBytes(randomNumber);
            randomNumber[0] = 21;
            while (randomNumber[0] > 20 || randomNumber[0] < 1)
            {
                rnd.NextBytes(randomNumber);
            }
            return Convert.ToInt32(randomNumber[0]);
        }
    }
}
