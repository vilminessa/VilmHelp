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

namespace VilmHelp.Windows
{
    /// <summary>
    /// Логика взаимодействия для Start_Base.xaml
    /// </summary>
    public partial class Start_Base : Window
    {
        public Start_Base()
        {
            InitializeComponent();
            Height = 400;
            Width = 800;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Base_Frame.Content = new Pages.Base();
        }
    }
}
