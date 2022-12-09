using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
using WPF_FILIPPOV_KR.ApplicationData;

namespace WPF_FILIPPOV_KR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            AppConnect.model0db = new KR_FILIPPOVEntities();
        }

        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user0bj = AppConnect.model0db.Client.FirstOrDefault(x => x.Name == txbLogin.Text && x.Familia == psbPassword.Password);
                if (user0bj == null)
                {
                    MessageBox.Show("Ошибка авторизации", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    switch (user0bj.Name)
                    {
                        case "1":
                            MessageBox.Show("Здравствуйте, Клиент" + user0bj.Name + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка" + Ex.Message.ToString() + "Критическая ошибка приложения", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
    }
    }
}

