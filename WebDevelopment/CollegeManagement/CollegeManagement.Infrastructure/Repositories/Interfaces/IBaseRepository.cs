namespace CollegeManagement.Infrastructure.Repositories.Interfaces;
public interface IBaseRepository<T>
{
    public Task<List<T>> GetAll(string searchText = "");
    public ValueTask<T> Get(int id);
    public Task Insert(T model);
    public Task Edit(T model);
    public Task Delete(int id);
}
