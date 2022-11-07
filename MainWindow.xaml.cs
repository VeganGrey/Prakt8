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
        List<RabotnikDet> listochek = new List<RabotnikDet>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Отчёт(object sender, RoutedEventArgs e)
        {
            try
            {
            int.TryParse(Clon.Text, out int indx);
            indx --;
            RabotnikDet rab1 = listochek[indx];
            Itog.Text = rab1.GetInfo();
            }
            catch
            {
                MessageBox.Show("Выберите доступного работника или введите нового");
            }
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
                listochek.Add(rab);
                listBox.Items.Add(rab.LastName);
                Itog.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите пропущенные данные");
            }      
        }

        private void Clone(object sender, RoutedEventArgs e)
        {
            try
            {
            int.TryParse(Clon.Text, out int indx);
            indx--;
            RabotnikDet rab1 = listochek[indx];
            RabotnikDet rab = (RabotnikDet)rab1.Clone();
            listochek.Add(rab);
            listBox.Items.Add(rab.LastName);
            }
            catch
            {
                MessageBox.Show("Bведите доступного работника");
            }
        }

        private void Сравнить(object sender, RoutedEventArgs e)
        {
            try 
            {
            int.TryParse(Srav1.Text, out int indx); int.TryParse(Srav2.Text, out int indx1);
            indx --;indx1--;
            RabotnikDet rab1 = listochek[indx];
            RabotnikDet rab2 = listochek[indx1];
            if (rab1.CompareTo(rab2) == 0) MessageBox.Show("Однофамильцы");
            else MessageBox.Show("Не однофамильцы");
            }
            catch
            {
                MessageBox.Show("Выберите доступного работника");
            }
        }

        private void Clear(object sender,RoutedEventArgs e)
        {
            listochek.Clear();
            listBox = null;
            Firstname.Text = "";
            Lastname.Text = "";
            Age.Text = "";
            Dolznost.Text = "";
            Childrens.Text = "";
            Itog.Text = "";
            Srav1.Text = "";
            Srav2.Text = "";
            Clon.Text = "";
        }

        private void Cpravka(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Калитин Сергей ИСП-31\nЗадание: Создать интерфейс - человек. Создать классы - работник и работник-отец"+
                "семейства. Классы должны включать конструкторы, функцию для формирования,строки информации о работнике. Сравнение производить по фамилии.");
        }

        private void Quit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Support(object sender,RoutedEventArgs e)
        {
            string target = "https://t.me/Doktorfleks";
            System.Diagnostics.Process.Start(target);
        }
    }
}
