using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketTools
{
    public static class DateTimeTool
    {
        public static DateTime? Max(DateTime? dt1, DateTime? dt2)
        {
            if (dt1 == null && dt2 == null)
                return null;
            else if (dt1 == null && dt2 != null)
                return dt2;
            else if (dt1 != null && dt2 == null)
                return dt1;
            else if (dt1.Value.Ticks > dt2.Value.Ticks)
                return dt1;
            else
                return dt2;
        }

    }
}
