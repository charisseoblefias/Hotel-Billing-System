
namespace Hotel_Billing_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.INdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OUTdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.NoOfDaysTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RoomCapacityComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RegularRadioButton = new System.Windows.Forms.RadioButton();
            this.DeLuxeRadioButton = new System.Windows.Forms.RadioButton();
            this.SuiteRadioButton = new System.Windows.Forms.RadioButton();
            this.TypeOfPaymentListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "RGFSH BILLING SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 27);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Date Check-in";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(60, 181);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(131, 29);
            this.CheckOutButton.TabIndex = 3;
            this.CheckOutButton.Text = "Date Check-out";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // INdateTimePicker
            // 
            this.INdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.INdateTimePicker.Location = new System.Drawing.Point(197, 147);
            this.INdateTimePicker.Name = "INdateTimePicker";
            this.INdateTimePicker.Size = new System.Drawing.Size(128, 27);
            this.INdateTimePicker.TabIndex = 4;
            // 
            // OUTdateTimePicker
            // 
            this.OUTdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OUTdateTimePicker.Location = new System.Drawing.Point(197, 183);
            this.OUTdateTimePicker.Name = "OUTdateTimePicker";
            this.OUTdateTimePicker.Size = new System.Drawing.Size(128, 27);
            this.OUTdateTimePicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Number of Days:";
            // 
            // NoOfDaysTextBox
            // 
            this.NoOfDaysTextBox.Location = new System.Drawing.Point(239, 248);
            this.NoOfDaysTextBox.Name = "NoOfDaysTextBox";
            this.NoOfDaysTextBox.Size = new System.Drawing.Size(86, 27);
            this.NoOfDaysTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Amount:";
            // 
            // TotalAmountTextBox
            // 
            this.TotalAmountTextBox.Location = new System.Drawing.Point(197, 291);
            this.TotalAmountTextBox.Name = "TotalAmountTextBox";
            this.TotalAmountTextBox.Size = new System.Drawing.Size(128, 27);
            this.TotalAmountTextBox.TabIndex = 8;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(34, 358);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(90, 38);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(239, 358);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(91, 38);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ComputeButton
            // 
            this.ComputeButton.Location = new System.Drawing.Point(130, 358);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(102, 38);
            this.ComputeButton.TabIndex = 9;
            this.ComputeButton.Text = "Compute";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Room Capacity";
            // 
            // RoomCapacityComboBox
            // 
            this.RoomCapacityComboBox.FormattingEnabled = true;
            this.RoomCapacityComboBox.Items.AddRange(new object[] {
            "Single",
            "Double ",
            "Family"});
            this.RoomCapacityComboBox.Location = new System.Drawing.Point(383, 114);
            this.RoomCapacityComboBox.Name = "RoomCapacityComboBox";
            this.RoomCapacityComboBox.Size = new System.Drawing.Size(119, 28);
            this.RoomCapacityComboBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RegularRadioButton);
            this.groupBox1.Controls.Add(this.DeLuxeRadioButton);
            this.groupBox1.Controls.Add(this.SuiteRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(383, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 117);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Type";
            // 
            // RegularRadioButton
            // 
            this.RegularRadioButton.AutoSize = true;
            this.RegularRadioButton.Location = new System.Drawing.Point(6, 81);
            this.RegularRadioButton.Name = "RegularRadioButton";
            this.RegularRadioButton.Size = new System.Drawing.Size(81, 24);
            this.RegularRadioButton.TabIndex = 0;
            this.RegularRadioButton.TabStop = true;
            this.RegularRadioButton.Text = "Regular";
            this.RegularRadioButton.UseVisualStyleBackColor = true;
            // 
            // DeLuxeRadioButton
            // 
            this.DeLuxeRadioButton.AutoSize = true;
            this.DeLuxeRadioButton.Location = new System.Drawing.Point(6, 53);
            this.DeLuxeRadioButton.Name = "DeLuxeRadioButton";
            this.DeLuxeRadioButton.Size = new System.Drawing.Size(83, 24);
            this.DeLuxeRadioButton.TabIndex = 0;
            this.DeLuxeRadioButton.TabStop = true;
            this.DeLuxeRadioButton.Text = "De Luxe";
            this.DeLuxeRadioButton.UseVisualStyleBackColor = true;
            // 
            // SuiteRadioButton
            // 
            this.SuiteRadioButton.AutoSize = true;
            this.SuiteRadioButton.Location = new System.Drawing.Point(6, 26);
            this.SuiteRadioButton.Name = "SuiteRadioButton";
            this.SuiteRadioButton.Size = new System.Drawing.Size(63, 24);
            this.SuiteRadioButton.TabIndex = 0;
            this.SuiteRadioButton.TabStop = true;
            this.SuiteRadioButton.Text = "Suite";
            this.SuiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // TypeOfPaymentListBox
            // 
            this.TypeOfPaymentListBox.FormattingEnabled = true;
            this.TypeOfPaymentListBox.ItemHeight = 20;
            this.TypeOfPaymentListBox.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Credit Card"});
            this.TypeOfPaymentListBox.Location = new System.Drawing.Point(383, 312);
            this.TypeOfPaymentListBox.Name = "TypeOfPaymentListBox";
            this.TypeOfPaymentListBox.Size = new System.Drawing.Size(119, 84);
            this.TypeOfPaymentListBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Type of Payment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 416);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TypeOfPaymentListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RoomCapacityComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TotalAmountTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NoOfDaysTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OUTdateTimePicker);
            this.Controls.Add(this.INdateTimePicker);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.DateTimePicker INdateTimePicker;
        private System.Windows.Forms.DateTimePicker OUTdateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NoOfDaysTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TotalAmountTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RoomCapacityComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RegularRadioButton;
        private System.Windows.Forms.RadioButton DeLuxeRadioButton;
        private System.Windows.Forms.RadioButton SuiteRadioButton;
        private System.Windows.Forms.ListBox TypeOfPaymentListBox;
        private System.Windows.Forms.Label label6;
    }
}

