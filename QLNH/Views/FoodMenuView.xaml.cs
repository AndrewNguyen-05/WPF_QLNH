using QLNH.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QLNH.Views
{
    /// <summary>
    /// Interaction logic for FoodMenuView.xaml
    /// </summary>
    public partial class FoodMenuView : UserControl
    {
        public FoodMenuView()
        {
            InitializeComponent();
        }
        private void AddFoodButton_Click(object sender, RoutedEventArgs e)
        {
            FoodCardView fcv = new FoodCardView();
            Thickness margin = fcv.Margin;
            margin.Left = margin.Right = 17;
            fcv.Margin = margin;
            FoodCardHolder.Children.Add(fcv);
        }
    }
}
