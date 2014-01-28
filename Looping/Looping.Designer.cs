namespace Looping
{
    partial class Looping
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sentenceLabel = new System.Windows.Forms.Label();
            this.sentenceTextBox = new System.Windows.Forms.TextBox();
            this.letterCountLabel = new System.Windows.Forms.Label();
            this.reversedTextBox = new System.Windows.Forms.TextBox();
            this.reversedLabal = new System.Windows.Forms.Label();
            this.animateCheckBox = new System.Windows.Forms.CheckBox();
            this.countButton = new System.Windows.Forms.Button();
            this.leftCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // sentenceLabel
            // 
            this.sentenceLabel.AutoSize = true;
            this.sentenceLabel.Location = new System.Drawing.Point(12, 18);
            this.sentenceLabel.Name = "sentenceLabel";
            this.sentenceLabel.Size = new System.Drawing.Size(82, 13);
            this.sentenceLabel.TabIndex = 0;
            this.sentenceLabel.Text = "Enter sentence:";
            // 
            // sentenceTextBox
            // 
            this.sentenceTextBox.Location = new System.Drawing.Point(15, 34);
            this.sentenceTextBox.Name = "sentenceTextBox";
            this.sentenceTextBox.Size = new System.Drawing.Size(100, 20);
            this.sentenceTextBox.TabIndex = 1;
            // 
            // letterCountLabel
            // 
            this.letterCountLabel.AutoSize = true;
            this.letterCountLabel.Location = new System.Drawing.Point(11, 97);
            this.letterCountLabel.Name = "letterCountLabel";
            this.letterCountLabel.Size = new System.Drawing.Size(68, 13);
            this.letterCountLabel.TabIndex = 2;
            this.letterCountLabel.Text = "Letter Count:";
            // 
            // reversedTextBox
            // 
            this.reversedTextBox.Location = new System.Drawing.Point(15, 136);
            this.reversedTextBox.Name = "reversedTextBox";
            this.reversedTextBox.Size = new System.Drawing.Size(100, 20);
            this.reversedTextBox.TabIndex = 3;
            // 
            // reversedLabal
            // 
            this.reversedLabal.AutoSize = true;
            this.reversedLabal.Location = new System.Drawing.Point(12, 120);
            this.reversedLabal.Name = "reversedLabal";
            this.reversedLabal.Size = new System.Drawing.Size(56, 13);
            this.reversedLabal.TabIndex = 4;
            this.reversedLabal.Text = "Reversed:";
            // 
            // animateCheckBox
            // 
            this.animateCheckBox.AutoSize = true;
            this.animateCheckBox.Location = new System.Drawing.Point(15, 177);
            this.animateCheckBox.Name = "animateCheckBox";
            this.animateCheckBox.Size = new System.Drawing.Size(64, 17);
            this.animateCheckBox.TabIndex = 5;
            this.animateCheckBox.Text = "Animate";
            this.animateCheckBox.UseVisualStyleBackColor = true;
            this.animateCheckBox.CheckedChanged += new System.EventHandler(this.animateCheckBox_CheckedChanged);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(14, 60);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 6;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // leftCheckBox
            // 
            this.leftCheckBox.AutoSize = true;
            this.leftCheckBox.Location = new System.Drawing.Point(85, 177);
            this.leftCheckBox.Name = "leftCheckBox";
            this.leftCheckBox.Size = new System.Drawing.Size(74, 17);
            this.leftCheckBox.TabIndex = 7;
            this.leftCheckBox.Text = "Move Left";
            this.leftCheckBox.UseVisualStyleBackColor = true;
            // 
            // Looping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.leftCheckBox);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.animateCheckBox);
            this.Controls.Add(this.reversedLabal);
            this.Controls.Add(this.reversedTextBox);
            this.Controls.Add(this.letterCountLabel);
            this.Controls.Add(this.sentenceTextBox);
            this.Controls.Add(this.sentenceLabel);
            this.Name = "Looping";
            this.Text = "Looping";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Looping_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Looping_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sentenceLabel;
        private System.Windows.Forms.TextBox sentenceTextBox;
        private System.Windows.Forms.Label letterCountLabel;
        private System.Windows.Forms.TextBox reversedTextBox;
        private System.Windows.Forms.Label reversedLabal;
        private System.Windows.Forms.CheckBox animateCheckBox;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.CheckBox leftCheckBox;
    }
}

