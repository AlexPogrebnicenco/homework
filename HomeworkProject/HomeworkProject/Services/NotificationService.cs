using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Interfaces;

namespace HomeworkProject.Services
{
    public class NotificationService
    {
        private readonly List<INotifier> _notifiers;

        public NotificationService(List<INotifier> notifiers)
        {
            _notifiers = notifiers;
        }

        public void NotifyAll(string message, string recipient)
        {
            foreach (var notifier in _notifiers)
            {
                notifier.Send(message, recipient);
            }
        }
    }
}
