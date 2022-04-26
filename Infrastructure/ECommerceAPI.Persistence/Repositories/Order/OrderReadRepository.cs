﻿using ECommerceAPI.Application.Repositories.Order;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories.Order
{
    public class OrderReadRepository : ReadRepository<Domain.Entities.Order>, IOrderReadRepository
    {
        public OrderReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
