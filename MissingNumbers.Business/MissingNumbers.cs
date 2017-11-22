using System.Text;

namespace MissingNumbers.Business
{
    public class MissingNumbers
    {
        /// <summary>
        /// Finds the missing numbers between 2 lists.
        /// </summary>
        /// <param name="n">Size of the first list</param>
        /// <param name="m">Size of the second list</param>
        /// <param name="lstValues1">Values of the first list</param>
        /// <param name="lstValues2">Values of the second list</param>
        /// <param name="msg">Output Message</param>
        /// <returns>Missing numbers</returns>
        public string FindMissingNumbers(int n, int m, string[] lstValues1, string[] lstValues2, ref string msg)
        {
            StringBuilder sbResult = new StringBuilder("");
            Constants cons = new Constants();
            int[] A = new int[cons.XSIZE];
            int[] B = new int[cons.XSIZE];
            int x = 0;
            int xmin = 0;
            int xmax = 0;
            bool isNum = true;

            for (int i = 0; i < n; i++)
            {
                isNum = int.TryParse(lstValues1[i], out x);
                if (isNum && x <= cons.XSIZE)
                {
                    A[x]++;
                    if (i == 0)
                        xmin = x;
                    if (x < xmin)
                        xmin = x;
                    if (x > xmax)
                        xmax = x;
                }
                else
                {
                    msg = "The values of the fist list must be numerics and can't be > " + cons.XSIZE;
                    i = m;
                }
            }

            for (int i = 0; i < m; i++)
            {
                isNum = int.TryParse(lstValues2[i], out x);
                if (isNum && x <= cons.XSIZE)
                {
                    B[x]++;
                    if (i == 0)
                        xmin = x;
                    if (x < xmin)
                        xmin = x;
                    if (x > xmax)
                        xmax = x;
                }
                else
                {
                    msg = "The values of the second list must be numerics and can't be > " + cons.XSIZE;
                    i = m;
                }
            }

            if (msg == string.Empty)
            {
                for (int i = xmin; i <= xmax; i++)
                {
                    if (B[i] > A[i])
                        sbResult.Append(string.Concat(i, " "));
                }
            }

            return sbResult.ToString();
        }
    }
}
