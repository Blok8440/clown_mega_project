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
using System.Timers;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {

        private int m_counter = 50;
        private int reset_value;
        private bool timer_state = false;

        System.Windows.Threading.DispatcherTimer timer;

        private void timert_Elapsed(object sender, System.EventArgs e)
        {
            if (m_counter > 0 && timer_state)
            {
                m_counter--;
            }
            else
            {
                timer.Stop();
            }
            update_text();
        }

        public MainWindow()
        {
            InitializeComponent();

            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(timert_Elapsed);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);

            read.Content = m_counter.ToString();
            reset_value = m_counter;
        }

        private void update_text()
        {
            timer_textbox.Text = m_counter.ToString();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            timer_state = true;
            timer.Start();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            timer_state = false;
            timer.Stop();
            m_counter = Convert.ToInt32(read.Content);
            update_text();
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {
            timer_state = !timer_state;
            if (timer_state) {
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
            
        }

        private void minus_btn_Click(object sender, RoutedEventArgs e)
        {
            reset_value--;
            update_read();
        }

        private void plus_btn_Click(object sender, RoutedEventArgs e)
        {
            reset_value++;
            update_read();
        }

        private void update_read()
        {
            read.Content = reset_value.ToString();
        }
    }
}
