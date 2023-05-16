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
using NERABOTA.Data;

namespace NERABOTA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Account Account { get; set; }

        NERABOTAEntities NERABOTAEntities { get; set; }

        public MainWindow()
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
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Account = NERABOTAEntities.Account.ToList().Where(x => x.login == LoginBox.Text && x.password == PasswordBox.Password).FirstOrDefault();

            var soiskatel = NERABOTAEntities.Soiskatel.ToList().Where(x => x.id_acc == Account.id_acc).FirstOrDefault();
            var rabotadatel = NERABOTAEntities.Rabotadatel.ToList().Where(x => x.id_acc == Account.id_acc).FirstOrDefault();


            if (soiskatel != null)
            {
                if (LoginBox.Text == "")
                {
                    System.Windows.MessageBox.Show("Заполните логин.");
                }
                else
                {
                    if (PasswordBox.Password == "")
                    {
                        System.Windows.MessageBox.Show("Заполните пароль.");
                    }
                    else
                    {
                        Main main = new Main(soiskatel);
                        main.Show();
                        this.Close();
                    }
                }
            }

            if(rabotadatel != null)
            {
                if (LoginBox.Text == "")
                {
                    System.Windows.MessageBox.Show("Заполните логин.");
                }
                else
                {
                    if (PasswordBox.Password == "")
                    {
                        System.Windows.MessageBox.Show("Заполните пароль.");
                    }
                    else
                    {
                        MainRabot mainRabot = new MainRabot();
                        mainRabot.Show();
                        this.Close();
                    }
                }
            }

           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }
    }
}
