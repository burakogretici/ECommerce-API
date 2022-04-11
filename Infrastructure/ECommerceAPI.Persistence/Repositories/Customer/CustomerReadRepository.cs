﻿using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories.Customer
{
    public class CustomerReadRepository : ReadRepository<Domain.Entities.Customer>,ICustomerReadRepository
    {
        public CustomerReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
