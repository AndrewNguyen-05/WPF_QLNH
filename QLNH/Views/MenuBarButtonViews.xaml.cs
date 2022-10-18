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
    /// Interaction logic for MenuBarButtonViews.xaml
    /// </summary>
    public partial class MenuBarButtonViews : UserControl
    {
        public MenuBarButtonViews()
        {
            InitializeComponent();
            this.DataContext = this;
            IsChecked = "False";
        }
        public string Title { get; set; }
        public string ImgDirectory { get; set; }
        public string IsChecked { get; set; }
        public string Type { get; set; } 
        public event EventHandler IsCheckedChanged;
        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsCheckedChanged != null)
            {
                this.IsCheckedChanged(this, e);
            }
        }
    }
}
