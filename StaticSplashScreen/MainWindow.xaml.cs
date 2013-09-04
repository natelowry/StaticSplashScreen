using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace StaticSplashScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DoSomethingThatTakesALongTime();
            DoSomethingElseThatTakesALongTime();
            InitializeComponent();
        }

        private static void DoSomethingThatTakesALongTime()
        {
            Thread.Sleep(5000);
        }

        private static void DoSomethingElseThatTakesALongTime()
        {
            Thread.Sleep(5000);
        }
    }
}
