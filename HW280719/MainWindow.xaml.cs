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

namespace HW280719
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

      

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("inner");
            //e.Handled = true; // for direct event
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("outer");
        }

        private void outter_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("outter");
            
        }

        private void inner_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("inner");
           
        }

        private void outter_PreviewKeyDow(object sender, KeyEventArgs e)
        {
            MessageBox.Show("outter");
        }

        private void inner_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("inner");
        }

    

    }
}
