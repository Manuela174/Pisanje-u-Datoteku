using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PisanjeUDatoteki
{
    class Program
    {
        static void Main(string[] args)
        {

            Process[] proc = Process.GetProcesses();
            string lokacijaspremanja = @"D:\";
            using(StreamWriter sw = new StreamWriter(lokacijaspremanja+"Tekst.txt"))
            {
               
                foreach (Process p in proc)
                {
                    sw.WriteLine("{0,-20} {1,10} {2,20}", p.ProcessName, p.Id, p.WorkingSet64);
                }
            }

            using (StreamReader sr=new StreamReader(lokacijaspremanja + "Tekst.txt"))
            {
                string line;
                int brojac = 0;
                while((line=sr.ReadLine()) !=null)
                {
                    brojac++;
                    Console.WriteLine(line);
                }
                Console.WriteLine("====================================================================");
                Console.WriteLine(brojac);
            }
        }
    }
}
