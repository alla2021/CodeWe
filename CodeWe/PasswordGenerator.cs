using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorPass
{
    class PasswordGenerator
    {
        private string symbols = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private string special = "@_$#";
        Random random;
        StringBuilder sB;

        public PasswordGenerator()
        {
            random = new Random();

        }

        private int getSpecialSymbolCount(int length)
        {
            if (length < 5)
                return 1;
            else
                return length / 5;
        }

        public string passwordGeneratorFunc(int length)
        {
            string password = "";

            for (int i = 0; i < length; i++)
            {
                password += symbols[random.Next(0, symbols.Length)];
            }

            sB = new StringBuilder(password);
            List<int> list = new List<int>();

            for (int i = 0; i < this.getSpecialSymbolCount(length); i++)
            {
                bool isEmpty = true;
                do
                {
                    int pos = random.Next(0, sB.Length);

                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j] == pos)
                        {
                            isEmpty = false;
                        }

                    }

                    if (isEmpty)
                    {
                        list.Add(pos);
                        sB[pos] = special[random.Next(0, special.Length)];
                    }

                } while (!isEmpty);

            }

            return sB.ToString();
        }
    }
}
