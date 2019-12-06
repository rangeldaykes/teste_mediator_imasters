using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TesteMdiatr_01.Notifications;

namespace TesteMdiatr_01.EventsHandlers
{
    public class EmailHandler : INotificationHandler<CustomerActionNotification>
    {
        public Task Handle(CustomerActionNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($" O cliente {notification.FirstName} {notification.LastName} foi {notification.Action.ToString().ToLower()}");
            });
        }
    }
}
