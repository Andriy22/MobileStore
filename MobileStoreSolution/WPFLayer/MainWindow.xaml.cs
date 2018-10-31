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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFLayer.Models;

namespace WPFLayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Phones> ph = new List<Phones>();
            ph.Add(new Phones() { Name = "Samsung Govno", Description = "Shit of shits", Price = 100 });
            ph.Add(new Phones() { Name = "Apple <Samsung", Description = "The best shit in the world", Price = 50 });
            ph.Add(new Phones() { Name = "XIAOMI", Description = "The best phone in the world", Price = 200 });



            lbPhones.ItemsSource = ph;
        }

        private void lbPhones_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Purchase purchase = new Purchase(lbPhones.SelectedItem as Phones);
            purchase.ShowDialog();

        }
    }
}
