using DocumentFormat.OpenXml.Spreadsheet;
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


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
          for(int i =0; i < 4; i++)
            {
                RadioButton radioButton = new RadioButton();

                radioButton.Text = $"";



                priceFlowLayoutPanel.Controls.Add(radioButton);


            }

          for(int j =0; j < 10; j++)
            {
                CheckBox checkBox = new CheckBox();

                checkBox.Text = $"";



                ingridientsFlowLayoutPanel.Controls.Add(checkBox);
            }

        }

       

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (sender as CheckBox);

            MessageBox.Show(checkBox.Text + " : " + checkBox.Checked);
        }

         private void settingsButton_Click(object sender, EventArgs e)
        {
         
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            /*/Pizza Ingridients selection

            if (basilCheckBox.Checked==true)
            {
                ListViewItem ingridient = new ListViewItem(" Basil");
                ingridient.SubItems.Add("");
                ingridient.SubItems.Add("0.75");
                listView1.Items.Add(ingridient);
            }
            if (blackOlivesCheckBox.Checked == true)
            {
                ListViewItem ingridient = new ListViewItem(" Black Olives");
                ingridient.SubItems.Add("");
                ingridient.SubItems.Add("0.75");
                listView1.Items.Add(ingridient);
            }
            if (chickenCheckBox.Checked == true)
            {
                ListViewItem ingridient = new ListViewItem(" Chicken");
                ingridient.SubItems.Add("");
                ingridient.SubItems.Add("0.75");
                listView1.Items.Add(ingridient);
            }
            if (crushedRedPepperCheckBox.Checked == true)
            {
                ListViewItem ingridient = new ListViewItem(" Crushed Red Pepper");
                ingridient.SubItems.Add("");
                ingridient.SubItems.Add("0.75");
                listView1.Items.Add(ingridient);
            }
            if (eggCheckBox.Checked == true)
            {
                ListViewItem ingridient = new ListViewItem(" Egg");
                ingridient.SubItems.Add("");
                ingridient.SubItems.Add("0.75");
                listView1.Items.Add(ingridient);
            }
            if (eggplantCheckBox.Checked == true)
            {
                ListViewItem ingridient = new ListViewItem(" Eggplant");
                ingridient.SubItems.Add("");
                ingridient.SubItems.Add("0.75");
                listView1.Items.Add(ingridient);
            }
            if (garlicCheckBox.Checked == true)
            {
                ListViewItem ingridient = new ListViewItem(" Garlic");
                ingridient.SubItems.Add("");
                ingridient.SubItems.Add("0.75");
                listView1.Items.Add(ingridient);
            }
            if (greenBellPepperCheckBox.Checked == true)
            {
                ListViewItem ingridient = new ListViewItem(" Green Bell Pepper");
                ingridient.SubItems.Add("");
                ingridient.SubItems.Add("0.75");
                listView1.Items.Add(ingridient);
            }
            if (hotSauceCheckBox.Checked == true)
            {
                ListViewItem ingridient = new ListViewItem(" Hot Sauce");
                ingridient.SubItems.Add("");
                ingridient.SubItems.Add("0.75");
                listView1.Items.Add(ingridient);
            }
            if (jalapenoCheckBox.Checked == true)
            {
                ListViewItem ingridient = new ListViewItem(" Jalapeno");
                ingridient.SubItems.Add("");
                ingridient.SubItems.Add("0.75");
                listView1.Items.Add(ingridient);
            }
            if (mozarellaCheckBox.Checked == true)
            {
                ListViewItem ingridient = new ListViewItem(" Mozarella");
                ingridient.SubItems.Add("");
                ingridient.SubItems.Add("0.75");
                listView1.Items.Add(ingridient);
            }
            if (mushroomCheckBox.Checked == true)
            {
                ListViewItem ingridient = new ListViewItem(" Mushroom");
                ingridient.SubItems.Add("");
                ingridient.SubItems.Add("0.75");
                listView1.Items.Add(ingridient);
            }
            if (oliveOilCheckBox.Checked == true)
            {
                ListViewItem ingridient = new ListViewItem(" Olive Oil");
                ingridient.SubItems.Add("");
                ingridient.SubItems.Add("0.75");
                listView1.Items.Add(ingridient);
            }
            if (onionCheckBox.Checked == true)
            {
                ListViewItem ingridient = new ListViewItem(" Onion");
                ingridient.SubItems.Add("");
                ingridient.SubItems.Add("0.75");
                listView1.Items.Add(ingridient);
            }
            if (oreganoCheckBox.Checked == true)
            {
                ListViewItem ingridient = new ListViewItem(" Oregano");
                ingridient.SubItems.Add("");
                ingridient.SubItems.Add("0.75");
                listView1.Items.Add(ingridient);
            }
            if (parmigianoCheckBox.Checked == true)
            {
                ListViewItem ingridient = new ListViewItem(" Parmigiano-Reggiano");
                ingridient.SubItems.Add("");
                ingridient.SubItems.Add("0.75");
                listView1.Items.Add(ingridient);
            }

            */


            foreach (ListViewItem item in listView1.Items)
            {
                totalPrice += Convert.ToDouble(item.SubItems[2].Text);
            }

            string amount = totalPrice.ToString("c2");

            totalPriceTextBox.Text = amount;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingForm = new SettingsForm();
            settingForm.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
