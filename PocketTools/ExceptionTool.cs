using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketTools
{
    public static class ExceptionExtensions
    {
        public static string UnwrapMessage(this Exception ex)
        {
            if (ex == null)
                return null;
            else if (ex is AggregateException && ex.InnerException != null)
                return ex.InnerException.Message;
            else if (ex is TypeInitializationException && ex.InnerException != null)
                return ex.InnerException.Message;
            return ex.Message;
        }

    }
}
