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

namespace costbook
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            InitializeComponent();
        }
        public void total()
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            // 產生一個方塊
            taskbox item = new taskbox();

            // 放到 Todostack
            TodoStack.Children.Add(item);
        }

        private void SaveBtn_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // 產生一個方塊
            taskbox item = new taskbox();

            // 放到 Todostack
            TodoStack.Children.Add(item);
        }

        private void taskbox_Loaded(object sender, RoutedEventArgs e)
        {

        }
        


        private void DeleteItem(object sender, EventArgs e)
        {
            DODO.Children.Remove((taskbox)sender);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            List<string> datas = new List<string>();

            foreach (taskbox item in DODO.Children)
            {
                string line = "";
                line += "|" + item.date + "|" + item.th + "|" + item.cost;
                datas.Add(line);

            }

            System.IO.File.WriteAllLines(@"D:\temp\data.txt", datas);
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\temp\data.txt");

    foreach (string line in lines)
            {

                string[] parts = line.Split('|');

                taskbox item = new taskbox();
                item.TH = parts[1];
                item.DeleteItem += new EventHandler(DeleteItem);
 DODO.Children.Add(item);
            }
        }
    }
}

