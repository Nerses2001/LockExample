using LockExample;

Thread[] threads = new Thread[5];
for (int i = 0; i < 5; i++)
{
    threads[i] = new Thread(CLassA.DoWork);
    threads[i].Start();
}

foreach (var thread in threads)
{
    thread.Join();
}

Console.WriteLine("Work completed.");
Console.ReadLine();