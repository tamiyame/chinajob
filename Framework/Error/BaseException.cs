using System;

namespace Com.Framework.Error
{
    public class BaseException : Exception
    {
        public BaseException(string message, Exception innerException) : base(message, innerException)
		{
		}

        public virtual void Notify()
        {
        }
    }
}
