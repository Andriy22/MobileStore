using MahApps.Metro.Controls;
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
using WPFLayer.Models;

namespace WPFLayer
{
    /// <summary>
    /// Interaction logic for Purchase.xaml
    /// </summary>
    public partial class Purchase : MetroWindow
    {
        public Purchase(Phones phone)
        {
            InitializeComponent();
            this.Title = phone.Price + "$";
            tbName.Text = phone.Name;
            tbPrice.Text = phone.Price.ToString();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

   
    }
}
