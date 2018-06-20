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
    /// taskbox.xaml 的互動邏輯
    /// </summary>
    public partial class taskbox : UserControl

    {

        

        private void datebox_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void thing_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void money_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void TextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
        public string Dates
        {
            get
            {
                return date.Text;
            }
            set
            {
                date.Text = value;
            }

        }
        public string TH
        {
            get
            {
                return th.Text;
            }
            set
            {
                th.Text = value;
            }

        }
        public string ItemPrice
        {
            get
            {
                return cost.Text;
            }
            set
            {
                cost.Text = value;
            }

        }
        public taskbox()
        {
            InitializeComponent();
        }
        // 自訂刪除事件
        public event EventHandler DeleteItem;

        // 項目名稱鍵盤按下事件
        private void TaskNamePreviewKeyDown(object sender, KeyEventArgs e)
        {
            // 任務空白，而且按下 Backspace 鍵時，引發 DeleteItem 事件
            if (th.Text == "" && e.Key == Key.Back)
            {
                DeleteItem(this, null);
            }
        }
        public int itemPriceValue
        {
            get
            {
                //嘗試解析價格
                try
                {
                    return int.Parse(cost.Text);
                }
                //失敗後要求用家輸入數字
                catch
                {
                    MessageBox.Show("請輸入數字");
                    return 0;
                }
            }
            set
            {
                cost.Text = value.ToString();
            }
        }


    }

}
    