using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteMdiatr_01.Notifications
{
    public class CustomerActionNotification : INotification
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ActionNotification Action { get; set; }
    }
}
