using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Sharyl Hammer
 * ITD 1253 C#
 * Section 3 Programming Exam
 * December 10, 2016
 * Fall 2016 
 */ 
namespace DenominationProject
{
    public partial class FrmDenomination : Form
    {
        public FrmDenomination()
        {
            InitializeComponent();
        }
        // Global Variable for displaying messages
        // Couldn't get my logic to work. Kept getting error message stating that the && can't be used with a string.

        string messages = "";
        public bool IsValidData()
        {
            return
                IsPresent(txtDispenseAmt, "Dispense amount ") &&
                IsDecimal(txtDispenseAmt, "Dispense amount ") &&
                IsInt32(txtDispenseAmt, "Dispense amount ") &&
                IsNegative(txtDispenseAmt, "Dispense amount ");
        }

    
        public bool IsPresent(TextBox textBox, string name)
        {
          if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
               //    messages += name + " is a required field.";
                textBox.Focus();
                 return false;

            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
          
            
                if (textBox.Text.IndexOf(".") ==-1)
            {
                return true;

            }
            else
            {
               MessageBox.Show(name + "can not be a decimal value.", "Entry Error");
              //  messages += name + "can not be a decimal value.";
               textBox.Focus();
                return false;
            }


        }

        public bool IsInt32(TextBox textBox, string name)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;

            }
            else
            {
                MessageBox.Show(name + " must be an integer.", "Entry Error");
              //  messages += name + " must be an integer.";
                textBox.Focus();
                return false;
            }

           }

        public bool IsNegative(TextBox textBox, string name)
        {


            if (textBox.Text.IndexOf("-") == -1)
            {

                return true;
            }
            else
            {

               MessageBox.Show(name + "can not be a negative value.", "Entry Error");
             //   messages += name + "can not be a negative value.";
                textBox.Focus();
                return false;
            }

                  
        }



        private string GetDispenseAmt(int dispenseNumber, string denstring )
        {
            string CalcString = "";
          //  string denstring = "";
            int i =0;
               
                     
            int[] denArray = new int[9];
            // Place String into an Integer Array
            string[] tokens = denstring.Split();

             denArray = Array.ConvertAll<string, int>(tokens, int.Parse);
          
            int count = 0;
            int denCount = 0;


            for (i = 0; i < denArray.Length; i++)
            {

                count = dispenseNumber / denArray[i];
                if (count != 0)
                {
                    CalcString += "$" + denArray[i].ToString() + " x " + "\t\t"+ count + "\t\t"  +" = "  +"$" +denArray[i]*count + "\n\n"; 

                }

                denCount += count;
                dispenseNumber = dispenseNumber % denArray[i];
            }  

                       
            return CalcString;

        }
       



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDispenseAmt.Text = "";
            lblMessage.Text = "";
            chk100.Checked = true;
            chk50.Checked = true;
            chk20.Checked = true;
            chk10.Checked = true;
            chk5.Checked = true;
            chk1.Checked = true;
            grpDenominations.BackColor = this.BackColor;
            
        }

        private void FrmDenomination_Load(object sender, EventArgs e)
        {
            string shortTime;
            chk1.AutoCheck = false;
            chk5.Checked = true;
            chk10.Checked = true;
            chk20.Checked = true;
            chk50.Checked = true;
            chk100.Checked = true;
            DateTime currentDateTime = DateTime.Now;
            shortTime = currentDateTime.ToShortTimeString();
            lblTIme.Text = shortTime.ToString();
        }

        private void btnDispense_Click(object sender, EventArgs e)
        {
            //Make the background color of the labels display yellow.

            grpDenominations.BackColor = Color.LightYellow;

            int dispenseNumber = 0;
            string RawNumber = "";
            string Answer = "";
            // When number comes in need to remove the $ and ,

            RawNumber = txtDispenseAmt.Text;
            // RawNumber = RawNumber.Trim();
            txtDispenseAmt.Text = txtDispenseAmt.Text.Trim();
            txtDispenseAmt.Text = txtDispenseAmt.Text.Replace("$", "");
            txtDispenseAmt.Text = txtDispenseAmt.Text.Replace(",", "");
            //  RawNumber = RawNumber.Replace("$", "");
            //  RawNumber = RawNumber.Replace(",", "");

            string denstring = "";
           
            try
            {
               //  messages = this.IsValidData();
                if (IsValidData())
              //     if (messages == "") // found no errors here in global error message
                  {
                    dispenseNumber = Convert.ToInt32(txtDispenseAmt.Text);
                    txtDispenseAmt.Text = "";

                    // we need to build a string from the checkboxes.

                    if (chk100.Checked)
                    {
                        denstring += 100 + " ";
                    }

                    if (chk50.Checked)
                    {
                        denstring += 50 + " ";
                    }

                    if (chk20.Checked)
                    {
                        denstring += 20 + " ";

                    }

                    if (chk10.Checked)
                    {
                        denstring += 10 + " ";

                    }

                    if (chk5.Checked)
                    {
                        denstring += 5 + " ";

                    }
                    if (chk1.Checked)
                    {
                        denstring += 1;

                    }


                Answer = this.GetDispenseAmt(dispenseNumber, denstring);
                lblMessage.Text = "\n"+ "DENOMINATION BREAKDOWN" +"\n\n" + Answer.ToString();     
                                      
                 
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
