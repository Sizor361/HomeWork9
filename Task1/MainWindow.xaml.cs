using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static System.Net.Mime.MediaTypeNames;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] imputText;

        /// <summary>
        /// Разделяем весь написанный текст на отдельные строки и помещаем в массив
        /// </summary>
        /// <returns></returns>
        private string[] WriteAndSplitText()
        {
            return imputText = TextForWrite.Text.Split(' ');
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Показываем в ЛистБоксе разделенные слова
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplitWords_Click(object sender, RoutedEventArgs e)
        {
            SplitText.ItemsSource = WriteAndSplitText();
        }

        /// <summary>
        /// Перестановка слов местами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RelocateWords_Click(object sender, RoutedEventArgs e)
        {
            TextForReverse.Text = ""; //Чтобы очистить строку после повторного использования

            for (int i = WriteAndSplitText().Length-1; i >= 0; i--)
            {
                TextForReverse.Text += $"{WriteAndSplitText()[i]} ";
            }
        }
    }
}
