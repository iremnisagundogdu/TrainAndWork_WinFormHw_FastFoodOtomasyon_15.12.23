using KFC.Model;
using SimpleTCP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KFC
{
    public static class TCPConnection
    {
        static List<CurrentOrder> currentOrdersFromTcp = new List<CurrentOrder>();

        public static List<CurrentOrder> JsonGetData(Form form)
        {
            IPAddress localAddr = IPAddress.Parse("192.168.1.101");
            int port = 3034;
            // 
            TcpListener server = new TcpListener(localAddr, port);
            server.Start();

            Task.Run(() =>
            {
                while (true)
                {
                    using (TcpClient client = server.AcceptTcpClient())
                    using (NetworkStream stream = client.GetStream())
                    {
                        byte[] lengthBytes = new byte[4];
                        stream.Read(lengthBytes, 0, 4);
                        int length = BitConverter.ToInt32(lengthBytes, 0);

                        byte[] jsonBytes = new byte[length];
                        stream.Read(jsonBytes, 0, jsonBytes.Length);

                        string jsonString = Encoding.UTF8.GetString(jsonBytes);

                        List<CurrentOrder> receivedOrders = System.Text.Json.JsonSerializer.Deserialize<List<CurrentOrder>>(jsonString);

                        form.Invoke((MethodInvoker)delegate
                        {
                            currentOrdersFromTcp.Clear();
                            foreach (CurrentOrder order in receivedOrders)
                            {
                                currentOrdersFromTcp.Add(order);
                            }
                        });
                    }
                }
            });
            return currentOrdersFromTcp;
        }
        public static void TcpSendData(List<CurrentOrder> currentOrderList, string IpAdress = "192.168.1.101", int serverPort = 3057)
        {
            IPAddress serverAddr = IPAddress.Parse(IpAdress);
            Task.Run(() =>
            {
                using (TcpClient client = new TcpClient(serverAddr.ToString(), serverPort))
                using (NetworkStream stream = client.GetStream())
                {
                    string json = JsonSerializer.Serialize(currentOrderList);
                    byte[] jsonBytes = Encoding.UTF8.GetBytes(json);
                    byte[] lengthPrefix = BitConverter.GetBytes(jsonBytes.Length);
                    stream.Write(lengthPrefix, 0, lengthPrefix.Length);
                    stream.Write(jsonBytes, 0, jsonBytes.Length);
                }
            });
        }


    }


}
