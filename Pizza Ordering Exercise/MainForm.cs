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
    public partial class MainForm : Form
    {
        public int counts = 0;
        public int numberOfIngridients;
        public int notThat;
        public double totalPrice = 0.0;
        public double firstPrice = 0.0;
        public DataGridView pizzaSizeDataGridView { get; }
        public SettingsForm SettingsForm = new SettingsForm();

        SettingsForm settingForm = new SettingsForm();

        public MainForm()
        {
            InitializeComponent();
            ShowButtons();
        }
        private void ShowButtons()
        {

            ingridientsFlowLayoutPanel.Controls.Clear();
            sizeFlowLayoutPanel.Controls.Clear();


            foreach (var ingridients in SettingsForm.pizzaIngridients.OrderBy(x => x.Name))
            {
                var ingridientsCheckBox = new CheckBox();

                ingridientsCheckBox.Text = ingridients.Name;
                ingridientsCheckBox.Tag = ingridients;
                ingridientsCheckBox.AutoSize = true;
                
                ingridientsCheckBox.CheckedChanged += IngridientsCheckBox_CheckedChanged;

                ingridientsFlowLayoutPanel.Controls.Add(ingridientsCheckBox);

            }

            foreach (var sizes in SettingsForm.pizzaSizes)
            {
                var sizesRadioButton = new RadioButton();
               
                sizesRadioButton.Text = sizes.Name;
                sizesRadioButton.Tag = sizes;
                sizesRadioButton.AutoSize = true;
                
                sizesRadioButton.CheckedChanged += SizesRadioButton_CheckedChanged;

                sizeFlowLayoutPanel.Controls.Add(sizesRadioButton);

            }
        }

        private void IngridientsCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            var ingridientsCheckBox = (sender as CheckBox);
            var ingridients = ingridientsCheckBox.Tag as PizzaSize;
            double extraIngridient = 0.0;

            if(ingridientsCheckBox.Checked == true)
            {
                counts++;
            }
            else if (ingridientsCheckBox.Checked == false)
            {
                counts--;
            }

            if(counts>numberOfIngridients)
            {
                extraIngridient = ingridients.Price;
                notThat = counts - numberOfIngridients;
                if(notThat>0)
                {
                    extraIngridient = notThat * ingridients.Price;
                }
                totalPrice = firstPrice + extraIngridient;
            }
            else
            {
                totalPrice = firstPrice;
            }

            totalPriceTextBox.Text=totalPrice.ToString("C");

            //   MessageBox.Show($"{ingridients.Name}{ingridients.Price} Checked : {ingridientsCheckBox.Checked}");
        }

        private void SizesRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            var sizeRadioButton=(sender as RadioButton);
            var sizes = sizeRadioButton.Tag as PizzaSize;

            numberOfIngridients = sizes.FreeIngridientCount;
            firstPrice = sizes.Price;
            totalPrice = firstPrice;
            totalPriceTextBox.Text = totalPrice.ToString("C");
            freeIngridientsTextBox.Text=sizes.FreeIngridientCount.ToString();
            totalPrice = firstPrice;
            OrderButton.Visible = true;
            ingridientsGroupBox.Enabled = true;

           // MessageBox.Show($"{sizes.Name}{sizes.Price} Checked : {sizeRadioButton.Checked}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
           var time24 = DateTime.Now.TimeOfDay.ToString();
            deliveryMaskedTextBox.Text = time24;

            bool parse;

            parse = TimeSpan.TryParse(deliveryMaskedTextBox.Text, out TimeSpan deliveryTime);

            if (parse)
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show($"The Total Price for your Pizza is {totalPrice.ToString("C")}, the delivery time is {deliveryMaskedTextBox.Text}).\n Accept the Order?",
                    "Order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Order Complete!", "ORDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The Order is cancelled", "ORDER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wrong Format!", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clearFormButton_Click(object sender, EventArgs e)
        {
            ShowButtons();
            counts = 0;
            ingridientsGroupBox.Enabled=false;
            freeIngridientsTextBox.Text = "";
            totalPriceTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SettingsForm settingForm = new SettingsForm();
            settingForm.ShowDialog();
            ShowButtons();
        }

    }
}
