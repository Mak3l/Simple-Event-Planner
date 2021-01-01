namespace SkillsUSARegionalApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recallEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EventNameInputLabel = new System.Windows.Forms.Label();
            this.txtEventNameInput = new System.Windows.Forms.TextBox();
            this.gpbInput = new System.Windows.Forms.GroupBox();
            this.txtMinuteTimeInput = new System.Windows.Forms.TextBox();
            this.txtHourTimeInput = new System.Windows.Forms.TextBox();
            this.txtYearDateInput = new System.Windows.Forms.TextBox();
            this.txtDayDateInput = new System.Windows.Forms.TextBox();
            this.EventDateInputLabel = new System.Windows.Forms.Label();
            this.txtMonthDateInput = new System.Windows.Forms.TextBox();
            this.DateBGLabel = new System.Windows.Forms.Label();
            this.EventTimeInputLabel = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.gpbDisplay = new System.Windows.Forms.GroupBox();
            this.EventNameLabel = new System.Windows.Forms.Label();
            this.btnInformation = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.eventList = new System.Windows.Forms.CheckedListBox();
            this.gpbRetrieval = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.EventTimeLabel = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.EventDateLabel = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.EventNameRetrievalLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntrySearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gpbInput.SuspendLayout();
            this.gpbDisplay.SuspendLayout();
            this.gpbRetrieval.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEntryToolStripMenuItem,
            this.viewEntriesToolStripMenuItem,
            this.recallEntriesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newEntryToolStripMenuItem
            // 
            this.newEntryToolStripMenuItem.Name = "newEntryToolStripMenuItem";
            this.newEntryToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.newEntryToolStripMenuItem.Text = "&New Entry";
            this.newEntryToolStripMenuItem.Click += new System.EventHandler(this.newEntryToolStripMenuItem_Click);
            // 
            // viewEntriesToolStripMenuItem
            // 
            this.viewEntriesToolStripMenuItem.Name = "viewEntriesToolStripMenuItem";
            this.viewEntriesToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.viewEntriesToolStripMenuItem.Text = "&View Entries";
            this.viewEntriesToolStripMenuItem.Click += new System.EventHandler(this.viewEntriesToolStripMenuItem_Click);
            // 
            // recallEntriesToolStripMenuItem
            // 
            this.recallEntriesToolStripMenuItem.Name = "recallEntriesToolStripMenuItem";
            this.recallEntriesToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.recallEntriesToolStripMenuItem.Text = "&Recall Entries";
            this.recallEntriesToolStripMenuItem.Click += new System.EventHandler(this.recallEntriesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // EventNameInputLabel
            // 
            this.EventNameInputLabel.AutoSize = true;
            this.EventNameInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNameInputLabel.Location = new System.Drawing.Point(6, 36);
            this.EventNameInputLabel.Name = "EventNameInputLabel";
            this.EventNameInputLabel.Size = new System.Drawing.Size(178, 32);
            this.EventNameInputLabel.TabIndex = 1;
            this.EventNameInputLabel.Text = "Event Name:";
            this.EventNameInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEventNameInput
            // 
            this.txtEventNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventNameInput.Location = new System.Drawing.Point(190, 30);
            this.txtEventNameInput.Name = "txtEventNameInput";
            this.txtEventNameInput.Size = new System.Drawing.Size(414, 44);
            this.txtEventNameInput.TabIndex = 2;
            // 
            // gpbInput
            // 
            this.gpbInput.Controls.Add(this.txtMinuteTimeInput);
            this.gpbInput.Controls.Add(this.txtHourTimeInput);
            this.gpbInput.Controls.Add(this.txtYearDateInput);
            this.gpbInput.Controls.Add(this.txtDayDateInput);
            this.gpbInput.Controls.Add(this.EventDateInputLabel);
            this.gpbInput.Controls.Add(this.txtMonthDateInput);
            this.gpbInput.Controls.Add(this.EventNameInputLabel);
            this.gpbInput.Controls.Add(this.txtEventNameInput);
            this.gpbInput.Controls.Add(this.DateBGLabel);
            this.gpbInput.Controls.Add(this.EventTimeInputLabel);
            this.gpbInput.Controls.Add(this.btnClearAll);
            this.gpbInput.Controls.Add(this.btnEnter);
            this.gpbInput.Location = new System.Drawing.Point(12, 36);
            this.gpbInput.Name = "gpbInput";
            this.gpbInput.Size = new System.Drawing.Size(702, 254);
            this.gpbInput.TabIndex = 4;
            this.gpbInput.TabStop = false;
            this.gpbInput.Text = "New Entry";
            // 
            // txtMinuteTimeInput
            // 
            this.txtMinuteTimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinuteTimeInput.Location = new System.Drawing.Point(361, 134);
            this.txtMinuteTimeInput.MaxLength = 2;
            this.txtMinuteTimeInput.Name = "txtMinuteTimeInput";
            this.txtMinuteTimeInput.Size = new System.Drawing.Size(46, 44);
            this.txtMinuteTimeInput.TabIndex = 12;
            // 
            // txtHourTimeInput
            // 
            this.txtHourTimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourTimeInput.Location = new System.Drawing.Point(292, 134);
            this.txtHourTimeInput.MaxLength = 2;
            this.txtHourTimeInput.Name = "txtHourTimeInput";
            this.txtHourTimeInput.Size = new System.Drawing.Size(46, 44);
            this.txtHourTimeInput.TabIndex = 11;
            // 
            // txtYearDateInput
            // 
            this.txtYearDateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearDateInput.Location = new System.Drawing.Point(523, 80);
            this.txtYearDateInput.MaxLength = 4;
            this.txtYearDateInput.Name = "txtYearDateInput";
            this.txtYearDateInput.Size = new System.Drawing.Size(79, 44);
            this.txtYearDateInput.TabIndex = 10;
            // 
            // txtDayDateInput
            // 
            this.txtDayDateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDayDateInput.Location = new System.Drawing.Point(452, 80);
            this.txtDayDateInput.MaxLength = 2;
            this.txtDayDateInput.Name = "txtDayDateInput";
            this.txtDayDateInput.Size = new System.Drawing.Size(46, 44);
            this.txtDayDateInput.TabIndex = 7;
            // 
            // EventDateInputLabel
            // 
            this.EventDateInputLabel.AutoSize = true;
            this.EventDateInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDateInputLabel.Location = new System.Drawing.Point(6, 86);
            this.EventDateInputLabel.Name = "EventDateInputLabel";
            this.EventDateInputLabel.Size = new System.Drawing.Size(366, 32);
            this.EventDateInputLabel.TabIndex = 4;
            this.EventDateInputLabel.Text = "Event Date (MM/DD/YYYY):";
            this.EventDateInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMonthDateInput
            // 
            this.txtMonthDateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthDateInput.Location = new System.Drawing.Point(378, 80);
            this.txtMonthDateInput.MaxLength = 2;
            this.txtMonthDateInput.Name = "txtMonthDateInput";
            this.txtMonthDateInput.Size = new System.Drawing.Size(46, 44);
            this.txtMonthDateInput.TabIndex = 5;
            // 
            // DateBGLabel
            // 
            this.DateBGLabel.AutoSize = true;
            this.DateBGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBGLabel.Location = new System.Drawing.Point(427, 86);
            this.DateBGLabel.Name = "DateBGLabel";
            this.DateBGLabel.Size = new System.Drawing.Size(94, 32);
            this.DateBGLabel.TabIndex = 8;
            this.DateBGLabel.Text = "/         /";
            this.DateBGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventTimeInputLabel
            // 
            this.EventTimeInputLabel.AutoSize = true;
            this.EventTimeInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventTimeInputLabel.Location = new System.Drawing.Point(6, 140);
            this.EventTimeInputLabel.Name = "EventTimeInputLabel";
            this.EventTimeInputLabel.Size = new System.Drawing.Size(349, 32);
            this.EventTimeInputLabel.TabIndex = 9;
            this.EventTimeInputLabel.Text = "Event Time (HH/MM):        :";
            this.EventTimeInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(305, 199);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(184, 49);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(146, 199);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(153, 49);
            this.btnEnter.TabIndex = 14;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // gpbDisplay
            // 
            this.gpbDisplay.Controls.Add(this.EventNameLabel);
            this.gpbDisplay.Controls.Add(this.btnInformation);
            this.gpbDisplay.Controls.Add(this.btnDelete);
            this.gpbDisplay.Controls.Add(this.eventList);
            this.gpbDisplay.Location = new System.Drawing.Point(12, 36);
            this.gpbDisplay.Name = "gpbDisplay";
            this.gpbDisplay.Size = new System.Drawing.Size(702, 254);
            this.gpbDisplay.TabIndex = 6;
            this.gpbDisplay.TabStop = false;
            this.gpbDisplay.Text = "View Entries";
            // 
            // EventNameLabel
            // 
            this.EventNameLabel.AutoSize = true;
            this.EventNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNameLabel.Location = new System.Drawing.Point(6, 22);
            this.EventNameLabel.Name = "EventNameLabel";
            this.EventNameLabel.Size = new System.Drawing.Size(150, 29);
            this.EventNameLabel.TabIndex = 17;
            this.EventNameLabel.Text = "Event Name:";
            // 
            // btnInformation
            // 
            this.btnInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformation.Location = new System.Drawing.Point(165, 200);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(190, 49);
            this.btnInformation.TabIndex = 16;
            this.btnInformation.Text = "Information";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(6, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 49);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // eventList
            // 
            this.eventList.FormattingEnabled = true;
            this.eventList.Location = new System.Drawing.Point(6, 56);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(673, 142);
            this.eventList.TabIndex = 0;
            // 
            // gpbRetrieval
            // 
            this.gpbRetrieval.Controls.Add(this.lblTime);
            this.gpbRetrieval.Controls.Add(this.EventTimeLabel);
            this.gpbRetrieval.Controls.Add(this.lblDate);
            this.gpbRetrieval.Controls.Add(this.EventDateLabel);
            this.gpbRetrieval.Controls.Add(this.lblEventName);
            this.gpbRetrieval.Controls.Add(this.EventNameRetrievalLabel);
            this.gpbRetrieval.Controls.Add(this.label4);
            this.gpbRetrieval.Controls.Add(this.txtEntrySearch);
            this.gpbRetrieval.Controls.Add(this.btnSearch);
            this.gpbRetrieval.Location = new System.Drawing.Point(6, 36);
            this.gpbRetrieval.Name = "gpbRetrieval";
            this.gpbRetrieval.Size = new System.Drawing.Size(702, 254);
            this.gpbRetrieval.TabIndex = 5;
            this.gpbRetrieval.TabStop = false;
            this.gpbRetrieval.Text = "Recall";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(200, 181);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(2, 34);
            this.lblTime.TabIndex = 23;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventTimeLabel
            // 
            this.EventTimeLabel.AutoSize = true;
            this.EventTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventTimeLabel.Location = new System.Drawing.Point(28, 181);
            this.EventTimeLabel.Name = "EventTimeLabel";
            this.EventTimeLabel.Size = new System.Drawing.Size(166, 32);
            this.EventTimeLabel.TabIndex = 22;
            this.EventTimeLabel.Text = "Event Time:";
            this.EventTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(200, 137);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(2, 34);
            this.lblDate.TabIndex = 21;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventDateLabel
            // 
            this.EventDateLabel.AutoSize = true;
            this.EventDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDateLabel.Location = new System.Drawing.Point(38, 137);
            this.EventDateLabel.Name = "EventDateLabel";
            this.EventDateLabel.Size = new System.Drawing.Size(156, 32);
            this.EventDateLabel.TabIndex = 20;
            this.EventDateLabel.Text = "Entry Date:";
            this.EventDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(200, 92);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(2, 34);
            this.lblEventName.TabIndex = 19;
            this.lblEventName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventNameRetrievalLabel
            // 
            this.EventNameRetrievalLabel.AutoSize = true;
            this.EventNameRetrievalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNameRetrievalLabel.Location = new System.Drawing.Point(16, 92);
            this.EventNameRetrievalLabel.Name = "EventNameRetrievalLabel";
            this.EventNameRetrievalLabel.Size = new System.Drawing.Size(178, 32);
            this.EventNameRetrievalLabel.TabIndex = 18;
            this.EventNameRetrievalLabel.Text = "Event Name:";
            this.EventNameRetrievalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Entry Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEntrySearch
            // 
            this.txtEntrySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrySearch.Location = new System.Drawing.Point(190, 30);
            this.txtEntrySearch.Name = "txtEntrySearch";
            this.txtEntrySearch.Size = new System.Drawing.Size(331, 44);
            this.txtEntrySearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(527, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 49);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 302);
            this.Controls.Add(this.gpbRetrieval);
            this.Controls.Add(this.gpbDisplay);
            this.Controls.Add(this.gpbInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Tracker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbInput.ResumeLayout(false);
            this.gpbInput.PerformLayout();
            this.gpbDisplay.ResumeLayout(false);
            this.gpbDisplay.PerformLayout();
            this.gpbRetrieval.ResumeLayout(false);
            this.gpbRetrieval.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label EventNameInputLabel;
        private System.Windows.Forms.TextBox txtEventNameInput;
        private System.Windows.Forms.GroupBox gpbInput;
        private System.Windows.Forms.GroupBox gpbRetrieval;
        private System.Windows.Forms.GroupBox gpbDisplay;
        private System.Windows.Forms.TextBox txtDayDateInput;
        private System.Windows.Forms.Label EventDateInputLabel;
        private System.Windows.Forms.TextBox txtMonthDateInput;
        private System.Windows.Forms.Label DateBGLabel;
        private System.Windows.Forms.TextBox txtMinuteTimeInput;
        private System.Windows.Forms.TextBox txtHourTimeInput;
        private System.Windows.Forms.Label EventTimeInputLabel;
        private System.Windows.Forms.TextBox txtYearDateInput;
        private System.Windows.Forms.ToolStripMenuItem newEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEntriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recallEntriesToolStripMenuItem;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckedListBox eventList;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Label EventNameLabel;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label EventTimeLabel;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label EventDateLabel;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label EventNameRetrievalLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEntrySearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

