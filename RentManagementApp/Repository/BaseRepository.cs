namespace RentManagementApp.Repository;

public class BaseRepository<T> where T:CommonInterface
{
    public List<T> ListedObjects=new List<T>();
    
    public T Add(T newObject)
    {
        ListedObjects.Add(newObject);
        return newObject;
    }
    
    public List<T> GetAll()
    {
        return ListedObjects;
    }
    
    public T? GetById(int id)
    {
        T? obje=ListedObjects.Where(x=>x.Id==id).FirstOrDefault();
        return obje;
    }
    
    public List<T> Update(int id, T updatedObject)
    {
        Dictionary<int,T> objects = ListedObjects.ToDictionary(x=>x.Id,x=>x);

        if (objects.ContainsKey(id))
        {
            objects[id] = updatedObject;
        }
        else
        {
            Console.WriteLine("Not Found");
        }
        return ListedObjects = objects.Values.ToList();
    }
    
    public void Delete(int id)
    {
        T? deleteObject = GetById(id);
        ListedObjects.Remove(deleteObject);
    }
}