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
using Newtonsoft.Json;

namespace BankApplication
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Client client1 = new Client("Кирилл", "Паладич", "Максимович", "+79521109088", "4235 678905");
            Client client2 = new Client("Теодор", "Мосби", "Эвелин", "45 56 76589");
            Consultant cons1 = new Consultant("Барни");
            Manager manager1 = new Manager("Маршал");

            ConsClientList.Items.Add(cons1.ClientInfo(client1));
            ConsClientList.Items.Add(cons1.ClientInfo(client2));

            consultantName.Text = $"Привет, {cons1.Name}";
        }

        private void ConsChangeInfo(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
