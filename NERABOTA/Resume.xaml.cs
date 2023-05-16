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
    /// Логика взаимодействия для Resume.xaml
    /// </summary>
    public partial class Resume : Window
    {
        NERABOTAEntities NERABOTAEntities { get; set; }
        ResumeAc ResumeAc { get; set; }
        Soiskatel Soiskatel { get; set; }
        public Resume()
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
            ResumeAc resum = new ResumeAc()
            {
                exp_work = ComEpl.Text,
                qualitys = ResumeText.Text
            };

            NERABOTAEntities.ResumeAc.Add(resum);
            NERABOTAEntities.SaveChanges();

            Accc_soisk accc_Soisk = new Accc_soisk(Soiskatel);
            accc_Soisk.Show();
            this.Close();
        }
    }
}
