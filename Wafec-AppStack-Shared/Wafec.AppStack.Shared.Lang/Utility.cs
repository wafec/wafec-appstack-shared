using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wafec.AppStack.Shared.Lang
{
    public class Utility
    {
        public static bool TrueIfThrows<T>(Action action) where T : Exception
        {
            try
            {
                action();
                return true;
            }
            catch (Exception exc)
            {
                if (exc is T)
                    return true;
                else
                    throw exc;
            }
        }
    }
}