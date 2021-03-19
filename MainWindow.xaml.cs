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

namespace PasswordVerification
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

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text.Length == 0) { MessageBox.Show("Input username."); }
            else if (PasswordTextBox.Text.Length < 6) { MessageBox.Show("Password must contain at least 6 characters."); }
            else if (!PasswordTextBox.Text.Any(char.IsDigit)) { MessageBox.Show("Password must contain at least one digit."); }
            else
            {
                MessageBox.Show("Valid password and username entered.");

                Button newBtn = new Button();
                newBtn.Name = "ConfirmButton";
                Grid.SetColumn(newBtn, 2);
                Grid.SetRow(newBtn, 4);
                newBtn.Content = "Confirm and leave";
                newBtn.FontSize = 15;
                newBtn.Margin = new Thickness(5);
                newBtn.Click += ConfirmButton_Click;
                SignInGrid.Children.Add(newBtn);

            }
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
