using proekt_sotrudnikov.ViewModel;
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

namespace proekt_sotrudnikov
{
    /// <summary>
    /// Логика взаимодействия для WindowNewEmployee.xaml
    /// </summary>
    public partial class WindowNewEmployee : Page
    {
        private RoleViewModel roleViewModel;
        public WindowNewEmployee()
        {
            InitializeComponent();
            CbRole.ItemsSource = new RoleViewModel().ListRole;
        }

        internal bool ShowDialog()
        {
            throw new NotImplementedException();
        }

        private void BtSave_Click(object sender, RoutedEventArgs e, bool DialogResult)
        {
            DialogResult = true;
        }
    }
}
