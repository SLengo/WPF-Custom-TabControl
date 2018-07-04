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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace CustomTabControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adding tab programmatically from calling context
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTab_Click(object sender, RoutedEventArgs e)
        {
            CustomTabView.CustomItems.Add(new TabItem() {
                Header = "Tab from window " + DateTime.Now.ToLongTimeString()
            });
        }
    }
}
