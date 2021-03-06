namespace Svelto.Tasks
{
    public interface IRunner
    {
        bool    paused { get; set; }
        bool    isStopping { get; }

        void	StartCoroutine(IPausableTask task);
        void    StartCoroutineThreadSafe(IPausableTask task);
        void 	StopAllCoroutines();

        int numberOfRunningTasks { get; }
    }
}
