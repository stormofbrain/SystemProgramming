using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using MyDiskInfo;

namespace Client
{
    [ServiceContract]
    public interface IMyDiskInfo
    {
        [OperationContract]
        string FreeSpace(string obj);
        [OperationContract]
        string TotalSpace(string obj);
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IMyDisk> factory = new ChannelFactory<IMyDisk>(
                    new BasicHttpBinding(),
                    new EndpointAddress("http://localhost/MyDiskInfo/ep2"));
            IMyDisk channel = factory.CreateChannel();

            string free = channel.FreeSpace("C");
            string total = channel.TotalSpace("D");
            Console.WriteLine("Free space: " + free);
            Console.WriteLine("Total space: " + total + "\n\n\n");
            Console.ReadLine();
        }
    }
}

