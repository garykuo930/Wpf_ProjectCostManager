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
using System.Windows.Shapes;
using Wpf_ProjectCostManager.MyUserControls;

namespace Wpf_ProjectCostManager.View
{
    /// <summary>
    /// Window_AddRxpense.xaml 的互動邏輯
    /// </summary>
    public partial class Window_AddExpense : Window
    {
        public Window_AddExpense()
        {
            InitializeComponent();
            this.Resource1.Add += Resource1_Add;
            this.Resource1.Remove += Resource1_Remove;
        }

        private void Resource1_Remove(object sender, RoutedEventArgs e)
        {
            UC_Resource resource = sender as UC_Resource;
            this.sp_Resources.Children.Remove(resource);
        }

        private void Resource1_Add(object sender, RoutedEventArgs e)
        {
            UC_Resource resource = new UC_Resource();
            resource.Date = DateTime.Now;
            resource.Add += Resource1_Add;
            resource.Remove += Resource1_Remove;
            resource.Margin = new Thickness(0, 5, 0, 0);
            this.sp_Resources.Children.Add(resource);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Resource1_Loaded(object sender, RoutedEventArgs e)
        {
            this.Resource1.Date = DateTime.Now;
        }
    }
}
