using System.Diagnostics;
using System.Threading;

namespace M09T2Activitats
{
    public class Program
    {
        public static void Main()
        {
            /*
            using (StreamWriter writer = new StreamWriter("processes.txt"))
            {
                Process[] progresses = Process.GetProcesses();
                foreach (Process process in progresses)
                {
                    Console.WriteLine(process.Id);
                    writer.WriteLine(process.Id);
                }
            }
            PrintThreads();
            */
            //Ex5
            //A)
            Thread th1 = new Thread(() => Console.WriteLine("Soc el primer fil"));
            Thread th2 = new Thread(() => Console.WriteLine("Soc el segon fil"));
            Thread th3 = new Thread(() => Console.WriteLine("Soc el tercer fil"));
            Thread th4 = new Thread(() => Console.WriteLine("Soc el quart fil"));
            Thread th5 = new Thread(() => Console.WriteLine("Soc el cinque fil"));
            th1.Start();
            th2.Start();
            th3.Start();
            th4.Start();
            th5.Start();
            //B)
            Thread countdown = new Thread(() =>
            {
                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
            });
            countdown.Start();
        }

        public static void PrintThreads()
        {
            Process[] procesos = Process.GetProcessesByName("msedge");
            if(procesos.Length == 0)
            {
                Console.WriteLine("There is no processes in edge");
                return;
            }
            foreach (Process process in procesos)
            {
                foreach (ProcessThread thread in process.Threads)
                {
                    Console.WriteLine($"Thread ID: {thread.Id}, Start Time: {thread.StartTime}, Priority: {thread.PriorityLevel}");
                }
            }
        }
    }
}