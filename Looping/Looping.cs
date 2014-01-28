using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Looping
{
    public partial class Looping : Form
    {
        bool doAnimation = false;

        public Looping()
        {
            InitializeComponent();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            int letterCount = 0;

            // Use for loop to find and count letters only.
            for (int i = 0; i < sentenceTextBox.Text.Length; i++)
            {
                // Determine if we have a character.
                if (char.IsLetter(sentenceTextBox.Text, i))
                    letterCount++;
            }

            letterCountLabel.Text = "Letter count: " + letterCount;

            // Use while loop to reverse. 
            StringBuilder reverseSB = new StringBuilder(sentenceTextBox.Text.Length);

            int letterPosition = sentenceTextBox.Text.Length;
            while (letterPosition > 0)
            {
                // Add character, working from end of string backwards.
                reverseSB.Append(sentenceTextBox.Text.Substring(--letterPosition, 1));
            }

            reversedTextBox.Text = reverseSB.ToString();
        }

        private void animateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Determine if we are to animate, then force paint event to occur using Refresh.
            doAnimation = animateCheckBox.Checked;
            this.Refresh();
        }


        
        private void Looping_Paint(object sender, PaintEventArgs e)
        {
            string drawText = sentenceTextBox.Text.Length > 0 ? sentenceTextBox.Text : "Some text";
            // Determine our approximate stopping point.
            float maxWidth = e.Graphics.VisibleClipBounds.Width;
            // Set up starting x and y locations, noting that only the x is going to change.
            float x = animateCheckBox.Left;
            float y = animateCheckBox.Top + (animateCheckBox.Height * 2);
            // We'll need a previous x location so we can 'erase' the previous drawing.
            float previousX = x;


            { 
                 
                // Loop until either we've reached our stopping point, or doAnimation is false.
                do
                {
                    // Draw text at old location.
                    e.Graphics.DrawString(drawText, new Font("Arial", 8), new SolidBrush(this.BackColor), previousX, y);
                    // Make the system sleep for a short time so we can see the animation.
                    System.Threading.Thread.Sleep(20);
                    // Allow the program to process events so we can allow the user interface to be responsive after sleeping.
                    Application.DoEvents();
                    // Draw text at new location.
                    e.Graphics.DrawString(drawText, new Font("Arial", 8), new SolidBrush(Color.Red), x, y);
                    // Save the current location.
                    previousX = x;
                    // Advance to next location.
                    x--;
                } while (x < maxWidth && doAnimation && leftCheckBox.Checked == true && animateCheckBox.Checked == true);

                do
                {
                    // Draw text at old location.
                    e.Graphics.DrawString(drawText, new Font("Arial", 8), new SolidBrush(this.BackColor), previousX, y);
                    // Make the system sleep for a short time so we can see the animation.
                    System.Threading.Thread.Sleep(20);
                    // Allow the program to process events so we can allow the user interface to be responsive after sleeping.
                    Application.DoEvents();
                    // Draw text at new location.
                    e.Graphics.DrawString(drawText, new Font("Arial", 8), new SolidBrush(Color.Red), x, y);
                    // Save the current location.
                    previousX = x;
                    // Advance to next location.
                    x++;
                } while (x < maxWidth && doAnimation && leftCheckBox.Checked == false && animateCheckBox.Checked == true);

                // Do some cleanup.
                e.Graphics.DrawString(drawText, new Font("Arial", 8), new SolidBrush(this.BackColor), previousX, y);
                animateCheckBox.Checked = false;
                doAnimation = false;
            }
        }
            

        

        private void Looping_FormClosing(object sender, FormClosingEventArgs e)
        {
            // We need to prevent, or cancel, closing, as code may still be in animation do loop.
            if (doAnimation)
            {
                MessageBox.Show("You must stop any animation before trying to close the program", this.Text, MessageBoxButtons.OK);
                e.Cancel = true;
            }
        }
    }
}