using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace Checkout
{
    public partial class checkoutForm : Form
    {
        public checkoutForm()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(formSize, 429);
            label1.Size = new System.Drawing.Size(lableSize, 108);
        }
        //Declare sound
        SoundPlayer Print = new SoundPlayer(Properties.Resources.printsound);

        //Declare and initialize variables
        double total;
        int swords;
        int shields;
        int bow;
        double cost;
        double tax;

        double tendered;
        double change;
        int orderNumber = 1;
        int lableSize = 434;
        int formSize = 440;
        
        //When cost button is pushed
        private void costButton_Click(object sender, EventArgs e)
        {
            //Incase the inputs are blank set them to 0
            if (swordInput.Text == "")
            {
                swordInput.Text = "0";
            }
            if (shieldInput.Text == "")
            {
                shieldInput.Text = "0";
            }
            if (bowInput.Text == "")
            {
                bowInput.Text = "0";
            }
            
            //Prevent errors by trying 
            try 
            { 
                //Convert input to intergers
                swords = Convert.ToInt16(swordInput.Text);
                shields = Convert.ToInt16(shieldInput.Text);
                bow = Convert.ToInt16(bowInput.Text);

                //Calculate cost
                cost = (swords * 100.10) + (shields * 89.99) + (bow * 67.99);
                tax = cost * 0.13;
                total = tax + cost;
                
                //Convert values to string with correct format ($0.00)
                subtotalOutput.Text = cost.ToString("C");
                taxOutput.Text = tax.ToString("C");
                totalOutput.Text = total.ToString("C");
            }

            //Catch just incase something is invalid display error message
            catch
            {
                totalOutput.Text = "Numbers only";
            }
          
        }

        //If the change button is pushed
        private void changeButton_Click(object sender, EventArgs e)
        {
            //Attempt calculating change
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);
                change = tendered - total;
                changeOutput.Text = change.ToString("C");
            }

            //If invalid input display error message
            catch 
            {
                changeOutput.Text = "Invalid";
            }
        }

        //if print button is pushed
        private void printButton_Click(object sender, EventArgs e)
        {
            //Expands form an lable to show reciept
            while (formSize < 811 && lableSize < 800)
            {
                lableSize += 15;
                formSize += 15;
                this.Size = new System.Drawing.Size(formSize, 429);
                label1.Size = new System.Drawing.Size(lableSize, 108);
                Refresh();
            }

            //Play the print sound effect
            Print.Play();

            //Wait then begin printing line by line
            Thread.Sleep(1700);
            receiptLabel.Text = "Weapon Checkout";
            receiptLabel.Refresh();
            Thread.Sleep(200);
            receiptLabel.Text = receiptLabel.Text + $"\n Order number: {orderNumber}";
            receiptLabel.Refresh();
            Thread.Sleep(200);
            receiptLabel.Text = receiptLabel.Text + $"\n\n SwordX{swords}...........@ $100.10";
            receiptLabel.Refresh();
            Thread.Sleep(200);
            receiptLabel.Text = receiptLabel.Text + $"\n ShieldsX{shields}............@ $89.99";
            receiptLabel.Refresh();
            Thread.Sleep(200);
            receiptLabel.Text = receiptLabel.Text + $"\n BowX{bow}................@ $67.99";
            receiptLabel.Refresh();
            Thread.Sleep(200);
            receiptLabel.Text = receiptLabel.Text + $"\n\n Subtotal................{cost.ToString("C")}";
            receiptLabel.Refresh();
            Thread.Sleep(200);
            receiptLabel.Text = receiptLabel.Text + $"\n Tax......................{tax.ToString("C")}";
            receiptLabel.Refresh();
            Thread.Sleep(200);
            receiptLabel.Text = receiptLabel.Text + $"\n Total....................{total.ToString("C")}";
            receiptLabel.Refresh();
            Thread.Sleep(200);
            receiptLabel.Text = receiptLabel.Text + $"\n\n Tendered................{tendered.ToString("C")}";
            receiptLabel.Refresh();
            Thread.Sleep(200);
            receiptLabel.Text = receiptLabel.Text + $"\n Change..................{change.ToString("C")}";
        }

        //When the new order button is pushed
        private void newButton_Click(object sender, EventArgs e)
        {
            //Reset all inputs and outputs
            swordInput.ResetText();
            shieldInput.ResetText();
            bowInput.ResetText();
            subtotalOutput.ResetText();
            taxOutput.ResetText();
            totalOutput.ResetText();
            tenderedInput.ResetText();
            changeOutput.ResetText();
            receiptLabel.ResetText();

            //Set all values to zero
            swords = 0;
            shields = 0;
            bow = 0;
            tax = 0;
            cost = 0;
            total = 0;
            tendered = 0;
            change = 0;

            //Increase order number
            orderNumber++;

            //Collablse the side panel to hide the reciept
            while (formSize > 440 && lableSize > 434)
            {
                lableSize -= 15;
                formSize -= 15;
                this.Size = new System.Drawing.Size(formSize, 429);
                label1.Size = new System.Drawing.Size(lableSize, 108);
                Refresh();
            }
        }
    }
}
