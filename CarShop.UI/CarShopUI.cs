using CarClassLibrary;
using System;
using System.Windows.Forms;

namespace CarShop.UI
{
    public partial class CarShopUI : Form
    {
        Store myStore = new Store();

        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();



        public CarShopUI()
        {
            InitializeComponent();
        }

        private void CreateCarButton_Click(object sender, EventArgs e)
        {
            Car newCar = new Car(MakeBox.Text, ModelBox.Text, decimal.Parse(PriceBox.Text));
            //MessageBox.Show(newCar.ToString());
            myStore.CarList.Add(newCar);
            carInventoryBindingSource.ResetBindings(false);
        }



        private void CarsInInventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarShopUI_Load(object sender, EventArgs e)
        {
            carInventoryBindingSource.DataSource = myStore.CarList;
            CarsInInventoryListBox.DataSource = carInventoryBindingSource;
            CarsInInventoryListBox.DisplayMember = ToString();

            cartBindingSource.DataSource = myStore.ShoppingList;
            CarsInCartListBox.DataSource = cartBindingSource;
            CarsInCartListBox.DisplayMember = ToString();

        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            Car selectedCar = (Car)CarsInInventoryListBox.SelectedItem;
            myStore.ShoppingList.Add(selectedCar);
            cartBindingSource.ResetBindings(false);

        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            decimal totalPrice = myStore.Checkout();
            TotalPrice.Text = totalPrice.ToString();
            cartBindingSource.ResetBindings(false);
        }
    }
}
