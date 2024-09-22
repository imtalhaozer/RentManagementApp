namespace RentManagementApp.Entity;

public class Object
{
    private int _id;
    public int Id
    {
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Value cannot be negative.");
            }
            _id = value;
        }
        get
        {
            return _id;
        }
    }
    public string? Name{get;set;}
};