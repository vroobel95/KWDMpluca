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

namespace KWDMpluca
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

        private void BSettings_Click(object sender, RoutedEventArgs e)
        {
            string serwerIP = "127.0.0.0.1";
            ushort serwerPort = 10010;
            string klientAET = "KLIENTL";
            string serwerAET = "ARCHIWUM";
            bool stan = gdcm.CompositeNetworkFunctions.CEcho(serwerIP, serwerPort, klientAET, serwerAET);
            LCheck.Content = "Przeszło";
        }
    }
}
