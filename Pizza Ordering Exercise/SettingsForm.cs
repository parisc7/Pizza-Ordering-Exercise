using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Ordering_Exercise
{
    
    public partial class SettingsForm : Form
    {
        public List<PizzaSize> pizzaSizes = new List<PizzaSize>();
        public List<Ingridients> pizzaIngridients = new List<Ingridients>();
        const string PizzaSizesFile = "PizzaFile_json";
        

        public SettingsForm()
        {
            InitializeComponent();
        }

       

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            

            pizzaSizes.Add(new PizzaSize("Small", 6.5, 2));
            pizzaSizes.Add(new PizzaSize("Medium", 9.25, 3));
            pizzaSizes.Add(new PizzaSize("Large", 12.00, 3));
            pizzaSizes.Add(new PizzaSize("XLarge", 13.75, 3));

            pizzaSizeDataGridView.DataSource = new BindingList<PizzaSize>(pizzaSizes);


            pizzaIngridients.Add(new Ingridients("Mushroom", 0.75));
            pizzaIngridients.Add(new Ingridients("Pepper", 1.25));
            pizzaIngridients.Add(new Ingridients("Onion", 1));

            IngridientsDataGridView.DataSource = new BindingList<Ingridients>(pizzaIngridients);


            var serializedSize = JsonConvert.SerializeObject(pizzaSizes);
            File.WriteAllText(PizzaSizesFile, serializedSize, Encoding.UTF8);


        }



        private void sizesSaveButton_Click(object sender, EventArgs e)
        {
            //SaveSize();
            MessageBox.Show("Successfully saved the Pizza Sizes.", "Success", MessageBoxButtons.OK);
        }

        private void sizesResetButton_Click(object sender, EventArgs e)
        {
           // LoadSizes();
        }
    }
    
}
    