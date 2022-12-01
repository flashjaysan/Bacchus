namespace Bacchus.Common.Resources;

public class OrderLineResource
{
    public int Id { get; set; }
    public WineResource Wine { get; set; }
    public int Quantity { get; set; }
}
