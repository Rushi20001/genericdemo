using System;

public class ID<T >
{
    public T Id { get; set; }
    
}

public class Customer : ID<int>
{
    public string CustomerName { get; set; }
    public string CustomerAddress { get; set; }
    public string PhoneNo { get; set; }
}

public class ProductType : ID<int>
{
    public string TypeName { get; set; }
}

public class Product : ID<int>
{
    public int ProductTypeId { get; set; }
    public string ProductName { get; set; }
    public int Amount { get; set; }
}

public class PaymentMode : ID<int >
{
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
    public string PaymentMethod { get; set; }
    public DateTime PaymentDate { get; set; }
}

public class CartHistory : ID<int>
{
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
    public DateTime PurchaseDate { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of classes
        Customer customer = new Customer
        {
            Id = 1,
            CustomerName = "Tony",
            CustomerAddress = "NYC",
            PhoneNo = "2222"
        };

        ProductType productType = new ProductType
        {
            Id = 101,
            TypeName = "Electronics"
        };

        Product product = new Product
        {
            Id = 201,
            ProductTypeId = productType.Id,
            ProductName = "Smartphone",
            Amount = 5000
        };

        PaymentMode payment = new PaymentMode
        {
            Id = 301,





            CustomerId = customer.Id,
            ProductId = product.Id,
            PaymentMethod = "Credit Card",
            PaymentDate = DateTime.Now
        };

        CartHistory cartHistory = new CartHistory
        {
            Id = 501,
            CustomerId = customer.Id,
            ProductId = product.Id,
            PurchaseDate = DateTime.Now
        };

        Console.WriteLine($"Customer: {customer.Id} {customer.CustomerName}");
        Console.WriteLine($"Product Type: {productType.TypeName}");
        Console.WriteLine($"Product: {product.ProductName}, Amount: {product.Amount}");
        Console.WriteLine($"Payment Method: {payment.PaymentMethod}, Date: {payment.PaymentDate}");
        Console.WriteLine($"Purchase Date: {cartHistory.PurchaseDate}");
    }
}
