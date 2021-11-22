namespace Pizza_Ordering_Exercise
{
    partial class ManageUsersForm
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
            this.manageUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.addUserButton = new System.Windows.Forms.Button();
            this.resetUserButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.manageUsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // manageUsersDataGridView
            // 
            this.manageUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manageUsersDataGridView.Location = new System.Drawing.Point(93, 38);
            this.manageUsersDataGridView.Name = "manageUsersDataGridView";
            this.manageUsersDataGridView.RowHeadersWidth = 51;
            this.manageUsersDataGridView.RowTemplate.Height = 24;
            this.manageUsersDataGridView.Size = new System.Drawing.Size(620, 316);
            this.manageUsersDataGridView.TabIndex = 0;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(93, 402);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(117, 39);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Add New User";
            this.addUserButton.UseVisualStyleBackColor = true;
            // 
            // resetUserButton
            // 
            this.resetUserButton.Location = new System.Drawing.Point(352, 402);
            this.resetUserButton.Name = "resetUserButton";
            this.resetUserButton.Size = new System.Drawing.Size(104, 42);
            this.resetUserButton.TabIndex = 2;
            this.resetUserButton.Text = "Reset Record";
            this.resetUserButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(659, 403);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 40);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Record";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 487);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.resetUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.manageUsersDataGridView);
            this.Name = "ManageUsersForm";
            this.ShowIcon = false;
            this.Text = "Manage Users";
            ((System.ComponentModel.ISupportInitialize)(this.manageUsersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView manageUsersDataGridView;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button resetUserButton;
        private System.Windows.Forms.Button deleteButton;
    }
}