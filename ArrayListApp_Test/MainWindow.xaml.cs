using System;
using System.Collections;
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

namespace ArrayListApp_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void Click_Add(object sender, RoutedEventArgs e)
        {
            if(TextBox_Data.Text == "")
            {
                MessageBox.Show("Please insert Data in textbox.");
            }
            else
            {
                arrayList.Add(TextBox_Data.Text);
                MessageBox.Show(TextBox_Data.Text + " has Add.");
                TextBox_Data.Clear();
            }
        }

        private void Remove_Text(object sender, RoutedEventArgs e)
        {
            {
                arrayList.Clear();
                MessageBox.Show("All Data remove.");
                TextBox_Data.Clear();
            }
        }

        private void Show_All(object sender, RoutedEventArgs e)
        {
            arrayList.Sort();
            foreach(string textBox in arrayList)
            {
                MessageBox.Show(textBox.ToString());
            }
        }
    }
}
