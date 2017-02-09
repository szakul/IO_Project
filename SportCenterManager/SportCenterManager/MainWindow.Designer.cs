namespace SportCenterManager
{
    partial class MainWindow
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
            this.tabPageAddEvent = new System.Windows.Forms.TabPage();
            this.comboBoxEventFacility = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerEventDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEventDescription = new System.Windows.Forms.TextBox();
            this.textBoxEventName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerEventStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEventEnd = new System.Windows.Forms.DateTimePicker();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageAddEvent.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAddEvent);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(287, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAddEvent
            // 
            this.tabPageAddEvent.Controls.Add(this.dateTimePickerEventEnd);
            this.tabPageAddEvent.Controls.Add(this.dateTimePickerEventStart);
            this.tabPageAddEvent.Controls.Add(this.label8);
            this.tabPageAddEvent.Controls.Add(this.label7);
            this.tabPageAddEvent.Controls.Add(this.label6);
            this.tabPageAddEvent.Controls.Add(this.comboBoxEventFacility);
            this.tabPageAddEvent.Controls.Add(this.label5);
            this.tabPageAddEvent.Controls.Add(this.dateTimePickerEventDate);
            this.tabPageAddEvent.Controls.Add(this.label4);
            this.tabPageAddEvent.Controls.Add(this.button1);
            this.tabPageAddEvent.Controls.Add(this.label2);
            this.tabPageAddEvent.Controls.Add(this.label1);
            this.tabPageAddEvent.Controls.Add(this.textBoxEventDescription);
            this.tabPageAddEvent.Controls.Add(this.textBoxEventName);
            this.tabPageAddEvent.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddEvent.Name = "tabPageAddEvent";
            this.tabPageAddEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddEvent.Size = new System.Drawing.Size(279, 354);
            this.tabPageAddEvent.TabIndex = 0;
            this.tabPageAddEvent.Text = "Add event";
            this.tabPageAddEvent.UseVisualStyleBackColor = true;
            // 
            // comboBoxEventFacility
            // 
            this.comboBoxEventFacility.FormattingEnabled = true;
            this.comboBoxEventFacility.Location = new System.Drawing.Point(4, 288);
            this.comboBoxEventFacility.Name = "comboBoxEventFacility";
            this.comboBoxEventFacility.Size = new System.Drawing.Size(272, 21);
            this.comboBoxEventFacility.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Event facility";
            // 
            // dateTimePickerEventDate
            // 
            this.dateTimePickerEventDate.CustomFormat = "";
            this.dateTimePickerEventDate.Location = new System.Drawing.Point(4, 209);
            this.dateTimePickerEventDate.Name = "dateTimePickerEventDate";
            this.dateTimePickerEventDate.Size = new System.Drawing.Size(272, 20);
            this.dateTimePickerEventDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Event date:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add event";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Event name:";
            // 
            // textBoxEventDescription
            // 
            this.textBoxEventDescription.Location = new System.Drawing.Point(4, 58);
            this.textBoxEventDescription.Multiline = true;
            this.textBoxEventDescription.Name = "textBoxEventDescription";
            this.textBoxEventDescription.Size = new System.Drawing.Size(272, 132);
            this.textBoxEventDescription.TabIndex = 1;
            // 
            // textBoxEventName
            // 
            this.textBoxEventName.Location = new System.Drawing.Point(4, 19);
            this.textBoxEventName.Name = "textBoxEventName";
            this.textBoxEventName.Size = new System.Drawing.Size(272, 20);
            this.textBoxEventName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(279, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(279, 304);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "You are logged as Admin with ID = 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Event duration:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "start";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "end";
            // 
            // dateTimePickerEventStart
            // 
            this.dateTimePickerEventStart.CustomFormat = "hh:mm";
            this.dateTimePickerEventStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEventStart.Location = new System.Drawing.Point(4, 246);
            this.dateTimePickerEventStart.Name = "dateTimePickerEventStart";
            this.dateTimePickerEventStart.ShowUpDown = true;
            this.dateTimePickerEventStart.Size = new System.Drawing.Size(77, 20);
            this.dateTimePickerEventStart.TabIndex = 14;
            // 
            // dateTimePickerEventEnd
            // 
            this.dateTimePickerEventEnd.CustomFormat = "hh:mm";
            this.dateTimePickerEventEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEventEnd.Location = new System.Drawing.Point(165, 246);
            this.dateTimePickerEventEnd.Name = "dateTimePickerEventEnd";
            this.dateTimePickerEventEnd.ShowUpDown = true;
            this.dateTimePickerEventEnd.Size = new System.Drawing.Size(77, 20);
            this.dateTimePickerEventEnd.TabIndex = 15;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(241, 418);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(200, 100);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(192, 74);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 420);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.tabControl1.ResumeLayout(false);
            this.tabPageAddEvent.ResumeLayout(false);
            this.tabPageAddEvent.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAddEvent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEventDescription;
        private System.Windows.Forms.TextBox textBoxEventName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerEventDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxEventFacility;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerEventEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerEventStart;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
    }
}