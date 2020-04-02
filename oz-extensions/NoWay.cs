using System;

namespace OzExtensions
{
    public static class NoWay
    {
        public static class GetFucked
        {
            /// <summary>
            /// Throws an exception
            /// </summary>
            /// <example>NoWay.GetFucked.FuckOff(new Exception(&quot;Bugger&quot;));</example>
            /// <param name="e"></param>
            public static void FuckOff(Exception e)
            {
                throw e;
            }

            /// <summary>
            /// Throws an exception
            /// </summary>
            /// <example>NoWay.GetFucked.FuckOff&lt;Exception&gt;();</example>
            public static void FuckOff<T>() where T : Exception, new()
            {
                throw new T();
            }
        }
    }
}