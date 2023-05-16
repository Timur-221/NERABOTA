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
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        NERABOTAEntities NERABOTAEntities { get; set; }

        Work Work { get; set; }
        Soiskatel Soiskatel { get; set; }
        public Main(Soiskatel soiskatel)
        {
            InitializeComponent();
            NERABOTAEntities = new NERABOTAEntities();
            Work = new Work();
            Soiskatel = soiskatel;
            NameText.Content = soiskatel.name_sois;
            NameText2.Content = soiskatel.surname_sois;
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

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Accc_soisk accc_Soisk = new Accc_soisk(Soiskatel);
            accc_Soisk.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Vakansii1 vakansii1 = new Vakansii1(Work);
            vakansii1.Show();
            this.Close();
        }
    }
}
