namespace Bacchus.Common.Entities;

public class OrderLineEntity
{
    public int Id { get; set; }
    public WineEntity Wine { get; set; }
    public int Quantity { get; set; }
}
