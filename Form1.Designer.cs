
namespace kovsie_study_and_assignment_tracker
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
            this.txtAssignmentName = new System.Windows.Forms.TextBox();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.lblAssignment = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.btnAddAssignment = new System.Windows.Forms.Button();
            this.btnMarkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAssignmentName
            // 
            this.txtAssignmentName.Location = new System.Drawing.Point(112, 15);
            this.txtAssignmentName.Name = "txtAssignmentName";
            this.txtAssignmentName.Size = new System.Drawing.Size(100, 20);
            this.txtAssignmentName.TabIndex = 0;
            // 
            // cmbModule
            // 
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Items.AddRange(new object[] {
            "CSIS1644",
            "EBSC1524",
            "EIOP1524",
            "BCIS1623"});
            this.cmbModule.Location = new System.Drawing.Point(112, 38);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(121, 21);
            this.cmbModule.TabIndex = 1;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(112, 65);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDueDate.TabIndex = 2;
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignments.Location = new System.Drawing.Point(4, 204);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.Size = new System.Drawing.Size(784, 246);
            this.dgvAssignments.TabIndex = 3;
            // 
            // lblAssignment
            // 
            this.lblAssignment.AutoSize = true;
            this.lblAssignment.Location = new System.Drawing.Point(12, 15);
            this.lblAssignment.Name = "lblAssignment";
            this.lblAssignment.Size = new System.Drawing.Size(95, 13);
            this.lblAssignment.TabIndex = 4;
            this.lblAssignment.Text = "Assignment Name:";
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(15, 38);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(45, 13);
            this.lblModule.TabIndex = 5;
            this.lblModule.Text = "Module:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(15, 65);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(56, 13);
            this.lblDueDate.TabIndex = 6;
            this.lblDueDate.Text = "Due Date:";
            // 
            // btnAddAssignment
            // 
            this.btnAddAssignment.Location = new System.Drawing.Point(320, 131);
            this.btnAddAssignment.Name = "btnAddAssignment";
            this.btnAddAssignment.Size = new System.Drawing.Size(101, 23);
            this.btnAddAssignment.TabIndex = 7;
            this.btnAddAssignment.Text = "Add Assignment";
            this.btnAddAssignment.UseVisualStyleBackColor = true;
            this.btnAddAssignment.Click += new System.EventHandler(this.btnAddAssignment_Click);
            // 
            // btnMarkButton
            // 
            this.btnMarkButton.Location = new System.Drawing.Point(320, 161);
            this.btnMarkButton.Name = "btnMarkButton";
            this.btnMarkButton.Size = new System.Drawing.Size(101, 23);
            this.btnMarkButton.TabIndex = 8;
            this.btnMarkButton.Text = "Mark As Complete";
            this.btnMarkButton.UseVisualStyleBackColor = true;
            this.btnMarkButton.Click += new System.EventHandler(this.btnMarkButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMarkButton);
            this.Controls.Add(this.btnAddAssignment);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lblAssignment);
            this.Controls.Add(this.dgvAssignments);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.cmbModule);
            this.Controls.Add(this.txtAssignmentName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAssignmentName;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.Label lblAssignment;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Button btnAddAssignment;
        private System.Windows.Forms.Button btnMarkButton;
    }
}

