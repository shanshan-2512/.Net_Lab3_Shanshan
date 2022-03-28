namespace DotNet_Lab3_Shanshan;


public class Product
{
    public int ProductId { get; set; }
    public string? Name { get; set; }

    public virtual Product? Product { get; set; }

}
