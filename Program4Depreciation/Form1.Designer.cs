
namespace Program4Depreciation
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.lifetimeTextBox = new System.Windows.Forms.TextBox();
            this.endValueTextBox = new System.Windows.Forms.TextBox();
            this.startValueTextBox = new System.Windows.Forms.TextBox();
            this.dateOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.doubleRadioButton = new System.Windows.Forms.RadioButton();
            this.straightRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.summaryTextBox = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "How to use this application";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 111);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(496, 238);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Welcome to the Super Depreication Calculator (BC version). Enter your inventory i" +
    "n the inventory tab.  Go to the summary tab to find the value of your inventory." +
    "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Super Depreciation Calculator - BC version";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.errorTextBox);
            this.tabPage2.Controls.Add(this.lifetimeTextBox);
            this.tabPage2.Controls.Add(this.endValueTextBox);
            this.tabPage2.Controls.Add(this.startValueTextBox);
            this.tabPage2.Controls.Add(this.dateOutDateTimePicker);
            this.tabPage2.Controls.Add(this.dateInDateTimePicker);
            this.tabPage2.Controls.Add(this.titleTextBox);
            this.tabPage2.Controls.Add(this.addButton);
            this.tabPage2.Controls.Add(this.doubleRadioButton);
            this.tabPage2.Controls.Add(this.straightRadioButton);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.removeButton);
            this.tabPage2.Controls.Add(this.inventoryListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(809, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // errorTextBox
            // 
            this.errorTextBox.Location = new System.Drawing.Point(344, 330);
            this.errorTextBox.Multiline = true;
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.ReadOnly = true;
            this.errorTextBox.Size = new System.Drawing.Size(421, 84);
            this.errorTextBox.TabIndex = 17;
            this.errorTextBox.Visible = false;
            // 
            // lifetimeTextBox
            // 
            this.lifetimeTextBox.Location = new System.Drawing.Point(461, 115);
            this.lifetimeTextBox.Name = "lifetimeTextBox";
            this.lifetimeTextBox.Size = new System.Drawing.Size(319, 26);
            this.lifetimeTextBox.TabIndex = 16;
            // 
            // endValueTextBox
            // 
            this.endValueTextBox.Location = new System.Drawing.Point(461, 83);
            this.endValueTextBox.Name = "endValueTextBox";
            this.endValueTextBox.Size = new System.Drawing.Size(319, 26);
            this.endValueTextBox.TabIndex = 15;
            // 
            // startValueTextBox
            // 
            this.startValueTextBox.Location = new System.Drawing.Point(461, 51);
            this.startValueTextBox.Name = "startValueTextBox";
            this.startValueTextBox.Size = new System.Drawing.Size(319, 26);
            this.startValueTextBox.TabIndex = 14;
            // 
            // dateOutDateTimePicker
            // 
            this.dateOutDateTimePicker.Location = new System.Drawing.Point(461, 179);
            this.dateOutDateTimePicker.Name = "dateOutDateTimePicker";
            this.dateOutDateTimePicker.Size = new System.Drawing.Size(319, 26);
            this.dateOutDateTimePicker.TabIndex = 13;
            // 
            // dateInDateTimePicker
            // 
            this.dateInDateTimePicker.Location = new System.Drawing.Point(461, 147);
            this.dateInDateTimePicker.Name = "dateInDateTimePicker";
            this.dateInDateTimePicker.Size = new System.Drawing.Size(319, 26);
            this.dateInDateTimePicker.TabIndex = 12;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(461, 19);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(319, 26);
            this.titleTextBox.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(419, 280);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(264, 44);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add Form Item To Inventory";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // doubleRadioButton
            // 
            this.doubleRadioButton.AutoSize = true;
            this.doubleRadioButton.Location = new System.Drawing.Point(481, 250);
            this.doubleRadioButton.Name = "doubleRadioButton";
            this.doubleRadioButton.Size = new System.Drawing.Size(154, 24);
            this.doubleRadioButton.TabIndex = 9;
            this.doubleRadioButton.TabStop = true;
            this.doubleRadioButton.Text = "Double Declining";
            this.doubleRadioButton.UseVisualStyleBackColor = true;
            // 
            // straightRadioButton
            // 
            this.straightRadioButton.AutoSize = true;
            this.straightRadioButton.Checked = true;
            this.straightRadioButton.Location = new System.Drawing.Point(481, 220);
            this.straightRadioButton.Name = "straightRadioButton";
            this.straightRadioButton.Size = new System.Drawing.Size(124, 24);
            this.straightRadioButton.TabIndex = 8;
            this.straightRadioButton.TabStop = true;
            this.straightRadioButton.Text = "Straight Line";
            this.straightRadioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date out of inventory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date in inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lifetime (years)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "End Value $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Starting Value $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(7, 296);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(306, 51);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove Selected Item From Inventory";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.HorizontalScrollbar = true;
            this.inventoryListBox.ItemHeight = 20;
            this.inventoryListBox.Location = new System.Drawing.Point(7, 6);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(283, 264);
            this.inventoryListBox.TabIndex = 0;
            this.inventoryListBox.DoubleClick += new System.EventHandler(this.inventoryListBox_DoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.summaryTextBox);
            this.tabPage3.Controls.Add(this.calculateButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Summary";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // summaryTextBox
            // 
            this.summaryTextBox.AutoSize = true;
            this.summaryTextBox.Location = new System.Drawing.Point(209, 222);
            this.summaryTextBox.Name = "summaryTextBox";
            this.summaryTextBox.Size = new System.Drawing.Size(259, 20);
            this.summaryTextBox.TabIndex = 1;
            this.summaryTextBox.Text = "The total value of your inventory is $";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(213, 97);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(333, 65);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate Inventory Value";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 485);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Super Depreciation Calculator 300 (BC Version)";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton doubleRadioButton;
        private System.Windows.Forms.RadioButton straightRadioButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker dateInDateTimePicker;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DateTimePicker dateOutDateTimePicker;
        private System.Windows.Forms.TextBox lifetimeTextBox;
        private System.Windows.Forms.TextBox endValueTextBox;
        private System.Windows.Forms.TextBox startValueTextBox;
        private System.Windows.Forms.Label summaryTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox errorTextBox;
    }
}

