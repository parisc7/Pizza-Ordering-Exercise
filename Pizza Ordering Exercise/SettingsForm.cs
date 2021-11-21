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
        const string PizzaIngridientsFile = "PizzaIngridientsFile_json";


        public SettingsForm()
        {
            InitializeComponent();
            LoadSizes();
            LoadIngridients();
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
            pizzaIngridients.Add(new Ingridients("Basil", 1));
            pizzaIngridients.Add(new Ingridients("Ham", 1));
            pizzaIngridients.Add(new Ingridients("Chicken", 1));
            pizzaIngridients.Add(new Ingridients("Oregano", 1));
            pizzaIngridients.Add(new Ingridients("Bacon", 1));
            pizzaIngridients.Add(new Ingridients("Garlic", 1));
            pizzaIngridients.Add(new Ingridients("Mozarella", 1));
            pizzaIngridients.Add(new Ingridients("Pepperoni", 1));
            pizzaIngridients.Add(new Ingridients("Tomato", 1));
            pizzaIngridients.Add(new Ingridients("Shrimps", 1));
            pizzaIngridients.Add(new Ingridients("Olives", 1));

            IngridientsDataGridView.DataSource = new BindingList<Ingridients>(pizzaIngridients);

        }



        private void sizesSaveButton_Click(object sender, EventArgs e)
        {
            SaveSize();
        }

        private void sizesResetButton_Click(object sender, EventArgs e)
        {
            LoadSizes();
        }

        private void SaveSize()
        {
            var serializedSize = JsonConvert.SerializeObject(pizzaSizes);
            File.WriteAllText(PizzaSizesFile, serializedSize, Encoding.UTF8);
            MessageBox.Show("Successfully saved the Pizza Sizes.", "Success", MessageBoxButtons.OK);
        }

        private void LoadSizes()
        {
            if(File.Exists(PizzaSizesFile))
            {
                var jsonString = File.ReadAllText(PizzaSizesFile);
                pizzaSizes = JsonConvert.DeserializeObject<List<PizzaSize>>(jsonString);
            }
            else
            {
                pizzaSizes.Clear();

                pizzaSizeDataGridView.DataSource = new BindingList<PizzaSize>(pizzaSizes);
            }
        }

        private void ingridientsSaveButton_Click(object sender, EventArgs e)
        {
            SaveIngridient();
        }

        private void SaveIngridient()
        {
            var serializedSize = JsonConvert.SerializeObject(pizzaIngridients);
            File.WriteAllText(PizzaIngridientsFile, serializedSize, Encoding.UTF8);
            MessageBox.Show("Successfully saved the Ingridients.", "Success", MessageBoxButtons.OK);

        }

        private void ingridientsResetButton_Click(object sender, EventArgs e)
        {
            LoadIngridients();
        }

        private void LoadIngridients()
        {
            if (File.Exists(PizzaIngridientsFile))
            {
                var jsonString = File.ReadAllText(PizzaIngridientsFile);
                pizzaIngridients = JsonConvert.DeserializeObject<List<Ingridients>>(jsonString);
            }
            else
            {
                pizzaIngridients.Clear();

                IngridientsDataGridView.DataSource = new BindingList<Ingridients>(pizzaIngridients);

            }
        }
    }
    
}
    