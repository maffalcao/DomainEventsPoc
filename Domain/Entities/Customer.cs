using System;
using Domain.Validations;
using FluentValidation;

namespace Domain.Entities
{
    public class Customer : Entity
    {
        public string Name { get; }
        public string Email { get; }

        public Customer(string name, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;

            Validate(this, new CustomerValidator());
        }
    }
}