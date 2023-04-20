using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_06
{
    class TaiwanID
    {
        string CodeChar = "ABCDEFGHJKLMNPQRSTUVXYWZIO";
        int[] IDCode = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 
                         23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35 };
        int Capital;

        public bool Verify(string X)
        {
            if (!uint.TryParse(X.Substring(2, 8), out uint result) || result == 0) return false;

            if (X.Length != 10) return false;
            else if (String.Compare(X.Substring(0, 1), "A") < 0 || String.Compare(X.Substring(0, 1), "Z") > 0) return false;
            else if (X.Substring(1, 1) != "1" && X.Substring(1, 1) != "2") return false;            
            else
            {
                int Total;
                int Weight = 8;

                Capital = IDCode[CodeChar.IndexOf(X.Substring(0, 1))];
                Total = (Capital / 10) * 1 + (Capital % 10) * 9;

                for (int i = 1; i<= 8; i++)
                {
                    Total += int.Parse(X.Substring(i, 1)) * Weight;
                    Weight--;
                }

                Total += int.Parse(X.Substring(9, 1));
                
                if (Total % 10 == 0) return true;
                else return false;
            }
        }
    }
}
