using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Main Thread started");

            Thread thread1 = new Thread(Thread1Function);

            Thread thread2 = new Thread(Thread2Function);

            thread1.Start();
            thread2.Start();

            if (thread1.Join(1000))
            {
                Console.WriteLine("Thread1Function Done");
            }
            else
            {
                Console.WriteLine("Thread1Function wasn't done within 1 second");
            }

            //thread1.Join();
            //Console.WriteLine("Thread1Function done");
            thread2.Join();
            Console.WriteLine("Thread2Function done");

            for (int i = 0; i < 10; i++)
            {
                if (thread1.IsAlive)
                {
                    Console.WriteLine("Thread1 is still doing stuff");
                    Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine("Thread1 completed");
                }
            }

            

            Console.WriteLine("Main Thread ended");
            /*
            Console.WriteLine("Hello World 1!");

            Thread.Sleep(1000);
            Console.WriteLine("Hello World 2!");

            Thread.Sleep(1000);
            Console.WriteLine("Hello World 3!");

            Thread.Sleep(1000);
            Console.WriteLine("Hello World 4!");
            */

            /*
            new Thread(() => 
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            }).Start();
            */

            //var taskCompletionSource = new TaskCompletionSource<bool>();

            /*
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");

            })
            { IsBackground = true }.Start();
            */

            /*
            Enumerable.Range(0, 1000).ToList().ForEach(i =>
            {
                    ThreadPool.QueueUserWorkItem((o) =>
                    {
                        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
                        Thread.Sleep(1000);
                        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
                        //taskCompletionSource.SetResult(true);
                    });

            });
            */
            /*
            new Thread(() =>
            {
                Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started"); 
                Thread.Sleep(1000);
                //taskCompletionSource.TrySetResult(true);
                Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
            }).Start();
            */
            
            //thread.Start();

            //var test = taskCompletionSource.Task.Result;

            //Console.WriteLine("Task was done: {0}", test);
            
            Console.ReadKey();
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function started");
            Thread.Sleep(3000);
            Console.WriteLine("Thread1Function coming back to Main");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function started");
        }
    }
}
