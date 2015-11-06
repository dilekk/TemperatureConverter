using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TempConv
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e) //void: nothing to return
            //in VB: Sub btnStart_Click(sender As System.Object, e As System.EventArgs) sub does not return
        {
            this.Close();
        }
        
        private double fToC(decimal fTemp)
        {
            return 50;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //get the current value, this following code is self documented code
            calculateCValue();
            addToListbox(numericUpDown1.Value, numericUpDown2.Value);
        }

        private void addToListbox(decimal fValue, decimal cValue)
        {
            listBox1.Items.Add(fValue + "F=" + cValue + "C");
        }

        private void calculateCValue()
        {
            decimal fValue = getCurrentValue(); //procedure, gets the currentValue sets to fvalue

            //convert it
            decimal cValue = convertoCelsius(fValue); //initialize cValue and convert function, sets the cValue converted below

            //put in the other box
            showInCBox(cValue);
        }

        private void showInCBox(decimal cValue)
        {
            numericUpDown2.Value = cValue;
        }

        private decimal convertoCelsius(decimal fValue) //procedure (mostly called function), converts it here
        {
            decimal cValue = (fValue - 32) * 5 / 9; //converts F to C
            return cValue;
        }

        private decimal getCurrentValue() //function
        {
 	    return numericUpDown1.Value;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculateCValue();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton2.Checked)
            //{
            //    numericUpDown1.Enabled =true;
            //    numericUpDown2.Enabled =false;
            //}
            //    else{
            //        numericUpDown1.Enabled =false;
            //        numericUpDown2.Enabled =true;
            //    }
            numericUpDown1.Enabled = radioButton2.Checked; //above code optimized here
            numericUpDown2.Enabled = !radioButton2.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = !radioButton1.Checked;
            numericUpDown2.Enabled = radioButton1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

  
        }
    }
