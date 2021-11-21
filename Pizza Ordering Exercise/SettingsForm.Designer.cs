
namespace Pizza_Ordering_Exercise
{
    partial class SettingsForm
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
            this.sizesGroupBox = new System.Windows.Forms.GroupBox();
            this.sizesResetButton = new System.Windows.Forms.Button();
            this.sizesSaveButton = new System.Windows.Forms.Button();
            this.pizzaSizeDataGridView = new System.Windows.Forms.DataGridView();
            this.IngridientsGroupBox = new System.Windows.Forms.GroupBox();
            this.ingridientsResetButton = new System.Windows.Forms.Button();
            this.ingridientsSaveButton = new System.Windows.Forms.Button();
            this.IngridientsDataGridView = new System.Windows.Forms.DataGridView();
            this.sizesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaSizeDataGridView)).BeginInit();
            this.IngridientsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IngridientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sizesGroupBox
            // 
            this.sizesGroupBox.Controls.Add(this.sizesResetButton);
            this.sizesGroupBox.Controls.Add(this.sizesSaveButton);
            this.sizesGroupBox.Controls.Add(this.pizzaSizeDataGridView);
            this.sizesGroupBox.Location = new System.Drawing.Point(12, 25);
            this.sizesGroupBox.Name = "sizesGroupBox";
            this.sizesGroupBox.Size = new System.Drawing.Size(522, 514);
            this.sizesGroupBox.TabIndex = 0;
            this.sizesGroupBox.TabStop = false;
            this.sizesGroupBox.Text = "Sizes";
            // 
            // sizesResetButton
            // 
            this.sizesResetButton.Location = new System.Drawing.Point(250, 467);
            this.sizesResetButton.Name = "sizesResetButton";
            this.sizesResetButton.Size = new System.Drawing.Size(138, 41);
            this.sizesResetButton.TabIndex = 2;
            this.sizesResetButton.Text = "&Reset";
            this.sizesResetButton.UseVisualStyleBackColor = true;
            this.sizesResetButton.Click += new System.EventHandler(this.sizesResetButton_Click);
            // 
            // sizesSaveButton
            // 
            this.sizesSaveButton.Location = new System.Drawing.Point(87, 467);
            this.sizesSaveButton.Name = "sizesSaveButton";
            this.sizesSaveButton.Size = new System.Drawing.Size(138, 41);
            this.sizesSaveButton.TabIndex = 1;
            this.sizesSaveButton.Text = "&Save";
            this.sizesSaveButton.UseVisualStyleBackColor = true;
            this.sizesSaveButton.Click += new System.EventHandler(this.sizesSaveButton_Click);
            // 
            // pizzaSizeDataGridView
            // 
            this.pizzaSizeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pizzaSizeDataGridView.Location = new System.Drawing.Point(6, 21);
            this.pizzaSizeDataGridView.Name = "pizzaSizeDataGridView";
            this.pizzaSizeDataGridView.RowHeadersWidth = 51;
            this.pizzaSizeDataGridView.RowTemplate.Height = 24;
            this.pizzaSizeDataGridView.Size = new System.Drawing.Size(510, 421);
            this.pizzaSizeDataGridView.TabIndex = 0;
            // 
            // IngridientsGroupBox
            // 
            this.IngridientsGroupBox.Controls.Add(this.ingridientsResetButton);
            this.IngridientsGroupBox.Controls.Add(this.ingridientsSaveButton);
            this.IngridientsGroupBox.Controls.Add(this.IngridientsDataGridView);
            this.IngridientsGroupBox.Location = new System.Drawing.Point(561, 25);
            this.IngridientsGroupBox.Name = "IngridientsGroupBox";
            this.IngridientsGroupBox.Size = new System.Drawing.Size(554, 514);
            this.IngridientsGroupBox.TabIndex = 1;
            this.IngridientsGroupBox.TabStop = false;
            this.IngridientsGroupBox.Text = "Ingridients";
            // 
            // ingridientsResetButton
            // 
            this.ingridientsResetButton.Location = new System.Drawing.Point(328, 467);
            this.ingridientsResetButton.Name = "ingridientsResetButton";
            this.ingridientsResetButton.Size = new System.Drawing.Size(120, 41);
            this.ingridientsResetButton.TabIndex = 2;
            this.ingridientsResetButton.Text = "&Reset";
            this.ingridientsResetButton.UseVisualStyleBackColor = true;
            // 
            // ingridientsSaveButton
            // 
            this.ingridientsSaveButton.Location = new System.Drawing.Point(157, 467);
            this.ingridientsSaveButton.Name = "ingridientsSaveButton";
            this.ingridientsSaveButton.Size = new System.Drawing.Size(130, 41);
            this.ingridientsSaveButton.TabIndex = 1;
            this.ingridientsSaveButton.Text = "&Save";
            this.ingridientsSaveButton.UseVisualStyleBackColor = true;
            // 
            // IngridientsDataGridView
            // 
            this.IngridientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngridientsDataGridView.Location = new System.Drawing.Point(6, 21);
            this.IngridientsDataGridView.Name = "IngridientsDataGridView";
            this.IngridientsDataGridView.RowHeadersWidth = 51;
            this.IngridientsDataGridView.RowTemplate.Height = 24;
            this.IngridientsDataGridView.Size = new System.Drawing.Size(542, 421);
            this.IngridientsDataGridView.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 551);
            this.Controls.Add(this.IngridientsGroupBox);
            this.Controls.Add(this.sizesGroupBox);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.sizesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pizzaSizeDataGridView)).EndInit();
            this.IngridientsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IngridientsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sizesGroupBox;
        private System.Windows.Forms.Button sizesResetButton;
        private System.Windows.Forms.Button sizesSaveButton;
        private System.Windows.Forms.DataGridView pizzaSizeDataGridView;
        private System.Windows.Forms.GroupBox IngridientsGroupBox;
        private System.Windows.Forms.Button ingridientsResetButton;
        private System.Windows.Forms.Button ingridientsSaveButton;
        private System.Windows.Forms.DataGridView IngridientsDataGridView;
       
    }
}