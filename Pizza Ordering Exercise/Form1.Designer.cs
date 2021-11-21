
namespace Pizza_Ordering_Exercise
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
            this.OrderButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.priceFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ingridientsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.SeaShell;
            this.OrderButton.Location = new System.Drawing.Point(843, 337);
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
            this.groupBox1.Controls.Add(this.priceFlowLayoutPanel);
            this.groupBox1.Location = new System.Drawing.Point(28, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(226, 242);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ingridientsFlowLayoutPanel);
            this.groupBox2.Location = new System.Drawing.Point(259, 119);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(465, 295);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingridients (Free Up to 3)";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welocme to PizzaMania";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(759, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Delivery Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(759, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Price:";
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Location = new System.Drawing.Point(864, 176);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(82, 15);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(313, 23);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(103, 37);
            this.settingsButton.TabIndex = 9;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.SeaShell;
            this.exitButton.Location = new System.Drawing.Point(843, 393);
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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(864, 239);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalPriceTextBox.TabIndex = 13;
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem1.Text = "&Settings";
            // 
            // priceFlowLayoutPanel
            // 
            this.priceFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.priceFlowLayoutPanel.Location = new System.Drawing.Point(3, 17);
            this.priceFlowLayoutPanel.Name = "priceFlowLayoutPanel";
            this.priceFlowLayoutPanel.Size = new System.Drawing.Size(220, 223);
            this.priceFlowLayoutPanel.TabIndex = 0;
            // 
            // ingridientsFlowLayoutPanel
            // 
            this.ingridientsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingridientsFlowLayoutPanel.Location = new System.Drawing.Point(3, 17);
            this.ingridientsFlowLayoutPanel.Name = "ingridientsFlowLayoutPanel";
            this.ingridientsFlowLayoutPanel.Size = new System.Drawing.Size(459, 276);
            this.ingridientsFlowLayoutPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1044, 480);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel priceFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ingridientsFlowLayoutPanel;
    }
}

