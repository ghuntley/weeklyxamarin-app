using System.Runtime.CompilerServices;

using WeeklyXamarin.Utility;

namespace System.Threading.Tasks
{
    public static class TaskExtensions
    {
        public static ConfiguredTaskAwaitable ContinueOnAnyContext(this Task @this)
        {
            Ensure.ArgumentNotNull(@this, nameof(@this));
            return @this.ConfigureAwait(continueOnCapturedContext: false);
        }

        public static ConfiguredTaskAwaitable<T> ContinueOnAnyContext<T>(this Task<T> @this)
        {
            Ensure.ArgumentNotNull(@this, nameof(@this));
            return @this.ConfigureAwait(continueOnCapturedContext: false);
        }
    }
}