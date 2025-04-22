using System.Diagnostics;

namespace M09T2Activitats
{
    public class Program
    {
        public static void Main()
        {
            using(StreamWriter writer = new StreamWriter("processes.txt"))
            {
                Process[] progresses = Process.GetProcesses();
                foreach (Process process in progresses)
                {
                    Console.WriteLine(process.Id);
                    writer.WriteLine(process.Id);
                }
            }
        }
    }
}