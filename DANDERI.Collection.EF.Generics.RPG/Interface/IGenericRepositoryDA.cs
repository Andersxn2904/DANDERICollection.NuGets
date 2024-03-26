using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DANDERI.Collection.EF.Generics.RPG.Interface
{
	public interface IGenericRepository<Entity, Context> where Entity : class where Context : DbContext
	{
		Task<Entity> AddAsync(Entity entity);
		Task UpdateAsync(Entity entity, int ID);
		Task DeleteAsync(Entity entity);
		Task<Entity> GetByIdAsync(int ID);
		Task<List<Entity>> GetAllAsync();
		Task<List<Entity>> GetAllWithIncludeAsync(List<string> properties);
		Entity Add(Entity entity);
		void Update(Entity entity, int ID);
		void Delete(Entity entity);
		List<Entity> GetAll();
		Entity GetById(int ID);
		List<Entity> GetAllWithInclude(List<string> properties);
		int Count();
		List<Entity> GetFiltered(Expression<Func<Entity, bool>> filter);
		List<Entity> GetPaginated(int pageNumber, int pageSize);
		List<Entity> GetOrdered(Expression<Func<Entity, object>> orderBy);
		Task<int> CountAsync();
		Task<List<Entity>> GetFilteredAsync(Expression<Func<Entity, bool>> filter);
		Task<List<Entity>> GetPaginatedAsync(int pageNumber, int pageSize);

		Task<List<Entity>> GetOrderedAsync(Expression<Func<Entity, object>> orderBy);




	}
}

