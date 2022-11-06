using System;
using System.Windows;

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
            Firstname.Focus();
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
                if ((bool)Male.IsChecked) pol = "М";
                if ((bool)Female.IsChecked) pol = "Ж";
                listBox.Items.Add(new RabotnikDet(Firstname.Text, Lastname.Text, age, pol, Dolznost.Text, childrens));
                kol++;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
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
            int.TryParse(Srav1.Text, out int indx);
            int.TryParse(Srav2.Text, out int indx1);

            RabotnikDet rab1 = (RabotnikDet)listBox.Items[indx];
            RabotnikDet rab2 = (RabotnikDet)listBox.Items[indx1];

            if (rab1.CompareTo(rab2) == 0)
            {
                MessageBox.Show("Однофамильцы");
            }
            else
            {
                MessageBox.Show("Не однофамильцы");
            }
        }

        private void Очистка(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            Firstname.Clear();
            Lastname.Clear();
            Age.Clear();
            Childrens.Clear();
            Male.IsChecked = false;
            Female.IsChecked = false;
            Dolznost.Clear();
            Firstname.Focus();
        }

        private void Справка(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("");
        }

        private void Выход(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
