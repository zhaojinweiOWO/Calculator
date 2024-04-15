using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        float firstNumber, secondNumber; 
        int operators = -1; 

        private void btnOne_Click(object sender, EventArgs e)
        {
            Add_Number("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            Add_Number("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            Add_Number("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Add_Number("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            Add_Number("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            Add_Number("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            Add_Number("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            Add_Number("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            Add_Number("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            Add_Number("0");
        }

        private void Add_Number(string _number)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + _number;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Select_Operator(0);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Select_Operator(1);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Select_Operator(2);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Select_Operator(3);
        }

        private void Select_Operator(int _operator)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text); 
            txtNumber.Text = "0"; 
            operators = _operator; 
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            
            if (txtNumber.Text.IndexOf(".") == -1)
                txtNumber.Text = txtNumber.Text + ".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            float finalResults = 0f; 
            secondNumber = Convert.ToSingle(txtNumber.Text); 

            
            switch (operators)
            {
                case 0:
                    finalResults = firstNumber + secondNumber;
                    break;
                case 1:
                    finalResults = firstNumber - secondNumber;
                    break;
                case 2:
                    finalResults = firstNumber * secondNumber;
                    break;
                case 3:
                    finalResults = firstNumber / secondNumber;
                    break;
            }

            txtNumber.Text = string.Format("{0:0.##########}", finalResults); 

           
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }
    }
}