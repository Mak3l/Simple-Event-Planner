using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * SkillsUSA Regional Program
 * 
 */

namespace SkillsUSARegionalApp
{
    public partial class Form1 : Form
    {
        // Global Variables
        List<String> eventNames = new List<String>();
        List<String> dates = new List<String>();
        List<String> times = new List<String>();

        public Form1()
        {
            InitializeComponent();
            gpbInput.Visible = true;
            gpbDisplay.Visible = false;
            gpbRetrieval.Visible = false;
        }

        // Menu Strip Programming
        private void newEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clears the form and displays the new entry page
            clearEntries();
            gpbInput.Visible = true;
            gpbDisplay.Visible = false;
            gpbRetrieval.Visible = false;
        }
        private void viewEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays the View Entry page and loads the list of events into checkbox
            gpbDisplay.Visible = true;
            gpbInput.Visible = false;
            gpbRetrieval.Visible = false;

            eventList.Items.Clear();
            foreach (String events in eventNames) {
                eventList.Items.Add(events);
            }
        }
        private void recallEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays recall page
            gpbRetrieval.Visible = true;
            gpbInput.Visible = false;
            gpbDisplay.Visible = false;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By: Contestant 2333 for SkillsUSA Regional Competition Region 6.");
        }

        // Buttons Programming
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(txtMonthDateInput.Text) > 12 || Int32.Parse(txtMonthDateInput.Text) < 0)
            {
                MessageBox.Show("There are only 12 months in a year!");
                return;
            }
            if (Int32.Parse(txtMonthDateInput.Text) == 2)
            {
                if (Int32.Parse(txtDayDateInput.Text) > 28 || Int32.Parse(txtDayDateInput.Text) < 0)
                {
                    MessageBox.Show("Invalid number of days in that month!");
                    return;
                } 
            }
            else if (Int32.Parse(txtMonthDateInput.Text) % 2 == 1)
            {
                if (Int32.Parse(txtDayDateInput.Text) > 31 || Int32.Parse(txtDayDateInput.Text) < 0)
                {
                    MessageBox.Show("Invalid number of days in that month!");
                    return;
                }
            } else if(Int32.Parse(txtMonthDateInput.Text) % 2 == 0)
            {
                if (Int32.Parse(txtDayDateInput.Text) > 30 || Int32.Parse(txtDayDateInput.Text) < 0)
                {
                    MessageBox.Show("Invalid number of days in that month!");
                    return;
                }
            }
            if (Int32.Parse(txtHourTimeInput.Text) > 24 || Int32.Parse(txtHourTimeInput.Text) < 0)
            {
                MessageBox.Show("There are only 24 hours in a day!");
                return;
            }
            if (Int32.Parse(txtMinuteTimeInput.Text) > 59 || Int32.Parse(txtMinuteTimeInput.Text) < 0)
            {
                MessageBox.Show("There are only 60 minutes in an hour!");
                return;
            }
            // Sends name, date, and time to database
            eventNames.Add(txtEventNameInput.Text.ToString());
            String enterdate = txtMonthDateInput.Text + "/" + txtDayDateInput.Text + "/" + txtYearDateInput.Text;
            dates.Add(enterdate.ToString());
            String entertime = txtHourTimeInput.Text + ":" + txtMinuteTimeInput.Text;
            times.Add(entertime.ToString());
            MessageBox.Show("Successfully added entry.");
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            //Clears the input window
            clearEntries();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Searches through the list to see what is checked
            for (int i = 0; i < eventList.Items.Count; i++)
            {
                // If an item is checked
                if (eventList.GetItemChecked(i) == true)
                {
                    eventNames.RemoveAt(i);
                    dates.RemoveAt(i);
                    times.RemoveAt(i);
                    eventList.Items.RemoveAt(i);
                    MessageBox.Show("Successfully removed item.");
                }
            }
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            // Searches through the list to see what is checked
            for (int i = 0; i < eventList.Items.Count; i++)
            {
                // If an item is checked
                if (eventList.GetItemChecked(i))
                {
                    string name = (string)eventList.Items[i];
                    string date = (string)dates[i];
                    string time = (string)times[i];
                    MessageBox.Show("Event Name: " + name + "\nEvent Date: " + date + "\nEvent Time: " + time);
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Searches to find entry
            for (int i = 0; i < eventNames.Count; i++)
            {
                // If an item in list has the same name as the one in textbox
                if (eventNames[i] == txtEntrySearch.Text)
                {
                    lblEventName.Text = eventNames[i];
                    lblDate.Text = dates[i];
                    lblTime.Text = times[i];
                }
            }
        }

        // Custom Functions
        public void clearEntries()
        {
            txtEventNameInput.Text = "";
            txtMonthDateInput.Text = "";
            txtMinuteTimeInput.Text = "";
            txtDayDateInput.Text = "";
            txtYearDateInput.Text = "";
            txtHourTimeInput.Text = "";
        }
    }
}
