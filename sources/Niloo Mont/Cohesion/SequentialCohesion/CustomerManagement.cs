namespace SequentialCohesion;
public class CustomerManagement
{
    List<Customer> customers = new()
    {
        new Customer { Id = 1, Name = "Test", Age = 15, IsPremium = true},
        new Customer { Id = 2, Name = "Test", Age = 20, IsPremium = false},
        new Customer { Id = 3, Name = "Test", Age = 50, IsPremium = true},
        new Customer { Id = 4, Name = "Test", Age = 13, IsPremium = false}
    };
    public List<Customer> GetAdultCustomers()
    {
        return customers.Where(p => p.Age >= 18).ToList();
    }
    public List<Customer> getPremiumCustomers(List<Customer> customerList)
    {
        return customerList.Where(p => p.IsPremium).ToList();            ;
    }
}
