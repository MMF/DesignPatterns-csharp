namespace DesignPatterns.SingletonPattern;
public sealed class ThreadSafeSingleton
{
    private static ThreadSafeSingleton? _instance = null;
    private static readonly object _lock = new object();
    public string Value { get; set; }

    private ThreadSafeSingleton() { }
    
    public static ThreadSafeSingleton GetInstance(string val)
    {
        if (_instance == null)
        {
            // multiple thread will come here
            // the first thread will acquire the lock
            lock (_lock)
            {
                // if the first thread released the lock and the second thread enters this section
                // extra check to prevent the new thread from creating another instance
                if (_instance == null)
                {
                    _instance = new ThreadSafeSingleton();
                    _instance.Value = val;
                }
            }
        }

        return _instance;
    }
}
