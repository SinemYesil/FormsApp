namespace FormsApp.Models;

public class Repository
{
    private static readonly List<Product> _products = new();
    private static readonly List<Category> _categaries = new();

    static Repository()
    {
        _categaries.Add(new Category { CategoryId = 1, Name = "Telefon"});
        _categaries.Add(new Category { CategoryId = 2, Name = "Bilgisayar"});
        
        _products.Add(new Product{ ProductId =1 , Name = "iphone 14", Price= 40000, IsActive = true, Image ="1.jpeg", CategoryId =1 });
        _products.Add(new Product{ ProductId =2 , Name = "iphone  13", Price= 30000, IsActive = true, Image ="2.jpeg", CategoryId =1 });
        _products.Add(new Product{ ProductId =3 , Name = "iphone  12", Price= 20000, IsActive = true, Image ="3.jpeg", CategoryId =1 });
        _products.Add(new Product{ ProductId =4 , Name = "iphone  13 Pro", Price= 35000, IsActive = true, Image ="4.jpeg", CategoryId =1 });
        
        _products.Add(new Product {ProductId =5 , Name = "MacBook", Price= 80000, IsActive = true, Image ="b3.jpeg", CategoryId =2 });
        _products.Add(new Product {ProductId =6 , Name = "MacBook Air", Price= 70000, IsActive = true, Image ="b4.jpeg", CategoryId =2 });

    }

    public static List<Product> Products
    {
        get
        {
            return _products;
        }
    }
    public static List<Category> Categories
    {
        get
        {
            return _categaries;
        }
    }
}