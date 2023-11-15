//Lab3
//09.25.2022
//F2218
//This program calculates the diameter, surface area, and volume for the user inputed radius
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userInputCalculationBtn_Click(object sender, EventArgs e)
        {
            double diameter, diameteroutput, //Variables for diameterOutputLbl
    surfacearea, surfaceareaoutput, //Variables for surfaceAreaOutputLbl
    volume, volumeoutput; //Variables for volumeOutputLbl

            diameter = double.Parse(userRadiusInputTxt.Text);//User input text becomes the variable diameter
            surfacearea = double.Parse(userRadiusInputTxt.Text); //User input text becomes the variable surfacearea
            volume = double.Parse(userRadiusInputTxt.Text); //User input text becomes the variable volume
            diameteroutput = (diameter * 2); //Diameter equation with user input a diameter
            surfaceareaoutput = (4 * Math.PI * Math.Pow(surfacearea, 2)); //Surface Area with user input as surfacearea
            volumeoutput = ((4 * Math.PI * Math.Pow(volume, 2)) / 3); //Volume with user input as volume
            diameterOutputLbl.Text = $"{diameteroutput:F2}"; //Diameteroutput is displayed in label text with two decimal points
            surfaceAreaOutputLbl.Text = $"{surfaceareaoutput:F2}"; //Surfaceareaoutput is displayed in label text with two decimal points
            volumeOutputLbl.Text = $"{volumeoutput:F2}"; //Volumeoutput is displayed in label text with two decimal points
        }
    }
}
