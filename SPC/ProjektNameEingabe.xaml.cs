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
using System.Windows.Shapes;
using SPC.Start_Menu;

namespace SPC
{
    /// <summary>
    /// Interaktionslogik für ProjektNameEingabe.xaml
    /// </summary>
    public partial class ProjektNameEingabe : Page
    {
        public ProjektNameEingabe()
        {
            InitializeComponent();
        }

        private void WeiterButton_Click(object sender, RoutedEventArgs e)
        {
            String projectName;
            projectName = projektNameTextFeld.Text;
            new New_Project(projectName);

            SPCEditor e1 = new SPCEditor();
            NavigationService.Navigate(e1);   
            
        }

        private void ZurückButton_Click(object sender, RoutedEventArgs e)
        {
            SPC.SPCStartMenu startMenu = new SPCStartMenu();
            NavigationService.Navigate(startMenu);
        }
    }
}
