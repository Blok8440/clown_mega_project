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

namespace WpfApp1
{
    public class ogo
    {
        private int HP = 20;
        private TextBlock HP_bar;
        
        public ogo(dynamic _HP_bar)
        {
            HP_bar = _HP_bar;
        }

        public void update_Text()
        {
            HP_bar.Text = HP.ToString();
        }

        public void increase_HP()
        {
            HP++;
        }

        public void decreaes_HP()
        {
            HP--;
        }
    }

    public partial class MainWindow : Window
    {
        private ogo hp_bar;
        
        public MainWindow()
        {
            InitializeComponent();
            hp_bar = new ogo(HP_bar);
        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            hp_bar.increase_HP();
            hp_bar.update_Text();
        }

        private void decrease_buttton_Click(object sender, RoutedEventArgs e)
        {
            hp_bar.decreaes_HP();
            hp_bar.update_Text();
        }
    }
}
