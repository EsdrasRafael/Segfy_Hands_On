using FluentValidation;
using SegfyHandsOn.Domain.Entities;
using SegfyHandsOn.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SegfyHandsOn.Service.Services
{
    public class BaseServiceIService<T> where T : BaseEntity
    {
        private BaseRepository<T> repository = new BaseRepository<T>();

        public T Post<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Insert(obj);
            return obj;
        }

        public T Put<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Update(obj);
            return obj;
        }

        public void Remove(int id)
        {
            if (id == 0)
                throw new ArgumentException("O id não pode ser zero.");

            repository.Remove(id);
        }

        public IList<T> Get() => repository.SelectAll();

        public T Get(int id)
        {
            if (id == 0)
                throw new ArgumentException("O id não pode ser zero.");

            return repository.SelectById(id);
        }

        private void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
