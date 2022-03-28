namespace DotNet_Lab3_Shanshan;


public class User
{
    public int UserId { get; set; }
    public string? Name { get; set; }

    public virtual Product? Product { get; set; }

    public int? StreetNumber { get; set; }
    public string? StreetName { get; set; }

    [RegularExpression(@"^[A-Za-z][0-9][A-Za-z][ ]*[0-9][A-Za-z][0-9]$", ErrorMessage = "Please enter postal code in the correct way!")]
    public string? PostalCode { get; set; }
    [Required]
    public string? City { get; set; }
    public string? Province { get; set; }
    public string? Phone { get; set; }

}