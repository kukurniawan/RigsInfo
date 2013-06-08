using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace MainboardInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");

            var information = searcher.Get();
            foreach (ManagementObject obj in information)
            {
                Console.WriteLine(obj["Manufacturer"].ToString());
                Console.WriteLine(obj["Product"].ToString());
                Console.WriteLine(obj["SerialNumber"].ToString());
                // Retrieving the properties (columns)
                // Writing column name then its value
                //foreach (var data in obj.Properties)
                //    Console.WriteLine("{0} = {1}", data.Name, data.Value);
                //Console.WriteLine();
            }


            Console.ReadLine();

        }
    }
}
