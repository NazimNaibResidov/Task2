using JobTaskSecond.ConApp.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JobTaskSecond.ConApp
{
    class Program
    {

        static  void Main(string[] args)
        {
            string ss = Directory.GetCurrentDirectory();
            Console.WriteLine("10 boyuk reqem girin");
            int count = int.Parse(Console.ReadLine());
            //File.WriteAllLines("ini.txt", str);
            string[] firstWord = File.ReadAllLines(ss + "/ini.txt");
            string url = "http://localhost:55372";
            try
            {
            string[] word = firstWord.Take(count).ToArray();
            foreach (var item in word)
            {
                Tools.save(url, item);
            }
               
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            var client = new HttpClient();
            
     var content = client.GetStringAsync(url + "/api/values").Result.ToArray();
          string str = new string(content);
           string sss= JsonConvert.DeserializeObject(str).ToString();
            Console.WriteLine(sss);

            Console.ReadKey();
           
               
            
           

        }
       
       
    }
}
