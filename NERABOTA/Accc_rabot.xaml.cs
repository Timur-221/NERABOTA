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

namespace NERABOTA
{
    /// <summary>
    /// Логика взаимодействия для Accc_rabot.xaml
    /// </summary>
    public partial class Accc_rabot : Window
    {
        public Accc_rabot()
        {
            InitializeComponent();
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
            if (tb1.Text == "")
            {
                System.Windows.MessageBox.Show("Имя не заполнено");
            }
            else
            {
                if (tb2.Text == "")
                {
                    System.Windows.MessageBox.Show("Фамилия не заполнена");
                }
                else
                {
                    if (tb3.Text == "")
                    {
                        System.Windows.MessageBox.Show("Отчество не заполнено");
                    }
                    else
                    {
                        if (tb4.Text == "")
                        {
                            System.Windows.MessageBox.Show("Город не заполенен");
                        }
                        else
                        {
                            if (tb5.Text == "")
                            {
                                System.Windows.MessageBox.Show("Номер компании не заполенен");
                            }
                            else
                            {
                                if(tb6.Text == "")
                                {
                                    System.Windows.MessageBox.Show("Номер работы не заполенен");
                                }
                                else
                                {
                                    System.Windows.MessageBox.Show("Профиль сохранен");
                                    MainRabot mainrabot = new MainRabot();
                                    mainrabot.Show();
                                    this.Close();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainRabot mainRabot = new MainRabot();
            mainRabot.Show();
            this.Close();
        }
    }
}
