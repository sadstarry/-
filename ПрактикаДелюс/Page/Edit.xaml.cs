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
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Page
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void NextAddProd_click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ClearAddProd_click(object sender, RoutedEventArgs e)
        {

        }

        private void AddProd_click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddImage_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
