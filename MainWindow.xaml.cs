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

namespace ExamApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public List<string> SaveResult = new List<string>();

        private void result_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Boxx_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckForText check= new CheckForText();
            check.CheckText(Boxx);
        }

        private void Boxeps_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckForText check = new CheckForText();
            check.CheckText(Boxeps);
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            string xInput = Boxx.Text;
            string epsInput=Boxeps.Text;
            if (xInput != "" && epsInput != " ")
            {
                double x = Convert.ToDouble(Boxx.Text);
                double eps = Convert.ToDouble(epsInput);
                Calculations sum = new Calculations();
                var results = sum.CalculationSumSeries(x, eps);
                result.ItemsSource= results;
                SaveResult = results.ToList();
            }
            else
            {
                MessageBox.Show("Enter data");
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "Do you want to clear a list?";
            MessageBoxButton button = MessageBoxButton.YesNo;
            string caption = "Clear a list";
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult Result;
            Result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            if (Result == MessageBoxResult.Yes)
            {
                Boxx.Clear();
                Boxeps.Clear();
                result.ItemsSource = null;
            }
        }

        private void File_Click(object sender, RoutedEventArgs e)
        {
            WriteToFile writeTo = new WriteToFile();
            writeTo.WriteFile(result);
            MessageBox.Show("Data has been saved to file File1.txt");
            
        }
    }
}
