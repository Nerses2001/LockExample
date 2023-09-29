
namespace LockExample
{
    public class CLassA
    {
        private static object lockObject = new();

        public static void DoWork()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} attempting to enter the critical section.");

            Monitor.Enter(lockObject);
            try
            {
                Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} entered the critical section.");

                Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is performing work.");

                Thread.Sleep(1000);
            }
            finally
            {
                Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} leaving the critical section.");

                Monitor.Exit(lockObject);
            }
        }
    }
}
