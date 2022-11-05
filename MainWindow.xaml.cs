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
using System.Diagnostics;

namespace Prakt8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int kol = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Отчёт(object sender, RoutedEventArgs e)
        {
            int.TryParse(Porad.Text, out int indx);
            //indx -= 1;
            RabotnikDet rab1;
            rab1 = (RabotnikDet)listBox.Items[indx];
            Itog.Text = rab1.GetInfo();
        }

        private void Записать(object sender, RoutedEventArgs e)
        {
            try
            {
                Int32.TryParse(Age.Text, out int age);
                Int32.TryParse(Childrens.Text, out int childrens);
                string pol = "";
                if (Male.IsChecked.Value == true) pol = "М";
                if (Female.IsChecked.Value == true) pol = "Ж";
                RabotnikDet rab = new RabotnikDet(Firstname.Text, Lastname.Text, age, pol, Dolznost.Text, childrens);
                kol += 1;
                listBox.Items.Add(rab+$" Работник{kol}");;
            }
            catch
            {
                MessageBox.Show("Введите пропущенные данные");
            }           
        }
    }
}
