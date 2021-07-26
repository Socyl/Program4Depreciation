using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4Depreciation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DepreciationStraightLine newItem;
        private void addButton_Click(object sender, EventArgs e)
        {
            
            //what kind of depreciation?
            if (straightRadioButton.Checked)
            {
                //newItem is a straight depreciation item
                newItem = new DepreciationStraightLine(); 
            }
            else if (doubleRadioButton.Checked)
            {
                //newItem is a double declining depreciating item
                newItem = new DepreciationDoubleDeclining();   
            }
            try
            {
                //add the final fields/properties
                newItem.DateAddedToInventory = dateInDateTimePicker.Value;
                newItem.LifeTime = Convert.ToInt32(lifetimeTextBox.Text);
                newItem.Title = titleTextBox.Text;
                newItem.StartValue = Convert.ToDecimal(startValueTextBox.Text);
                newItem.EndValue = Convert.ToDecimal(endValueTextBox.Text);
                

                //add the item to the listbox
                inventoryListBox.Items.Add(newItem);

                //clean up the user entry textboxes
                CleanUp();
            }
            catch (FormatException exp)
            {
                //set error and make textbox visible.
                errorTextBox.Text = "Error: You must enter valid numbers in the form. " +
                                    "Starting Value and End Value are decimals representing the value of the item in dollars " +
                                    "and Lifetime is an integer representing the item's lifetime in years";
                errorTextBox.Visible = true;
            }
            catch (OverflowException exp)
            {
                //set error and make textbox visible.
                errorTextBox.Text = "Error: One of your numerical entries is too small/large and has overflowed.  Please check your entries";
                errorTextBox.Visible = true;
            }
            catch (Exception exp)
            { 
                //Console.WriteLine("There was an error!");
                errorTextBox.Text="Error! " + exp.Message + "\nException type:" + exp.GetType();
            }
        
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //get the index of the selected item
            int selIndex = inventoryListBox.SelectedIndex;
            //if something is selected
            if (selIndex != -1)
            {
                inventoryListBox.Items.RemoveAt(selIndex);  //remove it
            }

            //clean up the user entry textboxes
            CleanUp();
        }

        private void inventoryListBox_DoubleClick(object sender, EventArgs e)
        {
            //treat the listbox object as a DepreciationStraightLine (can also pass in DepreciationDoubleDeclining as it is a child)
            DepreciationStraightLine newItem = inventoryListBox.SelectedItem as DepreciationStraightLine;
            //set the textboxes to match the object
            titleTextBox.Text = newItem.Title;
            startValueTextBox.Text = newItem.StartValue.ToString();
            endValueTextBox.Text = newItem.EndValue.ToString();
            lifetimeTextBox.Text = newItem.LifeTime.ToString();
            //set the dateTimePickers to match the object
            dateInDateTimePicker.Value = newItem.DateAddedToInventory;
            dateOutDateTimePicker.Value = newItem.DateRemovedFromInventory;
            //set the radio buttons to match the object
            if (inventoryListBox.SelectedItem is DepreciationDoubleDeclining)
            {
                doubleRadioButton.Checked = true;
            }
            else
            {
                straightRadioButton.Checked = true; 
            }      
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal totalValue = 0;
            //go through each item in the listbox
             foreach(DepreciationStraightLine item in inventoryListBox.Items)
            {
                totalValue += item.SalvageValue; //add its value to the total value
            }
             //output our total value 
            summaryTextBox.Text = String.Format("The total value of your inventory is {0:C2}.",
                         totalValue); 
        }

        private void CleanUp()
        {
            //clean up error textbox since all went well
            errorTextBox.Text = "";
            errorTextBox.Visible = false;

            //clear the user entry fields once item created.
            titleTextBox.Text = "";
            startValueTextBox.Text = "";
            endValueTextBox.Text = "";
            lifetimeTextBox.Text = "";
            dateInDateTimePicker.Value = DateTime.Now;
            dateOutDateTimePicker.Value = DateTime.Now;

            //clear the summary text box
            summaryTextBox.Text = "";

        }
    }
}
