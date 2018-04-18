using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Windows.Input;

namespace Rent_Calculator
{   
    public partial class FormSettings : Form
    {
        #region Other Stuff

        int ySpace = 24; // Distance between the new controls;
        int rent = 0;

        // Constructor
        public FormSettings()
        {
            InitializeComponent();
            //this.VerticalScroll.Visible = true;
        }

        // Create a list of names;
        List<string> Names = new List<string>();

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btnCheckName_Click(object sender, EventArgs e)
        {
            string newText = "";
            int newNumber = 1;

            // Write all the names;
            newText += "Dwellers: \n\n";
            foreach(string s in Names) 
            {
                newText += newNumber.ToString() + " - " + s + "\n";
                newNumber++;
            }
            newText += "\nRent price: " + rent; 
            MessageBox.Show(newText, "Information");
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            AddName();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            
            tbName.Text = TextMethods.ToName(tbName.Text);
            TextMethods.SetPointer(tbName);
        }  

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddName();
            }
        }

        private void btnSaveRent_Click(object sender, EventArgs e)
        {
            SaveRent();
        }

        private void btnSaveRent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveRent();
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            lPeriod.Text = "Time Period = " + CountDays().ToString() + " days";
        }

        private void dtpTill_ValueChanged(object sender, EventArgs e)
        {
            lPeriod.Text = "Time Period = " + CountDays().ToString() + " days";
        }

        #endregion

        #region Methods

            #region Add Name
            private void AddName()
            {
                if (tbName.Text != "") 
                {
                    if (!(Names.Count >= 9))
                    {
                        // Add the name to the list;
                        Names.Add(tbName.Text);

                        // Reset the textbox text;
                        tbName.Text = "";

                        // Create the label, textbox and a button for a new Name;
                        MakeControls();


                    } else 
                    {   // Too many names exception
                        MessageBox.Show("Sorry, you have too many roommates!\nWe can't add more!", "Too many people");
                    }
                } else
                {   // No text exception
                    MessageBox.Show("A name should contain at least 1 symbol", "No text entered");
                }                
            }
            #endregion

            private void MakeControls()
            {
                // General for All
                int newCount = Names.Count - 1; // The last number which I should add the control for;
                string newName = Names[newCount].ToString();

                #region Create a Label
                // Create a label
                    Label newLabel = new Label();
                    newLabel.Tag = newCount;

                    newLabel.Location = new Point(lblStart.Location.X, lblStart.Location.Y + newCount*ySpace);
                    newLabel.Size = lblStart.Size;
                    newLabel.TextAlign = ContentAlignment.MiddleRight;
                
                    // Generate a short name with max 8 chars and a dot if there are more;
                    string newNameText = "";
                    for(int i = 0; i < Names[newCount].Length; i++) 
                    {
                        if (i < 8) 
                            newNameText += newName[i] ;
                        else 
                            {
                                newNameText += ".";
                                break;
                            }
                    }

                    newLabel.Text = newNameText;

                    // Makes the thing visible(?)
                    Controls.Add(newLabel);
                #endregion

                #region Create TextBox
                //Create a TextBox
                    TextBox newTextBox = new TextBox();
                    newTextBox.Tag = newCount;

                    newTextBox.Location = new Point(tbStart.Location.X, tbStart.Location.Y+newCount*ySpace);
                    newTextBox.AutoSize = false;
                    newTextBox.Size = tbStart.Size;
                    newTextBox.TextAlign = HorizontalAlignment.Center;
                    newTextBox.Text = "0";
                    newTextBox.MaxLength = 5;

                    newTextBox.KeyPress += new KeyPressEventHandler(NumericTB);

                    // Center the control;
                    //newTextBox.Left = (this.ClientSize.Width - newTextBox.Width) / 2 ;
                    //newTextBox.Top = (this.ClientSize.Height - newTextBox.Height) / 2;

                    Controls.Add (newTextBox);
                #endregion

                #region Create [X] Button
                // Create an [x] button
                    Button newButton = new Button();
                    newButton.Tag = newCount;

                    newButton.Location = new Point(btnStart.Location.X, btnStart.Location.Y+newCount*ySpace);
                    newButton.Size = btnStart.Size;
                    newButton.Text = "X"; 
                    newButton.Click += new EventHandler(DeleteName);

                    Controls.Add(newButton);
                #endregion

            }

            // Happens when you click the [X] button;
            #region Delete Name

            private void DeleteName(object sender, EventArgs e)
            {
                List<Control> toDelete = new List<Control>();
                List<Control> toMove = new List<Control>();

                Button btn = sender as Button;

                foreach (Control c in Controls) 
                {
                    // If the tags are the same;
                    if (c.Tag?.ToString() == btn.Tag?.ToString())
                    {
                        toDelete.Add(c);
                    }

                    else 
                    
                    // If the tag is higher than of a button, meaning that these controls are located lower;
                    if (int.TryParse(c.Tag?.ToString(), out int newResult))
                    {
                        if ( int.Parse(c.Tag?.ToString()) > int.Parse(btn.Tag?.ToString()) ) 
                        {
                            toMove.Add(c);
                        }
                    }


                    //Another way to write the same code with null-conditional operators
                    /*if ((c.Tag != null) && (btn.Tag != null))
                    {
                        if (c.Tag?.ToString() == btn.Tag?.ToString())
                        {
                            toDelete.Add(c);
                        }
                    }*/
                }

                int tmp = toDelete.Count;
                int tmpM = toMove.Count;

                for (int i = 0; i < tmp; i++)
                {
                    Controls.Remove(toDelete[i]);
                }

                for (int i = 0; i < tmpM; i++)
                {
                    toMove[i].Top -= ySpace;
                    toMove[i].Tag = int.Parse(toMove[i].Tag?.ToString()) - 1;
                }

                Names.RemoveAt( int.Parse (btn.Tag?.ToString()) );
            }

        #endregion

        #region Save Rent

            private void SaveRent()
            {
                if ( int.TryParse(tbRentCost.Text, out int iCost) )
                {
                    rent = iCost;
                } else 
                {
                    MessageBox.Show("A rent cost should only contain numbers!", "Bad rent cost format");
                    return;
                }
            }

        #endregion

        #region Count Days

            private int CountDays()
            {
                // Sets the clock to 00:00
                dtpFrom.Value = dtpFrom.Value.Date;
                dtpTill.Value = dtpTill.Value.Date;

                int total = 0;
                TimeSpan diff = dtpTill.Value - dtpFrom.Value;
                total = (int)diff.TotalDays;
                return Math.Abs(total);
            }

        #endregion

        #region Check if the text in TextBox is numeric
        private void NumericTB(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb.Text.Length > 0)
            {
                if (int.Parse(tb.Text[0].ToString()) == 0) {
                    tb.Text = tb.Text.Remove(0, 1);
                }
            }
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                    e.Handled = true; //Stops the event if you try to type a letter;
            }
        }
        #endregion
 
        #endregion

        #region Calculations (Based on the user's input)

        // int rent is saved from Save Rent;

        public void Calculate()
        {
            foreach (TextBox t in Controls.OfType<TextBox>())
            {
                if ( (t.Tag != null) && (int.TryParse(t.Tag.ToString(), out int g)) )
                {
                    if (int.Parse(t.Text) > CountDays())
                    {
                        MessageBox.Show("The absense time of one or more dwellers is longer than the time period.\nI've changed the value for you.", "Too long absence");
                        t.Text = CountDays().ToString();
                    }
                }
            }

            // 1 - the amount of days passed during the taken period;
            int days = CountDays(); 
            // 2 (int rent, changed by Save Rent region) - the price to pay for everyone together;
            // 3 - int totalDays - multiply the amount of days by the amount of dwellers and subtract absense; FUBAR
            int totalDays = 0;

            int dwellers = Names.Count;
            List<Control> addValue = new List<Control>();

            string[] nameRef = new string[dwellers]; // Stores person's name;
            int[] numRef = new int[dwellers]; // Stores the amount of days this person was present;
            
            foreach (TextBox t in Controls.OfType<TextBox>()) // Loop through textboxes to find the absense time;
            {
                if ( (t.Tag != null) && (int.TryParse(t.Tag.ToString(), out int g)) )
                {
                    if ( (int)(t.Tag) < dwellers )
                    {
                        numRef[(int)t.Tag] = days - int.Parse(t.Text); // Store the amount of days the person has been PRESENT;
                        totalDays += (days - int.Parse(t.Text)); // Store the amount of days ALL PEOPLE TOGETHER have been PRESENT during the period;

                        foreach (Label l in Controls.OfType<Label>()) // Loop through the labels to find a correspondent name;
                        {
                            if ( (l.Tag != null) && (int.TryParse(l.Tag.ToString(), out int  yarr)) )
                            {
                                if (l.Tag?.ToString() == t.Tag?.ToString()) 
                                {
                                    nameRef[(int)l.Tag] = l.Text; // Store the name in a [Tag] part of an array, so that correspondent [] values are about the same person;
                                }
                            }   
                        }
                    }
                }
            }

            // 4 - int dayPrice - price per 1 day in the apartment for a person; FUBAR
            float dayPrice = 0;

            if (Names.Count <= 0)
            {
                MessageBox.Show("You should have at least 1 dweller!", "Nobody lives in your flat");
                return; // Does this exit the method? Seems like a yes to me;
            }

            SaveRent(); // Make sure the new entered value is always saved;

            if (CountDays() <= 0)
            {
                MessageBox.Show("The time period should be longer than 0 days!", "Time period = 0 days");
                return; // Does this exit the method? Seems like a yes to me;
            }

            if (totalDays != 0) 
            {
                dayPrice = (float)rent / totalDays;
            } else 
            {
                MessageBox.Show("At least 1 dweller should be present for at least 1 day!", "No one was present!");
                return; // Does this exit the method? Seems like a yes to me;
            }

            // 5 - string toSend - full text which says who should pay how much; FUBAR
            string toSend = "";
            double newTotal = 0; 

            for(int i=0; i<numRef.Length; i++)
            {
                double tStr = Math.Round((numRef[i]*dayPrice), 2);
                string nStr = nameRef[i].ToString();
                string p = String.Format("{0} should pay {1}\n", nStr, tStr);
                toSend += p;
                newTotal += tStr;

                // old code:
                //toSend += nameRef[i].ToString() + " should pay " + Math.Round((numRef[i]*dayPrice+0.00), 2) + "\n";
                //newTotal += Math.Round((numRef[i]*dayPrice), 2);
            }

            toSend += "\n\nTotal price: " + newTotal + " / " + (float)rent;

            // Finish calculating and open a new Form;

            FormMain fMain = new FormMain(toSend);
            fMain.FormMainRef = this;
            fMain.Show();
            fMain.Location = this.Location;
            this.Hide();
        }

        #endregion
    }
}
