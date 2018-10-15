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

namespace Wpf_ProjectCostManager.MyUserControls
{
    /// <summary>
    /// UC_Resource.xaml 的互動邏輯
    /// </summary>
    public partial class UC_Resource : System.Windows.Controls.UserControl
    {
        public UC_Resource()
        {
            InitializeComponent();
            this.btn_Add.Click += Btn_Add_Click; ;
            this.btn_Remove.Click += Btn_Remove_Click; ;
        }
        public event RoutedEventHandler Add;
        public event RoutedEventHandler Remove;

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            if (this.Add != null)
            {
                this.Add.Invoke(this, e);
            }
        }

        private void Btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            if (this.Remove != null)
            {
                this.Remove.Invoke(this, e);
            }
        }

        public DateTime Date
        {
            get
            {
                return (DateTime)this.dp_ExpenseDate.SelectedDate;
            }
            set
            {
                this.dp_ExpenseDate.SelectedDate = value;
            }
        }
        public string ResourceName
        {
            get
            {
                return this.cb_Expense.SelectionBoxItem.ToString();
            }
        }
        public int Quantity
        {
            get
            {
                int.TryParse(this.tb_Quantity.Text,out int quantity);
                return quantity;
            }
            set
            {
                this.tb_Quantity.Text = value.ToString();
            }
        }
        public string Unit
        {
            get
            {
                return this.tb_Unit.Text;
            }
            set
            {
                this.tb_Unit.Text = value;
            }
        }
        public decimal UnitPrice
        {
            get
            {
                decimal.TryParse(this.tb_UnitPrice.Text, out decimal price);
                return price;
            }
            set
            {
                this.tb_UnitPrice.Text = value.ToString();
            }
        }
    }
}
