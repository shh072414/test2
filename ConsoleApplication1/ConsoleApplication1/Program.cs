using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string bb = string.Empty;
            string filepath = @"D:\test.ini";
            string qq = string.Empty;
            int aa = GetPrivateProfileSectionA("ccc",bb,1024,filepath);
            //2349
            Console.WriteLine(bb.ToString());
            Console.Read();

        }
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int GetPrivateProfileSectionA(string lpAppName, string lpReturnedString, int nSize, string lpFileName);


    }
}