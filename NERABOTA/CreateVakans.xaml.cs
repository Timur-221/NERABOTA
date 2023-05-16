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
    /// Логика взаимодействия для CreateVakans.xaml
    /// </summary>
    public partial class CreateVakans : Window
    {
        public CreateVakans()
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
            if(tb1.Text == "")
            {
                System.Windows.MessageBox.Show("Название вакансии не заполнено");
            }
            else
            {
                if (tb2.Text == "")
                {
                    System.Windows.MessageBox.Show("Город не заполнен");
                }
                else
                {
                    if (cb1.Text == "")
                    {
                        System.Windows.MessageBox.Show("Метро не заполнено");
                    }
                    else
                    {
                        if (cb2.Text == "")
                        {
                            System.Windows.MessageBox.Show("Опыт работы не заполнен");
                        }
                        else
                        {
                            if (tb3.Text == "")
                            {
                                System.Windows.MessageBox.Show("Заработная плата не заполнена");
                            }
                            else
                            {
                                System.Windows.MessageBox.Show("Вакансия создана");
                                MainRabot mainRabot = new MainRabot();
                                mainRabot.Show();
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        private void tb3_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ".")
               && (!tb3.Text.Contains(".")
               && tb3.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }
    }
}
