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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opens new CustomizeCombo and sends choice as parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomizeCombo(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            NavigationService.Navigate(new CustomizeCombo(button.Name));
        }
    }
}
