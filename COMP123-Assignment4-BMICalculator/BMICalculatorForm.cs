//Created by: Remedios Meneses
//SN: 300691712
//Last Modified: 2020-08-07 @ 5:45PM
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Assignment4_BMICalculator
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (HeightTextBox == null || HeightTextBox.Text == "")
            {
                BMIRichTextBox.Clear();
                HeightTextBox.AppendText("Text cannot be null");
            }
            

            if (WeightTextBox == null || WeightTextBox.Text == "")
            {
                BMIRichTextBox.Clear();
                WeightTextBox.AppendText("Text cannot be null");
            }
            
            else
            {
                BMIRichTextBox.Clear();
                Calculate();

            }

        }

        public void Calculate()
        {
            double finalTotal;
            if (ImperialButton.Checked == true)
            {
                double value = double.Parse(HeightTextBox.Text);
                double value2 = double.Parse(WeightTextBox.Text);
                double total;
                total = (value2 * 703) / (value * value);
                finalTotal = total;
                if (finalTotal < 18.5)
                {
                    BMIRichTextBox.AppendText("Underweight\n");
                }

                if (finalTotal >= 18.5 && finalTotal <= 24.9)
                {
                   BMIRichTextBox.AppendText("Normal\n"); 
                }

                if (finalTotal >= 25 && finalTotal <= 29.9)
                {
                    BMIRichTextBox.AppendText("Overweight\n");
                }

                if (finalTotal > 30)
                {
                   BMIRichTextBox.AppendText("Obese\n"); 
                }
                BMIRichTextBox.AppendText(finalTotal.ToString("F2"));
            }

            if (MetricButton.Checked == true)
            {
                double value = double.Parse(HeightTextBox.Text);
                double value2 = double.Parse(WeightTextBox.Text);
                double total;
                total = value2 / (value * value);
                finalTotal = total;
                if (finalTotal < 18.5)
                {
                    BMIRichTextBox.AppendText("Underweight\n");
                }

                if (finalTotal >= 18.5 && finalTotal <= 24.9)
                {
                    BMIRichTextBox.AppendText("Normal\n");
                }

                if (finalTotal >= 25 && finalTotal <= 29.9)
                {
                    BMIRichTextBox.AppendText("Overweight\n");
                }

                if (finalTotal > 30)
                {
                    BMIRichTextBox.AppendText("Obese\n");
                }
                BMIRichTextBox.AppendText(finalTotal.ToString("F2"));

                
            }
        }

        
        
    }
}
