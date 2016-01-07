using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddhabrotDrawer
{
    public static class Extensions
    {
        public static TParam ThrowIfNull<TParam>(this TParam param, string paramName ) where TParam : class
        {
            if (param == null) throw new ArgumentNullException(paramName);
            return param;
        }
    }
}
