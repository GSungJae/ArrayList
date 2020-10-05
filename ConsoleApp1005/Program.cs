using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5명의 이름을 입력받고, 5명의 이름을 출력해보세요.
            //string[] arr = new string[5];
            //int count = 1;
            //for(int i =0; i<arr.Length;i++)
            //{
            //    Console.Write($"이름을 입력하세요 {count} : ");
            //    arr[i]=Console.ReadLine();
            //    count++;
            //}
            //foreach (string a in arr)
            //    Console.Write("이름 : " + a + " \n");

            //string[,] info = new string[5, 2];
            //int count = 1;
            //for (int i = 0; i < info.GetLength(0); i++)
            //{
            //    Console.Write($"이름을 입력하세요 {count} : ");
            //    info[i, 0] = Console.ReadLine();

            //    Console.Write($"번호를 입력하세요 {count} : ");
            //    info[i, 1] = Console.ReadLine();
            //    count++;
            //}
            //for (int i = 0; i < info.GetLength(0); i++)
            //{
            //    Console.WriteLine($"{info[i,0]}의 전화번호는 {info[i,1]}");
            //}

            // 5명의 이름 전화번호 생일을 입력받아서 출력해보세요.

            //PhoneInfo[] pArr = new PhoneInfo[5];
            //int count = 1;
            //for (int i = 0; i < pArr.Length; i++)
            //{
            //    PhoneInfo info = new PhoneInfo();
            //    Console.Write($"이름을 입력하세요 {count} : ");
            //    info.Name = Console.ReadLine();
            //    Console.Write($"번호를 입력하세요 {count} : ");
            //    info.Phone = Console.ReadLine();
            //    Console.Write($"생일을 입력하세요 {count} : ");
            //    info.Birth = Console.ReadLine();
            //    pArr[i] = info;
            //    count++;
            //}
            //foreach(PhoneInfo info in pArr)
            //    Console.WriteLine($"{info.Name}, {info.Phone}, {info.Birth}");

            // 입력하는대로 이름 전화번호 생일을 모두 저장해서 출력.
            ArrayList aList = new ArrayList();
            aList.Add("tkrhk");
            aList.Add("tkrh");
            aList.Add("tkr");
            aList.Add("tk");

            aList.Remove("tkrh");
            Console.WriteLine(aList.Count);
            for(int i= 0; i<aList.Count;i++)
                Console.WriteLine(aList[i]);

        }
    }
    class PhoneInfo
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Birth { get; set; }

    }

}
