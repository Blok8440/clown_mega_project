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

namespace how_to_pid
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            SelfUserElement.Width = 300;
            SelfUserElement.Height = 200;
            SelfGrid.Width = 300;
            SelfGrid.Height = 300;
        }

        private void enlarge_btn_Click(object sender, RoutedEventArgs e)
        {
            if (SelfUserElement.Height == 200)
            {
                SelfUserElement.Height = 300;
                SelfGrid.Width = 300;
                SelfGrid.Height = 300;
            }
            else
            {
                SelfUserElement.Height = 200;
                SelfGrid.Width = 300;
                SelfGrid.Height = 300;
            }
        }

        private void Rect_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (SelfUserElement.Height == 200)
            {
                SelfUserElement.Height = 300;
                SelfGrid.Width = 300;
                SelfGrid.Height = 300;
            }
            else
            {
                SelfUserElement.Height = 200;
                SelfGrid.Width = 300;
                SelfGrid.Height = 300;
            }
        }
    }
}
