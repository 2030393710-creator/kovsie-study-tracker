using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kovsie_study_and_assignment_tracker
{
    public partial class Form1 : Form
    {
        private List<Assignment> assignmentList = new List<Assignment>();

        public Form1()
        {
            InitializeComponent();
            SetupGridColumns();
            LoadData();
        }

        // 2. This sets up the columns in your DataGridView
        private void SetupGridColumns()
        {
            dgvAssignments.Columns.Clear();
            dgvAssignments.Columns.Add("ModuleName", "Module");
            dgvAssignments.Columns.Add("AssignmentName", "Assignment Name");
            dgvAssignments.Columns.Add("DueDate", "Due Date");
            dgvAssignments.Columns.Add("Status", "Status");
            dgvAssignments.Columns.Add("Overdue", "Overdue?");
        }

        // 3. This triggers when you click your "Add Assignment" button
        private void btnAddAssignment_Click(object sender, EventArgs e)
        {
            // Simple validation check
            if (string.IsNullOrWhiteSpace(txtAssignmentName.Text) || cmbModule.SelectedItem == null)
            {
                MessageBox.Show("Please fill in the Assignment Name and select a Module!", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new assignment object from the inputs
            Assignment newAssignment = new Assignment
            {
                ModuleName = cmbModule.SelectedItem.ToString(),
                AssignmentName = txtAssignmentName.Text,
                DueDate = dtpDueDate.Value.Date,
                IsCompleted = false
            };

            // Add it to our list database
            assignmentList.Add(newAssignment);

            // Refresh the display grid table
            RefreshGrid();

            // FIXED HERE: We added the trigger to save to the file right after adding an assignment!
            SaveData();

            // Clear inputs for the next entry
            txtAssignmentName.Clear();
        }

        // 4. This updates the table grid and highlights overdue items
        private void RefreshGrid()
        {
            dgvAssignments.Rows.Clear();

            foreach (var asm in assignmentList)
            {
                string statusText = asm.IsCompleted ? "Completed" : "Pending";

                // Determine if it is overdue (Past today's date and not completed)
                bool isOverdue = !asm.IsCompleted && (asm.DueDate < DateTime.Today);
                string overdueText = isOverdue ? "YES" : "No";

                int rowIndex = dgvAssignments.Rows.Add(asm.ModuleName, asm.AssignmentName, asm.DueDate.ToShortDateString(), statusText, overdueText);

                // Highlight overdue items in soft red
                if (isOverdue)
                {
                    dgvAssignments.Rows[rowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
                    dgvAssignments.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                }
            }
        }

        // Saves the current list to a text file on your PC
        private void SaveData()
        {
            try
            {
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter("assignments.txt"))
                {
                    foreach (var asm in assignmentList)
                    {
                        writer.WriteLine($"{asm.ModuleName}|{asm.AssignmentName}|{asm.DueDate.ToString("yyyy-MM-dd")}|{asm.IsCompleted}");
                    }
                }
            }
            catch { /* Ignore errors silently to keep app running smoothly */ }
        }


        // Loads the data back when the app starts up
        private void LoadData()
        {
            try
            {
                if (System.IO.File.Exists("assignments.txt"))
                {
                    assignmentList.Clear();
                    string[] lines = System.IO.File.ReadAllLines("assignments.txt");
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 4)
                        {
                            assignmentList.Add(new Assignment
                            {
                                ModuleName = parts[0],
                                AssignmentName = parts[1],
                                DueDate = DateTime.Parse(parts[2]),
                                IsCompleted = bool.Parse(parts[3])
                            });
                        }
                    }
                    RefreshGrid();
                }
            }
            catch { /* Ignore errors silently */ }
        }

        private void btnMarkButton_Click(object sender, EventArgs e)
        {
            // Check if the student has actually selected a row in the table grid
            if (dgvAssignments.CurrentRow != null && dgvAssignments.CurrentRow.Index >= 0)
            {
                // Get the index number of the row they clicked on
                int selectedIndex = dgvAssignments.CurrentRow.Index;

                // Make sure the index matches an item in our list database
                if (selectedIndex < assignmentList.Count)
                {
                    // Flip the status to true!
                    assignmentList[selectedIndex].IsCompleted = true;

                    // Refresh the table grid to update colors and text immediately
                    RefreshGrid();

                    //  the trigger to save to the file right after marking completed!
                    SaveData();
                }
            }
        }

        // 5. The Assignment Blueprint class
        public class Assignment
        {
            public string ModuleName { get; set; }
            public string AssignmentName { get; set; }
            public DateTime DueDate { get; set; }
            public bool IsCompleted { get; set; }
        }
    }
}
    
