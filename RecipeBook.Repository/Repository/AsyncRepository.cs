﻿using Microsoft.EntityFrameworkCore;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Repository.Repository
{
	public class AsyncRepository<T> : IAsyncRepository<T> where T : class
	{
		protected readonly RecipeBookDbContext _dbContext;


		public AsyncRepository(RecipeBookDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public virtual async Task<T> GetByIdAsync(Guid id)
		{
			T t = await _dbContext.Set<T>().FindAsync(id);
			return t;
		}
		public virtual async Task<IReadOnlyList<T>> ListAllAsync()
		{
			return await _dbContext.Set<T>().ToListAsync();
		}

		public virtual async Task<T> AddAsync(T entity)
		{
			await _dbContext.Set<T>().AddAsync(entity);
			await _dbContext.SaveChangesAsync();

			return entity;
		}

		public async Task UpdateAsync(T entity)
		{
			_dbContext.Entry(entity).State = EntityState.Modified;
			await _dbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(T entity)
		{
			_dbContext.Set<T>().Remove(entity);
			await _dbContext.SaveChangesAsync();
		}

		
	}
}
