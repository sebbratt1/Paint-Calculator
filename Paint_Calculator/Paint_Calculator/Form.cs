using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Calculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        // Instance Variables ------------------------------------
        private double _height; //Stores the inputted room height
        private double _width;  //Stores the inputted room width
        private double _length; //Stores the inputted room length

        // Constructor ------------------------------------
        public Form()
        {
            InitializeComponent();
            cb_measure.SelectedIndex = 1;
        }

        // When btn_calc is clicked ------------------------------------
        private void btn_Calc_Click(object sender, EventArgs e)
        {
            // Variables
            Boolean validValue = true;  //Stores a boolean value for whether or not user input was valid

            // Convert input from string to double and store it appropriately - with basic validation
            try
            {
                _height = Convert.ToDouble(tb_height.Text);
                if(_height <= 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid height!");
                validValue = false;
            }

            try
            {
                _width = Convert.ToDouble(tb_width.Text);
                if (_width <= 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid width!");
                validValue = false;
            }

            try
            {
                _length = Convert.ToDouble(tb_length.Text);
                if (_length <= 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid length!");
                validValue = false;
            }
       


            // If input is valid, clear form and calculate output
            if (validValue)
            {
                clearForm();
                calculate();
            }

        }

        // Clears form textboxes of text ------------------------------------
        private void clearForm()
        {
            tb_height.Text = "";
            tb_width.Text = "";
            tb_length.Text = "";
            tb_floorArea.Text = "";
            tb_roomVolume.Text = "";
            tb_paintReq.Text = "";
        }

        // Calculates and displays Output ------------------------------------
        private void calculate()
        {
            // Variables
            double floorArea;   //Stores the calculated area of the floor (in square metres)
            double roomVolumne; //Stores the calculated volumn of the room (in cubic metres)
            double paintReq;   //Stores the calculated amount of paint needed to cover the walls (in square litres)


            // Calculate area of the floor
            floorArea = _width * _length;

            // Calculate volume of the room
            roomVolumne = floorArea * _height;

            // Calculate paint required to paint walls
            // Assuming 1 litre of paint covers 10 square meters
            paintReq = (((_height * _width) * 2) + ((_height * _length) * 2)) / 10;

            // Display Results
            switch (cb_measure.SelectedIndex)
            {
                // Imperial Calculation
                case 0:
                    // Display area of the floor
                    tb_floorArea.Text = string.Format("{0:0.000}", floorArea) + " ft²";

                    // Display volume of the room    
                    tb_roomVolume.Text = string.Format("{0:0.000}", roomVolumne) + " ft³";
                break;

                // Metric Calculation
                case 1:
                    // Display area of the floor
                    tb_floorArea.Text = string.Format("{0:0.000}", floorArea) + " m²";

                    // Display volume of the room       
                    tb_roomVolume.Text = string.Format("{0:0.000}", roomVolumne) + " m³";
                break;
            }

            // Display paint required to paint walls
            tb_paintReq.Text = string.Format("{0:0.000}", paintReq) + " litres";

        }

    }
}
