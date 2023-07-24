using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class Form1 : Form
    {
        private int[] intArray;
        private bool flagCreatedArray = false;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)      //Initialization
        {
            if (!flagCreatedArray)
            {
                try
                {
                    intArray = Array.ConvertAll(TB1.Text.Split(' '), int.Parse);
                    Form1L1.Text = "Array created successfully";
                    TB1.Text = "";
                    flagCreatedArray = true;
                }
                catch (FormatException)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    form2.F2L1.Text = "Operation error! Please, check your request.";
                    TB1.Text = "";
                }
                catch (ArgumentNullException)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    form2.F2L1.Text = "Operation error! Please, check your request.";
                }
                catch (OverflowException)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    form2.F2L1.Text = "Operation error! Overflow array.";
                }
                catch (Exception)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    form2.F2L1.Text = "Operation error! Please, check your request.";
                }
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
                form2.F2L1.Text = "Array already created.";
            }
        }
        private void button2_Click(object sender, EventArgs e)      //Sum    
        {
            try
            {
                Form1L1.Text = "Sum: " + Convert.ToString(intArray.Sum());
            }
            catch (ArgumentNullException)
            {
                Form2 form2 = new Form2();
                form2.Show();
                form2.F2L1.Text = "Operation error! Please, initialize the array.";
            }
            catch (OverflowException)
            {
                Form2 form2 = new Form2();
                form2.Show();
                form2.F2L1.Text = "Operation error! Overflow array.";
            }
            catch (Exception)
            {
                Form2 form2 = new Form2();
                form2.Show();
                form2.F2L1.Text = "Operation error! Please, check your request.";
            }
        }
        private void button3_Click(object sender, EventArgs e)      //Max element
        {
            try
            {
                int maxElement = intArray[0];
                for (int i = 0; i < intArray.Length; i++)
                {
                    if (maxElement < intArray[i]) maxElement = intArray[i];
                }
                Form1L1.Text = "Max element: " + Convert.ToString(maxElement);
            }
            catch (NullReferenceException)
            {
                Form2 form2 = new Form2();
                form2.Show();
                form2.F2L1.Text = "Error! Please, initialize the array.";
            }
            catch (Exception)
            {
                Form2 form2 = new Form2();
                form2.Show();
                form2.F2L1.Text = "Operation error! Please, check your request.";
            }
        }
        private void button4_Click(object sender, EventArgs e)      //Min element
        {
            try
            {
                int minElement = intArray[0];
                for (int i = 0; i < intArray.Length; i++)
                {
                    if (minElement > intArray[i]) minElement = intArray[i];
                }
                Form1L1.Text = "Min element: " + Convert.ToString(minElement);
            }
            catch (NullReferenceException)
            {
                Form2 form2 = new Form2();
                form2.Show();
                form2.F2L1.Text = "Error! Please, initialize the array.";
            }
            catch (Exception)
            {
                Form2 form2 = new Form2();
                form2.Show();
                form2.F2L1.Text = "Operation error! Please, check your request.";
            }
        }
        private void button5_Click(object sender, EventArgs e)      //Average number
        {
            try {
                Form1L1.Text = "The Average number: " + (intArray.Sum() / intArray.Length);
            }
            catch (ArgumentNullException)
            {
                Form2 form2 = new Form2();
                form2.Show();
                form2.F2L1.Text = "Operation error! Please, initialize the array.";
            }
            catch (OverflowException)
            {
                Form2 form2 = new Form2();
                form2.Show();
                form2.F2L1.Text = "Operation error! Overflow array.";
            }
            catch (Exception)
            {
                Form2 form2 = new Form2();
                form2.Show();
                form2.F2L1.Text = "Operation error! Please, check your request.";
            }
        }
        private void button6_Click(object sender, EventArgs e)      //Sort array
        {
            try
            {
                int[] sortedArray = new int[intArray.Length];
                int temp;

                for (int i = 0; i <= intArray.Length - 2; i++)
                {
                    for (int j = 0; j <= intArray.Length - 2; j++)
                    {
                        if (RB1.Checked)
                        {
                            if (intArray[j] > intArray[j + 1])
                            {
                                temp = intArray[j + 1];
                                intArray[j + 1] = intArray[j];
                                intArray[j] = temp;
                            }
                        }
                        else if (intArray[j] < intArray[j + 1])
                        {
                            temp = intArray[j + 1];
                            intArray[j + 1] = intArray[j];
                            intArray[j] = temp;
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {
                Form2 form2 = new Form2();
                form2.Show();
                form2.F2L1.Text = "Error! Please, initialize the array.";
            }
            catch (Exception)
            {
                Form2 form2 = new Form2();
                form2.Show();
                form2.F2L1.Text = "Operation error! Please, check your request.";
            }
        }
        private void button7_Click(object sender, EventArgs e)      //Print array
        {
            try { TB1.Text = String.Join(" ", intArray); }
            catch (ArgumentNullException)
            {
                Form2 form2 = new Form2();
                form2.Show();
                form2.F2L1.Text = "Operation error! Please, initialize the array.";
            }
            catch (Exception)
            {
                Form2 form2 = new Form2();
                form2.Show();
                form2.F2L1.Text = "Operation error! Please, check your request.";
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}