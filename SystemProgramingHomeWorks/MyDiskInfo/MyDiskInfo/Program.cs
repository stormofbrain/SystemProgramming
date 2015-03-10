using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.IO;


namespace MyDiskInfo
{
    [ServiceContract]
    public interface IMyDisk
    {
        [OperationContract]
        string FreeSpace(string obj);
        [OperationContract]
        string TotalSpace(string obj);
    }

    public class MyDisk : IMyDisk
    {
        public string FreeSpace(string obj)
        {
            DriveInfo DI = new DriveInfo(obj);

            long notUsed = DI.TotalFreeSpace;
            


            return notUsed.ToString();
        }
        public string TotalSpace(string obj)
        {

            DriveInfo DI = new DriveInfo(obj);

            long used = DI.TotalSize;


            return used.ToString();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(MyDisk));
            sh.Open();
            Console.WriteLine("Press ENTER for ending...");
            Console.ReadLine();
            sh.Close();
        }
    }
}
