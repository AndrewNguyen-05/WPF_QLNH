using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for CardView.xaml
    /// </summary>
    public partial class FoodCardView : UserControl
    {
        public FoodCardView()
        {
            InitializeComponent();
        }

        private void ChangeImgButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                Uri uri = new Uri(ofd.FileName);
                Img.Source = new BitmapImage(uri);
            }
        }

        private void DelFoodButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
