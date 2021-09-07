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

namespace WpfApp5
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
        
        int count;
        int[] myArr = { 2, 2, 2, 2, 2, 2, 2, 2, 2 }; // 0 Нолик, 1 Крестик
        string win;
        string crossesAndZero;
        int[] Crosses = { 1, 0, 1, 0, 1, 0, 1, 0, 1 };
        int[] Zeros = { 0, 1, 0, 1, 0, 1, 0, 1, 0 };
        string winCrossesZeros;
        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            bt1Image.Source = new BitmapImage(new Uri($"{Games(0)}", UriKind.Relative));
            bt1.IsEnabled = false;
            Win();
        }
        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            bt2Image.Source = new BitmapImage(new Uri($"{Games(1)}", UriKind.Relative));
            bt2.IsEnabled = false;
            Win();
        }
        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            bt3Image.Source = new BitmapImage(new Uri($"{Games(2)}", UriKind.Relative));
            bt3.IsEnabled = false;
            Win();
        }
        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            bt4Image.Source = new BitmapImage(new Uri($"{Games(3)}", UriKind.Relative));
            bt4.IsEnabled = false;
            Win();
        }
        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            bt5Image.Source = new BitmapImage(new Uri($"{Games(4)}", UriKind.Relative));
            bt5.IsEnabled = false;
            Win();
        }
        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            bt6Image.Source = new BitmapImage(new Uri($"{Games(5)}", UriKind.Relative));
            bt6.IsEnabled = false;
            Win();
        }
        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            bt7Image.Source = new BitmapImage(new Uri($"{Games(6)}", UriKind.Relative));
            bt7.IsEnabled = false;
            Win();
        }
        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            bt8Image.Source = new BitmapImage(new Uri($"{Games(7)}", UriKind.Relative));
            bt8.IsEnabled = false;
            Win();
        }
        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            bt9Image.Source = new BitmapImage(new Uri($"{Games(8)}", UriKind.Relative));
            bt9.IsEnabled = false;
            Win();
        }

        private void rbCrosses_Click(object sender, RoutedEventArgs e)
        {
            // Включение кнопок поля
            bt1.IsEnabled = true;
            bt2.IsEnabled = true;
            bt3.IsEnabled = true;
            bt4.IsEnabled = true;
            bt5.IsEnabled = true;
            bt6.IsEnabled = true;
            bt7.IsEnabled = true;
            bt8.IsEnabled = true;
            bt9.IsEnabled = true;
            // Отключеие радио кнопок
            rbCrosses.IsEnabled = false;
            rbZeros.IsEnabled = false;
            crossesAndZero = "x";
        }

        private void rbZeros_Click(object sender, RoutedEventArgs e)
        {
            // Включение кнопок поля
            bt1.IsEnabled = true;
            bt2.IsEnabled = true;
            bt3.IsEnabled = true;
            bt4.IsEnabled = true;
            bt5.IsEnabled = true;
            bt6.IsEnabled = true;
            bt7.IsEnabled = true;
            bt8.IsEnabled = true;
            bt9.IsEnabled = true;
            // Отключеие радио кнопок
            rbCrosses.IsEnabled = false;
            rbZeros.IsEnabled = false;
            crossesAndZero = "0";
        }


        public string Games(int a)
        {


            if (crossesAndZero == "x")
            {
                myArr[a] = Crosses[count];
                crossesAndZero = "0";
                return "Image/Crosses.png";
            }
            else
            {
                myArr[a] = Zeros[count];
                crossesAndZero = "x";
                return "Image/Zeros.png";
            }

        }

        public void Win()
        {
            if ((myArr[0] == 1 && myArr[1] == 1 && myArr[2] == 1) || (myArr[0] == 0 && myArr[1] == 0 && myArr[2] == 0)) // 1 Выйграшная комбинация
                win = "true";
            if ((myArr[3] == 1 && myArr[4] == 1 && myArr[5] == 1) || (myArr[3] == 0 && myArr[4] == 0 && myArr[5] == 0)) // 2 Выйграшная комбинация
                win = "true";
            if ((myArr[6] == 1 && myArr[7] == 1 && myArr[8] == 1) || (myArr[6] == 0 && myArr[7] == 0 && myArr[8] == 0)) // 3 Выйграшная комбинация
                win = "true";
            if ((myArr[0] == 1 && myArr[3] == 1 && myArr[6] == 1) || (myArr[0] == 0 && myArr[3] == 0 && myArr[6] == 0)) // 4 Выйграшная комбинация
                win = "true";
            if ((myArr[1] == 1 && myArr[4] == 1 && myArr[7] == 1) || (myArr[1] == 0 && myArr[4] == 0 && myArr[7] == 0)) // 5 Выйграшная комбинация
                win = "true";
            if ((myArr[2] == 1 && myArr[5] == 1 && myArr[8] == 1) || (myArr[2] == 0 && myArr[5] == 0 && myArr[8] == 0)) // 6 Выйграшная комбинация
                win = "true";
            if ((myArr[0] == 1 && myArr[4] == 1 && myArr[8] == 1) || (myArr[0] == 0 && myArr[4] == 0 && myArr[8] == 0)) // 7 Выйграшная комбинация
                win = "true";
            if ((myArr[2] == 1 && myArr[4] == 1 && myArr[6] == 1) || (myArr[2] == 0 && myArr[4] == 0 && myArr[6] == 0)) // 8 Выйграшная комбинация
                win = "true";
            if (myArr[0] != 2 && myArr[1] != 2 && myArr[2] != 2 && myArr[3] != 2 && myArr[4] != 2 && myArr[5] != 2 && myArr[6] != 2 && myArr[7] != 2 && myArr[8] != 2)
                win = "false";



            if (myArr[0] == 1 && myArr[1] == 1 && myArr[2] == 1)
                winCrossesZeros = "Крестики";
            else if (myArr[3] == 1 && myArr[4] == 1 && myArr[5] == 1)
                winCrossesZeros = "Крестики";
            else if (myArr[6] == 1 && myArr[7] == 1 && myArr[8] == 1)
                winCrossesZeros = "Крестики";
            else if (myArr[0] == 1 && myArr[3] == 1 && myArr[6] == 1)
                winCrossesZeros = "Крестики";
            else if (myArr[1] == 1 && myArr[4] == 1 && myArr[7] == 1)
                winCrossesZeros = "Крестики";
            else if (myArr[2] == 1 && myArr[5] == 1 && myArr[8] == 1)
                winCrossesZeros = "Крестики";
            else if (myArr[0] == 1 && myArr[4] == 1 && myArr[8] == 1)
                winCrossesZeros = "Крестики";
            else if (myArr[2] == 1 && myArr[4] == 1 && myArr[6] == 1)
                winCrossesZeros = "Крестики";
            else
                winCrossesZeros = "Нолики";


            if (win == "true")
            {
                bt1.IsEnabled = false;
                bt2.IsEnabled = false;
                bt3.IsEnabled = false;
                bt4.IsEnabled = false;
                bt5.IsEnabled = false;
                bt6.IsEnabled = false;
                bt7.IsEnabled = false;
                bt8.IsEnabled = false;
                bt9.IsEnabled = false;

                MessageBox.Show($"Выйграли {winCrossesZeros}");
            }
            if (win == "false")
            {
                MessageBox.Show("Ничья");
            }


        }

    }
}