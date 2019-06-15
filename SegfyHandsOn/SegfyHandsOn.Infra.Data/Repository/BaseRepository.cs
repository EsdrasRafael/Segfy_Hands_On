using SegfyHandsOn.Domain.Entities;
using SegfyHandsOn.Domain.Interfaces;
using SegfyHandsOn.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SegfyHandsOn.Infra.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MySqlContext context;

        public BaseRepository(MySqlContext _context)
        {
            context = _context;
        }

        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            context.Set<T>().Remove(SelectById(id));
            context.SaveChanges();
        }

        public IList<T> SelectAll()
        {
            return context.Set<T>().ToList();
        }

        public T SelectById(int id)
        {
            return context.Set<T>().Find(id);
        }
    }
}
