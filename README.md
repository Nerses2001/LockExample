# LockExample
# Lock Example in C#

In the given code, an example of implementing a lock mechanism is demonstrated using C#. The `lock` is used to ensure that a critical section of code is accessed by only one thread at a time, ensuring thread safety.

## Concepts

### Lock
In multithreading, a `lock` is a synchronization primitive used to prevent multiple threads from accessing a shared resource simultaneously. It allows only one thread at a time to enter the critical section, ensuring exclusive access to the resource.

### Monitor
The `Monitor` class in C# is used to synchronize access to a block of code or an object. It provides a way to acquire and release locks, ensuring thread-safe access to shared resources.

## Code Explanation

In the provided C# code:
- `CLassA` is a class containing a method `DoWork` that demonstrates the usage of a `lock` to synchronize access to a critical section of code.
- `lockObject` is used as the synchronization object to control access to the critical section.
- The `DoWork` method uses `Monitor.Enter` and `Monitor.Exit` to acquire and release the lock, respectively, ensuring that only one thread can execute the critical section at a time.

## Usage

Five threads are created, and each thread is assigned the `DoWork` method from `CLassA` to perform work within the critical section. The threads are then started and joined to wait for completion, ensuring the work is performed in a synchronized manner.

```csharp
namespace LockExample
{
    // ... (rest of the code)
}

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
