using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev204
{
    class Mod2
    {
        public void mod2()
        {
            #region Mod2


            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("XO");
                    }
                    else
                    {
                        Console.Write("OX");
                    }
                }
                Console.Write("\n");
            }

            #endregion
        }
    }
}
