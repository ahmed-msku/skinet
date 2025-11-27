namespace Core.Entities;

public class ShippingMethod : BaseEntity
{
    public required string ShortName { get; set; }
    public required string ShippingTime { get; set; }
    public required string Description { get; set; }

    public decimal Price { get; set; }
}
