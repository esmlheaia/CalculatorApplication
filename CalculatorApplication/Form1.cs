using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal; //initiate inside the constructor
        double num1, num2;
        string arithmetic;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(txtboxfnumber.Text);
            num2 = Double.Parse(txtboxsnumber.Text);
            arithmetic = cbOperator.Text;
            
            
            // call the event anddisplay the answer of level 
            switch (arithmetic)
            {
                case "+":
                    cal.CalculateEvent += new Formula<double>(cal.GetSum);
                    lbltotal.Text = cal.GetSum(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                    break;
                case "-":
                    cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                    lbltotal.Text = cal.GetDifference(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
                    break;
                case "*":
                    cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                    lbltotal.Text = cal.GetProduct(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
                    break;
                case "/":
                    cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                    lbltotal.Text = cal.GetQuotient(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
                    break;
            }
            }
        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();


        }

        
    }
}
