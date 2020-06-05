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

namespace KanbanManager
{
    /// <summary>
    /// Lógica de interacción para SideMenuControl.xaml
    /// </summary>
    public partial class SideMenuControl : UserControl
    {
        public SideMenuControl()
        {
            InitializeComponent();
        }

        private void GridTitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void BtnDashboardClick(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this).ToString() != "KanbanManager.Dashboard")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                Window.GetWindow(this).Close();
            }

        }

        private void BtnProfileClick(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this).ToString() != "KanbanManager.Profile")
            {
                Profile dashboard = new Profile();
                dashboard.Show();
                Window.GetWindow(this).Close();
            }

        }

        private void BtnExitClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
