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
            /*
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
            */
            //Ex6
            Thread camell1 = new Thread(() => Camel(1, 10, 40));
            Thread camell2 = new Thread(() => Camel(2, 15, 30));
            Thread camell3 = new Thread(() => Camel(3, 5, 60));
            Thread camell4 = new Thread(() => Camel(4, 1, 100));
            Thread camell5 = new Thread(() => Camel(5, 20, 25));
            camell1.Start();
            camell2.Start();
            camell3.Start();
            camell4.Start();
            camell5.Start();
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

        public static void Camel(int num, int min, int max)
        {
            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                Console.WriteLine("Soc el camell numero {0}: {1}", num, i);
                Thread.Sleep(Convert.ToInt32(random.NextInt64(min, max)));
            }
            Console.WriteLine("Soc el camell numero {0}: He acabat", num);
        }
    }
}