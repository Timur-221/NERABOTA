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
    /// Логика взаимодействия для Vakansii1.xaml
    /// </summary>
    public partial class Vakansii1 : Window
    {
        NERABOTAEntities NERABOTAEntities { get; set; }

        Soiskatel Soiskatel { get; set; }

        Work Work { get; set; }
        public Vakansii1(Work work)
        {
            InitializeComponent();
            NERABOTAEntities = new NERABOTAEntities();
            Work = new Work();
            Work = work;
            WorkOne.Content = work.name_work;
            //SalaryOne.Content = work.salary;
        }

        public Vakansii1(Soiskatel soiskatel)
        {
            Soiskatel = soiskatel;
        }

        public Vakansii1()
        {
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
            Main main = new Main(Soiskatel);
            main.Show();
            this.Close();
        }
    }
}
