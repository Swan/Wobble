using System;
using System.Collections.Generic;
using System.Text;

namespace Wobble.Scheduling
{
    public class TaskCompleteEventArgs<T, TResult> : EventArgs
    {
        /// <summary>
        ///     Input given to task
        /// </summary>
        public T Input { get; }

        /// <summary>
        ///     Result of the task
        /// </summary>
        public TResult Result { get; }

        public TaskCompleteEventArgs(T input, TResult result)
        {
            Input = input;
            Result = result;
        }
    }
}
