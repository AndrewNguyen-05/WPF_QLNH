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
using static System.Net.Mime.MediaTypeNames;

namespace QLNH.Views
{
    /// <summary>
    /// Interaction logic for MenuBar.xaml
    /// </summary>
    public partial class MenuBarViews : UserControl
    {
        public FoodMenuView foodMenu { get; set; }
        public DashboardMenuView dashboardMenu { get; set; }
        public TableMenuView tableMenu { get; set; }
        public EmployeeMenuView employeeMenu { get; set; }
        public WarehouseMenuView warehouseMenu { get; set; }
        public MenuBarViews()
        {
            InitializeComponent();
            CheckCurrent();
            foodMenu = new FoodMenuView();
            dashboardMenu = new DashboardMenuView();
            tableMenu = new TableMenuView();
            employeeMenu = new EmployeeMenuView();
            warehouseMenu = new WarehouseMenuView();
        }
        private void CheckCurrent()
        {
            foreach (MenuBarButtonViews x in MenuButtonStack.Children)
            {
                if (x.IsChecked == "True")
                {
                    Uri uri = new Uri(x.ImgDirectory, UriKind.RelativeOrAbsolute);
                    ImageSource imgSource = new BitmapImage(uri);
                    CurrentImg.Source = imgSource;
                    CurrentTitle.Text = x.Title;
                    //CurrentMain
                    break;
                }
            }
        }
        private void ChangeMenu(object sender)
        {
            CurrentMain.Children.Clear();
            MenuBarButtonViews x = sender as MenuBarButtonViews;
            switch (x.Type)
            {
                case "1":
                    CurrentMain.Children.Add(dashboardMenu);
                    break;
                case "2": 
                    CurrentMain.Children.Add(tableMenu);
                    break;
                case "3":
                    CurrentMain.Children.Add(foodMenu);
                    break;
                case "4":
                    CurrentMain.Children.Add(employeeMenu);
                    break;
                case "5":
                    CurrentMain.Children.Add(warehouseMenu);
                    break;
                default:
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại");
                    break;
            }
        }
        private void MenuBarButtonViews_IsCheckedChanged(object sender, EventArgs e)
        {
            CheckCurrent();
            ChangeMenu(sender);
        }


    }
}
