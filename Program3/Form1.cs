//Grading ID: K1791
//Program 3
//5 November 2020
//CIS 199-02
//This assignment explores parallel arrays, range matching.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //When the calculate button is pressed, the following calculations will take place
        private void calculationButton_Click(object sender, EventArgs e)
        {
            

            string[] productNumbers = { "1001", "1002", "1003", "1004", "1005", "1006", "1007", }; //Values of product numbers
            double[] costPerUnit = { 7.78, 9.51, 10.73 , 9.99 , 11.99, 5.00, 4.58 }; //Values of cost per units



            string[] states = { "KY", "OH", "IN", "IL", }; //List of four states
            stateComboBox.Items.AddRange(states); //Adds the array of states to the combobox
            double[] tax = { 0.06, 0.0717, 0.07, 0.0874, }; //A list of sales taxes, already converted to useful forms

            string[] items = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" }; //How many items the user has input
            double[] discount = { 0, 0, 0, 0, 0, 0.05, 0.05, 0.05, 0.05, 0.05, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.15 }; //The discount that is given based on the number of items sold



            string userProductNumber = productTextBox.Text; //What product number did the user use?
            string userQuantityNumber = quantityTextBox.Text; //How many items did the user get?
           
            int firstCost; //An int to calculate the initial cost

            firstCost = Convert.ToInt32(userQuantityNumber); //Converted the user input into a form that can be used for the calculations

            string userState = stateComboBox.Text; //What state did the user select?



            int index1 = 0; //A simple way to create the most basic of while loops
            int index2 = 0; //A simple way to create the most basic of while loops
            int index3 = 0; //A simple way to create the most basic of while loops

            double cutOffValue1; //A simple way to create the most basic of while loops
            double cutOffValue2; //A simple way to create the most basic of while loops
            double cutOffValue3; //A simple way to create the most basic of while loops



            bool productFound = false; //A simple way to create the most basic of while loops
            bool quantityFound = false; //A simple way to create the most basic of while loops
            bool stateFound = false; //A simple way to create the most basic of while loops

            double finalCostPerUnit = 0; //Assigning a value of zero, that will get reassigned eventually if the while loop executes correctly.
            double finalCostPerQuantity = 0; //Assigning a value of zero, that will get reassigned eventually if the while loop executes correctly.
            double finalCostPerState = 0; //Assigning a value of zero, that will get reassigned eventually if the while loop executes correctly.

            //Determines if the value of the product number textbox is valid, and if so assigns it to a variable

            


            while (index1 < productNumbers.Length && !productFound) //While index1 is less than the length of product numbers, and product number is false..
            {
                if (productNumbers[index1] == userProductNumber)

                {
                    productFound = true; //Updates the product found to true
                    cutOffValue1 = costPerUnit[index1]; //The cutoff value has now been assigned the value of the matching cost per unit based on the product array
                    finalCostPerUnit = cutOffValue1; //We now have a usable value, which is assigned from the above cutoffvalue1
                    

                }
                else
                {
                    
                    ++index1;
                }
            }

           //Determines if the value of the items textbox is valid, and if so assigns it to a variable
           
            while (index2 < items.Length && !quantityFound) //While index2 is less than the length of the item array, and quantity number is false..
            {
                if (items[index2] == userQuantityNumber) //If the user input a quanity that matches the items array...

                {

                    quantityFound = true; //Updates the quantity found to true
                    cutOffValue2 = discount[index2]; //The cutoff value has now been assigned the value of the discount that matches up with the quantity array
                    finalCostPerQuantity= cutOffValue2; //We now have a usable value, which is assigned from the above cutoffvalue2

                }
               
                else
                {
                    ++index2; //Updates index 2 count
                }
            }

            //Determines if the value of the state combobox is valid, and if so assigns it to a variable


            while (index3 < states.Length && !stateFound) //While index3 is less than the length of the states array, and state number is false...
            {
                if (states[index3] == userState) //If the value that the user input is in the states array...

                {
                    stateFound = true; //Statesfound has been updated to true
                    cutOffValue3 = tax[index3]; //The cutoff value has now been assigned the matching tax value as compared to the states array
                    finalCostPerState = cutOffValue3; //We now have a usable value, which is assigned from the above cutoffvalue3

                }
                else //If the above is not true..
                {
                    ++index3; //Updates the index3 count
                }
            }



            double initialCalculation; //The initial calculation before any taxes or discounts are applied
            double discountedCalculation; //The discounted calculation 
            double trueAndHonestDiscount; //The actual discounted value
            double taxCalculation; //The calculation that involves taxes
            double totalCostCalculation;//The final calculation

            if (firstCost > 20) // If the user has input more than 20 items...
            {
                finalCostPerQuantity = 0.15; //Assigns this value if items are over 20
            }




            initialCalculation = firstCost *  finalCostPerUnit; //Multiples the value found by the first loop, by how the quanity the user input in the quanity textbox
            initialCostOutput.Text = initialCalculation.ToString("C2"); //Outputs the above value to the initial cost output, with 2 decimals of precision.

            discountedCalculation = initialCalculation * finalCostPerQuantity; //Discount calculaton is equal to the initial cost multiplied by the discount based on how many items that were purchased

            trueAndHonestDiscount = initialCalculation - discountedCalculation; //Gives an actual discounted value by subtracting the calculation above from the initial calculation

            discountedCostOutput.Text = trueAndHonestDiscount.ToString("C2"); //Outputs the above to the label


            taxCalculation = trueAndHonestDiscount * finalCostPerState; //Multiplies the discounted price by the tax value, which was found from a while loop

            taxOutput.Text = taxCalculation.ToString("C2"); //Outputs the above calculation to a label

            totalCostCalculation = taxCalculation + trueAndHonestDiscount; //The tax calculation, plus the discount is equal to the total

            totalPriceOutput.Text = totalCostCalculation.ToString("C2"); //Displays the above calculation to a label



















        }

    }
}



