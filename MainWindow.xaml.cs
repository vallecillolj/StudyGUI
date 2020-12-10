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

namespace Study
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
        //Button variables from https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.button?view=net-5.0
        //Populating Text box: https://docs.microsoft.com/en-us/visualstudio/vsto/walkthrough-displaying-text-in-a-text-box-in-a-document-using-a-button?view=vs-2019
        private void OnClick1(object sender, RoutedEventArgs e)
        {
            this.Cats.Text += "Clowder";
        }
        private void OnClick2(object sender, RoutedEventArgs e)
        {
            this.Crows.Text += "Murder";
        }
        private void OnClick3(object sender, RoutedEventArgs e)
        {
            this.Alphabet.Text += "26";
        }
    }
}
