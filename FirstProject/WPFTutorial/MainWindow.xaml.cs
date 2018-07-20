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
using WPFTutorial.Models;

namespace WPFTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Code Behind for our MainWindow.
    /// </summary>
    public partial class MainWindow : Window
    {
        string sName = "Hello world!";
        public MainWindow()
        {
            InitializeComponent();
            MyModelObject button1DataContext = new MyModelObject() { Name = "I'm button 1" };
            MyModelObject button2DataContext = new MyModelObject() { Name = "I'm button 2" };

            Button1.DataContext = button1DataContext;
            Button2.DataContext = button2DataContext;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // write your custom code for functionality you want to run when Window id Loaded.
            // there is going to be no difference between accessing variables named "sName" and "MainGridPanel".
            sName = "No Hello world!";
            MainGridPanel.Background = Brushes.Purple;
        }
    }
}
