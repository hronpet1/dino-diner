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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeNuggets.xaml
    /// </summary>
    public partial class CustomizeNuggets : Page
    {
        private DinoNuggets Nuggets { get; set; }
        public CustomizeNuggets(DinoNuggets nuggets)
        {
            InitializeComponent();
            Nuggets = nuggets;
        }
        private void addNugget(object sender, RoutedEventArgs e)
        {
            this.Nuggets.AddNugget();
        }
    }
}
