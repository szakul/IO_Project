namespace SportCenterManager
{
    partial class AdminWindow
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
            this.dateTimePickerEventEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEventStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxAdditionalInfo = new System.Windows.Forms.TextBox();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Starts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Decision = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.checkBoxAwaiting = new System.Windows.Forms.CheckBox();
            this.checkBoxAccepted = new System.Windows.Forms.CheckBox();
            this.checkBoxRejected = new System.Windows.Forms.CheckBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageAddEvent.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(546, 340);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAddEvent
            // 
            this.tabPageAddEvent.Controls.Add(this.dateTimePickerEventEnd);
            this.tabPageAddEvent.Controls.Add(this.dateTimePickerEventStart);
            this.tabPageAddEvent.Controls.Add(this.label8);
            this.tabPageAddEvent.Controls.Add(this.label7);
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
            this.tabPageAddEvent.Size = new System.Drawing.Size(538, 314);
            this.tabPageAddEvent.TabIndex = 0;
            this.tabPageAddEvent.Text = "Add event";
            this.tabPageAddEvent.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEventEnd
            // 
            this.dateTimePickerEventEnd.CustomFormat = "hh:mm";
            this.dateTimePickerEventEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEventEnd.Location = new System.Drawing.Point(473, 209);
            this.dateTimePickerEventEnd.Name = "dateTimePickerEventEnd";
            this.dateTimePickerEventEnd.ShowUpDown = true;
            this.dateTimePickerEventEnd.Size = new System.Drawing.Size(59, 20);
            this.dateTimePickerEventEnd.TabIndex = 15;
            // 
            // dateTimePickerEventStart
            // 
            this.dateTimePickerEventStart.CustomFormat = "hh:mm";
            this.dateTimePickerEventStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEventStart.Location = new System.Drawing.Point(322, 209);
            this.dateTimePickerEventStart.Name = "dateTimePickerEventStart";
            this.dateTimePickerEventStart.ShowUpDown = true;
            this.dateTimePickerEventStart.Size = new System.Drawing.Size(59, 20);
            this.dateTimePickerEventStart.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "end";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "start";
            // 
            // comboBoxEventFacility
            // 
            this.comboBoxEventFacility.FormattingEnabled = true;
            this.comboBoxEventFacility.Location = new System.Drawing.Point(4, 248);
            this.comboBoxEventFacility.Name = "comboBoxEventFacility";
            this.comboBoxEventFacility.Size = new System.Drawing.Size(528, 21);
            this.comboBoxEventFacility.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 232);
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
            this.dateTimePickerEventDate.Size = new System.Drawing.Size(233, 20);
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
            this.button1.Location = new System.Drawing.Point(4, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(528, 35);
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
            this.textBoxEventDescription.Size = new System.Drawing.Size(528, 132);
            this.textBoxEventDescription.TabIndex = 1;
            // 
            // textBoxEventName
            // 
            this.textBoxEventName.Location = new System.Drawing.Point(4, 19);
            this.textBoxEventName.Name = "textBoxEventName";
            this.textBoxEventName.Size = new System.Drawing.Size(528, 20);
            this.textBoxEventName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonRefresh);
            this.tabPage2.Controls.Add(this.checkBoxRejected);
            this.tabPage2.Controls.Add(this.checkBoxAccepted);
            this.tabPage2.Controls.Add(this.checkBoxAwaiting);
            this.tabPage2.Controls.Add(this.textBoxAdditionalInfo);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(538, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(538, 314);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "You are logged as Admin with ID = 1";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_,
            this.Type,
            this.Facility,
            this.Starts,
            this.Duration,
            this.Decision});
            this.dataGridView1.Location = new System.Drawing.Point(7, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxAdditionalInfo
            // 
            this.textBoxAdditionalInfo.Location = new System.Drawing.Point(7, 240);
            this.textBoxAdditionalInfo.Multiline = true;
            this.textBoxAdditionalInfo.Name = "textBoxAdditionalInfo";
            this.textBoxAdditionalInfo.Size = new System.Drawing.Size(358, 68);
            this.textBoxAdditionalInfo.TabIndex = 1;
            // 
            // Name_
            // 
            this.Name_.HeaderText = "Name_";
            this.Name_.Name = "Name_";
            this.Name_.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.FillWeight = 50F;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 50;
            // 
            // Facility
            // 
            this.Facility.FillWeight = 97F;
            this.Facility.HeaderText = "Facility";
            this.Facility.Name = "Facility";
            this.Facility.ReadOnly = true;
            this.Facility.Width = 97;
            // 
            // Starts
            // 
            this.Starts.HeaderText = "Starts";
            this.Starts.Name = "Starts";
            this.Starts.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.FillWeight = 55F;
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 55;
            // 
            // Decision
            // 
            this.Decision.FillWeight = 80F;
            this.Decision.HeaderText = "Decision";
            this.Decision.Name = "Decision";
            this.Decision.Width = 80;
            // 
            // checkBoxAwaiting
            // 
            this.checkBoxAwaiting.AutoSize = true;
            this.checkBoxAwaiting.Checked = true;
            this.checkBoxAwaiting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAwaiting.Location = new System.Drawing.Point(452, 240);
            this.checkBoxAwaiting.Name = "checkBoxAwaiting";
            this.checkBoxAwaiting.Size = new System.Drawing.Size(66, 17);
            this.checkBoxAwaiting.TabIndex = 2;
            this.checkBoxAwaiting.Text = "Awaiting";
            this.checkBoxAwaiting.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccepted
            // 
            this.checkBoxAccepted.AutoSize = true;
            this.checkBoxAccepted.Location = new System.Drawing.Point(452, 263);
            this.checkBoxAccepted.Name = "checkBoxAccepted";
            this.checkBoxAccepted.Size = new System.Drawing.Size(72, 17);
            this.checkBoxAccepted.TabIndex = 3;
            this.checkBoxAccepted.Text = "Accepted";
            this.checkBoxAccepted.UseVisualStyleBackColor = true;
            // 
            // checkBoxRejected
            // 
            this.checkBoxRejected.AutoSize = true;
            this.checkBoxRejected.Location = new System.Drawing.Point(452, 286);
            this.checkBoxRejected.Name = "checkBoxRejected";
            this.checkBoxRejected.Size = new System.Drawing.Size(69, 17);
            this.checkBoxRejected.TabIndex = 4;
            this.checkBoxRejected.Text = "Rejected";
            this.checkBoxRejected.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(371, 240);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 68);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 379);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminWindow";
            this.Text = "MainWindow";
            this.tabControl1.ResumeLayout(false);
            this.tabPageAddEvent.ResumeLayout(false);
            this.tabPageAddEvent.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimePickerEventEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerEventStart;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxAdditionalInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facility;
        private System.Windows.Forms.DataGridViewTextBoxColumn Starts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewComboBoxColumn Decision;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.CheckBox checkBoxRejected;
        private System.Windows.Forms.CheckBox checkBoxAccepted;
        private System.Windows.Forms.CheckBox checkBoxAwaiting;
    }
}