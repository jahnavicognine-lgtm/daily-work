namespace Question4
{
    using System;
    using System.Diagnostics;
    using System.Threading;

    class Program
    {
        static void Main()
        {
            object obj = new object();
            Console.WriteLine("Start generation: " + GC.GetGeneration(obj)); //gc.getgeneration gives in which gen the object is

            Stopwatch t = new Stopwatch();
            t.Start();
            while (GC.GetGeneration(obj) == 0)
            {
                GC.Collect(0);
                GC.WaitForPendingFinalizers();
                Thread.Sleep(10);
            }
            t.Stop();
            Console.WriteLine("Time taken from  moving Gen 0 to Gen 1: " + t.ElapsedMilliseconds + " ms");

            // Wait for object moving  from Gen 1 to Gen 2
            t.Restart();
            while (GC.GetGeneration(obj) == 1)
            {
                GC.Collect(1);
                GC.WaitForPendingFinalizers();
                Thread.Sleep(10);
            }
            t.Stop();
            Console.WriteLine("Time taken from moving  from Gen 1 to Gen 2: " + t.ElapsedMilliseconds + " ms");

            Console.WriteLine("Final generation: " + GC.GetGeneration(obj));
        }
    }

}
