﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.OrderManagement.Interfaces;
using Construdelas.OrderSystem.Infra.Data.Contexts;

namespace Construdelas.OrderSystem.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(OrderSystemContext context) : base(context){ }   
    }
}
