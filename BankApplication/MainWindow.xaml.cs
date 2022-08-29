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
        Client client1;
        Client client2;
        Consultant cons1;
        List<Client> clients;
        Manager manager1;
        List<string> consClients;
        public MainWindow()
        {
            InitializeComponent();

            client1 = new Client("Кирилл", "Паладич", "Максимович", "+79521109088", "4235 678905");
            client2 = new Client("Теодор", "Мосби", "Эвелин", "45 56 76589");
            cons1 = new Consultant("Барни");
            manager1 = new Manager("Маршал");
            clients = new List<Client>() {client1, client2};
            consClients = new List<string> { $"{cons1.ClientInfo(client1)}", $"{cons1.ClientInfo(client2)}" };
            ConsClientList.ItemsSource = consClients;
            //ConsClientList.Text = cons1.ClientInfo(client1);
            //ConsClientList.Text = cons1.ClientInfo(client2);

            consultantName.Text = $"Привет, {cons1.Name}";
        }

        private void ConsChangeInfo(object sender, RoutedEventArgs e)
        {
            string newPhone = newClientPhone.Text;
            int index = ConsClientList.SelectedIndex;
            cons1.ChangePhone(clients[index],newPhone);
            ConsClientList.ItemsSource = consClients;

        }

        private void SelectClient(object sender, SelectionChangedEventArgs e)
        {
            clientInfo.Text = ConsClientList.SelectedItem.ToString();
        }
    }
}
