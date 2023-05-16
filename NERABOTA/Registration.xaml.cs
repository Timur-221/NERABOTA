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
using System.Windows.Shapes;
using NERABOTA.Data;

namespace NERABOTA
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        NERABOTAEntities NERABOTAEntities { get; set; }

        Soiskatel Soiskatel { get; set; }
        public Registration()
        {
            InitializeComponent();
            NERABOTAEntities = new NERABOTAEntities();
        }
        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ExitButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Toolbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var account = new Account
            {
                login = RegLogin.Text,
                password = RegPass.Password
            };

            if (RegLogin.Text == "")
            {
                System.Windows.MessageBox.Show("Заполните логин.");
            }
            else
            {
                if (RegPass.Password == "")
                {
                    System.Windows.MessageBox.Show("Заполните пароль.");
                }
                else
                {
                    if (RegPass2.Password == "")
                    {
                        System.Windows.MessageBox.Show("Повторите пароль.");
                    }
                    else
                    {
                        if(RegPass.Password == RegPass2.Password)
                        {
                            if (cb1.Text == "")
                            {
                                System.Windows.MessageBox.Show("Выберите специализацию.");
                            }
                            else
                            {
                                MainWindow mainwindow = new MainWindow();
                                mainwindow.Show();
                                this.Close();
                            }
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("Пароли не совпадают.");
                        }
                    }
                }
            }
            NERABOTAEntities.Account.Add(account);
            NERABOTAEntities.SaveChanges();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
