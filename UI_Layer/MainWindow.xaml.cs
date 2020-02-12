using System.Windows;
using Functions_Layer;
using Database_Layer;
using Item_Layer;
using System.Data;
using System;

namespace UI_Layer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Show_All_Button_Click(object sender, RoutedEventArgs e)
        {
            FL itemFL = new FL();
            Item item = new Item();
            DataTable dTable = new DataTable();
            dTable = itemFL.GetAllItems(item);
            Data_Grid.ItemsSource = dTable.AsDataView();
        }

        private void Search_ID_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(id_TextBox.Text);
            FL itemFL = new FL();
            Item item = new Item();
            DataTable dTable = new DataTable();
            dTable = itemFL.GetItemByID(id);
            Data_Grid.ItemsSource = dTable.AsDataView();
        }

        private void Combined_Value_Button_Click(object sender, RoutedEventArgs e)
        {
            FL fl = new FL();
            Item item = new Item();
            DataTable dTable = new DataTable();
            dTable = fl.GetTotalPrice();
            Data_Grid.ItemsSource = dTable.AsDataView();
        }

        private void Search_Above_Below_AVG_Button_Click(object sender, RoutedEventArgs e)
        {
            FL fl = new FL();
            Item item = new Item();
            DataTable dTable = new DataTable();
            avgPriceLabel.Content = fl.GetAveragePrice();
            if (lessEqualRadioButton.IsChecked == true)
            {
                dTable = fl.GetByPriceLessThanAVG();
                Data_Grid.ItemsSource = dTable.AsDataView();
            }
            else if (moreEqualRadioButton.IsChecked == true)
            {
                dTable = fl.GetByPriceMoreThanAVG();
                Data_Grid.ItemsSource = dTable.AsDataView();
            }
            else return;
        }
        private void Search_Parametrized_Click(object sender, RoutedEventArgs e)
        {
            //int amount = 0;
            //int rgb = 0;
            //double price = 0;
            //string type = "";

            //if (amount_TextBox.Text.Length != 0) amount = Convert.ToInt32(amount_TextBox.Text);
            //else amount = 0;
            //if (rgb_TextBox.Text.Length != 0)
            //{
            //    if (int.Parse(rgb_TextBox.Text) == 0) rgb = 0;
            //    else if (int.Parse(rgb_TextBox.Text) == 1) rgb = 1;
            //    else rgb = 2;
            //}
            //else rgb = 2;
            //if (price_TextBox.Text.Length != 0) price = Convert.ToInt32(price_TextBox.Text);
            //else price = 0;
            //if (type_TextBox.Text.Length != 0) type = type_TextBox.Text;

            //FL fl = new FL();
            //Item item = new Item();
            //DataTable dTable = new DataTable();
            //dTable = fl.GetByParameters(amount, price, rgb, type);
            //Data_Grid.ItemsSource = dTable.AsDataView();
        }
    }
}
