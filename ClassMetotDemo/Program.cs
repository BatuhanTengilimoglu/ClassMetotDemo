using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Client client1 = new Client();
            client1.ClientName = "Batuhan";
            client1.ClientLastName = "Tengilimoğlu";
            client1.ClientID = 10001;

            Client client2 = new Client();
            client2.ClientName = "Engin";
            client2.ClientLastName = "Demiroğ";
            client2.ClientID = 10002;

            Client client3 = new Client();
            client3.ClientName = "Oğuzhan";
            client3.ClientLastName = "Tengilimoğlu";
            client3.ClientID = 10003;

            Client[] clients = new Client[] { client1, client2, client3 };

            foreach (var client in clients)
            {
                Console.WriteLine("\nAd Soyad: "+client.ClientName + " " + client.ClientLastName + "\n" + "      ID: " + client.ClientID);
            }
            Console.WriteLine("\n--------Müşteri Ekleme-------");
            ClientManager clientManager = new ClientManager();
            clientManager.Add(client1);
            clientManager.Add(client2);
            clientManager.Add(client3);
            Console.WriteLine("\n--------Müşteri Silme-------");
            clientManager.Remove(client1);
            clientManager.Remove(client2);
            clientManager.Remove(client3);
            Console.WriteLine("\n--------Müşteri Listesi-------");
            clientManager.List(client1);
            clientManager.List(client2);
            clientManager.List(client3);
        }
    }
}
