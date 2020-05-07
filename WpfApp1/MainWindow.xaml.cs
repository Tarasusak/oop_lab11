using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp1
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

        private void buttonUkr_Click(object sender, RoutedEventArgs e)
        {
            //Name
            Regex reg = new Regex(@"^[A-Яа-яіІєЄїЇ]{2,}$");
            if (reg.IsMatch(textBoxUkr.Text))
            {
                labelUkr.Content = "Вірно";
                labelUkr.Foreground = Brushes.Green;
            }
            else
            {
                labelUkr.Foreground = Brushes.Red;
                labelUkr.Content = "Помилка";
            }
        }

        private void buttonPass_Click(object sender, RoutedEventArgs e)
        {
            //Passport
            Regex reg = new Regex(@"^(([А-ЯІЄЇ]{2}\d{9})|(\d{9}))$");
            if (reg.IsMatch(textBoxPass.Text))
            {
                labelPass.Content = "Вірно";
                labelPass.Foreground = Brushes.Green;
            }
            else
            {
                labelPass.Foreground = Brushes.Red;
                labelPass.Content = "Помилка";
            }
        }

        private void buttonEmail_Click(object sender, RoutedEventArgs e)
        {
            //Mail
            Regex reg = new Regex(@"\w+@\w+\.\w+", RegexOptions.IgnoreCase);
            if (reg.IsMatch(textBoxEmail.Text))
            {
                labelEmail.Content = "Вірно";
                labelEmail.Foreground = Brushes.Green;
            }
            else
            {
                labelEmail.Foreground = Brushes.Red;
                labelEmail.Content = "Помилка";
            }
        }

        private void buttonNum_Click(object sender, RoutedEventArgs e)
        {
            //Figures
            Regex reg = new Regex(@"^[2-6]((331[1-9])|([2-6][0-9][0-9][0-9]|9[0-2][0-4][0-6]))$");
            if (reg.IsMatch(textBoxNum.Text))
            {
                labelNum.Content = "Вірно";
                labelNum.Foreground = Brushes.Green;
            }
            else
            {
                labelNum.Foreground = Brushes.Red;
                labelNum.Content = "Помилка";
            }
        }

        //P_number
        private void buttonTel_Click(object sender, RoutedEventArgs e)
        {

            Regex reg = new Regex(@"^\+380\d{9}$");
            if (reg.IsMatch(textBoxTel.Text))
            {
                labelTel.Content = "Вірно";
                labelTel.Foreground = Brushes.Blue;

            }
            else
            {
                labelTel.Foreground = Brushes.Red;
                labelTel.Content = "Помилка";
            }
        }

        
        private void buttonTime_Click(object sender, RoutedEventArgs e)
        {
            //Time
            Regex reg = new Regex(@"^\d{2}:\d{2}$");
            if (reg.IsMatch(textBoxTime.Text))
            {
                labelTime.Content = "Вірно";
                labelTime.Foreground = Brushes.Green;
            }
            else
            {
                labelTime.Foreground = Brushes.Red;
                labelTime.Content = "Помилка";
            }
        }

        
    }
}
