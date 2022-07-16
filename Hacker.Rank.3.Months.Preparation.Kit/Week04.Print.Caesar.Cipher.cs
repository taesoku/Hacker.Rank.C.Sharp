using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week04PrintCaesarCipher
    {

        public static void Answer()
        {
            var input6 = "!m-rB`-oN!.W`cLAcVbN/CqSoolII!SImji.!w/`Xu`uZa1TWPRq`uRBtok`xPT`lL-zPTc.BSRIhu..-!.!tcl!-U";
            PrintCaesarCipher(input6, 62);
        }

        private static string PrintCaesarCipher(string s, int k)
        {
            var output = new StringBuilder();
            for (var i = 0; i < s.Length; i++)
            {
                int curr = s[i];
                k = k % 26;
                if (Regex.IsMatch(s[i].ToString(), @"^[A-Z]+$"))
                {
                    curr += k;
                    while (curr >= 91) curr -= 26;
                }
                if (Regex.IsMatch(s[i].ToString(), @"^[a-z]+$"))
                {
                    curr += k;
                    while (curr >= 123) curr -= 26;
                }
                output.Append((char)curr);
            }
            return output.ToString();
        }

    }
}
