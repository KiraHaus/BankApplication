namespace BankApplication
{
    internal class Consultant
    {
        private protected string name;

        public string Name { get; set; }

        public Consultant(string name)
        {
            this.Name = name;
        }

        public virtual string ClientInfo(Client client)
        {
            string info = $"Name:{client.Name} {client.Surname} {client.FName}; Phone: {client.Phone}; Passport: ********";
            return info;
        }

        public void ChangePhone(Client client, string number)
        {
            if (client.Phone != null)
            {
                client.Phone = number;
            }
        }
    }
}