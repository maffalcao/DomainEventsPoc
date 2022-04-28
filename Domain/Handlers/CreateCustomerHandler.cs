using System;
using Domain.Entities;
using Domain.Notification;

namespace Domain.Handlers
{
    public class CreateCustomerHandler: ICreateCustomerHandler
    {
        private readonly NotificationContext _notificationContext;        

        public CreateCustomerHandler(NotificationContext notificationContext)
        {
            _notificationContext = notificationContext;            
        }

        public Guid Add(string name, string email)
        {
            var customer = new Customer(name, email);

            if (customer.Invalid)
            {
                _notificationContext.AddNotifications(customer.ValidationResult);
                return Guid.Empty;
            }
            
            return Guid.NewGuid();
        }
    }
}