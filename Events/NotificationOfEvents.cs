using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class NotificationOfEvents
    {
        public delegate void NotifyDelegate(int i);

        public event NotifyDelegate notifyDelegate;

        public void NotifyMethod(int i)
        {
            notifyDelegate?.Invoke(i);
        }
    }
}
