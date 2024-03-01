using System;
using System.Collections.Generic;
using System.IO;
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

namespace AsyncAwaitWPFExamples
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            lbl1.Content = await Task.Run(()=> MethodAsync());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            lbl1.Content = a++.ToString();
        }

        string MethodAsync()
        {
   
                while (File.Exists(@"C:\Users\Vadim.Nacharov\Desktop\testdoc.txt"))
                {

                }
                
            return "File changed";
        }
    }
}
