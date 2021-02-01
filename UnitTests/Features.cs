namespace UnitTests
{
    using System;

    class Features
    {
        public int xSum(int x1, int x2)
        {
            return x1 + x2;
        }

        public int xSum(int x1, int x2, int x3)
        {
            return x1 + x2 + x3;
        }

        public int xSum(params int[] list)
        {
            int res = 0;

            for (int i = 0; i < list.Length; i++)
            {
                res += list[i];
            }

            return res;
        }

        public string xSum(string x1, string x2)
        {
            return (Convert.ToInt32(x1) + Convert.ToInt32(x2)).ToString();
        }
    }
}
