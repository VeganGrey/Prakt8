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
            int.TryParse(Clon.Text, out int indx);
            RabotnikDet rab1 = (RabotnikDet)listBox.Items[indx];
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
                kol++;
                listBox.Items.Add(rab);
            }
            catch
            {
                MessageBox.Show("Введите пропущенные данные");
            }           
        }

        private void Clone(object sender, RoutedEventArgs e)
        {
            int.TryParse(Clon.Text, out int indx);
            RabotnikDet rab1 = (RabotnikDet)listBox.Items[indx];
            RabotnikDet rab = (RabotnikDet)rab1.Clone();
            kol++;
            listBox.Items.Add(rab);
        }

        private void Сравнить(object sender, RoutedEventArgs e)
        {
            int.TryParse(Srav1.Text, out int indx); int.TryParse(Srav2.Text, out int indx1);
            RabotnikDet rab1 = (RabotnikDet)listBox.Items[indx];
            RabotnikDet rab2 = (RabotnikDet)listBox.Items[indx1];
            if (rab1.CompareTo(rab2) == 0) MessageBox.Show("Однофамильцы");
            else MessageBox.Show("Не однофамильцы");          
        }
    }
}
