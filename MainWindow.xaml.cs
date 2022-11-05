﻿using System;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Отчёт(object sender, RoutedEventArgs e)
        {
            if (Childrens.Text == null)
            {
                try
                {
                    Int32.TryParse(Age.Text, out int age);
                    string pol = "";
                    if (Male.IsChecked.Value == true) pol = "М";
                    if (Female.IsChecked.Value == true) pol = "Ж";
                    Rabotnik rab1 = new Rabotnik(Firstname.Text, Lastname.Text, age, pol, Dolznost.Text);
                    Itog.Text = rab1.GetInfo();
                }
                catch
                {
                    MessageBox.Show("Введите пропущенные данные");
                }
            }
            else
            {
                try
                {
                    Int32.TryParse(Age.Text, out int age);
                    Int32.TryParse(Childrens.Text, out int childrens);
                    string pol = "";
                    if (Male.IsChecked.Value == true) pol = "М";
                    if (Female.IsChecked.Value == true) pol = "Ж";
                    RabotnikDet rab1 = new RabotnikDet(Firstname.Text, Lastname.Text, age, pol, Dolznost.Text,childrens);
                    Itog.Text = rab1.GetInfo();
                }
                catch
                {
                    MessageBox.Show("Введите пропущенные данные");
                }
            }
}
    }
}
