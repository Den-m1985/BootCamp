public class App<T>
    where T : Worker
{
    IRepository<T> current;

    public App(IRepository<T> repo) => current = repo;

    public void Create(T item) => current.Create(item);

    public void Update(int id, T modified) =>
        curent.Update(id, modified);
    
    public void Remove(int id) => current.Delete(id);

    public void Print() =>
    console.WriteLine(String.Join<T>('\n', current.Read()));
}