
namespace Pizza_Ordering_Exercise
{
    partial class MainForm
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
            this.OrderButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sizeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ingridientsGroupBox = new System.Windows.Forms.GroupBox();
            this.ingridientsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deliveryMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.freeIngridientsTextBox = new System.Windows.Forms.TextBox();
            this.clearFormButton = new System.Windows.Forms.Button();
            this.numOfIngridientsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.ingridientsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.LightGray;
            this.OrderButton.ForeColor = System.Drawing.Color.Chocolate;
            this.OrderButton.Location = new System.Drawing.Point(843, 302);
            this.OrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(103, 38);
            this.OrderButton.TabIndex = 0;
            this.OrderButton.Text = "Place &Order";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sizeFlowLayoutPanel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(28, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(226, 242);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // sizeFlowLayoutPanel
            // 
            this.sizeFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sizeFlowLayoutPanel.Location = new System.Drawing.Point(3, 17);
            this.sizeFlowLayoutPanel.Name = "sizeFlowLayoutPanel";
            this.sizeFlowLayoutPanel.Size = new System.Drawing.Size(220, 223);
            this.sizeFlowLayoutPanel.TabIndex = 0;
            // 
            // ingridientsGroupBox
            // 
            this.ingridientsGroupBox.Controls.Add(this.ingridientsFlowLayoutPanel);
            this.ingridientsGroupBox.Location = new System.Drawing.Point(259, 119);
            this.ingridientsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ingridientsGroupBox.Name = "ingridientsGroupBox";
            this.ingridientsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ingridientsGroupBox.Size = new System.Drawing.Size(465, 295);
            this.ingridientsGroupBox.TabIndex = 2;
            this.ingridientsGroupBox.TabStop = false;
            this.ingridientsGroupBox.Text = "Ingridients (Free Up to 3)";
            // 
            // ingridientsFlowLayoutPanel
            // 
            this.ingridientsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingridientsFlowLayoutPanel.Location = new System.Drawing.Point(3, 17);
            this.ingridientsFlowLayoutPanel.Name = "ingridientsFlowLayoutPanel";
            this.ingridientsFlowLayoutPanel.Size = new System.Drawing.Size(459, 276);
            this.ingridientsFlowLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welocme to PizzaMania";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(758, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Delivery Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(758, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Price:";
            // 
            // deliveryMaskedTextBox
            // 
            this.deliveryMaskedTextBox.BackColor = System.Drawing.Color.Chocolate;
            this.deliveryMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deliveryMaskedTextBox.Location = new System.Drawing.Point(953, 175);
            this.deliveryMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deliveryMaskedTextBox.Mask = "00:00";
            this.deliveryMaskedTextBox.Name = "deliveryMaskedTextBox";
            this.deliveryMaskedTextBox.Size = new System.Drawing.Size(48, 15);
            this.deliveryMaskedTextBox.TabIndex = 8;
            this.deliveryMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightGray;
            this.exitButton.ForeColor = System.Drawing.Color.Chocolate;
            this.exitButton.Location = new System.Drawing.Point(918, 374);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(103, 38);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.BackColor = System.Drawing.Color.Chocolate;
            this.totalPriceTextBox.Location = new System.Drawing.Point(953, 239);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(66, 22);
            this.totalPriceTextBox.TabIndex = 13;
            // 
            // freeIngridientsTextBox
            // 
            this.freeIngridientsTextBox.BackColor = System.Drawing.Color.Chocolate;
            this.freeIngridientsTextBox.Location = new System.Drawing.Point(953, 136);
            this.freeIngridientsTextBox.Name = "freeIngridientsTextBox";
            this.freeIngridientsTextBox.Size = new System.Drawing.Size(32, 22);
            this.freeIngridientsTextBox.TabIndex = 14;
            // 
            // clearFormButton
            // 
            this.clearFormButton.BackColor = System.Drawing.Color.LightGray;
            this.clearFormButton.ForeColor = System.Drawing.Color.Chocolate;
            this.clearFormButton.Location = new System.Drawing.Point(786, 374);
            this.clearFormButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.Size = new System.Drawing.Size(103, 38);
            this.clearFormButton.TabIndex = 11;
            this.clearFormButton.Text = "Clear";
            this.clearFormButton.UseVisualStyleBackColor = false;
            this.clearFormButton.Click += new System.EventHandler(this.clearFormButton_Click);
            // 
            // numOfIngridientsLabel
            // 
            this.numOfIngridientsLabel.AutoSize = true;
            this.numOfIngridientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfIngridientsLabel.Location = new System.Drawing.Point(759, 136);
            this.numOfIngridientsLabel.Name = "numOfIngridientsLabel";
            this.numOfIngridientsLabel.Size = new System.Drawing.Size(172, 18);
            this.numOfIngridientsLabel.TabIndex = 15;
            this.numOfIngridientsLabel.Text = "Number Of Ingridients";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pizza_Ordering_Exercise.Properties.Resources.pizza_hut_pepperoni_pizza;
            this.pictureBox1.Location = new System.Drawing.Point(864, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.manageUsersToolStripMenuItem.Text = "Manage &Users";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1046, 452);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ingridientsGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ingridientsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox deliveryMaskedTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.FlowLayoutPanel sizeFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ingridientsFlowLayoutPanel;
        private System.Windows.Forms.TextBox freeIngridientsTextBox;
        private System.Windows.Forms.Button clearFormButton;
        private System.Windows.Forms.Label numOfIngridientsLabel;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

