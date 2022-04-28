using System;

namespace Domain.Handlers
{
    public interface ICreateCustomerHandler
    {        
         Guid Add(string name, string email);
    }
}