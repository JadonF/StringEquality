/*
 * Created by: Jadon F
 * Created on: 15-May-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - String Equality
 * This program checks if 2 strings are equal.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringEquality
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool stringEqualityChecker (string string1, string string2)
        {
            //local variables
            string upperS1;
            string upperS2;
            bool isEqual = false;

            //define variables
            upperS1 = string1.ToUpper();
            upperS2 = string2.ToUpper();

            //check
            if (string1.Length == string2.Length)
            {
                if (upperS1 == upperS2)
                {
                    isEqual = true;
                }
            }
            return isEqual;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //local variables
            string userString1;
            string userString2;

            //define variables.
            userString1 = Convert.ToString(txtString1.Text);
            userString2 = Convert.ToString(txtString2.Text);

            //call function
            bool isEqualMain = stringEqualityChecker(userString1, userString2);

            //messagebox
            if (isEqualMain == false)
            {
                MessageBox.Show("The two strings are NOT equal.", "String Equality");
            }
            if (isEqualMain == true)
            {
                MessageBox.Show("The two strings are equal", "String Equality");
            }
        }
    }
}
