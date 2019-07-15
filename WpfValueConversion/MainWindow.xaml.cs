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

namespace WpfValueConversion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainDataClass _maindc = new MainDataClass();

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = _maindc;
        }

        private void BtnChange_Click(object sender, RoutedEventArgs e)
        {
            _maindc.Color = txtColor.Text;
        }
    }
}
