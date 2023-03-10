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

namespace ПрактикаДелюс.Page
{
    /// <summary>
    /// Логика взаимодействия для List.xaml
    /// </summary>
    public partial class List
    {
        public List()
        {
            InitializeComponent();
        }

        private void podrobnee_Click(object sender, RoutedEventArgs e)
        {
            //var BtnProd = (sender as Button).DataContext as Product;
            //UserAuth.UserAuth.tovar = Dbconnect.db.Product.Where(x => x.ID == BtnProd.ID).FirstOrDefault();

            //NavigationService.Navigate(new RedAdminList(UserAuth.UserAuth.tovar));
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {   
            NavigationService.Navigate(new Add());
        }
    }
}
