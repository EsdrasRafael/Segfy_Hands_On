using SegfyHandsOn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SegfyHandsOn.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj);

        void Remove(int id);

        T SelectById(int id);

        IList<T> SelectAll();
    }
}
