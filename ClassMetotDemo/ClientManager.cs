using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class ClientManager
    {

        public void Add(Client client)
        {
            Console.WriteLine("\nMüşteri eklendi :" + client.ClientName +" "+ client.ClientLastName + "      ID: " + client.ClientID);
        }
        
        public void Remove(Client client)
        {
            Console.WriteLine("\nMüşteri Silindi");
        }

        public void List(Client client)
        {
            Console.WriteLine("\n"+"Ad Soyad: " + client.ClientName + " " + client.ClientLastName + "\n" + "      ID: " + client.ClientID);
        }

    }
}
