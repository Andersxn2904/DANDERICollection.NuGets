using DANDERI.Collection.EF.Generics.RPG.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DANDERI.Collection.EF.Generics.RPG.Repository
{

	public class GenericRepositoryDA<Entity, Context> : IGenericRepositoryDA<Entity,Context> where Entity : class
	where Context : DbContext
	{
		private readonly Context _dbContext;

		public GenericRepositoryDA(Context dbContext)
		{
			_dbContext = dbContext;
		}

		public virtual async Task<Entity> AddAsync(Entity entity)
		{
			await _dbContext.Set<Entity>().AddAsync(entity);
			await _dbContext.SaveChangesAsync();
			return entity;
		}

		public virtual async Task UpdateAsync(Entity entity, int ID)
		{
			
			var entry = await _dbContext.Set<Entity>().FindAsync(ID);
			_dbContext.Entry(entry).CurrentValues.SetValues(entity);
			await _dbContext.SaveChangesAsync();
		}

		public virtual async Task DeleteAsync(Entity entity)
		{
			_dbContext.Set<Entity>().Remove(entity);
			await _dbContext.SaveChangesAsync();
		}

		public virtual async Task<List<Entity>> GetAllAsync()
		{
			return await _dbContext.Set<Entity>().ToListAsync();
		}

		public virtual async Task<Entity> GetByIdAsync(int ID)
		{
			return await _dbContext.Set<Entity>().FindAsync(ID);
		}

		public virtual async Task<List<Entity>> GetAllWithIncludeAsync(List<string> properties)
		{
			IQueryable<Entity> query = _dbContext.Set<Entity>();

			foreach (string property in properties)
			{
				query = query.Include(property);
			}

			return await query.ToListAsync();
		}

		public virtual Entity Add(Entity entity)
		{
			_dbContext.Set<Entity>().Add(entity);
			_dbContext.SaveChanges();
			return entity;
		}

		public virtual void Update(Entity entity, int ID)
		{
			var entry = _dbContext.Set<Entity>().Find(ID);
			_dbContext.Entry(entry).CurrentValues.SetValues(entity);
			_dbContext.SaveChanges();
		}

		public virtual void Delete(Entity entity)
		{
			_dbContext.Set<Entity>().Remove(entity);
			_dbContext.SaveChanges();
		}

		public virtual List<Entity> GetAll()
		{
			return _dbContext.Set<Entity>().ToList();
		}

		public virtual Entity GetById(int ID)
		{
			return _dbContext.Set<Entity>().Find(ID);
		}

		public virtual List<Entity> GetAllWithInclude(List<string> properties)
		{
			IQueryable<Entity> query = _dbContext.Set<Entity>();

			foreach (string property in properties)
			{
				query = query.Include(property);
			}

			return query.ToList();
		}

		public async Task<int> CountAsync()
		{
			return await _dbContext.Set<Entity>().CountAsync();
		}

		public async Task<List<Entity>> GetFilteredAsync(Expression<Func<Entity, bool>> filter)
		{
			return await _dbContext.Set<Entity>().Where(filter).ToListAsync();
		}

		public async Task<List<Entity>> GetPaginatedAsync(int pageNumber, int pageSize)
		{
			return await _dbContext.Set<Entity>().Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
		}

		public async Task<List<Entity>> GetOrderedAsync(Expression<Func<Entity, object>> orderBy)
		{
			return await _dbContext.Set<Entity>().OrderBy(orderBy).ToListAsync();
		}

		public int Count()
		{
			return _dbContext.Set<Entity>().Count();
		}

		public List<Entity> GetFiltered(Expression<Func<Entity, bool>> filter)
		{
			return _dbContext.Set<Entity>().Where(filter).ToList();
		}

		public List<Entity> GetPaginated(int pageNumber, int pageSize)
		{
			return _dbContext.Set<Entity>().Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
		}

		public List<Entity> GetOrdered(Expression<Func<Entity, object>> orderBy)
		{
			return _dbContext.Set<Entity>().OrderBy(orderBy).ToList();
		}



	}
}
