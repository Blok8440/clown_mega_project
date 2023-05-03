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

namespace clown_mega_project
{
    /// <summary>
    /// Логика взаимодействия для GameChooseMenu.xaml
    /// </summary>
    public partial class GameChooseMenu : Page
    {
        public GameChooseMenu()
        {
            InitializeComponent();
        }

        private void CreateNewGame_btn_Click(object sender, RoutedEventArgs e)
        {
            var creation_window = new GameCreateWindow();
            creation_window.Show();
            creation_window.Activate();
        }
    }
}
