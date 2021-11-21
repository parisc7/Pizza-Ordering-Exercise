using AjaxControlToolkit;
using DocumentFormat.OpenXml.Spreadsheet;
using SolrNet.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Ordering_Exercise
{
    public partial class Form1 : Form
    {
        public double totalPrice = 0;
        public DataGridView pizzaSizeDataGridView { get; }
        public SettingsForm SettingsForm = new SettingsForm();

        public Form1()
        {
            InitializeComponent();
            InitializeSizes();
            InitializeIngridients();
        }

        private void InitializeIngridients()
        {
            ingridientsFlowLayoutPanel.Controls.Clear();


            foreach (var ingridients in SettingsForm.pizzaIngridients.OrderBy(x => x.Name))
            {
                var ingridientsCheckBox = new CheckBox();
                {
                    Text = ingridients.Name;
                    Tag = ingridients;
                    AutoSize = true;
                };

                ingridientsCheckBox.CheckedChanged += IngridientsCheckBox_CheckedChanged;

                ingridientsFlowLayoutPanel.Controls.Add(ingridientsCheckBox);

            }
        }

        private void IngridientsCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            var ingridientsCheckBox = (sender as CheckBox);
            var ingridients = ingridientsCheckBox.Tag as PizzaSize;

            MessageBox.Show($"{ingridients.Name}{ingridients.Price} Checked : {ingridientsCheckBox.Checked}");
        }

        private void InitializeSizes()
        {
            sizeFlowLayoutPanel.Controls.Clear();


            foreach (var sizes in SettingsForm.pizzaSizes.OrderBy(x => x.Name))
            {
                var sizesRadioButton = new RadioButton();
                {
                    Text = sizes.Name;
                    Tag = sizes;
                    AutoSize = true;
                };

                sizesRadioButton.CheckedChanged += SizesRadioButton_CheckedChanged;

                sizeFlowLayoutPanel.Controls.Add(sizesRadioButton);

            }
        }

        private void SizesRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            var sizeRadioButton=(sender as RadioButton);
            var sizes = sizeRadioButton.Tag as PizzaSize;

            MessageBox.Show($"{sizes.Name}{sizes.Price} Checked : {sizeRadioButton.Checked}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
           



        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingForm = new SettingsForm();
            settingForm.ShowDialog();
        }

       
    }
}
