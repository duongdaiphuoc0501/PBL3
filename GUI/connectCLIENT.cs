using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_Client.GUI
{
    public class connectCLIENT
    {
        public delegate void ClientDel(object[] obj);
        public delegate void ClientDel2(object[] obj);
        public ClientDel DelDN { get; set; }
        public ClientDel2 DelKH { get; set; }
        public IPEndPoint ip;
        public string RemoveEndPointPort = null;

        Socket client;
        object[] DV; //= new object[3];
        public void connect()
        {
            ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            ip.Port = 9999;
            try
            {
                client.Connect(ip);
            }
            catch
            {
                MessageBox.Show("khong the ket noi");
            }
            Thread listen = new Thread(receive);
            listen.IsBackground = true;
            listen.Start();
        }

        public void send(object[] dv)
        {
            try
            {
                client.Send(Serialize(dv));
            }
            catch
            {
                MessageBox.Show("loi send Client");
            }
        }
        public void receive()
        {
            try
            {
                while (true)
                {
                    Byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    DV = (object[])Deserialize(data);
                    //if(RemoveEndPointPort == 0)
                    //{
                    //    RemoveEndPointPort =Int32.Parse(DV.ToString()) ;
                    //}
                    THDV(DV);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("loi receive Cient    " + e.ToString());
                close();
            }
        }
        public void close()
        {
            client.Close();
        }

        Byte[] Serialize(Object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter format = new BinaryFormatter();
            format.Serialize(stream, obj);
            return stream.ToArray();
        }

        Object Deserialize(Byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter format = new BinaryFormatter();
            return format.Deserialize(stream);
        }
        public void THDV(object[] dv)
        {
            switch (dv[0])
            {
                case -1:
                    RemoveEndPointPort = dv[1].ToString();
                    break;
                case 0:
                    DelDN(dv);
                    break;
                case 1:
                    DelKH(dv);
                    break;
            }
        }
        public connectCLIENT()
        {

        }
    }
}
