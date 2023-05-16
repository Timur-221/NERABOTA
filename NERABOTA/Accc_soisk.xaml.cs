using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using NERABOTA.Data;

namespace NERABOTA
{
    /// <summary>
    /// Логика взаимодействия для Accc_soisk.xaml
    /// </summary>
    public partial class Accc_soisk : Window
    {
        NERABOTAEntities NERABOTAEntities { get; set; }

        City City { get; set; }
        Soiskatel Soiskatel { get; set; }

        public Accc_soisk(Soiskatel soiskatel)
        {
            InitializeComponent();
            NERABOTAEntities = new NERABOTAEntities();
            ComCity.ItemsSource = NERABOTAEntities.City.ToList();
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
                        if (ComCity.Text == "")
                        {
                            System.Windows.MessageBox.Show("Город не заполенен");
                        }
                        else
                        {
                            if (tb5.Text == "")
                            {
                                System.Windows.MessageBox.Show("Пол не заполенен");
                            }
                            else if (tb5.Text == "м" || tb5.Text == "ж")
                            {
                                if (tb6.Text == "16" || tb6.Text == "17" || tb6.Text == "18" || tb6.Text == "19" || tb6.Text == "20" || tb6.Text == "21" || tb6.Text == "22" || tb6.Text == "23" || tb6.Text == "24" || tb6.Text == "25" || tb6.Text == "26" || tb6.Text == "27" || tb6.Text == "28" || tb6.Text == "29" || tb6.Text == "30")
                                {
                                    System.Windows.MessageBox.Show("Профиль сохранен");
                                    Main main = new Main(Soiskatel);
                                    main.Show();
                                    this.Close();
                                }
                                else
                                {
                                    System.Windows.MessageBox.Show("Неверный возраст");
                                }
                            }
                            else
                            {
                                System.Windows.MessageBox.Show("Пол заполнен неверно.");
                            }
                        }
                    }
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Resume resume = new Resume();
            resume.Show();
            this.Close();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Main main = new Main(Soiskatel);
            main.Show();
            this.Close();
        }

        private void ComCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            City = ComCity.SelectedItem as City;
        }
    }
}
