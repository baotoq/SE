﻿using DAO.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repositories
{
	public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		protected readonly DbContext context;

		#region Properties
		private DbSet<TEntity> Entities { get; set; }
		protected HotelContext HotelContext
		{
			get
			{
				return context as HotelContext;
			}
		} 
		#endregion

		public Repository(DbContext context)
		{
			this.context = context;
			Entities = this.context.Set<TEntity>();
		}

		public TEntity Find(string id)
		{
			return Entities.Find(id);
		}

		public IEnumerable<TEntity> ToList()
		{
			return Entities.ToList();
		}

		public IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
		{
			return Entities.Where(predicate);
		}

		public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
		{
			return Entities.SingleOrDefault(predicate);
		}

		public void Add(TEntity entity)
		{
			Entities.Add(entity);
		}

		public void AddRange(IEnumerable<TEntity> entities)
		{
			Entities.AddRange(entities);
		}

		public void Remove(TEntity entity)
		{
			Entities.Remove(entity);
		}

		public void RemoveRange(IEnumerable<TEntity> entities)
		{
			Entities.RemoveRange(entities);
		}

		public int Count()
		{
			return Entities.Count();
		}
	}
}
