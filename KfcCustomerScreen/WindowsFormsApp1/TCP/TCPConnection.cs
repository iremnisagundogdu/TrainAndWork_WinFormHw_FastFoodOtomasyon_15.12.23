using KFCKitchen.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFCKitchen.TCP
{
    public static class TCPConnection
    {
        public static List<CurrentOrder> currentOrdersFromTcp = new List<CurrentOrder>();
        public static void JsonGetData(Form form)
        {
            IPAddress localAddr = IPAddress.Any;
            int port = 3333;
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
                            //currentOrdersFromTcp.Clear();
                            foreach (CurrentOrder order in receivedOrders)
                            {
                                currentOrdersFromTcp.Add(order);
                            }

                        });
                    }
                }
            });
        }
    }
}

