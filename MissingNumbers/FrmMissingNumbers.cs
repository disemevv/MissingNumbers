using System;
using System.Windows.Forms;

namespace MissingNumbers
{
    public partial class frmMissingNumbers : Form
    {
        public frmMissingNumbers()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btnFind control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            string values1, values2, msg = string.Empty;
            
            values1 = rtbValLst1.Text.Trim();
            values2 = rtbValLst2.Text.Trim();
            string[] lstValues1 = values1.Split(' ');
            string[] lstValues2 = values2.Split(' ');

            if (ValidateInputs(lstValues1.Length, lstValues2.Length, values1, values2, ref msg))
            {
                Business.MissingNumbers objMissingNumbers = new Business.MissingNumbers();
                rtbResult.Text = objMissingNumbers.FindMissingNumbers(lstValues1.Length, lstValues2.Length, lstValues1, lstValues2, ref msg);
            }

            if (!string.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
        }

        /// <summary>
        /// Validates the inputs.
        /// </summary>
        /// <param name="n">Size of the first list</param>
        /// <param name="m">Size of the second list</param>
        /// <param name="values1">Values of the first list</param>
        /// <param name="values2">Values of the second list</param>
        /// <param name="msg">Message</param>
        /// <returns>If the values of inpust are correct return True, else return False</returns>
        private bool ValidateInputs(int n, int m, string values1, string values2, ref string msg)
        {
            bool result = true;
            Business.Constants cons = new Business.Constants();


            if (n > m)
            {
                msg = "The size of the first list must be > the size of the second list\n";
                result = false;
            }

            if (String.IsNullOrEmpty(values1))
            {
                msg += "Insert values of the first list\n";
                result = false;
            }

            if (String.IsNullOrEmpty(values2))
            {
                msg += "Insert values of the second list\n";
                result = false;
            }

            if (n > cons.MSIZE || m > cons.MSIZE)
            {
                msg += string.Concat("The size of the lists can't be > ", cons.MSIZE, "\n");
                result = false;
            }

            return result;
        }
    }
}
