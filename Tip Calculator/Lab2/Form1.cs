/* Grading ID: F2218
 * Lab2
 * 09/18/2022
 * CIS 199-50-4228
 * This program uses a form to allow the user to input the price of a meal and calculate 3 different tip ammounts using GUI.
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

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Once user types in meal price by clicking the Calculate Tip button it executes the following code*/
        private void userTipCalculation_Click(object sender, EventArgs e)
        {
            const double TIP_RATE1 = .15; /*A constant is set for the 15% tip using decimals*/
            const double TIP_RATE2 = .18;/*A constant is set for the 18% tip using decimals*/
            const double TIP_RATE3 = .20;/*A constant is set for the 20% tip using decimals*/
            double tip1,ammount1,
                tip2,ammount2,
                tip3,ammount3;
            tip1 = double.Parse(userMealInputTxt.Text); /* Sets tip1 to equal user input*/
            tip2 = double.Parse(userMealInputTxt.Text);/* Sets tip2 to equal user input*/ 
            tip3 = double.Parse(userMealInputTxt.Text);/* Sets tip3 to equal user input*/
            ammount1 = (tip1 * TIP_RATE1);/*Ammount1 is created a a variable to allow the tip equation to take place*/
            ammount2 = (tip2 * TIP_RATE2);/*Ammount2 is created a a variable to allow the tip equation to take place*/
            ammount3 = (tip3 * TIP_RATE3);/*Ammount3 is created a a variable to allow the tip equation to take place*/
            userTipOutput1.Text = $"{ammount1:C2}";/* The ammount calculated in the ammount1 equation above is converted to currency and placed in userTipOutput1's text property*/
            userTipOutput2.Text = $"{ammount2:C2}";/* The ammount calculated in the ammount2 equation above is converted to currency and placed in userTipOutput2's text property*/
            userTipOutput3.Text = $"{ammount3:C2}";/* The ammount calculated in the ammount3 equation above is converted to currency and placed in userTipOutput3's text property*/



        }
    }
}
