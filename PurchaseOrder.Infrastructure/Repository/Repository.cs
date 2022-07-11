using Microsoft.EntityFrameworkCore;
using PurchaseOrder.Domain.Aggregates;
using PurchaseOrder.Domain.Entities;
using PurchaseOrder.Domain.Interfaces;
using PurchaseOrder.Domain.Specifications;
using PurchaseOrder.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace PurchaseOrder.Infrastructure.Repository
{
    public class Repository<T>: IRepository<T> where T : EntityBase, IAggregateRoot
    {
        private readonly PurchaseOrderContext context;

        public Repository(PurchaseOrderContext context)
        {
            this.context = context;
        }

        public T Add(T item)
        {
            return context.Add(item).Entity;
        }

        public IReadOnlyCollection<T> Get()
        {
            var Data = context.Set<T>().ToList();
            return Data.AsReadOnly();
        }
        public T GetById(long id)
        {
            return context.Set<T>().Find(id);
        }


        public T Remove(T item)
        {
            return context.Remove(item).Entity;
        }

        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }

        public T Update(T item)
        {
            return context.Update(item).Entity;
        }
    }
}