using System.Diagnostics;

namespace M09T2Activitats
{
    public class Program
    {
        public static void Main()
        {
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