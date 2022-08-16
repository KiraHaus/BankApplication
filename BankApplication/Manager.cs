namespace BankApplication
{
    internal class Manager : Consultant
    {
        public Manager(string name) : base(name)
        {
        }

        public override string ClientInfo(Client client)
        {
            string info = $"Name:{client.Name} {client.Surname} {client.FName}; Phone: {client.Phone}; Passport: {client.Password}";
            return info;
        }

        public void ChangeClientName(Client client, string name)
        {
            client.Name = name;
        }

        public void ChangeClientSurname(Client client, string surname)
        {
            client.Surname = surname;
        }

        public void ChangeClientFname(Client client, string fname)
        {
            client.FName = fname;
        }

        public void ChangeClientPhone(Client client, string phone)
        {
            client.Phone = phone;
        }

        public void ChangeClientPassport(Client client, string passport)
        {
            client.Password = passport;
        }
    }
}